using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WWRK
{
    class FragenManager
    {
        //https://docs.microsoft.com/de-de/dotnet/framework/data/adonet/populating-a-dataset-from-a-dataadapter
        //Datenbank sachen
        private readonly OleDbConnection _dbConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Adressen.mdb");
        private OleDbDataAdapter _dbAdapter;
        private DataSet _alleFragenDataSet;
        
        //Fragen und Antworten
        private readonly Frage[] _fragenTeam1 = new Frage[5];
        private readonly Frage[] _fragenTeam2 = new Frage[5];
        //private Frage[] alleFragen = new Frage[10000];

        private readonly List<Frage> _alleFragenList = new List<Frage>(0);

        private readonly Random _derZufall = new Random();

        private int _aktuelleFrageTeam1;
        private bool _team1Ausgeschieden;

        private int _aktuelleFrageTeam2;
        private bool _team2Ausgeschieden;

        private int _aktuellesTeam = 1;

        private readonly Form1 _form;

        private int _i;

        private int _rundenAnzahl = 5;
        
        public FragenManager(Form1 form)
        {
            _form = form;
            
            Neustarten();
        }

        public int RundenAnzahl
        {
            get => _rundenAnzahl;
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show(@"Sie müssen mindestens eine Runde spielen.", 
                        @"Fehler", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _rundenAnzahl = value;
                Console.WriteLine(value);
            }
        }

        public void AlleFragenLaden()
        {
            _alleFragenDataSet = new DataSet();

            //Daten aus DB laden
            _dbAdapter = new OleDbDataAdapter("SELECT * FROM Fragen", _dbConnection);
            _dbAdapter.Fill(_alleFragenDataSet, "Fragen");

            //Fragen vom DataSet ins Array
            if (_alleFragenDataSet != null)
            {
                _i = 0;

                foreach (DataRow row in _alleFragenDataSet.Tables["Fragen"].Rows)
                {
                    //Einzelne Frage-Objekte befüllen
                    Frage frage = new Frage(
                        row["Frage"].ToString(),
                        row["Antwort1"].ToString(),
                        row["Antwort2"].ToString(),
                        row["Antwort3"].ToString(),
                        row["Antwort4"].ToString());

                    //Frage ins Array einfügen
                    //alleFragen[i] = _frage;
                    _alleFragenList.Add(frage);

                    //Counter erhöhen
                    _i++;
                }
            }
        }

        public void FragenAuswählen()
        {
            //Wenn genug Fragen für eine Runde vorhanden sind, wähle für jedes Team 5 Fragen zufällig aus
            if (!(_alleFragenList.Count < 10))
            {
                _i = 0;

                //Team 1
                int random;
                while (_i < 5)
                {
                    //Zufallszahl bestimmen
                    random = _derZufall.Next(0, _alleFragenList.Count);
                    
                    //Prüfen, ob die zufällig ausgewählte Frage bereits zugewiesen ist, wenn nein dann:
                    //weise die Frage dem Team zu,
                    //erhöhe den Counter, sodass die nächste Frage zugewiesen wird.
                    if (!_fragenTeam1.Contains(_alleFragenList[random]) && !_fragenTeam2.Contains(_alleFragenList[random]))
                    {
                        _fragenTeam1[_i] = _alleFragenList[random];
                        _i++;
                    }
                }

                _i = 0;
                
                //Team 2
                while (_i < 5)
                {
                    //Zufallszahl bestimmen
                    random = _derZufall.Next(0, _alleFragenList.Count);

                    //Prüfen, ob die zufällig ausgewählte Frage bereits zugewiesen ist, wenn nein dann:
                    //      weise die Frage dem Team zu,
                    //      erhöhe den Counter, sodass die nächste Frage zugewiesen wird.
                    if (!_fragenTeam1.Contains(_alleFragenList[random]) && !_fragenTeam2.Contains(_alleFragenList[random]))
                    {
                        _fragenTeam2[_i] = _alleFragenList[random];
                        _i++;
                    }
                }
            }
        }

        public void NächsteFrage()
        {
            _form.btnAntwort1.Enabled = true;
            _form.btnAntwort2.Enabled = true;
            _form.btnAntwort3.Enabled = true;
            _form.btnAntwort4.Enabled = true;

            //Lokale Variablen
            int[] positionen = {-1,-1,-1,-1};
            string[] antworten = new string[4];
            Frage frage = new Frage("","","","","");

            _i = 0;

            //Die Positionen für die Antworten zufällig bestimmen
            while (_i < 4)
            {
                int random = _derZufall.Next( 0, 4);
                if (!positionen.Contains(random))
                {
                    positionen[_i] = random;
                    _i++;
                }
            }

            if (_aktuellesTeam == 1 && !_team1Ausgeschieden)
            {
                //Aktuelle Frage laden
                frage = _fragenTeam1[_aktuelleFrageTeam1];
                _form.txtBox_Frage.Text = frage.frage;
            }
            else if (_aktuellesTeam == 2 && !_team2Ausgeschieden)
            {
                //Aktuelle Frage laden
                frage = _fragenTeam2[_aktuelleFrageTeam2];
                _form.txtBox_Frage.Text = frage.frage;
            }

            //Anzeige welches Team dran ist
            switch (_aktuellesTeam)
            {
                case 1:
                    _form.lblTeam1Name.ForeColor = Color.Black;
                    _form.lblTeam2Name.ForeColor = Color.Gray;
                    break;
                case 2:
                    _form.lblTeam1Name.ForeColor = Color.Gray;
                    _form.lblTeam2Name.ForeColor = Color.Black;
                    break;
            }
            


            //Antworten in Array speichern
            antworten[0] = frage.KorrekteAntwort;
            antworten[1] = frage.Antwort1;
            antworten[2] = frage.Antwort2;
            antworten[3] = frage.Antwort3;

            //Antworten auf Buttons anzeigen
            _form.btnAntwort1.Text = antworten[positionen[0]];
            _form.btnAntwort2.Text = antworten[positionen[1]];
            _form.btnAntwort3.Text = antworten[positionen[2]];
            _form.btnAntwort4.Text = antworten[positionen[3]];
        }
        
        public void AntwortBestätigen(string ausgewählteAntwort)
        {
            if (_aktuellesTeam == 1)
            {
                //aktuelle Frage laden
                Frage frage = _fragenTeam1[_aktuelleFrageTeam1];

                //Überprüfen, ob richtige Antwort ausgewählt wurde
                if (ausgewählteAntwort == frage.KorrekteAntwort)
                {
                    //Grafik effekt
                    //_form.btnAntwortBestätigen.BackColor = Color.ForestGreen;
                    //Thread.Sleep(1000);
                    //_form.btnAntwortBestätigen.BackColor = Color.LightGray;

                    //Fragen-Zähler erhöhen
                    _aktuelleFrageTeam1++;
                    _form.pBarTeam1.Value++;
                }
                else
                {
                    //Team ausscheiden lassen
                    _team1Ausgeschieden = true;
                }
            }
            else if (_aktuellesTeam == 2)
            {
                //aktuelle Frage laden
                Frage frage = _fragenTeam2[_aktuelleFrageTeam2];


                //Überprüfen, ob richtige Antwort ausgewählt wurde
                if (ausgewählteAntwort == frage.KorrekteAntwort)
                {
                    //Grafik effekt
                    //_form.btnAntwortBestätigen.BackColor = Color.ForestGreen;
                    //Thread.Sleep(1000);
                    //_form.btnAntwortBestätigen.BackColor = Color.LightGray;

                    //Fragen-Zähler erhöhen
                    _aktuelleFrageTeam2++;
                    _form.pBarTeam2.Value++;
                }
                else
                {
                    //Team ausscheiden lassen
                    _team2Ausgeschieden = true;
                }
            }

            //------------------
            //  Ende bestimmen
            //------------------

            #region test

            /*if (aktuelleFrageTeam1 < 5 && aktuelleFrageTeam2 < 5 && team1Ausgeschieden == false &&
                team2Ausgeschieden == false)
            {
                //  -   Noch nicht zu Ende und beide Teams drin

                NächsteFrage();
            }
            else if (aktuelleFrageTeam1 == 5 && aktuelleFrageTeam2 < 5 && team1Ausgeschieden == false &&
                     team2Ausgeschieden == true)
            {
                //  -   Team 1 gewinnt

                MessageBox.Show(
                    "Team 1 hat gewonnen",
                    "Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (aktuelleFrageTeam1 == 5 && aktuelleFrageTeam2 == 5 && team1Ausgeschieden == false &&
                     team2Ausgeschieden == false)
            {
                //  -   Unentschieden

                MessageBox.Show(
                    "Unentschieden \nBeide Teams haben gleich viele Fragen richtig beantwortet.",
                    "Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (aktuelleFrageTeam1 == aktuelleFrageTeam2 && team1Ausgeschieden == true && team2Ausgeschieden == true)
            {
                //  -   Unentschieden

                MessageBox.Show(
                    "Unentschieden \nBeide Teams haben gleich viele Fragen richtig beantwortet.",
                    "Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (aktuelleFrageTeam1 < aktuelleFrageTeam2 && team1Ausgeschieden == true &&
                     team2Ausgeschieden == true)
            {
                //  -   Team 2 gewinnt

                MessageBox.Show(
                    "Team 2 hat gewonnen",
                    "Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (aktuelleFrageTeam1 > aktuelleFrageTeam2 && team1Ausgeschieden == true &&
                     team2Ausgeschieden == true)
            {
                //  -   Team 1 gewinnt

                MessageBox.Show(
                    "Team 1 hat gewonnen",
                    "Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else
            {
                //  -   Team 1 ausgeschieden aber Team 2 noch drin

                MessageBox.Show(
                    "Falsche Antwort!\nTeam " + aktuellesTeam.ToString() + " ausgeschieden!",
                    "Falsche Antwort!",
                    MessageBoxButtons.OK);

                aktuellesTeam = 2;

                NächsteFrage();
            }*/

            #endregion

            if (_aktuelleFrageTeam1 == 5 && _aktuelleFrageTeam2 == 5 && _team1Ausgeschieden == false &&
                _team2Ausgeschieden == false)
            {
                //  -   Unentschieden

                MessageBox.Show(
                    @"Unentschieden Beide Teams haben gleich viele Fragen richtig beantwortet.",
                    @"Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (_aktuelleFrageTeam1 == 5 && _aktuelleFrageTeam2 < 5 && _team1Ausgeschieden == false &&
                    _team2Ausgeschieden)
            {
                //  -   Team 1 gewinnt

                MessageBox.Show(
                    @"Team 1 hat gewonnen",
                    @"Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (_aktuelleFrageTeam1 < 5 && _aktuelleFrageTeam2 == 5 && _team1Ausgeschieden &&
                     _team2Ausgeschieden == false)
            {
                //  -   Team 2 gewinnt

                MessageBox.Show(
                    @"Team 2 hat gewonnen",
                    @"Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (_aktuelleFrageTeam1 < 5 && _aktuelleFrageTeam2 < 5 && _team1Ausgeschieden == false &&
                     _team2Ausgeschieden == false)
            {
                //  -   Spiel geht normal weiter

                _aktuellesTeam = _aktuellesTeam == 1 ? 2 : 1;

                NächsteFrage();
            }
            else if (_aktuelleFrageTeam1 == 5 && _aktuelleFrageTeam2 < 5 && _team1Ausgeschieden == false &&
                     _team2Ausgeschieden == false)
            {
                //  -   Spiel geht normal weiter !

                _aktuellesTeam = _aktuellesTeam == 1 ? 2 : 1;

                NächsteFrage();
            }
            else if (_aktuelleFrageTeam1 < 5 && _aktuelleFrageTeam2 == 5 && _team1Ausgeschieden == false &&
                     _team2Ausgeschieden == false)
            {
                //  -   Spiel geht normal weiter !

                _aktuellesTeam = _aktuellesTeam == 1 ? 2 : 1;

                NächsteFrage();
            }
            else if (_aktuelleFrageTeam1 < 5 && _aktuelleFrageTeam2 < 5 && _team1Ausgeschieden &&
                     _team2Ausgeschieden == false)
            {
                //  -   Team 2 darf weiter spielen

                if (_aktuellesTeam == 1)
                {
                    _aktuellesTeam = 2;
                }

                NächsteFrage();
            }
            else if (_aktuelleFrageTeam1 < 5 && _aktuelleFrageTeam2 < 5 && _team1Ausgeschieden == false &&
                     _team2Ausgeschieden)
            {
                //  -   Team 1 darf weiter spielen

                if (_aktuellesTeam == 2)
                {
                    _aktuellesTeam = 1;
                }

                NächsteFrage();
            }
            else if (_aktuelleFrageTeam1 < _aktuelleFrageTeam2 && _aktuelleFrageTeam2 < 5 && _team1Ausgeschieden &&
                     _team2Ausgeschieden == false)
            {
                //  -   Team 2 darf weiter spielen

                if (_aktuellesTeam == 1)
                {
                    _aktuellesTeam = 2;
                }

                NächsteFrage();
            }
            else if (_aktuelleFrageTeam2 < _aktuelleFrageTeam1 && _aktuelleFrageTeam1 < 5 && _team1Ausgeschieden == false &&
                     _team2Ausgeschieden)
            {
                //  -   Team 1 darf weiter spielen

                if (_aktuellesTeam == 2)
                {
                    _aktuellesTeam = 1;
                }

                NächsteFrage();
            }
            else if (_aktuelleFrageTeam2 < _aktuelleFrageTeam1 && _aktuelleFrageTeam1 < 5 && _team1Ausgeschieden &&
                     _team2Ausgeschieden)
            {
                //  -   Team 1 gewinnt

                MessageBox.Show(
                    @"Team 1 hat gewonnen",
                    @"Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (_aktuelleFrageTeam1 < _aktuelleFrageTeam2 && _aktuelleFrageTeam2 < 5 && _team1Ausgeschieden &&
                     _team2Ausgeschieden)
            {
                //  -   Team 2 gewinnt

                MessageBox.Show(
                    @"Team 2 hat gewonnen",
                    @"Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (_aktuelleFrageTeam1 == _aktuelleFrageTeam2 && _team1Ausgeschieden && _team2Ausgeschieden)
            {
                //  -   Unentschieden

                MessageBox.Show(
                    @"Unentschieden Beide Teams haben gleich viele Fragen richtig beantwortet.",
                    @"Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else
            {
                DialogResult result = MessageBox.Show(@"Unerwartetes Fehlverhalten! \n Diese Runde wird neugestartet!",
                                                      @"Fehler!",
                                                      MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    MessageBox.Show(@"Doch es gab einen Fehler.",
                        @"Fehler",
                        MessageBoxButtons.OK);
                }
                Neustarten();
            }

            //TODO: Endbedingung einfügen!!! (Nach der 5. Frage; Wenn beide Teams versagen)
        }

        public void Neustarten()
        {
            _team1Ausgeschieden = false;
            _team2Ausgeschieden = false;

            _form.btnJoker1Team1.Enabled = true;
            _form.btnJoker1Team2.Enabled = true;
            _form.btnJoker2Team2.Enabled = true;
            _form.btnJoker2Team2.Enabled = true;

            _form.pBarTeam1.Value = 0;
            _form.pBarTeam2.Value = 0;

            _aktuelleFrageTeam1 = 0;
            _aktuelleFrageTeam2 = 0;

            _aktuellesTeam = 1;

            AlleFragenLaden();
            FragenAuswählen();
            NächsteFrage();
        }

        public int RichtigeAntwort()
        {
            int korrekteAntwortButtonIndex = 0;

            var frage = _aktuellesTeam == 1 ? _fragenTeam1[_aktuelleFrageTeam1] : _fragenTeam2[_aktuelleFrageTeam2];

            if (_form.btnAntwort1.Text == frage.KorrekteAntwort)
            {
                korrekteAntwortButtonIndex = 1;
            }
            else if (_form.btnAntwort2.Text == frage.KorrekteAntwort)
            {
                korrekteAntwortButtonIndex = 2;
            }
            else if (_form.btnAntwort3.Text == frage.KorrekteAntwort)
            {
                korrekteAntwortButtonIndex = 3;
            }
            else if (_form.btnAntwort4.Text == frage.KorrekteAntwort)
            {
                korrekteAntwortButtonIndex = 4;
            }
            
            return korrekteAntwortButtonIndex;
        }

        public int GetAktuellesTeam()
        {
            return _aktuellesTeam;
        }

        public void FiftyfiftyJoker(int aktuellesTeam)
        {
            int richtigeAntwort = RichtigeAntwort();

            int btn1;
            int btn2;

            do
            {
                btn1 = _derZufall.Next(1, 4);
                btn2 = _derZufall.Next(1, 4);
            } while (btn1 == richtigeAntwort || btn2 == richtigeAntwort || btn1 == btn2);

            switch (btn1)
            {
                case 1:
                    _form.btnAntwort1.Enabled = false;
                    break;
                case 2:
                    _form.btnAntwort2.Enabled = false;
                    break;
                case 3:
                    _form.btnAntwort3.Enabled = false;
                    break;
                case 4:
                    _form.btnAntwort4.Enabled = false;
                    break;
            }

            switch (btn2)
            {
                case 1:
                    _form.btnAntwort1.Enabled = false;
                    break;
                case 2:
                    _form.btnAntwort2.Enabled = false;
                    break;
                case 3:
                    _form.btnAntwort3.Enabled = false;
                    break;
                case 4:
                    _form.btnAntwort4.Enabled = false;
                    break;
            }
        }

        public void PublikumsJoker(int aktuellesTeam)
        {
            int richtigeAntwort = RichtigeAntwort();

            int chanceRight = _derZufall.Next(_derZufall.Next(5, 15), _derZufall.Next(60, 90));
            int restChance = 100 - chanceRight;
            int chance1 = (restChance / 3) + _derZufall.Next(-_derZufall.Next(0, 20), _derZufall.Next(1, 20));
            int chance2 = (restChance / 3) + _derZufall.Next(-_derZufall.Next(0, 20), _derZufall.Next(1, 20));
            int chance3 = (restChance / 3) + _derZufall.Next(-_derZufall.Next(0, 20), _derZufall.Next(1, 20));

            Console.WriteLine(chanceRight);
            Console.WriteLine(chance1);
            Console.WriteLine(chance2);
            Console.WriteLine(chance3);

            while (chance1 + chance2 + chance3 < restChance)
            {
                int decider = _derZufall.Next(0, 3);
                switch (decider)
                {
                    case 1:
                        chance1++;
                        break;
                    case 2:
                        chance2++;
                        break;
                    case 3:
                        chance3++;
                        break;
                }
            }

            while (chance1 + chance2 + chance3 > restChance)
            {
                int decider = _derZufall.Next(0, 3);
                switch (decider)
                {
                    case 1:
                        chance1--;
                        break;
                    case 2:
                        chance2--;
                        break;
                    case 3:
                        chance3--;
                        break;
                }
            }
            
            switch (richtigeAntwort)
            {
                case 1:
                    MessageBox.Show(@"Das Publikum hat folgendermaßen abgestimmt: " + Environment.NewLine +
                                    @"Antwort 1: " + chanceRight + @"%" + Environment.NewLine +
                                    @"Antwort 2: " + chance1 + @"%" + Environment.NewLine +
                                    @"Antwort 3: " + chance2 + @"%" + Environment.NewLine +
                                    @"Antwort 4: " + chance3 + @"%",
                        @"Publikumsjoker", MessageBoxButtons.OK);
                    break;
                case 2:
                    MessageBox.Show(@"Das Publikum hat folgendermaßen abgestimmt: " + Environment.NewLine +
                                    @"Antwort 1: " + chance3 + @"%" + Environment.NewLine +
                                    @"Antwort 2: " + chanceRight + @"%" + Environment.NewLine +
                                    @"Antwort 3: " + chance1 + @"%" + Environment.NewLine +
                                    @"Antwort 4: " + chance2 + @"%",
                        @"Publikumsjoker", MessageBoxButtons.OK);
                    break;
                case 3:
                    MessageBox.Show(@"Das Publikum hat folgendermaßen abgestimmt: " + Environment.NewLine +
                                    @"Antwort 1: " + chance2 + @"%" + Environment.NewLine +
                                    @"Antwort 2: " + chance3 + @"%" + Environment.NewLine +
                                    @"Antwort 3: " + chanceRight + @"%" + Environment.NewLine +
                                    @"Antwort 4: " + chance1 + @"%",
                        @"Publikumsjoker", MessageBoxButtons.OK);
                    break;
                case 4:
                    MessageBox.Show(@"Das Publikum hat folgendermaßen abgestimmt: " + Environment.NewLine +
                                    @"Antwort 1: " + chance3 + @"%" + Environment.NewLine +
                                    @"Antwort 2: " + chance1 + @"%" + Environment.NewLine +
                                    @"Antwort 3: " + chance2 + @"%" + Environment.NewLine +
                                    @"Antwort 4: " + chanceRight + @"%",
                        @"Publikumsjoker", MessageBoxButtons.OK);
                    break;
            }
        }
    }
}
