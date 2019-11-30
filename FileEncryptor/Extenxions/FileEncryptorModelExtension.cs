using FileEncryptor.Models;
using System;
using System.IO;

namespace FileEncryptor.Extenxions
{
    public static class FileEncryptorModelExtension
    {
        public static string EncryptFileContent(this FileEncryptorModel model)
        {
            Encryption encryption = new Encryption(model.SecretKey);
            return encryption.Encrypt(model.FileContent);
        }

        public static byte[] DecryptFileContent(this FileEncryptorModel model)
        {
            Encryption encryption = new Encryption(model.SecretKey);
            return Convert.FromBase64String(encryption.Decrypt(model.FileContent));
        }

        public static void DeleteFileIfExist(this FileEncryptorModel model)
        {
            if (System.IO.File.Exists(model.FileFullPath))
            {
                System.IO.File.Delete(model.FileFullPath);
            }
        }

        public static void SetFileContent(this FileEncryptorModel model, Stream stream)
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                model.FileContent = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
            }
        }
    }
}
