using System.Data.SQLite;
using System.Linq;
using System.Text;
using APIHelper.Structs;
using Dapper;
using Newtonsoft.Json;

namespace APIHelper
{
    internal class ManifestConnection
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
    }
}
