﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WWRK
{
    class FragenManager
    {
        //Datenbank sachen
        OleDbConnection db_connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\bin\Addressen.mdb");
        private OleDbDataAdapter db_adapter;
        private OleDbCommand db_command;


        //Fragen und Antworten
        private Frage[] fragenTeam1 = new Frage[5];
        private Frage[] fragenTeam2 = new Frage[5];

        Random der_Zufall = new Random();

        private int aktuellTeam1;
        private int aktuellTeam2;

        private Form1 form;

        FragenManager(Form1 _form)
        {
            form = _form;

            db_command.Connection = db_connection;
        }

        public void AlleFragenLaden()
        {
            db_command.CommandText = "Select * FROM Fragen";
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
