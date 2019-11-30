namespace FileEncryptor.UI
{
    partial class FrmEncryptFile
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
            this.BtnEncryptFile = new System.Windows.Forms.Button();
            this.LblSecretKey = new System.Windows.Forms.Label();
            this.TxtSecretFile = new System.Windows.Forms.TextBox();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.LblFileName = new System.Windows.Forms.Label();
            // 
            // BtnEncryptFile
            // 
            this.BtnEncryptFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEncryptFile.Enabled = false;
            this.BtnEncryptFile.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnEncryptFile.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEncryptFile.Location = new System.Drawing.Point(62, 205);
            this.BtnEncryptFile.Name = "BtnEncryptFile";
            this.BtnEncryptFile.Size = new System.Drawing.Size(138, 59);
            this.BtnEncryptFile.TabIndex = 3;
            this.BtnEncryptFile.Text = "Encrypt File";
            this.BtnEncryptFile.UseVisualStyleBackColor = false;
            this.BtnEncryptFile.Click += new System.EventHandler(this.BtnEncryptFile_Click);
            // 
            // LblSecretKey
            // 
            this.LblSecretKey.AutoSize = true;
            this.LblSecretKey.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSecretKey.Location = new System.Drawing.Point(26, 18);
            this.LblSecretKey.Name = "LblSecretKey";
            this.LblSecretKey.Size = new System.Drawing.Size(78, 20);
            this.LblSecretKey.TabIndex = 4;
            this.LblSecretKey.Text = "Secret Key";
            // 
            // TxtSecretFile
            // 
            this.TxtSecretFile.Location = new System.Drawing.Point(25, 62);
            this.TxtSecretFile.Name = "TxtSecretFile";
            this.TxtSecretFile.Size = new System.Drawing.Size(224, 23);
            this.TxtSecretFile.TabIndex = 5;
            this.TxtSecretFile.TextChanged += new System.EventHandler(this.TxtSecretFile_TextChanged);
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnOpenFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnOpenFile.Location = new System.Drawing.Point(26, 112);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(95, 33);
            this.BtnOpenFile.TabIndex = 6;
            this.BtnOpenFile.Text = "Open File";
            this.BtnOpenFile.UseVisualStyleBackColor = false;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(26, 162);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(0, 15);
            this.LblFileName.TabIndex = 7;
            // 
            // FrmEncryptFile
            // 
            this.ClientSize = new System.Drawing.Size(275, 282);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.BtnOpenFile);
            this.Controls.Add(this.TxtSecretFile);
            this.Controls.Add(this.LblSecretKey);
            this.Controls.Add(this.BtnEncryptFile);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(291, 321);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(291, 321);
            this.Name = "FrmEncryptFile";

        }

        #endregion

        private System.Windows.Forms.Button BtnEncryptFile;
        private System.Windows.Forms.TextBox TxtSecretFile;
        private System.Windows.Forms.Label LblSecretKey;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Label LblFileName;
    }
}