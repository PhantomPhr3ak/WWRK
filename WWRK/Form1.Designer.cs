﻿namespace WWRK
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAntwort1 = new System.Windows.Forms.Button();
            this.btnAntwort2 = new System.Windows.Forms.Button();
            this.btnAntwort3 = new System.Windows.Forms.Button();
            this.btnAntwort4 = new System.Windows.Forms.Button();
            this.btnAntwortBestätigen = new System.Windows.Forms.Button();
            this.lblTeam1Name = new System.Windows.Forms.Label();
            this.lblTeam2Name = new System.Windows.Forms.Label();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.lblZeit = new System.Windows.Forms.Label();
            this.lblFrage = new System.Windows.Forms.Label();
            this.btnJoker1Team1 = new System.Windows.Forms.Button();
            this.btnJoker2Team1 = new System.Windows.Forms.Button();
            this.btnJoker1Team2 = new System.Windows.Forms.Button();
            this.btnJoker2Team2 = new System.Windows.Forms.Button();
            this.btnFragenManager = new System.Windows.Forms.Button();
            this.btnNeustarten = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstProtokoll = new System.Windows.Forms.ListBox();
            this.lblProtokoll = new System.Windows.Forms.Label();
            this.lblAktuellesTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAntwort1
            // 
            this.btnAntwort1.Location = new System.Drawing.Point(283, 172);
            this.btnAntwort1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntwort1.Name = "btnAntwort1";
            this.btnAntwort1.Size = new System.Drawing.Size(152, 73);
            this.btnAntwort1.TabIndex = 0;
            this.btnAntwort1.Text = "Antwort 1";
            this.btnAntwort1.UseVisualStyleBackColor = true;
            // 
            // btnAntwort2
            // 
            this.btnAntwort2.Location = new System.Drawing.Point(439, 172);
            this.btnAntwort2.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntwort2.Name = "btnAntwort2";
            this.btnAntwort2.Size = new System.Drawing.Size(152, 73);
            this.btnAntwort2.TabIndex = 1;
            this.btnAntwort2.Text = "Antwort 2";
            this.btnAntwort2.UseVisualStyleBackColor = true;
            // 
            // btnAntwort3
            // 
            this.btnAntwort3.Location = new System.Drawing.Point(283, 249);
            this.btnAntwort3.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntwort3.Name = "btnAntwort3";
            this.btnAntwort3.Size = new System.Drawing.Size(152, 73);
            this.btnAntwort3.TabIndex = 2;
            this.btnAntwort3.Text = "Antwort 3";
            this.btnAntwort3.UseVisualStyleBackColor = true;
            // 
            // btnAntwort4
            // 
            this.btnAntwort4.Location = new System.Drawing.Point(439, 249);
            this.btnAntwort4.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntwort4.Name = "btnAntwort4";
            this.btnAntwort4.Size = new System.Drawing.Size(152, 73);
            this.btnAntwort4.TabIndex = 3;
            this.btnAntwort4.Text = "Antwort 4";
            this.btnAntwort4.UseVisualStyleBackColor = true;
            // 
            // btnAntwortBestätigen
            // 
            this.btnAntwortBestätigen.Location = new System.Drawing.Point(283, 343);
            this.btnAntwortBestätigen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntwortBestätigen.Name = "btnAntwortBestätigen";
            this.btnAntwortBestätigen.Size = new System.Drawing.Size(152, 31);
            this.btnAntwortBestätigen.TabIndex = 4;
            this.btnAntwortBestätigen.Text = "Bestätigen";
            this.btnAntwortBestätigen.UseVisualStyleBackColor = true;
            // 
            // lblTeam1Name
            // 
            this.lblTeam1Name.AutoSize = true;
            this.lblTeam1Name.Location = new System.Drawing.Point(119, 27);
            this.lblTeam1Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeam1Name.Name = "lblTeam1Name";
            this.lblTeam1Name.Size = new System.Drawing.Size(35, 13);
            this.lblTeam1Name.TabIndex = 5;
            this.lblTeam1Name.Text = "label1";
            // 
            // lblTeam2Name
            // 
            this.lblTeam2Name.AutoSize = true;
            this.lblTeam2Name.Location = new System.Drawing.Point(704, 27);
            this.lblTeam2Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeam2Name.Name = "lblTeam2Name";
            this.lblTeam2Name.Size = new System.Drawing.Size(35, 13);
            this.lblTeam2Name.TabIndex = 6;
            this.lblTeam2Name.Text = "label1";
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(283, 8);
            this.pbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.pbStatus.Maximum = 10;
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(307, 32);
            this.pbStatus.TabIndex = 7;
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(419, 42);
            this.lblZeit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(25, 13);
            this.lblZeit.TabIndex = 8;
            this.lblZeit.Text = "Zeit";
            // 
            // lblFrage
            // 
            this.lblFrage.AutoSize = true;
            this.lblFrage.Location = new System.Drawing.Point(297, 118);
            this.lblFrage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrage.Name = "lblFrage";
            this.lblFrage.Size = new System.Drawing.Size(34, 13);
            this.lblFrage.TabIndex = 9;
            this.lblFrage.Text = "Frage";
            // 
            // btnJoker1Team1
            // 
            this.btnJoker1Team1.Location = new System.Drawing.Point(61, 54);
            this.btnJoker1Team1.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoker1Team1.Name = "btnJoker1Team1";
            this.btnJoker1Team1.Size = new System.Drawing.Size(143, 28);
            this.btnJoker1Team1.TabIndex = 10;
            this.btnJoker1Team1.Text = "50:50";
            this.btnJoker1Team1.UseVisualStyleBackColor = true;
            // 
            // btnJoker2Team1
            // 
            this.btnJoker2Team1.Location = new System.Drawing.Point(61, 94);
            this.btnJoker2Team1.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoker2Team1.Name = "btnJoker2Team1";
            this.btnJoker2Team1.Size = new System.Drawing.Size(143, 28);
            this.btnJoker2Team1.TabIndex = 11;
            this.btnJoker2Team1.Text = "Publikumsjoker";
            this.btnJoker2Team1.UseVisualStyleBackColor = true;
            // 
            // btnJoker1Team2
            // 
            this.btnJoker1Team2.Location = new System.Drawing.Point(647, 54);
            this.btnJoker1Team2.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoker1Team2.Name = "btnJoker1Team2";
            this.btnJoker1Team2.Size = new System.Drawing.Size(143, 28);
            this.btnJoker1Team2.TabIndex = 12;
            this.btnJoker1Team2.Text = "50:50";
            this.btnJoker1Team2.UseVisualStyleBackColor = true;
            // 
            // btnJoker2Team2
            // 
            this.btnJoker2Team2.Location = new System.Drawing.Point(647, 94);
            this.btnJoker2Team2.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoker2Team2.Name = "btnJoker2Team2";
            this.btnJoker2Team2.Size = new System.Drawing.Size(143, 28);
            this.btnJoker2Team2.TabIndex = 13;
            this.btnJoker2Team2.Text = "Publikumsjoker";
            this.btnJoker2Team2.UseVisualStyleBackColor = true;
            // 
            // btnFragenManager
            // 
            this.btnFragenManager.Location = new System.Drawing.Point(27, 368);
            this.btnFragenManager.Margin = new System.Windows.Forms.Padding(2);
            this.btnFragenManager.Name = "btnFragenManager";
            this.btnFragenManager.Size = new System.Drawing.Size(134, 30);
            this.btnFragenManager.TabIndex = 14;
            this.btnFragenManager.Text = "Fragen Katalog";
            this.btnFragenManager.UseVisualStyleBackColor = true;
            this.btnFragenManager.Click += new System.EventHandler(this.btnFragenManager_Click);
            // 
            // btnNeustarten
            // 
            this.btnNeustarten.Location = new System.Drawing.Point(27, 304);
            this.btnNeustarten.Margin = new System.Windows.Forms.Padding(2);
            this.btnNeustarten.Name = "btnNeustarten";
            this.btnNeustarten.Size = new System.Drawing.Size(133, 47);
            this.btnNeustarten.TabIndex = 15;
            this.btnNeustarten.Text = "Neustarten";
            this.btnNeustarten.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 258);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Start/Pause";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstProtokoll
            // 
            this.lstProtokoll.FormattingEnabled = true;
            this.lstProtokoll.Location = new System.Drawing.Point(650, 200);
            this.lstProtokoll.Margin = new System.Windows.Forms.Padding(2);
            this.lstProtokoll.Name = "lstProtokoll";
            this.lstProtokoll.Size = new System.Drawing.Size(185, 199);
            this.lstProtokoll.TabIndex = 17;
            // 
            // lblProtokoll
            // 
            this.lblProtokoll.AutoSize = true;
            this.lblProtokoll.Location = new System.Drawing.Point(647, 179);
            this.lblProtokoll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProtokoll.Name = "lblProtokoll";
            this.lblProtokoll.Size = new System.Drawing.Size(48, 13);
            this.lblProtokoll.TabIndex = 18;
            this.lblProtokoll.Text = "Protokoll";
            // 
            // lblAktuellesTeam
            // 
            this.lblAktuellesTeam.AutoSize = true;
            this.lblAktuellesTeam.Location = new System.Drawing.Point(297, 86);
            this.lblAktuellesTeam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAktuellesTeam.Name = "lblAktuellesTeam";
            this.lblAktuellesTeam.Size = new System.Drawing.Size(80, 13);
            this.lblAktuellesTeam.TabIndex = 19;
            this.lblAktuellesTeam.Text = "Aktuelles Team";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 419);
            this.Controls.Add(this.lblAktuellesTeam);
            this.Controls.Add(this.lblProtokoll);
            this.Controls.Add(this.lstProtokoll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNeustarten);
            this.Controls.Add(this.btnFragenManager);
            this.Controls.Add(this.btnJoker2Team2);
            this.Controls.Add(this.btnJoker1Team2);
            this.Controls.Add(this.btnJoker2Team1);
            this.Controls.Add(this.btnJoker1Team1);
            this.Controls.Add(this.lblFrage);
            this.Controls.Add(this.lblZeit);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.lblTeam2Name);
            this.Controls.Add(this.lblTeam1Name);
            this.Controls.Add(this.btnAntwortBestätigen);
            this.Controls.Add(this.btnAntwort4);
            this.Controls.Add(this.btnAntwort3);
            this.Controls.Add(this.btnAntwort2);
            this.Controls.Add(this.btnAntwort1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Wer wird Ratekönig?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAntwort1;
        private System.Windows.Forms.Button btnAntwort2;
        private System.Windows.Forms.Button btnAntwort3;
        private System.Windows.Forms.Button btnAntwort4;
        private System.Windows.Forms.Button btnAntwortBestätigen;
        private System.Windows.Forms.Label lblTeam1Name;
        private System.Windows.Forms.Label lblTeam2Name;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Label lblFrage;
        private System.Windows.Forms.Button btnJoker1Team1;
        private System.Windows.Forms.Button btnJoker2Team1;
        private System.Windows.Forms.Button btnJoker1Team2;
        private System.Windows.Forms.Button btnJoker2Team2;
        private System.Windows.Forms.Button btnFragenManager;
        private System.Windows.Forms.Button btnNeustarten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstProtokoll;
        private System.Windows.Forms.Label lblProtokoll;
        private System.Windows.Forms.Label lblAktuellesTeam;
    }
}
