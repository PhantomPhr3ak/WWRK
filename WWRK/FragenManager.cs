using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WWRK
{
    class FragenManager
    {
        //Datenbank sachen
        OleDbConnection db_connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\bin\Addressen.mdb");
        private OleDbDataAdapter db_adapter;
        private OleDbCommand db_command;


        //Fragen und Antworten
        private Frage[] FragenTeam1 = new Frage[5];
        private Frage[] FragenTeam2 = new Frage[5];

        Random der_Zufall = new Random();

        private int aktuellTeam1;
        private int aktuellTeam2;

        
    }
}
