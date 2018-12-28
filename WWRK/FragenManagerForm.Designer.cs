namespace WWRK
{
    partial class FragenManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBox_Questions = new System.Windows.Forms.ListBox();
            this.txtBox_Question = new System.Windows.Forms.TextBox();
            this.txtBox_Answer1 = new System.Windows.Forms.TextBox();
            this.txtBox_Answer2 = new System.Windows.Forms.TextBox();
            this.txtBox_Answer3 = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox_Questions
            // 
            this.lstBox_Questions.FormattingEnabled = true;
            this.lstBox_Questions.Location = new System.Drawing.Point(12, 12);
            this.lstBox_Questions.Name = "lstBox_Questions";
            this.lstBox_Questions.Size = new System.Drawing.Size(828, 342);
            this.lstBox_Questions.TabIndex = 0;
            this.lstBox_Questions.SelectedIndexChanged += new System.EventHandler(this.lstBox_Questions_SelectedIndexChanged);
            // 
            // txtBox_Question
            // 
            this.txtBox_Question.Location = new System.Drawing.Point(12, 358);
            this.txtBox_Question.Name = "txtBox_Question";
            this.txtBox_Question.ReadOnly = true;
            this.txtBox_Question.Size = new System.Drawing.Size(209, 20);
            this.txtBox_Question.TabIndex = 1;
            // 
            // txtBox_Answer1
            // 
            this.txtBox_Answer1.Location = new System.Drawing.Point(226, 358);
            this.txtBox_Answer1.Name = "txtBox_Answer1";
            this.txtBox_Answer1.ReadOnly = true;
            this.txtBox_Answer1.Size = new System.Drawing.Size(201, 20);
            this.txtBox_Answer1.TabIndex = 2;
            // 
            // txtBox_Answer2
            // 
            this.txtBox_Answer2.Location = new System.Drawing.Point(432, 358);
            this.txtBox_Answer2.Name = "txtBox_Answer2";
            this.txtBox_Answer2.ReadOnly = true;
            this.txtBox_Answer2.Size = new System.Drawing.Size(201, 20);
            this.txtBox_Answer2.TabIndex = 3;
            // 
            // txtBox_Answer3
            // 
            this.txtBox_Answer3.Location = new System.Drawing.Point(639, 358);
            this.txtBox_Answer3.Name = "txtBox_Answer3";
            this.txtBox_Answer3.ReadOnly = true;
            this.txtBox_Answer3.Size = new System.Drawing.Size(201, 20);
            this.txtBox_Answer3.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(12, 384);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Speichern";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FragenManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 419);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtBox_Answer3);
            this.Controls.Add(this.txtBox_Answer2);
            this.Controls.Add(this.txtBox_Answer1);
            this.Controls.Add(this.txtBox_Question);
            this.Controls.Add(this.lstBox_Questions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FragenManagerForm";
            this.Text = "Fragen Manager";
            this.Load += new System.EventHandler(this.FragenManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_Questions;
        private System.Windows.Forms.TextBox txtBox_Question;
        private System.Windows.Forms.TextBox txtBox_Answer1;
        private System.Windows.Forms.TextBox txtBox_Answer2;
        private System.Windows.Forms.TextBox txtBox_Answer3;
        private System.Windows.Forms.Button btn_Save;
    }
}