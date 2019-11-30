using FileEncryptor.Enums;
using FileEncryptor.Extenxions;
using FileEncryptor.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace FileEncryptor
{
    public partial class FrmEncryptFile : Form
    {
        public FrmEncryptFile()
        {
            InitializeComponent();
            Model = new FileEncryptorModel();
        }

        public FileEncryptorModel Model { get; set; }

        private void BtnEncryptFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select the folder where the file is to be saved",
                UseDescriptionForTitle = true
            };

            folderBrowserDialog.DialogResultIsOK(() =>
            {
                Model.FileName += ExtensionEnum.Lch.GetDescription();

                string newFullPath = Model.FileFullPath = Path.Combine(folderBrowserDialog.SelectedPath, Model.FileName);

                Model.DeleteFileIfExist();

                File.WriteAllText(newFullPath, Model.EncryptFileContent());

                DialogResult = DialogResult.OK;

                Close();
            }).Dispose();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = OpenFileDialogFilterEnum.AllFiles.GetDescription(),
                FilterIndex = 2,
                RestoreDirectory = true
            };

            openFileDialog.DialogResultIsOK(() =>
            {
                Model.FileFullPath = openFileDialog.FileName;

                var fileStream = openFileDialog.OpenFile();

                Model.FileContent = fileStream.ConvertToBase64();

                LblFileName.Text = Model.FileName = new FileInfo(Model.FileFullPath).Name;

                ValidateModel();
            });
            openFileDialog.Dispose();
        }

        private void TxtSecretFile_TextChanged(object sender, EventArgs e)
        {
            Model.SecretKey = ((TextBox)sender).Text;
            ValidateModel();
        }

        private void ValidateModel()
        {
            BtnEncryptFile.Enabled = !(string.IsNullOrWhiteSpace(Model.SecretKey) || string.IsNullOrWhiteSpace(Model.FileFullPath));
        }
    }
}
