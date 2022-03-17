using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using APIHelper.Structs;
using Newtonsoft.Json;

namespace APIHelper
{
    public class API
    {
        public static bool FetchManifest(string bungieApiKey)
        {
            RemoteAPI.BungieAPIKey = bungieApiKey;

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

            Console.WriteLine($"[Manifest] Found v.{item.Response.version}");

            var path = item.Response.mobileWorldContentPaths.en;
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
            new WebClient().DownloadFile(RemoteAPI.apiBaseUrl + path, manifestFilePath);

            Console.WriteLine("[Manifest] Unpacking...");
            ZipFile.ExtractToDirectory(manifestFilePath, "Data/Manifest");
            File.Delete(manifestFilePath);

            Console.WriteLine($"[Manifest] Extracted to {manifestFilePath}");

            ManifestConnection.dbFile = extractedManifestPath;

            return true;
        }

        public static D2Manifest.Root GetDestinyManifest()
        {
            return JsonConvert.DeserializeObject<D2Manifest.Root>(RemoteAPI.Query("/Platform/Destiny2/Manifest/"));
        }

        public static LinkedProfiles.Root GetLinkedProfiles(long membershipId, BungieMembershipType membershipType,
            bool getAllMemberships = false)
        {
            var url = $"/Platform/Destiny2/{(int) membershipType}/" +
                      $"Profile/{membershipId}/" +
                      $"LinkedProfiles/?getAllMemberships={getAllMemberships.ToString().ToLower()}";

            return JsonConvert.DeserializeObject<LinkedProfiles.Root>(RemoteAPI.Query(url));
        }

        public static DestinyProfile GetProfile(long membershipId, BungieMembershipType membershipType,
            Components.QueryComponents[] components)
        {
            var comps = components.Select(component => $"{(int) component}").ToList();

            var url = $"/Platform/Destiny2/{(int)membershipType}/" +
                      $"Profile/{membershipId}/" +
                      $"?components={string.Join(",", comps)}";

            return DestinyProfile.FromJson(RemoteAPI.Query(url));
        }
    }
}