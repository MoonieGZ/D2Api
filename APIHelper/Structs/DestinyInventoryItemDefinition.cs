// ReSharper disable PartialTypeWithSinglePart
namespace APIHelper.Structs
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using J = Newtonsoft.Json.JsonPropertyAttribute;
    using N = Newtonsoft.Json.NullValueHandling;

    public partial class DestinyInventoryItemDefinition
    {
        [J("displayProperties")] public DisplayProperties DisplayProperties { get; set; }
        [J("tooltipNotifications")] public object[] TooltipNotifications { get; set; }
        [J("collectibleHash")] public long CollectibleHash { get; set; }
        [J("iconWatermark")] public string IconWatermark { get; set; }
        [J("iconWatermarkShelved")] public string IconWatermarkShelved { get; set; }
        [J("backgroundColor")] public BackgroundColor BackgroundColor { get; set; }
        [J("screenshot")] public string Screenshot { get; set; }
        [J("itemTypeDisplayName")] public string ItemTypeDisplayName { get; set; }
        [J("flavorText")] public string FlavorText { get; set; }
        [J("uiItemDisplayStyle")] public string UiItemDisplayStyle { get; set; }
        [J("itemTypeAndTierDisplayName")] public string ItemTypeAndTierDisplayName { get; set; }
        [J("displaySource")] public string DisplaySource { get; set; }
        [J("action")] public Action Action { get; set; }
        [J("inventory")] public Inventory Inventory { get; set; }
        [J("stats")] public Stats Stats { get; set; }
        [J("equippingBlock")] public EquippingBlock EquippingBlock { get; set; }
        [J("translationBlock")] public TranslationBlock TranslationBlock { get; set; }
        [J("preview")] public Preview Preview { get; set; }
        [J("quality")] public Quality Quality { get; set; }
        [J("plug")] public Plug Plug { get; set; }
        [J("acquireRewardSiteHash")] public long AcquireRewardSiteHash { get; set; }
        [J("acquireUnlockHash")] public long AcquireUnlockHash { get; set; }
        [J("sockets")] public Sockets Sockets { get; set; }
        [J("talentGrid")] public TalentGrid TalentGrid { get; set; }
        [J("investmentStats")] public InvestmentStat[] InvestmentStats { get; set; }
        [J("perks")] public object[] Perks { get; set; }
        [J("summaryItemHash")] public long SummaryItemHash { get; set; }
        [J("allowActions")] public bool AllowActions { get; set; }
        [J("doesPostmasterPullHaveSideEffects")] public bool DoesPostmasterPullHaveSideEffects { get; set; }
        [J("nonTransferrable")] public bool NonTransferrable { get; set; }
        [J("itemCategoryHashes")] public long[] ItemCategoryHashes { get; set; }
        [J("specialItemType")] public long SpecialItemType { get; set; }
        [J("itemType")] public long ItemType { get; set; }
        [J("itemSubType")] public long ItemSubType { get; set; }
        [J("classType")] public long ClassType { get; set; }
        [J("breakerType")] public long BreakerType { get; set; }
        [J("equippable")] public bool Equippable { get; set; }
        [J("defaultDamageType")] public long DefaultDamageType { get; set; }
        [J("isWrapper")] public bool IsWrapper { get; set; }
        [J("traitIds")] public string[] TraitIds { get; set; }
        [J("traitHashes")] public long[] TraitHashes { get; set; }
        [J("hash")] public long Hash { get; set; }
        [J("index")] public long Index { get; set; }
        [J("redacted")] public bool Redacted { get; set; }
        [J("blacklisted")] public bool Blacklisted { get; set; }
    }

    public partial class Action
    {
        [J("verbName")] public string VerbName { get; set; }
        [J("verbDescription")] public string VerbDescription { get; set; }
        [J("isPositive")] public bool IsPositive { get; set; }
        [J("requiredCooldownSeconds")] public long RequiredCooldownSeconds { get; set; }
        [J("requiredItems")] public object[] RequiredItems { get; set; }
        [J("progressionRewards")] public object[] ProgressionRewards { get; set; }
        [J("actionTypeLabel")] public string ActionTypeLabel { get; set; }
        [J("rewardSheetHash")] public long RewardSheetHash { get; set; }
        [J("rewardItemHash")] public long RewardItemHash { get; set; }
        [J("rewardSiteHash")] public long RewardSiteHash { get; set; }
        [J("requiredCooldownHash")] public long RequiredCooldownHash { get; set; }
        [J("deleteOnAction")] public bool DeleteOnAction { get; set; }
        [J("consumeEntireStack")] public bool ConsumeEntireStack { get; set; }
        [J("useOnAcquire")] public bool UseOnAcquire { get; set; }
    }

    public partial class BackgroundColor
    {
        [J("colorHash")] public long ColorHash { get; set; }
        [J("red")] public long Red { get; set; }
        [J("green")] public long Green { get; set; }
        [J("blue")] public long Blue { get; set; }
        [J("alpha")] public long Alpha { get; set; }
    }

    public partial class EquippingBlock
    {
        [J("uniqueLabelHash")] public long UniqueLabelHash { get; set; }
        [J("equipmentSlotTypeHash")] public long EquipmentSlotTypeHash { get; set; }
        [J("attributes")] public long Attributes { get; set; }
        [J("equippingSoundHash")] public long EquippingSoundHash { get; set; }
        [J("hornSoundHash")] public long HornSoundHash { get; set; }
        [J("ammoType")] public long AmmoType { get; set; }
        [J("displayStrings")] public string[] DisplayStrings { get; set; }
    }

    public partial class Inventory
    {
        [J("maxStackSize")] public long MaxStackSize { get; set; }
        [J("bucketTypeHash")] public long BucketTypeHash { get; set; }
        [J("recoveryBucketTypeHash")] public long RecoveryBucketTypeHash { get; set; }
        [J("tierTypeHash")] public long TierTypeHash { get; set; }
        [J("isInstanceItem")] public bool IsInstanceItem { get; set; }
        [J("nonTransferrableOriginal")] public bool NonTransferrableOriginal { get; set; }
        [J("tierTypeName")] public string TierTypeName { get; set; }
        [J("tierType")] public long TierType { get; set; }
        [J("expirationTooltip")] public string ExpirationTooltip { get; set; }
        [J("expiredInActivityMessage")] public string ExpiredInActivityMessage { get; set; }
        [J("expiredInOrbitMessage")] public string ExpiredInOrbitMessage { get; set; }
        [J("suppressExpirationWhenObjectivesComplete")] public bool SuppressExpirationWhenObjectivesComplete { get; set; }
    }

    public partial class InvestmentStat
    {
        [J("statTypeHash")] public long StatTypeHash { get; set; }
        [J("value")] public long Value { get; set; }
        [J("isConditionallyActive")] public bool IsConditionallyActive { get; set; }
    }

    public partial class Plug
    {
        [J("insertionRules")] public InsertionRule[] InsertionRules { get; set; }
        [J("plugCategoryIdentifier")] public string PlugCategoryIdentifier { get; set; }
        [J("plugCategoryHash")] public long PlugCategoryHash { get; set; }
        [J("onActionRecreateSelf")] public bool OnActionRecreateSelf { get; set; }
        [J("actionRewardSiteHash")] public long ActionRewardSiteHash { get; set; }
        [J("actionRewardItemOverrideHash")] public long ActionRewardItemOverrideHash { get; set; }
        [J("insertionMaterialRequirementHash")] public long InsertionMaterialRequirementHash { get; set; }
        [J("previewItemOverrideHash")] public long PreviewItemOverrideHash { get; set; }
        [J("enabledMaterialRequirementHash")] public long EnabledMaterialRequirementHash { get; set; }
        [J("enabledRules")] public object[] EnabledRules { get; set; }
        [J("uiPlugLabel")] public string UiPlugLabel { get; set; }
        [J("plugStyle")] public long PlugStyle { get; set; }
        [J("plugAvailability")] public long PlugAvailability { get; set; }
        [J("alternateUiPlugLabel")] public string AlternateUiPlugLabel { get; set; }
        [J("alternatePlugStyle")] public long AlternatePlugStyle { get; set; }
        [J("isDummyPlug")] public bool IsDummyPlug { get; set; }
        [J("applyStatsToSocketOwnerItem")] public bool ApplyStatsToSocketOwnerItem { get; set; }
    }

    public partial class InsertionRule
    {
        [J("failureMessage")] public string FailureMessage { get; set; }
    }

    public partial class Preview
    {
        [J("screenStyle")] public string ScreenStyle { get; set; }
        [J("previewVendorHash")] public long PreviewVendorHash { get; set; }
        [J("previewActionString")] public string PreviewActionString { get; set; }
    }

    public partial class Quality
    {
        [J("itemLevels")] public object[] ItemLevels { get; set; }
        [J("qualityLevel")] public long QualityLevel { get; set; }
        [J("infusionCategoryName")] public string InfusionCategoryName { get; set; }
        [J("infusionCategoryHash")] public long InfusionCategoryHash { get; set; }
        [J("infusionCategoryHashes")] public long[] InfusionCategoryHashes { get; set; }
        [J("progressionLevelRequirementHash")] public long ProgressionLevelRequirementHash { get; set; }
        [J("currentVersion")] public long CurrentVersion { get; set; }
        [J("versions")] public Version[] Versions { get; set; }
        [J("displayVersionWatermarkIcons")] public string[] DisplayVersionWatermarkIcons { get; set; }
    }

    public partial class Version
    {
        [J("powerCapHash")] public long PowerCapHash { get; set; }
    }

    public partial class Sockets
    {
        [J("detail")] public string Detail { get; set; }
        [J("socketEntries")] public SocketEntry[] SocketEntries { get; set; }
        [J("intrinsicSockets")] public IntrinsicSocket[] IntrinsicSockets { get; set; }
        [J("socketCategories")] public SocketCategory[] SocketCategories { get; set; }
    }

    public partial class IntrinsicSocket
    {
        [J("plugItemHash")] public long PlugItemHash { get; set; }
        [J("socketTypeHash")] public long SocketTypeHash { get; set; }
        [J("defaultVisible")] public bool DefaultVisible { get; set; }
    }

    public partial class SocketCategory
    {
        [J("socketCategoryHash")] public long SocketCategoryHash { get; set; }
        [J("socketIndexes")] public long[] SocketIndexes { get; set; }
    }

    public partial class SocketEntry
    {
        [J("socketTypeHash")] public long SocketTypeHash { get; set; }
        [J("singleInitialItemHash")] public long SingleInitialItemHash { get; set; }
        [J("reusablePlugItems")] public ReusablePlugItem[] ReusablePlugItems { get; set; }
        [J("preventInitializationOnVendorPurchase")] public bool PreventInitializationOnVendorPurchase { get; set; }
        [J("preventInitializationWhenVersioning")] public bool PreventInitializationWhenVersioning { get; set; }
        [J("hidePerksInItemTooltip")] public bool HidePerksInItemTooltip { get; set; }
        [J("plugSources")] public long PlugSources { get; set; }
        [J("reusablePlugSetHash", NullValueHandling = N.Ignore)] public long? ReusablePlugSetHash { get; set; }
        [J("overridesUiAppearance")] public bool OverridesUiAppearance { get; set; }
        [J("defaultVisible")] public bool DefaultVisible { get; set; }
        [J("randomizedPlugSetHash", NullValueHandling = N.Ignore)] public long? RandomizedPlugSetHash { get; set; }
    }

    public partial class ReusablePlugItem
    {
        [J("plugItemHash")] public long PlugItemHash { get; set; }
    }

    public partial class Stats
    {
        [J("disablePrimaryStatDisplay")] public bool DisablePrimaryStatDisplay { get; set; }
        [J("statGroupHash")] public long StatGroupHash { get; set; }
        [J("stats")] public Dictionary<string, Stat> StatsStats { get; set; }
        [J("hasDisplayableStats")] public bool HasDisplayableStats { get; set; }
        [J("primaryBaseStatHash")] public long PrimaryBaseStatHash { get; set; }
    }

    public partial class Stat
    {
        [J("minimum")] public long Minimum { get; set; }
        [J("maximum")] public long Maximum { get; set; }
        [J("displayMaximum")] public long DisplayMaximum { get; set; }
    }

    public partial class TalentGrid
    {
        [J("talentGridHash")] public long TalentGridHash { get; set; }
        [J("itemDetailString")] public string ItemDetailString { get; set; }
        [J("hudDamageType")] public long HudDamageType { get; set; }
    }

    public partial class TranslationBlock
    {
        [J("weaponPatternHash")] public long WeaponPatternHash { get; set; }
        [J("defaultDyes")] public DefaultDye[] DefaultDyes { get; set; }
        [J("lockedDyes")] public object[] LockedDyes { get; set; }
        [J("customDyes")] public object[] CustomDyes { get; set; }
        [J("arrangements")] public Arrangement[] Arrangements { get; set; }
        [J("hasGeometry")] public bool HasGeometry { get; set; }
    }

    public partial class Arrangement
    {
        [J("classHash")] public long ClassHash { get; set; }
        [J("artArrangementHash")] public long ArtArrangementHash { get; set; }
    }

    public partial class DefaultDye
    {
        [J("channelHash")] public long ChannelHash { get; set; }
        [J("dyeHash")] public long DyeHash { get; set; }
    }

    public partial class DestinyInventoryItemDefinition
    {
        public static DestinyInventoryItemDefinition FromJson(string json) => JsonConvert.DeserializeObject<DestinyInventoryItemDefinition>(json, Converter.Settings);
    }
}
