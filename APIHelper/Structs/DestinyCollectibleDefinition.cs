using Newtonsoft.Json;

namespace APIHelper.Structs
{
    using J = JsonPropertyAttribute;
    using N = Newtonsoft.Json.NullValueHandling;

    public partial class DestinyCollectibleDefinition
    {
        [J("displayProperties")] public DisplayProperties DisplayProperties { get; set; }
        [J("scope")] public long Scope { get; set; }
        [J("sourceString")] public string SourceString { get; set; }
        [J("sourceHash")] public long SourceHash { get; set; }
        [J("itemHash")] public long ItemHash { get; set; }
        [J("acquisitionInfo")] public AcquisitionInfo AcquisitionInfo { get; set; }
        [J("stateInfo")] public StateInfo StateInfo { get; set; }
        [J("presentationNodeType")] public long PresentationNodeType { get; set; }
        [J("traitIds")] public object[] TraitIds { get; set; }
        [J("traitHashes")] public object[] TraitHashes { get; set; }
        [J("parentNodeHashes")] public long[] ParentNodeHashes { get; set; }
        [J("hash")] public long Hash { get; set; }
        [J("index")] public long Index { get; set; }
        [J("redacted")] public bool Redacted { get; set; }
        [J("blacklisted")] public bool Blacklisted { get; set; }
    }

    public class AcquisitionInfo
    {
        [J("runOnlyAcquisitionRewardSite")] public bool RunOnlyAcquisitionRewardSite { get; set; }
    }

    public class DisplayProperties
    {
        [J("description")] public string Description { get; set; }
        [J("name")] public string Name { get; set; }
        [J("icon", NullValueHandling = N.Ignore)] public string Icon { get; set; }
        [J("iconSequences", NullValueHandling = N.Ignore)] public IconSequence[] IconSequences { get; set; }
        [J("hasIcon")] public bool HasIcon { get; set; }
    }

    public class IconSequence
    {
        [J("frames")] public string[] Frames { get; set; }
    }

    public class StateInfo
    {
        [J("requirements")] public Requirements Requirements { get; set; }
    }

    public class Requirements
    {
        [J("entitlementUnavailableMessage")] public string EntitlementUnavailableMessage { get; set; }
    }

    public partial class DestinyCollectibleDefinition
    {
        public static DestinyCollectibleDefinition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<DestinyCollectibleDefinition>(json, Converter.Settings);
        }
    }
}