namespace FileEncryptor
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEncryptFile = new System.Windows.Forms.Button();
            this.BtnDecryptFile = new System.Windows.Forms.Button();
            // 
            // BtnEncryptFile
            // 
            this.BtnEncryptFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEncryptFile.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnEncryptFile.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEncryptFile.Location = new System.Drawing.Point(54, 184);
            this.BtnEncryptFile.Name = "BtnEncryptFile";
            this.BtnEncryptFile.Size = new System.Drawing.Size(138, 59);
            this.BtnEncryptFile.TabIndex = 3;
            this.BtnEncryptFile.Text = "Encrypt File";
            this.BtnEncryptFile.UseVisualStyleBackColor = false;
            this.BtnEncryptFile.Click += new System.EventHandler(this.BtnEncryptFile_Click);
            // 
            // BtnDecryptFile
            // 
            this.BtnDecryptFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDecryptFile.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDecryptFile.Location = new System.Drawing.Point(309, 184);
            this.BtnDecryptFile.Name = "BtnDecryptFile";
            this.BtnDecryptFile.Size = new System.Drawing.Size(134, 59);
            this.BtnDecryptFile.TabIndex = 4;
            this.BtnDecryptFile.Text = "Decrypt File";
            this.BtnDecryptFile.UseVisualStyleBackColor = false;
            this.BtnDecryptFile.Click += new System.EventHandler(this.BtnDecryptFile_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 343);
            this.Controls.Add(this.BtnDecryptFile);
            this.Controls.Add(this.BtnEncryptFile);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(529, 382);
            this.MinimumSize = new System.Drawing.Size(529, 382);
            this.Name = "FrmMain";
            this.Text = "FileEncryptor";

        }

        #endregion
        private System.Windows.Forms.Button BtnEncryptFile;
        private System.Windows.Forms.Button BtnDecryptFile;
    }
}

