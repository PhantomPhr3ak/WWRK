﻿using System;
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
        private FragenManager fragenManager;
        private Joker _joker;
        
        public Form1()
        {
            InitializeComponent();

            //FragenManager initialisieren (Es werden automatisch Fragen geladen und den Teams zugewiesen.)
            fragenManager = new FragenManager(this);
        }

        private void btnFragenManager_Click(object sender, EventArgs e)
        {
            _fragenManagerForm.Show();
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

        private void btnAntwort4_Click(object sender, EventArgs e)
        {
            fragenManager.AntwortBestätigen(btnAntwort4.Text);
        }
    }
}
