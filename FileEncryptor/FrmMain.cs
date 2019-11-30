using System;
using System.Windows.Forms;

namespace FileEncryptor
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnEncryptFile_Click(object sender, EventArgs e)
        {
            FrmEncryptFile frmEncryptFile = new FrmEncryptFile();
            if (frmEncryptFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("The file was successfully encrypted", nameof(FileEncryptor), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDecryptFile_Click(object sender, EventArgs e)
        {
            FrmDecryptFile frmDecryptFile = new FrmDecryptFile();
            if (frmDecryptFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("The file was successfully decrypted", nameof(FileEncryptor), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
