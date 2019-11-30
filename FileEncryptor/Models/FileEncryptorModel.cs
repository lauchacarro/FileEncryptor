using System.Diagnostics;

namespace FileEncryptor.Models
{
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class FileEncryptorModel
    {
        public string SecretKey { get; set; }
        public string FileContent { get; set; }
        public string FileFullPath { get; set; }
        public string FileName { get; set; }

        private string DebuggerDisplay
        {
            get { return string.Format("SecretKey: {0} FileName: {1}", SecretKey, FileName); }
        }
    }
}
