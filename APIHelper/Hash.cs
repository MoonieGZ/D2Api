using System;
using System.IO;
using System.Security.Cryptography;

namespace APIHelper
{
    internal class Hash
    {
        public static string CalculateMD5(string filename)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filename);
            return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
        }
    }
}