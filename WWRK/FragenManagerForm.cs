using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWRK
{
    public partial class FragenManagerForm : Form
    {
        public FragenManagerForm()
        {
            InitializeComponent();
        }

    private void FragenManagerForm_Load(object sender, EventArgs e)
        {
            OleDbConnection db_connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Adressen.mdb");
            db_connection.Open();
            OleDbCommand select = new OleDbCommand();
            select.Connection = db_connection;
            select.CommandText = "Select * From Adressen = ' '";
            OleDbDataReader reader = select.ExecuteReader();
            while (reader != null && reader.Read())
            {
                lstBox_Questions.Items.Add(reader[1] + "," + reader[2]);
            }
            db_connection.Close();
        }

        private void lstBox_Questions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBox_Question.ReadOnly = false;
            txtBox_Answer0.ReadOnly = false;
            txtBox_Answer1.ReadOnly = false;
            txtBox_Answer2.ReadOnly = false;
            txtBox_Answer3.ReadOnly = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //TextBox Fragen und TextBoxen Antworten in Excel speichern
        }
    }
}
