using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
