using System.Data.SQLite;
using System.Linq;
using System.Text;
using APIHelper.Structs;
using Dapper;

namespace APIHelper
{
    public class ManifestConnection
    {
        public static string dbFile { get; set; }

        private static SQLiteConnection ManifestDBConnection() => new SQLiteConnection("Data Source=" + dbFile);

        public static DestinyInventoryItemDefinition GetInventoryItemById(int id)
        {
            using var cnn = ManifestDBConnection();
            cnn.Open();
            var result = cnn.Query<BaseManifestEntry>(
                @"SELECT json FROM DestinyInventoryItemDefinition WHERE Id = @id", new { id }).FirstOrDefault();
            return result != null ? DestinyInventoryItemDefinition.FromJson(Encoding.Default.GetString(result.json)) : new DestinyInventoryItemDefinition();
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
