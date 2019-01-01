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

        private int aktuellTeam1;
        private int aktuellTeam2;

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
                //Team 1
                for (int i = 0; i < 5; i++)
                {
                    //Zufallszahl bestimmen
                    random = der_Zufall.Next(0, alleFragen.Length - 1);
                    
                    //Prüfen, ob Frage bereits zugewiesen ist.
                    if (!fragenTeam1.Contains(alleFragen[random]) && !fragenTeam2.Contains(alleFragen[random]))
                    {
                        fragenTeam1[i] = alleFragen[random];
                    }
                    else
                    {
                        //TODO was passiert, wenn die Frage bereits zugewiesen ist?
                    }
                }

                //Team 2
                for (int i = 0; i < 5; i++)
                {
                    //Zufallszahl bestimmen
                    random = der_Zufall.Next(0, alleFragen.Length - 1);

                    //Prüfen, ob Frage bereits zugewiesen ist.
                    if (!fragenTeam1.Contains(alleFragen[random]) && !fragenTeam2.Contains(alleFragen[random]))
                    {
                        fragenTeam2[i] = alleFragen[random];
                    }
                    else
                    {
                        //TODO was passiert, wenn die Frage bereits zugewiesen ist?
                    }
                }
            }
        }

        public void NächsteFrage()
        {
            
        }

        public void AntwortBestätigen(string ausgewählteAntwort)
        {

        }
    }
}
