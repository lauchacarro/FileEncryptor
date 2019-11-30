using System;
using System.IO;

namespace FileEncryptor.UI.Extenxions
{
    public static class StreamExtension
    {
        public static byte[] ConvertToBytes(this Stream stream)
        {
            byte[] bytes = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(bytes, 0, (int)stream.Length);
            stream.Close();
            stream.Dispose();
            return bytes;
        }

        public static string ConvertToBase64(this Stream stream)
        {
            return Convert.ToBase64String(stream.ConvertToBytes());
        }
    }
}
