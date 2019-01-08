using System;
using System.Windows.Forms;

namespace WWRK
{
    public partial class Form1 : Form
    {
        readonly FragenManagerForm _fragenManagerForm = new FragenManagerForm();
        private FragenManager fragenManager;
        
        public Form1()
        {
            InitializeComponent();

            //FragenManager initialisieren (Es werden automatisch Fragen geladen und den Teams zugewiesen.)
            fragenManager = new FragenManager(this);
        }

        private void btnAntwortBestätigen_Click(object sender, EventArgs e)
        {

        }

        private void btnAntwort1_Click(object sender, EventArgs e)
        {
            fragenManager.AntwortBestätigen(btnAntwort1.Text);
        }

        private void btnAntwort2_Click(object sender, EventArgs e)
        {
            fragenManager.AntwortBestätigen(btnAntwort2.Text);
        }

        private void btnAntwort3_Click(object sender, EventArgs e)
        {
            fragenManager.AntwortBestätigen(btnAntwort3.Text);
        }
        
        private void btnJoker1Team1_Click(object sender, EventArgs e)
        {
            if (fragenManager.GetAktuellesTeam() == 1)
            {
                btnJoker1Team1.Enabled = false;
                fragenManager.FiftyfiftyJoker(fragenManager.GetAktuellesTeam());
            }
            else
            {
                MessageBox.Show(@"Ihr Team ist gerade nicht am Zug.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJoker2Team1_Click(object sender, EventArgs e)
        {
            if (fragenManager.GetAktuellesTeam() == 1)
            {
                btnJoker2Team1.Enabled = false;
                fragenManager.PublikumsJoker(fragenManager.GetAktuellesTeam());
            }
            else
            {
                MessageBox.Show(@"Ihr Team ist gerade nicht am Zug.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJoker1Team2_Click(object sender, EventArgs e)
        {
            if (fragenManager.GetAktuellesTeam() == 2)
            {
                btnJoker1Team2.Enabled = false;
                fragenManager.FiftyfiftyJoker(fragenManager.GetAktuellesTeam());
            }
            else
            {
                MessageBox.Show(@"Ihr Team ist gerade nicht am Zug.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJoker2Team2_Click(object sender, EventArgs e)
        {
            if (fragenManager.GetAktuellesTeam() == 2)
            {
                btnJoker2Team2.Enabled = false;
                fragenManager.PublikumsJoker(fragenManager.GetAktuellesTeam());
            }
            else
            {
                MessageBox.Show(@"Ihr Team ist gerade nicht am Zug.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
