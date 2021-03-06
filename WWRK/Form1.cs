﻿using System;
using System.Windows.Forms;

namespace WWRK
{
    public partial class Form1 : Form
    {
        //readonly FragenManagerForm _fragenManagerForm = new FragenManagerForm();
        private readonly FragenManager _fragenManager;
        
        public Form1()
        {
            InitializeComponent();

            //FragenManager initialisieren (Es werden automatisch Fragen geladen und den Teams zugewiesen.)
            _fragenManager = new FragenManager(this);
        }

        private void btnAntwort1_Click(object sender, EventArgs e)
        {
            _fragenManager.AntwortBestätigen(btnAntwort1.Text);
        }

        private void btnAntwort2_Click(object sender, EventArgs e)
        {
            _fragenManager.AntwortBestätigen(btnAntwort2.Text);
        }

        private void btnAntwort3_Click(object sender, EventArgs e)
        {
            _fragenManager.AntwortBestätigen(btnAntwort3.Text);
        }
        
        private void btnAntwort4_Click(object sender, EventArgs e)
        {
            _fragenManager.AntwortBestätigen(btnAntwort4.Text);
        }

        private void btnJoker1Team1_Click(object sender, EventArgs e)
        {
            if (_fragenManager.GetAktuellesTeam() == 1)
            {
                btnJoker1Team1.Enabled = false;
                _fragenManager.FiftyfiftyJoker(_fragenManager.GetAktuellesTeam());
            }
            else
            {
                MessageBox.Show(@"Ihr Team ist gerade nicht am Zug.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJoker2Team1_Click(object sender, EventArgs e)
        {
            if (_fragenManager.GetAktuellesTeam() == 1)
            {
                btnJoker2Team1.Enabled = false;
                _fragenManager.PublikumsJoker(_fragenManager.GetAktuellesTeam());
            }
            else
            {
                MessageBox.Show(@"Ihr Team ist gerade nicht am Zug.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJoker1Team2_Click(object sender, EventArgs e)
        {
            if (_fragenManager.GetAktuellesTeam() == 2)
            {
                btnJoker1Team2.Enabled = false;
                _fragenManager.FiftyfiftyJoker(_fragenManager.GetAktuellesTeam());
            }
            else
            {
                MessageBox.Show(@"Ihr Team ist gerade nicht am Zug.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJoker2Team2_Click(object sender, EventArgs e)
        {
            if (_fragenManager.GetAktuellesTeam() == 2)
            {
                btnJoker2Team2.Enabled = false;
                _fragenManager.PublikumsJoker(_fragenManager.GetAktuellesTeam());
            }
            else
            {
                MessageBox.Show(@"Ihr Team ist gerade nicht am Zug.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNeustarten_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Wollen Sie das Spiel wirklich neustarten?", 
                @"Neustarten?",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _fragenManager.Neustarten();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Visible = false;
            MessageBox.Show(@"Zum fortfahren drücken Sie bitte OK.", "",MessageBoxButtons.OK);
            Visible = true;
        }

        private void txtBox_Runden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBox_Runden_TextChanged(object sender, EventArgs e)
        {
            if(txtBox_Runden.Text != string.Empty)
                _fragenManager.RundenAnzahl = Convert.ToInt32(txtBox_Runden.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBox_Runden.Text = _fragenManager.RundenAnzahl.ToString();
        }
    }
}
