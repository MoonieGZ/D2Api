using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using APIHelper;
using BungieSharper.Client;
using BungieSharper.Entities;
using BungieSharper.Entities.Destiny;
using Newtonsoft.Json;

namespace D2Api
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Felicity API Testing";

            Console.WriteLine("--- START FetchManifest");
            Console.WriteLine($"Manifest loaded: {API.FetchManifest()}");
            Console.WriteLine("--- END FetchManifest\n");

            // Console.Write("Enter membership ID: ");
            
            var memId = 4611686018471516071;

            var testItem = ManifestConnection.GetInventoryItemById(unchecked((int)3936625542));
            Console.WriteLine("--- START GetItemById");
            Console.WriteLine($"{testItem.DisplayProperties.Name} - {testItem.DisplaySource}");
            Console.WriteLine("--- END GetItemById\n");

            var bConfig = new BungieClientConfig
            {
                ApiKey = "secret",
                OAuthClientId = 39573,
                OAuthClientSecret = "secret",
                UserAgent = "Felicity/v4.0 (+will09600@gmail.com)"
            };
            var bClient = new BungieApiClient(bConfig);

            var memberships = bClient.Api.Destiny2_GetLinkedProfiles(memId, BungieMembershipType.All, true);
            Console.WriteLine("--- START GetLinkedProfiles");
            var applicableMembershipTypes = memberships.Result.Profiles.FirstOrDefault()?.ApplicableMembershipTypes;
            if (applicableMembershipTypes != null)
            {
                var platforms = string.Join(", ", applicableMembershipTypes);
                Console.WriteLine(
                    $"{memberships.Result.BnetMembership.SupplementalDisplayName} (Linked platforms: {platforms})");
            }

            Console.WriteLine("--- END GetLinkedProfiles\n");

            var profile = bClient.Api.Destiny2_GetProfile(memId,
                memberships.Result.Profiles.FirstOrDefault()!.MembershipType, new[]
                {
                    DestinyComponentType.Profiles, DestinyComponentType.Collectibles
                });

            Console.WriteLine("--- START GetProfile");
            Console.WriteLine($"{profile.Result.Profile.Data.UserInfo.DisplayName}:\n\tPrivacy: {profile.Result.Profile.Privacy}\n\tCharacter IDs: {string.Join(", ", profile.Result.Profile.Data.CharacterIds)}");
            Console.WriteLine("--- END GetProfile\n");

            /*
              Console.WriteLine("--- START GetBrightEngrams");
              Console.WriteLine($"Character has: {GetBrightEngrams(memId, memberships.Result.Profiles.FirstOrDefault()!.MembershipType)} bright engrams.");
              Console.WriteLine("--- END GetBrightEngrams\n");
            */


            Console.WriteLine("--- START FetchEmblems");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var emblemCount = 0;

            foreach (var (key, value) in profile.Result.ProfileCollectibles.Data.Collectibles)
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
                    if (!emblemList.Contains(manifestCollectibleParentNodeHash))
                        continue;

                    emblemCount++;
                    
                    if (value.State.HasFlag(DestinyCollectibleState.UniquenessViolation) && value.State.HasFlag(DestinyCollectibleState.NotAcquired))
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
            var url = $"/Platform/Destiny2/{(int) memType}/Profile/{memId}/?components=201";
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