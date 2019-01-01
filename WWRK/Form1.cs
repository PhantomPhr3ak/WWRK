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
    public partial class Form1 : Form
    {
        readonly FragenManagerForm _fragenManagerForm = new FragenManagerForm();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFragenManager_Click(object sender, EventArgs e)
        {
            _fragenManagerForm.Show();
        }

        private void btnAntwortBestätigen_Click(object sender, EventArgs e)
        {

        }
    }
}
