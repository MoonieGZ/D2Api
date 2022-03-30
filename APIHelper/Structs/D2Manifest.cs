using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

// ReSharper disable PartialTypeWithSinglePart

namespace APIHelper.Structs
{
    public partial class D2Manifest
    {
        [J("Response")] public Response Response { get; set; }
        [J("ErrorCode")] public long ErrorCode { get; set; }
        [J("ThrottleSeconds")] public long ThrottleSeconds { get; set; }
        [J("ErrorStatus")] public string ErrorStatus { get; set; }
        [J("Message")] public string Message { get; set; }
        [J("MessageData")] public MessageData MessageData { get; set; }
    }

    public partial class MessageData
    {
    }

    public partial class Response
    {
        [J("version")] public string Version { get; set; }
        [J("mobileAssetContentPath")] public string MobileAssetContentPath { get; set; }
        [J("mobileGearAssetDataBases")] public MobileGearAssetDataBasis[] MobileGearAssetDataBases { get; set; }
        [J("mobileWorldContentPaths")] public WorldContentPaths MobileWorldContentPaths { get; set; }
        [J("jsonWorldContentPaths")] public WorldContentPaths JsonWorldContentPaths { get; set; }
        [J("jsonWorldComponentContentPaths")] public JsonWorldComponentContentPaths JsonWorldComponentContentPaths { get; set; }
        [J("mobileClanBannerDatabasePath")] public string MobileClanBannerDatabasePath { get; set; }
        [J("mobileGearCDN")] public MobileGearCdn MobileGearCdn { get; set; }
        [J("iconImagePyramidInfo")] public object[] IconImagePyramidInfo { get; set; }
    }

    public partial class JsonWorldComponentContentPaths
    {
        [J("en")] public Dictionary<string, string> En { get; set; }
        [J("fr")] public Dictionary<string, string> Fr { get; set; }
        [J("es")] public Dictionary<string, string> Es { get; set; }
        [J("es-mx")] public Dictionary<string, string> EsMx { get; set; }
        [J("de")] public Dictionary<string, string> De { get; set; }
        [J("it")] public Dictionary<string, string> It { get; set; }
        [J("ja")] public Dictionary<string, string> Ja { get; set; }
        [J("pt-br")] public Dictionary<string, string> PtBr { get; set; }
        [J("ru")] public Dictionary<string, string> Ru { get; set; }
        [J("pl")] public Dictionary<string, string> Pl { get; set; }
        [J("ko")] public Dictionary<string, string> Ko { get; set; }
        [J("zh-cht")] public Dictionary<string, string> ZhCht { get; set; }
        [J("zh-chs")] public Dictionary<string, string> ZhChs { get; set; }
    }

    public partial class WorldContentPaths
    {
        [J("en")] public string En { get; set; }
        [J("fr")] public string Fr { get; set; }
        [J("es")] public string Es { get; set; }
        [J("es-mx")] public string EsMx { get; set; }
        [J("de")] public string De { get; set; }
        [J("it")] public string It { get; set; }
        [J("ja")] public string Ja { get; set; }
        [J("pt-br")] public string PtBr { get; set; }
        [J("ru")] public string Ru { get; set; }
        [J("pl")] public string Pl { get; set; }
        [J("ko")] public string Ko { get; set; }
        [J("zh-cht")] public string ZhCht { get; set; }
        [J("zh-chs")] public string ZhChs { get; set; }
    }

    public partial class MobileGearAssetDataBasis
    {
        [J("version")] public long Version { get; set; }
        [J("path")] public string Path { get; set; }
    }

    public partial class MobileGearCdn
    {
        [J("Geometry")] public string Geometry { get; set; }
        [J("Texture")] public string Texture { get; set; }
        [J("PlateRegion")] public string PlateRegion { get; set; }
        [J("Gear")] public string Gear { get; set; }
        [J("Shader")] public string Shader { get; set; }
    }
}