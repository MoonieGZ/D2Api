using System.Collections.Generic;

namespace APIHelper.Structs
{
    public class D2Manifest
    {
        public class WorldContentPaths
        {
            public string en { get; set; }
        }

        public class Response
        {
            public string version { get; set; }
            public WorldContentPaths mobileWorldContentPaths { get; set; }
            public string mobileClanBannerDatabasePath { get; set; }
            public List<object> iconImagePyramidInfo { get; set; }
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