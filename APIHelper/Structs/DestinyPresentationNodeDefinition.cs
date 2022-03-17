using Newtonsoft.Json;

namespace APIHelper.Structs
{
    using J = JsonPropertyAttribute;

    public partial class DestinyPresentationNodeDefinition
    {
        [J("displayProperties")] public DisplayProperties DisplayProperties { get; set; }
        [J("nodeType")] public long NodeType { get; set; }
        [J("scope")] public long Scope { get; set; }
        [J("objectiveHash")] public long ObjectiveHash { get; set; }
        [J("children")] public Children Children { get; set; }
        [J("displayStyle")] public long DisplayStyle { get; set; }
        [J("screenStyle")] public long ScreenStyle { get; set; }
        [J("requirements")] public Requirements Requirements { get; set; }
        [J("disableChildSubscreenNavigation")] public bool DisableChildSubscreenNavigation { get; set; }
        [J("categoryScoreUnlockValueHash")] public long CategoryScoreUnlockValueHash { get; set; }
        [J("maxCategoryRecordScore")] public long MaxCategoryRecordScore { get; set; }
        [J("presentationNodeType")] public long PresentationNodeType { get; set; }
        [J("traitIds")] public object[] TraitIds { get; set; }
        [J("traitHashes")] public object[] TraitHashes { get; set; }
        [J("parentNodeHashes")] public long[] ParentNodeHashes { get; set; }
        [J("hash")] public long Hash { get; set; }
        [J("index")] public long Index { get; set; }
        [J("redacted")] public bool Redacted { get; set; }
        [J("blacklisted")] public bool Blacklisted { get; set; }
    }

    public class Children
    {
        [J("presentationNodes")] public object[] PresentationNodes { get; set; }
        [J("collectibles")] public PresentationCollectible[] Collectibles { get; set; }
        [J("records")] public object[] Records { get; set; }
        [J("metrics")] public object[] Metrics { get; set; }
        [J("craftables")] public object[] Craftables { get; set; }
    }

    public class PresentationCollectible
    {
        [J("collectibleHash")] public long CollectibleHash { get; set; }
        [J("nodeDisplayPriority")] public long NodeDisplayPriority { get; set; }
    }

    public partial class DestinyPresentationNodeDefinition
    {
        public static DestinyPresentationNodeDefinition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<DestinyPresentationNodeDefinition>(json, Converter.Settings);
        }
    }
}