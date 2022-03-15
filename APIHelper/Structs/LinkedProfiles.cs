using System;
using System.Collections.Generic;
// ReSharper disable UnusedMember.Global

namespace APIHelper.Structs
{
    public class LinkedProfiles
    {
        public class Platform
        {
            public long itemHash { get; set; }
            public int quantity { get; set; }
            public int bindStatus { get; set; }
            public int location { get; set; }
            public int bucketHash { get; set; }
            public int transferStatus { get; set; }
            public bool lockable { get; set; }
            public int state { get; set; }
            public int dismantlePermission { get; set; }
            public bool isWrapper { get; set; }
        }

        public class PlatformSilver
        {
            public Platform TigerPsn { get; set; }
            public Platform TigerXbox { get; set; }
            public Platform TigerBlizzard { get; set; }
            public Platform TigerStadia { get; set; }
            public Platform TigerSteam { get; set; }
            public Platform BungieNext { get; set; }
            public PlatformSilver platformSilver { get; set; }
        }

        public class Profile
        {
            public DateTime dateLastPlayed { get; set; }
            public bool isOverridden { get; set; }
            public bool isCrossSavePrimary { get; set; }
            public PlatformSilver platformSilver { get; set; }
            public int crossSaveOverride { get; set; }
            public List<BungieMembershipType> applicableMembershipTypes { get; set; }
            public bool isPublic { get; set; }
            public BungieMembershipType membershipType { get; set; }
            public string membershipId { get; set; }
            public string displayName { get; set; }
            public string bungieGlobalDisplayName { get; set; }
            public int bungieGlobalDisplayNameCode { get; set; }
        }

        public class BnetMembership
        {
            public string supplementalDisplayName { get; set; }
            public string iconPath { get; set; }
            public int crossSaveOverride { get; set; }
            public bool isPublic { get; set; }
            public BungieMembershipType membershipType { get; set; }
            public string membershipId { get; set; }
            public string displayName { get; set; }
            public string bungieGlobalDisplayName { get; set; }
            public int bungieGlobalDisplayNameCode { get; set; }
        }

        public class InfoCard
        {
            public int crossSaveOverride { get; set; }
            public List<BungieMembershipType> applicableMembershipTypes { get; set; }
            public bool isPublic { get; set; }
            public BungieMembershipType membershipType { get; set; }
            public string membershipId { get; set; }
            public string displayName { get; set; }
            public string bungieGlobalDisplayName { get; set; }
            public int bungieGlobalDisplayNameCode { get; set; }
        }

        public class ProfilesWithError
        {
            public int errorCode { get; set; }
            public InfoCard infoCard { get; set; }
        }

        public class Response
        {
            public List<Profile> profiles { get; set; }
            public BnetMembership bnetMembership { get; set; }
            public List<ProfilesWithError> profilesWithErrors { get; set; }
        }

        public class MessageData
        {
        }

        public class Root
        {
            public Response Response { get; set; }
            public int ErrorCode { get; set; }
            public int ThrottleSeconds { get; set; }
            public string ErrorStatus { get; set; }
            public string Message { get; set; }
            public MessageData MessageData { get; set; }
        }
    }

    public enum BungieMembershipType
    {
        None = 0,
        Xbox = 1,
        Psn = 2,
        Steam = 3,
        Blizzard = 4,
        Stadia = 5,
        Demon = 10,
        BungieNext = 254,
        All = -1
    }
}