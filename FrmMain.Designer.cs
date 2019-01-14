namespace EncStego
{
    partial class FrmMain
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
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpHide = new System.Windows.Forms.TabPage();
            this.txtHidePassword = new System.Windows.Forms.TextBox();
            this.cmbHideEncryption = new System.Windows.Forms.ComboBox();
            this.rtxtText = new System.Windows.Forms.RichTextBox();
            this.lblHidePassword = new System.Windows.Forms.Label();
            this.lblHideEncryption = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.tbpUnhide = new System.Windows.Forms.TabPage();
            this.btnHide = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.txtUnhidePassword = new System.Windows.Forms.TextBox();
            this.cmbUnhideEncryption = new System.Windows.Forms.ComboBox();
            this.lblUnhidePassword = new System.Windows.Forms.Label();
            this.lblUnhideEncryption = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnFolderBrowse = new System.Windows.Forms.Button();
            this.btnUnhide = new System.Windows.Forms.Button();
            this.tbcMain.SuspendLayout();
            this.tbpHide.SuspendLayout();
            this.tbpUnhide.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpHide);
            this.tbcMain.Controls.Add(this.tbpUnhide);
            this.tbcMain.Location = new System.Drawing.Point(15, 12);
            this.tbcMain.Margin = new System.Windows.Forms.Padding(2);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(495, 260);
            this.tbcMain.TabIndex = 0;
            this.tbcMain.SelectedIndexChanged += new System.EventHandler(this.tbcMain_SelectedIndexChanged);
            // 
            // tbpHide
            // 
            this.tbpHide.Controls.Add(this.txtHidePassword);
            this.tbpHide.Controls.Add(this.cmbHideEncryption);
            this.tbpHide.Controls.Add(this.rtxtText);
            this.tbpHide.Controls.Add(this.lblHidePassword);
            this.tbpHide.Controls.Add(this.lblHideEncryption);
            this.tbpHide.Controls.Add(this.lblText);
            this.tbpHide.Location = new System.Drawing.Point(4, 22);
            this.tbpHide.Margin = new System.Windows.Forms.Padding(2);
            this.tbpHide.Name = "tbpHide";
            this.tbpHide.Padding = new System.Windows.Forms.Padding(2);
            this.tbpHide.Size = new System.Drawing.Size(487, 234);
            this.tbpHide.TabIndex = 0;
            this.tbpHide.Text = "Hide";
            this.tbpHide.UseVisualStyleBackColor = true;
            // 
            // txtHidePassword
            // 
            this.txtHidePassword.Location = new System.Drawing.Point(84, 197);
            this.txtHidePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtHidePassword.MaxLength = 32;
            this.txtHidePassword.Name = "txtHidePassword";
            this.txtHidePassword.Size = new System.Drawing.Size(174, 20);
            this.txtHidePassword.TabIndex = 3;
            // 
            // cmbHideEncryption
            // 
            this.cmbHideEncryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHideEncryption.FormattingEnabled = true;
            this.cmbHideEncryption.Items.AddRange(new object[] {
            "AES"});
            this.cmbHideEncryption.Location = new System.Drawing.Point(84, 158);
            this.cmbHideEncryption.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHideEncryption.Name = "cmbHideEncryption";
            this.cmbHideEncryption.Size = new System.Drawing.Size(174, 21);
            this.cmbHideEncryption.TabIndex = 2;
            // 
            // rtxtText
            // 
            this.rtxtText.Location = new System.Drawing.Point(84, 17);
            this.rtxtText.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtText.Name = "rtxtText";
            this.rtxtText.Size = new System.Drawing.Size(376, 123);
            this.rtxtText.TabIndex = 1;
            this.rtxtText.Text = "";
            // 
            // lblHidePassword
            // 
            this.lblHidePassword.AutoSize = true;
            this.lblHidePassword.Location = new System.Drawing.Point(19, 200);
            this.lblHidePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHidePassword.Name = "lblHidePassword";
            this.lblHidePassword.Size = new System.Drawing.Size(56, 13);
            this.lblHidePassword.TabIndex = 2;
            this.lblHidePassword.Text = "Password:";
            // 
            // lblHideEncryption
            // 
            this.lblHideEncryption.AutoSize = true;
            this.lblHideEncryption.Location = new System.Drawing.Point(19, 161);
            this.lblHideEncryption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHideEncryption.Name = "lblHideEncryption";
            this.lblHideEncryption.Size = new System.Drawing.Size(60, 13);
            this.lblHideEncryption.TabIndex = 1;
            this.lblHideEncryption.Text = "Encryption:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(19, 28);
            this.lblText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Text:";
            // 
            // tbpUnhide
            // 
            this.tbpUnhide.Controls.Add(this.btnFolderBrowse);
            this.tbpUnhide.Controls.Add(this.lblFolder);
            this.tbpUnhide.Controls.Add(this.txtFolderPath);
            this.tbpUnhide.Controls.Add(this.txtUnhidePassword);
            this.tbpUnhide.Controls.Add(this.cmbUnhideEncryption);
            this.tbpUnhide.Controls.Add(this.lblUnhidePassword);
            this.tbpUnhide.Controls.Add(this.lblUnhideEncryption);
            this.tbpUnhide.Location = new System.Drawing.Point(4, 22);
            this.tbpUnhide.Margin = new System.Windows.Forms.Padding(2);
            this.tbpUnhide.Name = "tbpUnhide";
            this.tbpUnhide.Padding = new System.Windows.Forms.Padding(2);
            this.tbpUnhide.Size = new System.Drawing.Size(487, 234);
            this.tbpUnhide.TabIndex = 1;
            this.tbpUnhide.Text = "Unhide";
            this.tbpUnhide.UseVisualStyleBackColor = true;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(226, 282);
            this.btnHide.Margin = new System.Windows.Forms.Padding(2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(70, 24);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // txtUnhidePassword
            // 
            this.txtUnhidePassword.Location = new System.Drawing.Point(88, 119);
            this.txtUnhidePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnhidePassword.MaxLength = 32;
            this.txtUnhidePassword.Name = "txtUnhidePassword";
            this.txtUnhidePassword.Size = new System.Drawing.Size(174, 20);
            this.txtUnhidePassword.TabIndex = 7;
            // 
            // cmbUnhideEncryption
            // 
            this.cmbUnhideEncryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnhideEncryption.FormattingEnabled = true;
            this.cmbUnhideEncryption.Items.AddRange(new object[] {
            "AES"});
            this.cmbUnhideEncryption.Location = new System.Drawing.Point(88, 77);
            this.cmbUnhideEncryption.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUnhideEncryption.Name = "cmbUnhideEncryption";
            this.cmbUnhideEncryption.Size = new System.Drawing.Size(174, 21);
            this.cmbUnhideEncryption.TabIndex = 5;
            // 
            // lblUnhidePassword
            // 
            this.lblUnhidePassword.AutoSize = true;
            this.lblUnhidePassword.Location = new System.Drawing.Point(24, 122);
            this.lblUnhidePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnhidePassword.Name = "lblUnhidePassword";
            this.lblUnhidePassword.Size = new System.Drawing.Size(56, 13);
            this.lblUnhidePassword.TabIndex = 6;
            this.lblUnhidePassword.Text = "Password:";
            // 
            // lblUnhideEncryption
            // 
            this.lblUnhideEncryption.AutoSize = true;
            this.lblUnhideEncryption.Location = new System.Drawing.Point(24, 80);
            this.lblUnhideEncryption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnhideEncryption.Name = "lblUnhideEncryption";
            this.lblUnhideEncryption.Size = new System.Drawing.Size(60, 13);
            this.lblUnhideEncryption.TabIndex = 4;
            this.lblUnhideEncryption.Text = "Encryption:";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(69, 21);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(315, 20);
            this.txtFolderPath.TabIndex = 8;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(24, 24);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 9;
            this.lblFolder.Text = "Folder:";
            // 
            // btnFolderBrowse
            // 
            this.btnFolderBrowse.Location = new System.Drawing.Point(390, 19);
            this.btnFolderBrowse.Name = "btnFolderBrowse";
            this.btnFolderBrowse.Size = new System.Drawing.Size(38, 23);
            this.btnFolderBrowse.TabIndex = 10;
            this.btnFolderBrowse.Text = "...";
            this.btnFolderBrowse.UseVisualStyleBackColor = true;
            this.btnFolderBrowse.Click += new System.EventHandler(this.btnFolderBrowse_Click);
            // 
            // btnUnhide
            // 
            this.btnUnhide.Location = new System.Drawing.Point(226, 282);
            this.btnUnhide.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnhide.Name = "btnUnhide";
            this.btnUnhide.Size = new System.Drawing.Size(70, 24);
            this.btnUnhide.TabIndex = 5;
            this.btnUnhide.Text = "Unhide";
            this.btnUnhide.UseVisualStyleBackColor = true;
            this.btnUnhide.Visible = false;
            this.btnUnhide.Click += new System.EventHandler(this.btnUnhide_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 319);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnUnhide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncStego";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tbcMain.ResumeLayout(false);
            this.tbpHide.ResumeLayout(false);
            this.tbpHide.PerformLayout();
            this.tbpUnhide.ResumeLayout(false);
            this.tbpUnhide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpHide;
        private System.Windows.Forms.TabPage tbpUnhide;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblHidePassword;
        private System.Windows.Forms.Label lblHideEncryption;
        private System.Windows.Forms.RichTextBox rtxtText;
        private System.Windows.Forms.ComboBox cmbHideEncryption;
        private System.Windows.Forms.TextBox txtHidePassword;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.TextBox txtUnhidePassword;
        private System.Windows.Forms.ComboBox cmbUnhideEncryption;
        private System.Windows.Forms.Label lblUnhidePassword;
        private System.Windows.Forms.Label lblUnhideEncryption;
        private System.Windows.Forms.Button btnFolderBrowse;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnUnhide;
    }
}

