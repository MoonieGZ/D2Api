﻿using System.Net.Http;

namespace APIHelper
{
    public class RemoteAPI
    {
        public const string apiBaseUrl = "https://bungie.net";
        public static string BungieAPIKey { get; set; }

        public static string Query(string url)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-API-Key", BungieAPIKey);

            var response = client.GetAsync(apiBaseUrl + url).Result;
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
