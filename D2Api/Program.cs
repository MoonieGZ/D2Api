using System;
using APIHelper;
using APIHelper.Structs;

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

            var reeds = Manifest.GetItemById(-1819611640);
            Console.WriteLine("--- START GetItemById");
            Console.WriteLine($"{reeds.displayProperties.name} - {reeds.flavorText}");
            Console.WriteLine("--- END GetItemById\n");

            var memberships = API.GetLinkedProfiles(4611686018471516071, BungieMembershipType.Steam, true);
            Console.WriteLine("--- START GetLinkedProfiles");
            var platforms = string.Join(", ", memberships.Response.profiles[0].applicableMembershipTypes);
            Console.WriteLine(
                $"{memberships.Response.bnetMembership.supplementalDisplayName} (Linked platforms: {platforms})");
            Console.WriteLine("--- END GetLinkedProfiles\n");

            var profile = API.GetProfile(4611686018471516071, BungieMembershipType.Steam, new[]
            {
                Components.QueryComponents.Profiles
            });
            Console.WriteLine("--- START GetProfile");
            Console.WriteLine($"{profile.Response.profile.data.userInfo.displayName}:\n\tPrivacy: {profile.Response.profile.privacy}\n\tCharacter IDs: {string.Join(", ", profile.Response.profile.data.characterIds)}");
            Console.WriteLine("--- END GetProfile");

            Console.ReadKey(true);
        }
    }
}