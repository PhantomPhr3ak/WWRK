namespace WWRK
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
            this.btnAntwort1.Location = new System.Drawing.Point(424, 265);
            this.btnAntwort1.Name = "btnAntwort1";
            this.btnAntwort1.Size = new System.Drawing.Size(228, 112);
            this.btnAntwort1.TabIndex = 0;
            this.btnAntwort1.Text = "Antwort 1";
            this.btnAntwort1.UseVisualStyleBackColor = true;
            // 
            // btnAntwort2
            // 
            this.btnAntwort2.Location = new System.Drawing.Point(658, 265);
            this.btnAntwort2.Name = "btnAntwort2";
            this.btnAntwort2.Size = new System.Drawing.Size(228, 112);
            this.btnAntwort2.TabIndex = 1;
            this.btnAntwort2.Text = "Antwort 2";
            this.btnAntwort2.UseVisualStyleBackColor = true;
            // 
            // btnAntwort3
            // 
            this.btnAntwort3.Location = new System.Drawing.Point(424, 383);
            this.btnAntwort3.Name = "btnAntwort3";
            this.btnAntwort3.Size = new System.Drawing.Size(228, 112);
            this.btnAntwort3.TabIndex = 2;
            this.btnAntwort3.Text = "Antwort 3";
            this.btnAntwort3.UseVisualStyleBackColor = true;
            // 
            // btnAntwort4
            // 
            this.btnAntwort4.Location = new System.Drawing.Point(658, 383);
            this.btnAntwort4.Name = "btnAntwort4";
            this.btnAntwort4.Size = new System.Drawing.Size(228, 112);
            this.btnAntwort4.TabIndex = 3;
            this.btnAntwort4.Text = "Antwort 4";
            this.btnAntwort4.UseVisualStyleBackColor = true;
            // 
            // btnAntwortBestätigen
            // 
            this.btnAntwortBestätigen.Location = new System.Drawing.Point(424, 528);
            this.btnAntwortBestätigen.Name = "btnAntwortBestätigen";
            this.btnAntwortBestätigen.Size = new System.Drawing.Size(228, 48);
            this.btnAntwortBestätigen.TabIndex = 4;
            this.btnAntwortBestätigen.Text = "Bestätigen";
            this.btnAntwortBestätigen.UseVisualStyleBackColor = true;
            this.btnAntwortBestätigen.Click += new System.EventHandler(this.btnAntwortBestätigen_Click);
            // 
            // lblTeam1Name
            // 
            this.lblTeam1Name.AutoSize = true;
            this.lblTeam1Name.Location = new System.Drawing.Point(178, 42);
            this.lblTeam1Name.Name = "lblTeam1Name";
            this.lblTeam1Name.Size = new System.Drawing.Size(51, 20);
            this.lblTeam1Name.TabIndex = 5;
            this.lblTeam1Name.Text = "label1";
            // 
            // lblTeam2Name
            // 
            this.lblTeam2Name.AutoSize = true;
            this.lblTeam2Name.Location = new System.Drawing.Point(1056, 42);
            this.lblTeam2Name.Name = "lblTeam2Name";
            this.lblTeam2Name.Size = new System.Drawing.Size(51, 20);
            this.lblTeam2Name.TabIndex = 6;
            this.lblTeam2Name.Text = "label1";
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(424, 12);
            this.pbStatus.Maximum = 10;
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(460, 49);
            this.pbStatus.TabIndex = 7;
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(628, 65);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(36, 20);
            this.lblZeit.TabIndex = 8;
            this.lblZeit.Text = "Zeit";
            // 
            // lblFrage
            // 
            this.lblFrage.AutoSize = true;
            this.lblFrage.Location = new System.Drawing.Point(446, 182);
            this.lblFrage.Name = "lblFrage";
            this.lblFrage.Size = new System.Drawing.Size(51, 20);
            this.lblFrage.TabIndex = 9;
            this.lblFrage.Text = "Frage";
            // 
            // btnJoker1Team1
            // 
            this.btnJoker1Team1.Location = new System.Drawing.Point(92, 83);
            this.btnJoker1Team1.Name = "btnJoker1Team1";
            this.btnJoker1Team1.Size = new System.Drawing.Size(214, 43);
            this.btnJoker1Team1.TabIndex = 10;
            this.btnJoker1Team1.Text = "50:50";
            this.btnJoker1Team1.UseVisualStyleBackColor = true;
            // 
            // btnJoker2Team1
            // 
            this.btnJoker2Team1.Location = new System.Drawing.Point(92, 145);
            this.btnJoker2Team1.Name = "btnJoker2Team1";
            this.btnJoker2Team1.Size = new System.Drawing.Size(214, 43);
            this.btnJoker2Team1.TabIndex = 11;
            this.btnJoker2Team1.Text = "Publikumsjoker";
            this.btnJoker2Team1.UseVisualStyleBackColor = true;
            // 
            // btnJoker1Team2
            // 
            this.btnJoker1Team2.Location = new System.Drawing.Point(970, 83);
            this.btnJoker1Team2.Name = "btnJoker1Team2";
            this.btnJoker1Team2.Size = new System.Drawing.Size(214, 43);
            this.btnJoker1Team2.TabIndex = 12;
            this.btnJoker1Team2.Text = "50:50";
            this.btnJoker1Team2.UseVisualStyleBackColor = true;
            // 
            // btnJoker2Team2
            // 
            this.btnJoker2Team2.Location = new System.Drawing.Point(970, 145);
            this.btnJoker2Team2.Name = "btnJoker2Team2";
            this.btnJoker2Team2.Size = new System.Drawing.Size(214, 43);
            this.btnJoker2Team2.TabIndex = 13;
            this.btnJoker2Team2.Text = "Publikumsjoker";
            this.btnJoker2Team2.UseVisualStyleBackColor = true;
            // 
            // btnFragenManager
            // 
            this.btnFragenManager.Location = new System.Drawing.Point(40, 566);
            this.btnFragenManager.Name = "btnFragenManager";
            this.btnFragenManager.Size = new System.Drawing.Size(201, 46);
            this.btnFragenManager.TabIndex = 14;
            this.btnFragenManager.Text = "Fragen Katalog";
            this.btnFragenManager.UseVisualStyleBackColor = true;
            this.btnFragenManager.Click += new System.EventHandler(this.btnFragenManager_Click);
            // 
            // btnNeustarten
            // 
            this.btnNeustarten.Location = new System.Drawing.Point(40, 468);
            this.btnNeustarten.Name = "btnNeustarten";
            this.btnNeustarten.Size = new System.Drawing.Size(200, 72);
            this.btnNeustarten.TabIndex = 15;
            this.btnNeustarten.Text = "Neustarten";
            this.btnNeustarten.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Start/Pause";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstProtokoll
            // 
            this.lstProtokoll.FormattingEnabled = true;
            this.lstProtokoll.ItemHeight = 20;
            this.lstProtokoll.Location = new System.Drawing.Point(975, 308);
            this.lstProtokoll.Name = "lstProtokoll";
            this.lstProtokoll.Size = new System.Drawing.Size(276, 304);
            this.lstProtokoll.TabIndex = 17;
            // 
            // lblProtokoll
            // 
            this.lblProtokoll.AutoSize = true;
            this.lblProtokoll.Location = new System.Drawing.Point(970, 275);
            this.lblProtokoll.Name = "lblProtokoll";
            this.lblProtokoll.Size = new System.Drawing.Size(70, 20);
            this.lblProtokoll.TabIndex = 18;
            this.lblProtokoll.Text = "Protokoll";
            // 
            // lblAktuellesTeam
            // 
            this.lblAktuellesTeam.AutoSize = true;
            this.lblAktuellesTeam.Location = new System.Drawing.Point(446, 132);
            this.lblAktuellesTeam.Name = "lblAktuellesTeam";
            this.lblAktuellesTeam.Size = new System.Drawing.Size(118, 20);
            this.lblAktuellesTeam.TabIndex = 19;
            this.lblAktuellesTeam.Text = "Aktuelles Team";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 645);
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

