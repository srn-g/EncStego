using EncStego.Classes;
using System;
using System.Windows.Forms;

namespace EncStego
{
    public partial class FrmMain : Form
    {
        Main main = Main.Instance;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cmbHideEncryption.SelectedIndex = 0;
            cmbUnhideEncryption.SelectedIndex = 0;

            main.Hash = new SHA512Hash();
            main.Split = new BaseSplit();
            main.Data = new InputText();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtText.Text))
            {
                rtxtText.Focus();

                return;
            }
            if (string.IsNullOrEmpty(txtHidePassword.Text))
            {
                txtHidePassword.Focus();

                return;
            }

            if ((cmbHideEncryption.SelectedIndex + 1) == (int)Global.CryptoType.AES)
                main.Crypto = new AES();

            main.Hide(rtxtText.Text, txtHidePassword.Text);
        }

        private void btnUnhide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolderPath.Text))
            {
                txtFolderPath.Focus();

                return;
            }
            if (string.IsNullOrEmpty(txtUnhidePassword.Text))
            {
                txtUnhidePassword.Focus();

                return;
            }

            if ((cmbUnhideEncryption.SelectedIndex + 1) == (int)Global.CryptoType.AES)
                main.Crypto = new AES();

            rtxtText.Text = main.Unhide(txtFolderPath.Text, txtUnhidePassword.Text);
            tbcMain.SelectedIndex = 0;
        }

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnUnhide.Visible = false;
            if (tbcMain.SelectedIndex == 1)
            {
                btnUnhide.Visible = true;
                btnHide.Visible = false;
            }
        }

        private void btnFolderBrowse_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = fbd.SelectedPath;
            }
        }
    }
}
