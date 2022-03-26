using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using APIHelper;
using APIHelper.Structs;
using Newtonsoft.Json;

namespace D2Api
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Levante/Felicity API Testing";

            Console.WriteLine("--- START FetchManifest");
            Console.WriteLine($"Manifest loaded: {API.FetchManifest("a92d9c461ea649e29f5dc89d42fc181e")}");
            Console.WriteLine("--- END FetchManifest\n");

            // Console.Write("Enter membership ID: ");
            
            var memId = 4611686018472551978;

            /* var testItem = ManifestConnection.GetInventoryItemById(unchecked((int)3936625542));
            Console.WriteLine("--- START GetItemById");
            Console.WriteLine($"{testItem.DisplayProperties.Name} - {testItem.FlavorText}");
            Console.WriteLine("--- END GetItemById\n");*/

            var memberships = API.GetLinkedProfiles(memId, BungieMembershipType.All, true);
            Console.WriteLine("--- START GetLinkedProfiles");
            var platforms = string.Join(", ", memberships.Response.profiles[0].applicableMembershipTypes);
            Console.WriteLine(
                $"{memberships.Response.bnetMembership.supplementalDisplayName} (Linked platforms: {platforms})");
            Console.WriteLine("--- END GetLinkedProfiles\n");

            var profile = API.GetProfile(memId, memberships.Response.profiles[0].membershipType, new[]
            {
                Components.QueryComponents.Profiles,
                Components.QueryComponents.Collectibles
            });
            Console.WriteLine("--- START GetProfile");
            Console.WriteLine($"{profile.Response.Profile.Data.UserInfo.DisplayName}:\n\tPrivacy: {profile.Response.Profile.Privacy}\n\tCharacter IDs: {string.Join(", ", profile.Response.Profile.Data.CharacterIds)}");
            Console.WriteLine("--- END GetProfile\n");

            Console.WriteLine("--- START GetBrightEngrams");
            Console.WriteLine($"Character has: {GetBrightEngrams(memId, memberships.Response.profiles[0].membershipType)} bright engrams.");
            Console.WriteLine("--- END GetBrightEngrams\n");


            Console.WriteLine("--- START FetchEmblems");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var emblemCount = 0;

            foreach (var (key, value) in profile.Response.ProfileCollectibles.Data.Collectibles)
            {
                var manifestCollectible = ManifestConnection.GetItemCollectibleId(unchecked((int)Convert.ToInt64(key)));
                if(manifestCollectible.Redacted)
                    continue;

                var emblemList = new List<long>
                {
                    2451657441, // Seasonal
                    24961706, // Account
                    1166184619, // General
                    1801524334, // Competitive
                    4111024827, // Gambit
                    3958514834, // Strikes
                    631010939, // World
                    2220993106, // Trials
                    329982304 // Raids
                };
                foreach (var manifestCollectibleParentNodeHash in manifestCollectible.ParentNodeHashes)
                {
                    if (!emblemList.Contains(manifestCollectibleParentNodeHash)) continue;
                    emblemCount++;
                    if (value.State.HasFlag(Components.State.UniquenessViolation) && value.State.HasFlag(Components.State.NotAcquired))
                    {
                        Console.WriteLine(manifestCollectible.DisplayProperties.Name + " is not legitimate.");
                    }
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"\nParsed {emblemCount} emblems in {elapsedMs}ms.");
            Console.WriteLine("--- END FetchEmblems");

            // Console.ReadKey(true);
        }
        public static int GetBrightEngrams(long memId, BungieMembershipType memType)
        {
            // lazy method because characterInventories struct is broken
            var url = $"/Platform/Destiny2/2/Profile/4611686018472551978/?components=201";
            File.WriteAllText("tmp.json", RemoteAPI.Query(url));
            dynamic resp = JsonConvert.DeserializeObject(RemoteAPI.Query(url));


            var i = 0;
            if (resp != null)
                foreach (var responseItem in resp.Response.characterInventories.data["2305843009929385054"].items)
                    if (responseItem.itemHash == 1968811824)
                        i += 1;

            return i;
        }
    }
}