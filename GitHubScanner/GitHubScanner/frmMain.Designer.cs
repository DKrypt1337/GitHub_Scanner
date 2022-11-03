namespace GitHubScanner
{
    partial class frmMain
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_SearchType = new System.Windows.Forms.Label();
            this.txt_SearchTerm = new System.Windows.Forms.RichTextBox();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_SearchTerms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Users",
            "Code"});
            this.comboBox1.Location = new System.Drawing.Point(150, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Users";
            // 
            // lbl_SearchType
            // 
            this.lbl_SearchType.AutoSize = true;
            this.lbl_SearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchType.Location = new System.Drawing.Point(147, 78);
            this.lbl_SearchType.Name = "lbl_SearchType";
            this.lbl_SearchType.Size = new System.Drawing.Size(115, 16);
            this.lbl_SearchType.TabIndex = 1;
            this.lbl_SearchType.Text = "Type of search:";
            // 
            // txt_SearchTerm
            // 
            this.txt_SearchTerm.Location = new System.Drawing.Point(295, 97);
            this.txt_SearchTerm.Name = "txt_SearchTerm";
            this.txt_SearchTerm.Size = new System.Drawing.Size(156, 21);
            this.txt_SearchTerm.TabIndex = 2;
            this.txt_SearchTerm.Text = "Ford";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(12, 191);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(776, 247);
            this.txtData.TabIndex = 3;
            this.txtData.Text = "";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Search.Location = new System.Drawing.Point(487, 97);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(143, 21);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_SearchTerms
            // 
            this.lbl_SearchTerms.AutoSize = true;
            this.lbl_SearchTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchTerms.Location = new System.Drawing.Point(292, 78);
            this.lbl_SearchTerms.Name = "lbl_SearchTerms";
            this.lbl_SearchTerms.Size = new System.Drawing.Size(118, 16);
            this.lbl_SearchTerms.TabIndex = 5;
            this.lbl_SearchTerms.Text = "Search Term(s):";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_SearchTerms);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txt_SearchTerm);
            this.Controls.Add(this.lbl_SearchType);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_SearchType;
        private System.Windows.Forms.RichTextBox txt_SearchTerm;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_SearchTerms;
    }
}

