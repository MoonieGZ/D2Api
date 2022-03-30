using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using APIHelper.Structs;
using Newtonsoft.Json;

namespace APIHelper
{
    public class API
    {
        private static readonly HttpClient _httpClient = new();

        public static bool FetchManifest()
        {
            if (RuntimeInformation.OSArchitecture is Architecture.Arm or Architecture.Arm64)
            {
                VerifyFile("SQLite.Interop.dll", "434CE7C48466525268DED77ADFC741D8");
                VerifyFile("System.Data.SQLite.dll", "0305308B988057D1B3048A1DC332E7E2");
            }

            var item = GetDestinyManifest();

            if (item == null)
            {
                Console.WriteLine("[Manifest] Failed to load.");
                return false;
            }

            if (item.ErrorCode != 1)
            {
                Console.WriteLine($"[Manifest] {item.ErrorStatus} - {item.Message}");
                return false;
            }

            Console.WriteLine($"[Manifest] Found v.{item.Response.Version}");

            var path = item.Response.MobileWorldContentPaths.En;
            var fileName = path.Split("/").LastOrDefault();
            var manifestFilePath = "Data/" + fileName;
            var extractedManifestPath = "Data/Manifest/" + fileName;

            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
            if (!Directory.Exists("Data/Manifest"))
                Directory.CreateDirectory("Data/Manifest");

            if (File.Exists(extractedManifestPath))
            {
                // TODO: Fix integrity check
                // Documentation would suggest that the file name contains the md5sum of the result but it just doesn't match?
                // Workaround: forcefully refresh the manifest file periodically

                /*
                    var presentHash = path.Split("_").LastOrDefault()?.Split(".").FirstOrDefault();
                    Console.WriteLine($"Manifest file found with hash: {presentHash}");
                    var remoteHash = Hash.CalculateMD5(extractedManifestPath);
                    Console.WriteLine($"Comparing to incoming manifest hash: {remoteHash}");

                    if (presentHash == remoteHash)
                        return true;
                */

                Console.WriteLine("[Manifest] Existing file is out of date, refreshing...");
                File.Delete(extractedManifestPath);
            }

            Console.WriteLine("[Manifest] Downloading...");
            var fileBytes = _httpClient.GetByteArrayAsync(RemoteAPI.apiBaseUrl + path).Result;
            File.WriteAllBytes(manifestFilePath, fileBytes);

            Console.WriteLine("[Manifest] Unpacking...");
            ZipFile.ExtractToDirectory(manifestFilePath, "Data/Manifest");
            File.Delete(manifestFilePath);

            Console.WriteLine($"[Manifest] Extracted to {manifestFilePath}");

            ManifestConnection.dbFile = extractedManifestPath;

            return true;
        }

        private static void VerifyFile(string fileName, string hash)
        {
            if (File.Exists(fileName))
                if (Hash.CalculateMD5(fileName) != hash)
                    File.Delete(fileName);
                else
                    return;

            Console.WriteLine($"[Deps] Downloading dependency {fileName} for ARM platforms.");

            if (fileName == null)
                return;

            var fileBytes = _httpClient.GetByteArrayAsync($"https://whaskell.pw/api/{fileName}").Result;
            File.WriteAllBytes(fileName, fileBytes);
        }

        public static D2Manifest GetDestinyManifest()
        {
            return JsonConvert.DeserializeObject<D2Manifest>(RemoteAPI.Query("/Platform/Destiny2/Manifest/"));
        }
    }
}