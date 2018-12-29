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
        OleDbConnection db_connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\bin\Addressen.mdb");
        private OleDbDataAdapter db_adapter;
        private OleDbCommand db_command;
        private DataSet alleFragenDataSet;


        //Fragen und Antworten
        private Frage[] fragenTeam1 = new Frage[5];
        private Frage[] fragenTeam2 = new Frage[5];
        private Frage[] alleFragen;

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
                    //einzelne Frage befüllen
                    Frage _frage = new Frage(
                        row["Frage"].ToString(),
                        row["Antwort1"].ToString(),
                        row["Antwort2"].ToString(),
                        row["Antwort3"].ToString(),
                        row["Antwort4"].ToString());

                    //Frage ins Array einfügen
                    alleFragen[i] = _frage;
                }
            }
        }

        public void FragenAuswählen()
        {
            
        }

        public void NächsteFrage()
        {
            
        }

        public void AntwortBestätigen(string ausgewählteAntwort)
        {

        }
    }
}
