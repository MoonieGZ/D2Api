using APIHelper.Structs;

namespace APIHelper
{
    public class Manifest
    {
        public static DestinyInventoryItemDefinition.Root GetItemById(int id) => ManifestConnection.GetInventoryItemById(id);
    }
}
