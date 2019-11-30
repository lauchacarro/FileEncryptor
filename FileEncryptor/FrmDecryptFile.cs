using FileEncryptor.UI.Enums;
using FileEncryptor.UI.Extenxions;
using FileEncryptor.UI.Models;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace FileEncryptor.UI
{
    public partial class FrmDecryptFile : Form
    {
        public FrmDecryptFile()
        {
            InitializeComponent();
            Model = new FileEncryptorModel();
        }

        public FileEncryptorModel Model { get; set; }

        private void BtnDecryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
                {
                    Description = "Select the folder where the file is to be saved",
                    UseDescriptionForTitle = true
                };

                folderBrowserDialog.DialogResultIsOK(() =>
                {
                    string newFullPath = Model.FileFullPath = Path.Combine(folderBrowserDialog.SelectedPath, Model.FileName[0..^4]);

                    Model.DeleteFileIfExist();

                    Encryption encryption = new Encryption(Model.SecretKey);

                    File.WriteAllBytes(newFullPath, Model.DecryptFileContent());

                    DialogResult = DialogResult.OK;

                    Close();
                }).Dispose();

            }
            catch (CryptographicException)
            {
                MessageBox.Show("The secret key is incorrect", nameof(FileEncryptor), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, nameof(FileEncryptor), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = OpenFileDialogFilterEnum.LchFiles.GetDescription(),
                FilterIndex = 2,
                RestoreDirectory = true
            };

            openFileDialog.DialogResultIsOK(() =>
            {
                Model.FileFullPath = openFileDialog.FileName;

                Stream fileStream = openFileDialog.OpenFile();

                Model.SetFileContent(fileStream);

                LblFileName.Text = Model.FileName = new FileInfo(Model.FileFullPath).Name;

                ValidateModel();
            }).Dispose();
        }

        private void TxtSecretFile_TextChanged(object sender, EventArgs e)
        {
            Model.SecretKey = ((TextBox)sender).Text;
            ValidateModel();
        }

        private void ValidateModel()
        {
            BtnDecryptFile.Enabled = !(string.IsNullOrWhiteSpace(Model.SecretKey) || string.IsNullOrWhiteSpace(Model.FileFullPath));
        }
    }
}
