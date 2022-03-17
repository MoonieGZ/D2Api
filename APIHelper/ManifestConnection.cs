using System.Data.SQLite;
using System.Linq;
using System.Text;
using APIHelper.Structs;
using Dapper;
using Newtonsoft.Json;

namespace APIHelper
{
    public class ManifestConnection
    {
        public static string dbFile { get; set; }

        private static SQLiteConnection ManifestDBConnection() => new SQLiteConnection("Data Source=" + dbFile);

        internal static DestinyInventoryItemDefinition.Root GetInventoryItemById(int id)
        {
            using var cnn = ManifestDBConnection();
            cnn.Open();
            var result = cnn.Query<BaseManifestEntry>(
                @"SELECT json FROM DestinyInventoryItemDefinition WHERE Id = @id", new { id }).FirstOrDefault();
            if (result != null)
                return JsonConvert.DeserializeObject<DestinyInventoryItemDefinition.Root>(
                    Encoding.Default.GetString(result.json));

            return new DestinyInventoryItemDefinition.Root();
        }

        public static DestinyCollectibleDefinition GetItemCollectibleId(int id)
        {
            using var cnn = ManifestDBConnection();
            cnn.Open();
            var result = cnn.Query<BaseManifestEntry>(
                @"SELECT json FROM DestinyCollectibleDefinition WHERE Id = @id", new { id }).FirstOrDefault();
            return result != null ? DestinyCollectibleDefinition.FromJson(Encoding.Default.GetString(result.json)) : new DestinyCollectibleDefinition();
        }

        public static DestinyPresentationNodeDefinition GetPresentationNodeId(int id)
        {
            using var cnn = ManifestDBConnection();
            cnn.Open();
            var result = cnn.Query<BaseManifestEntry>(
                @"SELECT json FROM DestinyPresentationNodeDefinition WHERE Id = @id", new { id }).FirstOrDefault();
            return result != null ? DestinyPresentationNodeDefinition.FromJson(Encoding.Default.GetString(result.json)) : new DestinyPresentationNodeDefinition();
        }
    }
}
