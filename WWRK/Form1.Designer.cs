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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAntwort1 = new System.Windows.Forms.Button();
            this.btnAntwort2 = new System.Windows.Forms.Button();
            this.btnAntwort3 = new System.Windows.Forms.Button();
            this.btnAntwort4 = new System.Windows.Forms.Button();
            this.btnAntwortBestätigen = new System.Windows.Forms.Button();
            this.lblTeam1Name = new System.Windows.Forms.Label();
            this.lblTeam2Name = new System.Windows.Forms.Label();
            this.lblFrage = new System.Windows.Forms.Label();
            this.btnJoker2Team1 = new System.Windows.Forms.Button();
            this.btnJoker1Team2 = new System.Windows.Forms.Button();
            this.btnJoker2Team2 = new System.Windows.Forms.Button();
            this.btnNeustarten = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pBarTeam2 = new System.Windows.Forms.ProgressBar();
            this.pBarTeam1 = new System.Windows.Forms.ProgressBar();
            this.btnJoker1Team1 = new System.Windows.Forms.Button();
            this.pBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAntwort1
            // 
            this.btnAntwort1.Location = new System.Drawing.Point(283, 172);
            this.btnAntwort1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntwort1.Name = "btnAntwort1";
            this.btnAntwort1.Size = new System.Drawing.Size(145, 73);
            this.btnAntwort1.TabIndex = 0;
            this.btnAntwort1.Text = "Antwort 1";
            this.btnAntwort1.UseVisualStyleBackColor = true;
            this.btnAntwort1.Click += new System.EventHandler(this.btnAntwort1_Click);
            // 
            // btnAntwort2
            // 
            this.btnAntwort2.Location = new System.Drawing.Point(433, 172);
            this.btnAntwort2.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntwort2.Name = "btnAntwort2";
            this.btnAntwort2.Size = new System.Drawing.Size(145, 73);
            this.btnAntwort2.TabIndex = 1;
            this.btnAntwort2.Text = "Antwort 2";
            this.btnAntwort2.UseVisualStyleBackColor = true;
            this.btnAntwort2.Click += new System.EventHandler(this.btnAntwort2_Click);
            // 
            // btnAntwort3
            // 
            this.btnAntwort3.Location = new System.Drawing.Point(283, 250);
            this.btnAntwort3.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntwort3.Name = "btnAntwort3";
            this.btnAntwort3.Size = new System.Drawing.Size(145, 73);
            this.btnAntwort3.TabIndex = 2;
            this.btnAntwort3.Text = "Antwort 3";
            this.btnAntwort3.UseVisualStyleBackColor = true;
            this.btnAntwort3.Click += new System.EventHandler(this.btnAntwort3_Click);
            // 
            // btnAntwort4
            // 
            this.btnAntwort4.Location = new System.Drawing.Point(433, 250);
            this.btnAntwort4.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntwort4.Name = "btnAntwort4";
            this.btnAntwort4.Size = new System.Drawing.Size(145, 73);
            this.btnAntwort4.TabIndex = 3;
            this.btnAntwort4.Text = "Antwort 4";
            this.btnAntwort4.UseVisualStyleBackColor = true;
            // 
            // btnAntwortBestätigen
            // 
            this.btnAntwortBestätigen.Location = new System.Drawing.Point(283, 358);
            this.btnAntwortBestätigen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntwortBestätigen.Name = "btnAntwortBestätigen";
            this.btnAntwortBestätigen.Size = new System.Drawing.Size(295, 50);
            this.btnAntwortBestätigen.TabIndex = 4;
            this.btnAntwortBestätigen.Text = "Bestätigen";
            this.btnAntwortBestätigen.UseVisualStyleBackColor = true;
            this.btnAntwortBestätigen.Click += new System.EventHandler(this.btnAntwortBestätigen_Click);
            // 
            // lblTeam1Name
            // 
            this.lblTeam1Name.AutoSize = true;
            this.lblTeam1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTeam1Name.Location = new System.Drawing.Point(51, 9);
            this.lblTeam1Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeam1Name.Name = "lblTeam1Name";
            this.lblTeam1Name.Size = new System.Drawing.Size(132, 39);
            this.lblTeam1Name.TabIndex = 5;
            this.lblTeam1Name.Text = "Team 1";
            // 
            // lblTeam2Name
            // 
            this.lblTeam2Name.AutoSize = true;
            this.lblTeam2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTeam2Name.Location = new System.Drawing.Point(668, 9);
            this.lblTeam2Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeam2Name.Name = "lblTeam2Name";
            this.lblTeam2Name.Size = new System.Drawing.Size(132, 39);
            this.lblTeam2Name.TabIndex = 6;
            this.lblTeam2Name.Text = "Team 2";
            // 
            // lblFrage
            // 
            this.lblFrage.AutoSize = true;
            this.lblFrage.Location = new System.Drawing.Point(280, 123);
            this.lblFrage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrage.Name = "lblFrage";
            this.lblFrage.Size = new System.Drawing.Size(34, 13);
            this.lblFrage.TabIndex = 9;
            this.lblFrage.Text = "Frage";
            // 
            // btnJoker2Team1
            // 
            this.btnJoker2Team1.Location = new System.Drawing.Point(58, 106);
            this.btnJoker2Team1.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoker2Team1.Name = "btnJoker2Team1";
            this.btnJoker2Team1.Size = new System.Drawing.Size(125, 50);
            this.btnJoker2Team1.TabIndex = 11;
            this.btnJoker2Team1.Text = "Publikumsjoker";
            this.btnJoker2Team1.UseVisualStyleBackColor = true;
            this.btnJoker2Team1.Click += new System.EventHandler(this.btnJoker2Team1_Click);
            // 
            // btnJoker1Team2
            // 
            this.btnJoker1Team2.Location = new System.Drawing.Point(676, 50);
            this.btnJoker1Team2.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoker1Team2.Name = "btnJoker1Team2";
            this.btnJoker1Team2.Size = new System.Drawing.Size(125, 50);
            this.btnJoker1Team2.TabIndex = 12;
            this.btnJoker1Team2.Text = "50:50";
            this.btnJoker1Team2.UseVisualStyleBackColor = true;
            this.btnJoker1Team2.Click += new System.EventHandler(this.btnJoker1Team2_Click);
            // 
            // btnJoker2Team2
            // 
            this.btnJoker2Team2.Location = new System.Drawing.Point(676, 104);
            this.btnJoker2Team2.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoker2Team2.Name = "btnJoker2Team2";
            this.btnJoker2Team2.Size = new System.Drawing.Size(125, 50);
            this.btnJoker2Team2.TabIndex = 13;
            this.btnJoker2Team2.Text = "Publikumsjoker";
            this.btnJoker2Team2.UseVisualStyleBackColor = true;
            this.btnJoker2Team2.Click += new System.EventHandler(this.btnJoker2Team2_Click);
            // 
            // btnNeustarten
            // 
            this.btnNeustarten.Location = new System.Drawing.Point(11, 361);
            this.btnNeustarten.Margin = new System.Windows.Forms.Padding(2);
            this.btnNeustarten.Name = "btnNeustarten";
            this.btnNeustarten.Size = new System.Drawing.Size(133, 47);
            this.btnNeustarten.TabIndex = 15;
            this.btnNeustarten.Text = "Neustarten";
            this.btnNeustarten.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Start/Pause";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pBarTeam2
            // 
            this.pBarTeam2.BackColor = System.Drawing.SystemColors.Control;
            this.pBarTeam2.Location = new System.Drawing.Point(676, 159);
            this.pBarTeam2.Maximum = 5;
            this.pBarTeam2.Name = "pBarTeam2";
            this.pBarTeam2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pBarTeam2.RightToLeftLayout = true;
            this.pBarTeam2.Size = new System.Drawing.Size(125, 25);
            this.pBarTeam2.Step = 1;
            this.pBarTeam2.TabIndex = 20;
            // 
            // pBarTeam1
            // 
            this.pBarTeam1.Location = new System.Drawing.Point(58, 161);
            this.pBarTeam1.Maximum = 5;
            this.pBarTeam1.Name = "pBarTeam1";
            this.pBarTeam1.Size = new System.Drawing.Size(125, 23);
            this.pBarTeam1.Step = 1;
            this.pBarTeam1.TabIndex = 21;
            // 
            // btnJoker1Team1
            // 
            this.btnJoker1Team1.Location = new System.Drawing.Point(58, 51);
            this.btnJoker1Team1.Name = "btnJoker1Team1";
            this.btnJoker1Team1.Size = new System.Drawing.Size(125, 50);
            this.btnJoker1Team1.TabIndex = 22;
            this.btnJoker1Team1.Text = "50:50";
            this.btnJoker1Team1.UseVisualStyleBackColor = true;
            this.btnJoker1Team1.Click += new System.EventHandler(this.btnJoker1Team1_Click);
            // 
            // pBoxMain
            // 
            this.pBoxMain.BackColor = System.Drawing.SystemColors.Control;
            this.pBoxMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxMain.BackgroundImage")));
            this.pBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pBoxMain.Location = new System.Drawing.Point(363, 12);
            this.pBoxMain.Name = "pBoxMain";
            this.pBoxMain.Size = new System.Drawing.Size(125, 75);
            this.pBoxMain.TabIndex = 23;
            this.pBoxMain.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 419);
            this.Controls.Add(this.pBoxMain);
            this.Controls.Add(this.btnJoker1Team1);
            this.Controls.Add(this.pBarTeam1);
            this.Controls.Add(this.pBarTeam2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNeustarten);
            this.Controls.Add(this.btnJoker2Team2);
            this.Controls.Add(this.btnJoker1Team2);
            this.Controls.Add(this.btnJoker2Team1);
            this.Controls.Add(this.lblFrage);
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
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAntwort1;
        public System.Windows.Forms.Button btnAntwort2;
        public System.Windows.Forms.Button btnAntwort4;
        public System.Windows.Forms.Button btnAntwortBestätigen;
        public System.Windows.Forms.Label lblTeam1Name;
        public System.Windows.Forms.Label lblTeam2Name;
        public System.Windows.Forms.Label lblFrage;
        public System.Windows.Forms.Button btnJoker2Team1;
        public System.Windows.Forms.Button btnJoker1Team2;
        public System.Windows.Forms.Button btnJoker2Team2;
        public System.Windows.Forms.Button btnNeustarten;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnAntwort3;
        public System.Windows.Forms.Button btnJoker1Team1;
        public System.Windows.Forms.PictureBox pBoxMain;
        public System.Windows.Forms.ProgressBar pBarTeam2;
        public System.Windows.Forms.ProgressBar pBarTeam1;
    }
}

