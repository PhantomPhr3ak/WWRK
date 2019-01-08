﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WWRK
{
    class FragenManager
    {
        //https://docs.microsoft.com/de-de/dotnet/framework/data/adonet/populating-a-dataset-from-a-dataadapter
        //Datenbank sachen
        OleDbConnection db_connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Adressen.mdb");
        private OleDbDataAdapter db_adapter;
        private OleDbCommand db_command;
        private DataSet alleFragenDataSet;
        
        //Fragen und Antworten
        private Frage[] fragenTeam1 = new Frage[5];
        private Frage[] fragenTeam2 = new Frage[5];
        //private Frage[] alleFragen = new Frage[10000];

        private List<Frage> alleFragenList = new List<Frage>(0);

        Random der_Zufall = new Random();

        private int aktuelleFrageTeam1 = 0;
        private Boolean team1Ausgeschieden = false;

        private int aktuelleFrageTeam2 = 0;
        private Boolean team2Ausgeschieden = false;

        private int aktuellesTeam = 1;

        private Form1 form;

        private int i, j, k;
        
        public FragenManager(Form1 _form)
        {
            form = _form;
            
            Neustarten();
        }

        public void AlleFragenLaden()
        {
            alleFragenDataSet = new DataSet();

            //Daten aus DB laden
            db_adapter = new OleDbDataAdapter("SELECT * FROM Fragen", db_connection);
            db_adapter.Fill(alleFragenDataSet, "Fragen");

            //Fragen vom DataSet ins Array
            if (alleFragenDataSet != null)
            {
                i = 0;

                foreach (DataRow row in alleFragenDataSet.Tables["Fragen"].Rows)
                {
                    //Einzelne Frage-Objekte befüllen
                    Frage _frage = new Frage(
                        row["Frage"].ToString(),
                        row["Antwort1"].ToString(),
                        row["Antwort2"].ToString(),
                        row["Antwort3"].ToString(),
                        row["Antwort4"].ToString());

                    //Frage ins Array einfügen
                    //alleFragen[i] = _frage;
                    alleFragenList.Add(_frage);

                    //Counter erhöhen
                    i++;
                }
            }
        }

        public void FragenAuswählen()
        {
            int random;

            //Wenn genug Fragen für eine Runde vorhanden sind, wähle für jedes Team 5 Fragen zufällig aus
            if (!(alleFragenList.Count < 10))
            {
                i = 0;

                //Team 1
                while (i < 5)
                {
                    //Zufallszahl bestimmen
                    random = der_Zufall.Next(0, alleFragenList.Count);
                    
                    //Prüfen, ob die zufällig ausgewählte Frage bereits zugewiesen ist, wenn nein dann:
                    //weise die Frage dem Team zu,
                    //erhöhe den Counter, sodass die nächste Frage zugewiesen wird.
                    if (!fragenTeam1.Contains(alleFragenList[random]) && !fragenTeam2.Contains(alleFragenList[random]))
                    {
                        fragenTeam1[i] = alleFragenList[random];
                        i++;
                    }
                }

                i = 0;
                
                //Team 2
                while (i < 5)
                {
                    //Zufallszahl bestimmen
                    random = der_Zufall.Next(0, alleFragenList.Count);

                    //Prüfen, ob die zufällig ausgewählte Frage bereits zugewiesen ist, wenn nein dann:
                    //      weise die Frage dem Team zu,
                    //      erhöhe den Counter, sodass die nächste Frage zugewiesen wird.
                    if (!fragenTeam1.Contains(alleFragenList[random]) && !fragenTeam2.Contains(alleFragenList[random]))
                    {
                        fragenTeam2[i] = alleFragenList[random];
                        i++;
                    }
                }
            }
        }

        public void NächsteFrage()
        {
            form.btnAntwort1.Enabled = true;
            form.btnAntwort2.Enabled = true;
            form.btnAntwort3.Enabled = true;
            form.btnAntwort4.Enabled = true;

            //Lokale Variablen
            int[] _positionen = {-1,-1,-1,-1};
            string[] _antworten = new string[4];
            Frage _frage = new Frage("","","","","");

            i = 0;

            //Die Positionen für die Antworten zufällig bestimmen
            while (i < 4)
            {
                int _random = der_Zufall.Next( 0, 4);
                if (!_positionen.Contains(_random))
                {
                    _positionen[i] = _random;
                    i++;
                }
            }

            if (aktuellesTeam == 1 && !team1Ausgeschieden)
            {
                //Aktuelle Frage laden
                _frage = fragenTeam1[aktuelleFrageTeam1];
                form.lblFrage.Text = _frage.frage;
            }
            else if (aktuellesTeam == 2 && !team2Ausgeschieden)
            {
                //Aktuelle Frage laden
                _frage = fragenTeam2[aktuelleFrageTeam2];
                form.lblFrage.Text = _frage.frage;
            }

            //Anzeige welches Team dran ist
            form.lblAktuellesTeam.Text = "Aktuelles Team: " + aktuellesTeam.ToString();

            //Antworten in Array speichern
            _antworten[0] = _frage.korrekteAntwort;
            _antworten[1] = _frage.antwort1;
            _antworten[2] = _frage.antwort2;
            _antworten[3] = _frage.antwort3;

            //Antworten auf Buttons anzeigen
            form.btnAntwort1.Text = _antworten[_positionen[0]];
            form.btnAntwort2.Text = _antworten[_positionen[1]];
            form.btnAntwort3.Text = _antworten[_positionen[2]];
            form.btnAntwort4.Text = _antworten[_positionen[3]];
        }

        public void AntwortBestätigen(string ausgewählteAntwort)
        {
            if (aktuellesTeam == 1)
            {
                //aktuelle Frage laden
                Frage _frage = fragenTeam1[aktuelleFrageTeam1];
                
                //Überprüfen, ob richtige Antwort ausgewählt wurde
                if (ausgewählteAntwort == _frage.korrekteAntwort)
                {
                    //Grafik effekt
                    form.btnAntwortBestätigen.BackColor = Color.ForestGreen;
                    System.Threading.Thread.Sleep(1000);
                    form.btnAntwortBestätigen.BackColor = Color.LightGray;

                    //Fragen-Zähler erhöhen
                    aktuelleFrageTeam1++;
                }
                else
                {
                    //Team ausscheiden lassen
                    team1Ausgeschieden = true;
                }
            }
            else if (aktuellesTeam == 2)
            {
                //aktuelle Frage laden
                Frage _frage = fragenTeam2[aktuelleFrageTeam2];


                //Überprüfen, ob richtige Antwort ausgewählt wurde
                if (ausgewählteAntwort == _frage.korrekteAntwort)
                {
                    //Grafik effekt
                    form.btnAntwortBestätigen.BackColor = Color.ForestGreen;
                    System.Threading.Thread.Sleep(1000);
                    form.btnAntwortBestätigen.BackColor = Color.LightGray;

                    //Fragen-Zähler erhöhen
                    aktuelleFrageTeam2++;
                }
                else
                {
                    //Team ausscheiden lassen
                    team2Ausgeschieden = true;
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

            if (aktuelleFrageTeam1 == 5 && aktuelleFrageTeam2 == 5 && team1Ausgeschieden == false &&
                team2Ausgeschieden == false)
            {
                //  -   Unentschieden

                MessageBox.Show(
                    "Unentschieden \nBeide Teams haben gleich viele Fragen richtig beantwortet.",
                    "Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if(aktuelleFrageTeam1 == 5 && aktuelleFrageTeam2 < 5 && team1Ausgeschieden == false &&
                    team2Ausgeschieden == true)
            {
                //  -   Team 1 gewinnt

                MessageBox.Show(
                    "Team 1 hat gewonnen",
                    "Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (aktuelleFrageTeam1 < 5 && aktuelleFrageTeam2 == 5 && team1Ausgeschieden == true &&
                     team2Ausgeschieden == false)
            {
                //  -   Team 2 gewinnt

                MessageBox.Show(
                    "Team 2 hat gewonnen",
                    "Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (aktuelleFrageTeam1 < 5 && aktuelleFrageTeam2 < 5 && team1Ausgeschieden == false &&
                     team2Ausgeschieden == false)
            {
                //  -   Spiel geht normal weiter

                if (aktuellesTeam == 1)
                {
                    aktuellesTeam = 2;
                }
                else
                {
                    aktuellesTeam = 1;
                }

                NächsteFrage();
            }
            else if (aktuelleFrageTeam1 == 5 && aktuelleFrageTeam2 < 5 && team1Ausgeschieden == false &&
                     team2Ausgeschieden == false)
            {
                //  -   Spiel geht normal weiter !

                if (aktuellesTeam == 1)
                {
                    aktuellesTeam = 2;
                }
                else
                {
                    aktuellesTeam = 1;
                }

                NächsteFrage();
            }
            else if (aktuelleFrageTeam1 < 5 && aktuelleFrageTeam2 == 5 && team1Ausgeschieden == false &&
                     team2Ausgeschieden == false)
            {
                //  -   Spiel geht normal weiter !

                if (aktuellesTeam == 1)
                {
                    aktuellesTeam = 2;
                }
                else
                {
                    aktuellesTeam = 1;
                }

                NächsteFrage();
            }
            else if (aktuelleFrageTeam1 < 5 && aktuelleFrageTeam2 < 5 && team1Ausgeschieden == true &&
                     team2Ausgeschieden == false)
            {
                //  -   Team 2 darf weiter spielen

                if (aktuellesTeam == 1)
                {
                    aktuellesTeam = 2;
                }
                
                NächsteFrage();
            }
            else if (aktuelleFrageTeam1 < 5 && aktuelleFrageTeam2 < 5 && team1Ausgeschieden == false &&
                     team2Ausgeschieden == true)
            {
                //  -   Team 1 darf weiter spielen

                if (aktuellesTeam == 2)
                {
                    aktuellesTeam = 1;
                }

                NächsteFrage();
            }
            else if (aktuelleFrageTeam1 < aktuelleFrageTeam2 && aktuelleFrageTeam2 < 5 && team1Ausgeschieden == true &&
                     team2Ausgeschieden == false)
            {
                //  -   Team 2 darf weiter spielen

                if (aktuellesTeam == 1)
                {
                    aktuellesTeam = 2;
                }

                NächsteFrage();
            }
            else if (aktuelleFrageTeam2 < aktuelleFrageTeam1 && aktuelleFrageTeam1 < 5 && team1Ausgeschieden == false &&
                     team2Ausgeschieden == true)
            {
                //  -   Team 1 darf weiter spielen

                if (aktuellesTeam == 2)
                {
                    aktuellesTeam = 1;
                }

                NächsteFrage();
            }
            else if (aktuelleFrageTeam2 < aktuelleFrageTeam1 && aktuelleFrageTeam1 < 5 && team1Ausgeschieden == true &&
                     team2Ausgeschieden == true)
            {
                //  -   Team 1 gewinnt

                MessageBox.Show(
                    "Team 1 hat gewonnen",
                    "Spiel beendet!",
                    MessageBoxButtons.OK);

                Neustarten();
            }
            else if (aktuelleFrageTeam1 < aktuelleFrageTeam2 && aktuelleFrageTeam2 < 5 && team1Ausgeschieden == true &&
                     team2Ausgeschieden == true)
            {
                //  -   Team 2 gewinnt

                MessageBox.Show(
                    "Team 2 hat gewonnen",
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
            else
            {
                MessageBox.Show(
                    "Unerwartetes Verhalten! Runde wird neugestartet!",
                    "Fehler!",
                    MessageBoxButtons.OK);

                Neustarten();
            }


            //TODO: Endbedingung einfügen!!! (Nach der 5. Frage; Wenn beide Teams versagen)
        }

        public void Neustarten()
        {
            team1Ausgeschieden = false;
            team2Ausgeschieden = false;

            form.btnJoker1Team1.Enabled = true;
            form.btnJoker1Team2.Enabled = true;
            form.btnJoker2Team2.Enabled = true;
            form.btnJoker2Team2.Enabled = true;

            aktuelleFrageTeam1 = 0;
            aktuelleFrageTeam2 = 0;

            aktuellesTeam = 1;

            AlleFragenLaden();
            FragenAuswählen();
            NächsteFrage();
        }

        public int RichtigeAntwort()
        {
            Frage _frage;
            int korrekteAntwortButtonIndex = 0;

            if (aktuellesTeam == 1)
            {
                _frage = fragenTeam1[aktuelleFrageTeam1];
            }
            else
            {
                _frage = fragenTeam2[aktuelleFrageTeam2];
            }

            if (form.btnAntwort1.Text == _frage.korrekteAntwort)
            {
                korrekteAntwortButtonIndex = 1;
            }
            else if (form.btnAntwort2.Text == _frage.korrekteAntwort)
            {
                korrekteAntwortButtonIndex = 2;
            }
            else if (form.btnAntwort3.Text == _frage.korrekteAntwort)
            {
                korrekteAntwortButtonIndex = 3;
            }
            else if (form.btnAntwort4.Text == _frage.korrekteAntwort)
            {
                korrekteAntwortButtonIndex = 4;
            }
            
            return korrekteAntwortButtonIndex;
        }

        public int GetAktuellesTeam()
        {
            return aktuellesTeam;
        }

        public void FiftyfiftyJoker(int aktuellesTeam)
        {
            int richtigeAntwort = RichtigeAntwort();

            int btn1;
            int btn2;

            do
            {
                btn1 = der_Zufall.Next(1, 4);
                btn2 = der_Zufall.Next(1, 4);
            } while (btn1 == richtigeAntwort || btn2 == richtigeAntwort || btn1 == btn2);

            switch (btn1)
            {
                case 1:
                    form.btnAntwort1.Enabled = false;
                    break;
                case 2:
                    form.btnAntwort2.Enabled = false;
                    break;
                case 3:
                    form.btnAntwort3.Enabled = false;
                    break;
                case 4:
                    form.btnAntwort4.Enabled = false;
                    break;
            }

            switch (btn2)
            {
                case 1:
                    form.btnAntwort1.Enabled = false;
                    break;
                case 2:
                    form.btnAntwort2.Enabled = false;
                    break;
                case 3:
                    form.btnAntwort3.Enabled = false;
                    break;
                case 4:
                    form.btnAntwort4.Enabled = false;
                    break;
            }
        }

        public void PublikumsJoker(int aktuellesTeam)
        {
            int richtigeAntwort = RichtigeAntwort();

            int chanceRight = der_Zufall.Next(10, 75);
            int restChance = 100 - chanceRight;
            int chance1 = (restChance / 3) + der_Zufall.Next(-der_Zufall.Next(0, 20), der_Zufall.Next(0, 20));
            int chance2 = (restChance / 3) + der_Zufall.Next(-der_Zufall.Next(0, 20), der_Zufall.Next(0, 20));
            int chance3 = (restChance / 3) + der_Zufall.Next(-der_Zufall.Next(0, 20), der_Zufall.Next(0, 20));

            Console.WriteLine(chanceRight);
            Console.WriteLine(chance1);
            Console.WriteLine(chance2);
            Console.WriteLine(chance3);

            while (chance1 + chance2 + chance3 < restChance)
            {
                int decider = der_Zufall.Next(0, 3);
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
                int decider = der_Zufall.Next(0, 3);
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
