using System;
using APIHelper;
using APIHelper.Structs;

namespace D2Api
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine($"Manifest loaded: {API.FetchManifest("a92d9c461ea649e29f5dc89d42fc181e")}");
            Console.WriteLine();

            var reeds = Manifest.GetItemById(-1819611640);
            Console.WriteLine("--- START GetItemById");
            Console.WriteLine($"{reeds.displayProperties.name} - {reeds.flavorText}");
            Console.WriteLine("--- END GetItemById\n");

            var memberships = API.GetLinkedProfiles(4611686018471516071, BungieMembershipType.Steam, true);
            Console.WriteLine("--- START GetLinkedProfiles");
            var platforms = string.Join(", ", memberships.Response.profiles[0].applicableMembershipTypes);
            Console.WriteLine($"{memberships.Response.bnetMembership.supplementalDisplayName} (Linked platforms: {platforms})");
            Console.WriteLine("--- END GetLinkedProfiles\n");

            Console.WriteLine("");
        }
    }
}
