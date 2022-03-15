using System;
using System.Collections.Generic;
// ReSharper disable UnusedMember.Global

namespace APIHelper.Structs
{
    public class DestinyProfile
    {
        public class UserInfo
        {
            public BungieMembershipType crossSaveOverride { get; set; }
            public List<BungieMembershipType> applicableMembershipTypes { get; set; }
            public bool isPublic { get; set; }
            public BungieMembershipType membershipType { get; set; }
            public string membershipId { get; set; }
            public string displayName { get; set; }
            public string bungieGlobalDisplayName { get; set; }
            public int bungieGlobalDisplayNameCode { get; set; }
        }

        public class Data
        {
            public UserInfo userInfo { get; set; }
            public DateTime dateLastPlayed { get; set; }
            public int versionsOwned { get; set; } // this is a bitmask
            public List<string> characterIds { get; set; }
            public List<long> seasonHashes { get; set; }
            public long currentSeasonHash { get; set; }
            public int currentSeasonRewardPowerCap { get; set; }
        }

        public class Profile
        {
            public Data data { get; set; }
            public Components.ComponentPrivacySetting privacy { get; set; }
        }

        public class Response
        {
            public Profile profile { get; set; }
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
}
