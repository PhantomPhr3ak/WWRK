using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
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
        private Frage[] alleFragen = new Frage[0];

        Random der_Zufall = new Random();

        private int aktuelleFrageTeam1 = 0;
        private Boolean team1Ausgeschieden = false;

        private int aktuelleFrageTeam2 = 0;
        private Boolean team2Ausgeschieden = false;

        private int aktuellesTeam;


        private Form1 form;

        private int i, j, k;

        FragenManager(Form1 _form)
        {
            form = _form;
            
            AlleFragenLaden();
            FragenAuswählen();
        }

        public void AlleFragenLaden()
        {
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
                    alleFragen[i] = _frage;

                    //Counter erhöhen
                    i++;
                }
            }
        }

        public void FragenAuswählen()
        {
            int random;

            //Wenn genug Fragen für eine Runde vorhanden sind, wähle für jedes Team 5 Fragen zufällig aus
            if (!(alleFragen.Length < 10))
            {
                i = 0;

                //Team 1
                while (i < 5)
                {
                    //Zufallszahl bestimmen
                    random = der_Zufall.Next(0, alleFragen.Length - 1);
                    
                    //Prüfen, ob die zufällig ausgewählte Frage bereits zugewiesen ist, wenn nein dann:
                    //      weise die Frage dem Team zu,
                    //      erhöhe den Counter, sodass die nächste Frage zugewiesen wird.
                    if (!fragenTeam1.Contains(alleFragen[random]) && !fragenTeam2.Contains(alleFragen[random]))
                    {
                        fragenTeam1[i] = alleFragen[random];
                        i++;
                    }
                }

                i = 0;
                
                //Team 2
                while (i < 5)
                {
                    //Zufallszahl bestimmen
                    random = der_Zufall.Next(0, alleFragen.Length - 1);

                    //Prüfen, ob die zufällig ausgewählte Frage bereits zugewiesen ist, wenn nein dann:
                    //      weise die Frage dem Team zu,
                    //      erhöhe den Counter, sodass die nächste Frage zugewiesen wird.
                    if (!fragenTeam1.Contains(alleFragen[random]) && !fragenTeam2.Contains(alleFragen[random]))
                    {
                        fragenTeam2[i] = alleFragen[random];
                        i++;
                    }
                }
            }
        }

        public void NächsteFrage()
        {
            int[] _positionen = new int[4];
            string[] _antworten = new string[4];

            while (i < 4)
            {
                int _random = der_Zufall.Next(1, 4);
                if (!_positionen.Contains(_random))
                {
                    _positionen[i] = _random;
                    i++;
                }
            }

            if (aktuellesTeam == 1 && !team1Ausgeschieden)
            {
                Frage _frage = fragenTeam1[aktuelleFrageTeam1];
                form.lblFrage.Text = _frage.frage;

                _antworten[0] = _frage.korrekteAntwort;
                _antworten[1] = _frage.antwort1;
                _antworten[2] = _frage.antwort2;
                _antworten[3] = _frage.antwort3;
            }
            else if (aktuellesTeam == 2 && !team2Ausgeschieden)
            {
                Frage _frage = fragenTeam2[aktuelleFrageTeam2];
                form.lblFrage.Text = _frage.frage;

                _antworten[0] = _frage.korrekteAntwort;
                _antworten[1] = _frage.antwort1;
                _antworten[2] = _frage.antwort2;
                _antworten[3] = _frage.antwort3;
            }

            form.btnAntwort1.Text = _antworten[_positionen[0]];
            form.btnAntwort2.Text = _antworten[_positionen[1]];
            form.btnAntwort3.Text = _antworten[_positionen[2]];
            form.btnAntwort4.Text = _antworten[_positionen[3]];
        }

        public void AntwortBestätigen(string ausgewählteAntwort)
        {

        }
    }
}
