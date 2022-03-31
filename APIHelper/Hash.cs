using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace APIHelper
{
    public class Hash
    {
        public static string CalculateMD5(string filename)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filename);
            return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
        }

        public static string CalculateBase64(string input)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}