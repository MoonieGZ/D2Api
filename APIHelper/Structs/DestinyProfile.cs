using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace APIHelper.Structs
{
    using J = JsonPropertyAttribute;
    using N = NullValueHandling;

    public partial class DestinyProfile
    {
        [J("Response")] public Response Response { get; set; }
        [J("ErrorCode")] public long ErrorCode { get; set; }
        [J("ThrottleSeconds")] public long ThrottleSeconds { get; set; }
        [J("ErrorStatus")] public string ErrorStatus { get; set; }
        [J("Message")] public string Message { get; set; }
        [J("MessageData")] public MessageData MessageData { get; set; }
    }

    public class MessageData
    {
    }

    public class Response
    {
        [J("vendorReceipts")] public CharacterCurrencyLookups VendorReceipts { get; set; }
        [J("profileInventory")] public CharacterCurrencyLookups ProfileInventory { get; set; }
        [J("profileCurrencies")] public CharacterCurrencyLookups ProfileCurrencies { get; set; }
        [J("profile")] public Profile Profile { get; set; }
        [J("platformSilver")] public CharacterCurrencyLookups PlatformSilver { get; set; }
        [J("profileKiosks")] public ProfileKiosks ProfileKiosks { get; set; }
        [J("profilePlugSets")] public ProfilePlugSets ProfilePlugSets { get; set; }
        [J("profileProgression")] public ProfileProgression ProfileProgression { get; set; }
        [J("profilePresentationNodes")] public ProfilePresentationNodes ProfilePresentationNodes { get; set; }
        [J("profileRecords")] public ProfileRecords ProfileRecords { get; set; }
        [J("profileCollectibles")] public ProfileCollectibles ProfileCollectibles { get; set; }
        [J("profileTransitoryData")] public CharacterCurrencyLookups ProfileTransitoryData { get; set; }
        [J("metrics")] public Metrics Metrics { get; set; }
        [J("profileStringVariables")] public ProfileStringVariables ProfileStringVariables { get; set; }
        [J("characters")] public Characters Characters { get; set; }
        [J("characterInventories")] public CharacterCurrencyLookups CharacterInventories { get; set; }
        [J("characterProgressions")] public CharacterProgressions CharacterProgressions { get; set; }
        [J("characterRenderData")] public CharacterRenderData CharacterRenderData { get; set; }
        [J("characterActivities")] public CharacterActivities CharacterActivities { get; set; }
        [J("characterEquipment")] public CharacterEquipment CharacterEquipment { get; set; }
        [J("characterKiosks")] public CharacterKiosks CharacterKiosks { get; set; }
        [J("characterPlugSets")] public CharacterPlugSets CharacterPlugSets { get; set; }

        [J("characterUninstancedItemComponents")]
        public Dictionary<string, CharacterUninstancedItemComponent> CharacterUninstancedItemComponents { get; set; }

        [J("characterPresentationNodes")] public CharacterPresentationNodes CharacterPresentationNodes { get; set; }
        [J("characterRecords")] public CharacterRecords CharacterRecords { get; set; }
        [J("characterCollectibles")] public CharacterCollectibles CharacterCollectibles { get; set; }
        [J("characterStringVariables")] public CharacterStringVariables CharacterStringVariables { get; set; }
        [J("characterCraftables")] public CharacterCraftables CharacterCraftables { get; set; }
        [J("itemComponents")] public ItemComponents ItemComponents { get; set; }
        [J("characterCurrencyLookups")] public CharacterCurrencyLookups CharacterCurrencyLookups { get; set; }
    }

    public class CharacterActivities
    {
        [J("data")] public Dictionary<string, CharacterActivitiesDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterActivitiesDatum
    {
        [J("dateActivityStarted")] public DateTimeOffset DateActivityStarted { get; set; }
        [J("availableActivities")] public AvailableActivity[] AvailableActivities { get; set; }
        [J("currentActivityHash")] public long CurrentActivityHash { get; set; }
        [J("currentActivityModeHash")] public long CurrentActivityModeHash { get; set; }
        [J("currentPlaylistActivityHash")] public long CurrentPlaylistActivityHash { get; set; }
        [J("lastCompletedStoryHash")] public long LastCompletedStoryHash { get; set; }
    }

    public class AvailableActivity
    {
        [J("activityHash")] public long ActivityHash { get; set; }
        [J("isNew")] public bool IsNew { get; set; }
        [J("canLead")] public bool CanLead { get; set; }
        [J("canJoin")] public bool CanJoin { get; set; }
        [J("isCompleted")] public bool IsCompleted { get; set; }
        [J("isVisible")] public bool IsVisible { get; set; }

        [J("displayLevel", NullValueHandling = N.Ignore)]
        public long? DisplayLevel { get; set; }

        [J("recommendedLight", NullValueHandling = N.Ignore)]
        public long? RecommendedLight { get; set; }

        [J("difficultyTier")] public long DifficultyTier { get; set; }

        [J("challenges", NullValueHandling = N.Ignore)]
        public Challenge[] Challenges { get; set; }

        [J("modifierHashes", NullValueHandling = N.Ignore)]
        public long[] ModifierHashes { get; set; }

        [J("booleanActivityOptions", NullValueHandling = N.Ignore)]
        public Dictionary<string, bool> BooleanActivityOptions { get; set; }
    }

    public class Challenge
    {
        [J("objective")] public ObjectiveProgress Objective { get; set; }
    }

    public class ObjectiveProgress
    {
        [J("objectiveHash")] public long ObjectiveHash { get; set; }

        [J("activityHash", NullValueHandling = N.Ignore)]
        public long? ActivityHash { get; set; }

        [J("progress")] public long Progress { get; set; }
        [J("completionValue")] public long CompletionValue { get; set; }
        [J("complete")] public bool Complete { get; set; }
        [J("visible")] public bool Visible { get; set; }

        [J("destinationHash", NullValueHandling = N.Ignore)]
        public long? DestinationHash { get; set; }
    }

    public class CharacterCollectibles
    {
        [J("data")] public Dictionary<string, CharacterCollectiblesDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterCollectiblesDatum
    {
        [J("collectibles")] public Dictionary<string, Collectible> Collectibles { get; set; }

        [J("collectionCategoriesRootNodeHash")]
        public long CollectionCategoriesRootNodeHash { get; set; }

        [J("collectionBadgesRootNodeHash")] public long CollectionBadgesRootNodeHash { get; set; }
    }

    public class Collectible
    {
        [J("state")] public Components.State State { get; set; }
    }

    public class CharacterCraftables
    {
        [J("data")] public Dictionary<string, CharacterCraftablesDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterCraftablesDatum
    {
        [J("craftables")] public Dictionary<string, Craftable> Craftables { get; set; }
        [J("craftingRootNodeHash")] public long CraftingRootNodeHash { get; set; }
    }

    public class Craftable
    {
        [J("visible")] public bool Visible { get; set; }
        [J("failedRequirementIndexes")] public long[] FailedRequirementIndexes { get; set; }
        [J("sockets")] public CraftableSocket[] Sockets { get; set; }
    }

    public class CraftableSocket
    {
        [J("plugSetHash")] public long PlugSetHash { get; set; }

        [J("plugs", NullValueHandling = N.Ignore)]
        public SocketPlug[] Plugs { get; set; }
    }

    public class SocketPlug
    {
        [J("plugItemHash")] public long PlugItemHash { get; set; }
        [J("failedRequirementIndexes")] public long[] FailedRequirementIndexes { get; set; }
    }

    public class CharacterCurrencyLookups
    {
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterEquipment
    {
        [J("data")] public Dictionary<string, CharacterEquipmentDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterEquipmentDatum
    {
        [J("items")] public DatumItem[] Items { get; set; }
    }

    public class DatumItem
    {
        [J("itemHash")] public long ItemHash { get; set; }
        [J("itemInstanceId")] public string ItemInstanceId { get; set; }
        [J("quantity")] public long Quantity { get; set; }
        [J("bindStatus")] public long BindStatus { get; set; }
        [J("location")] public long Location { get; set; }
        [J("bucketHash")] public long BucketHash { get; set; }
        [J("transferStatus")] public long TransferStatus { get; set; }
        [J("lockable")] public bool Lockable { get; set; }
        [J("state")] public long State { get; set; }
        [J("dismantlePermission")] public long DismantlePermission { get; set; }
        [J("isWrapper")] public bool IsWrapper { get; set; }
        [J("tooltipNotificationIndexes")] public long[] TooltipNotificationIndexes { get; set; }

        [J("versionNumber", NullValueHandling = N.Ignore)]
        public long? VersionNumber { get; set; }

        [J("overrideStyleItemHash", NullValueHandling = N.Ignore)]
        public long? OverrideStyleItemHash { get; set; }
    }

    public class CharacterKiosks
    {
        [J("data")] public Dictionary<string, CharacterKiosksData> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterKiosksData
    {
        [J("kioskItems")] public MessageData KioskItems { get; set; }
    }

    public class CharacterPlugSets
    {
        [J("data")] public Dictionary<string, CharacterPlugSetsDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterPlugSetsDatum
    {
        [J("plugs")] public Dictionary<string, DatumElement[]> Plugs { get; set; }
    }

    public class DatumElement
    {
        [J("plugItemHash")] public long PlugItemHash { get; set; }
        [J("canInsert")] public bool CanInsert { get; set; }
        [J("enabled")] public bool Enabled { get; set; }

        [J("insertFailIndexes", NullValueHandling = N.Ignore)]
        public long[] InsertFailIndexes { get; set; }
    }

    public class CharacterPresentationNodes
    {
        [J("data")] public Dictionary<string, CharacterPresentationNodesData> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterPresentationNodesData
    {
        [J("nodes")] public Dictionary<string, NodeValue> Nodes { get; set; }
    }

    public class NodeValue
    {
        [J("state")] public long State { get; set; }

        [J("objective", NullValueHandling = N.Ignore)]
        public ObjectiveProgress Objective { get; set; }

        [J("progressValue")] public long ProgressValue { get; set; }
        [J("completionValue")] public long CompletionValue { get; set; }

        [J("recordCategoryScore", NullValueHandling = N.Ignore)]
        public long? RecordCategoryScore { get; set; }
    }

    public class CharacterProgressions
    {
        [J("data")] public Dictionary<string, CharacterProgressionsDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterProgressionsDatum
    {
        [J("progressions")] public Dictionary<string, Ion> Progressions { get; set; }
        [J("factions")] public Dictionary<string, Ion> Factions { get; set; }
        [J("milestones")] public Dictionary<string, Milestone> Milestones { get; set; }
        [J("quests")] public object[] Quests { get; set; }

        [J("uninstancedItemObjectives")]
        public Dictionary<string, ObjectiveProgress[]> UninstancedItemObjectives { get; set; }

        [J("uninstancedItemPerks")] public MessageData UninstancedItemPerks { get; set; }
        [J("checklists")] public Dictionary<string, Dictionary<string, bool>> Checklists { get; set; }
        [J("seasonalArtifact")] public DatumSeasonalArtifact SeasonalArtifact { get; set; }
    }

    public class Ion
    {
        [J("factionHash", NullValueHandling = N.Ignore)]
        public long? FactionHash { get; set; }

        [J("factionVendorIndex", NullValueHandling = N.Ignore)]
        public long? FactionVendorIndex { get; set; }

        [J("progressionHash")] public long ProgressionHash { get; set; }
        [J("dailyProgress")] public long DailyProgress { get; set; }
        [J("dailyLimit")] public long DailyLimit { get; set; }
        [J("weeklyProgress")] public long WeeklyProgress { get; set; }
        [J("weeklyLimit")] public long WeeklyLimit { get; set; }
        [J("currentProgress")] public long CurrentProgress { get; set; }
        [J("level")] public long Level { get; set; }
        [J("levelCap")] public long LevelCap { get; set; }
        [J("stepIndex")] public long StepIndex { get; set; }
        [J("progressToNextLevel")] public long ProgressToNextLevel { get; set; }
        [J("nextLevelAt")] public long NextLevelAt { get; set; }

        [J("currentResetCount", NullValueHandling = N.Ignore)]
        public long? CurrentResetCount { get; set; }

        [J("rewardItemStates", NullValueHandling = N.Ignore)]
        public long[] RewardItemStates { get; set; }
    }

    public class Milestone
    {
        [J("milestoneHash")] public long MilestoneHash { get; set; }

        [J("activities", NullValueHandling = N.Ignore)]
        public Activity[] Activities { get; set; }

        [J("rewards", NullValueHandling = N.Ignore)]
        public Reward[] Rewards { get; set; }

        [J("startDate", NullValueHandling = N.Ignore)]
        public DateTimeOffset? StartDate { get; set; }

        [J("endDate", NullValueHandling = N.Ignore)]
        public DateTimeOffset? EndDate { get; set; }

        [J("order")] public long Order { get; set; }

        [J("availableQuests", NullValueHandling = N.Ignore)]
        public AvailableQuest[] AvailableQuests { get; set; }

        [J("vendors", NullValueHandling = N.Ignore)]
        public Vendor[] Vendors { get; set; }
    }

    public class Activity
    {
        [J("activityHash")] public long ActivityHash { get; set; }
        [J("challenges")] public Challenge[] Challenges { get; set; }

        [J("modifierHashes", NullValueHandling = N.Ignore)]
        public long[] ModifierHashes { get; set; }

        [J("booleanActivityOptions", NullValueHandling = N.Ignore)]
        public Dictionary<string, bool> BooleanActivityOptions { get; set; }

        [J("phases", NullValueHandling = N.Ignore)]
        public Phase[] Phases { get; set; }
    }

    public class Phase
    {
        [J("complete")] public bool Complete { get; set; }
        [J("phaseHash")] public long PhaseHash { get; set; }
    }

    public class AvailableQuest
    {
        [J("questItemHash")] public long QuestItemHash { get; set; }
        [J("status")] public Status Status { get; set; }
    }

    public class Status
    {
        [J("questHash")] public long QuestHash { get; set; }
        [J("stepHash")] public long StepHash { get; set; }
        [J("stepObjectives")] public ObjectiveProgress[] StepObjectives { get; set; }
        [J("tracked")] public bool Tracked { get; set; }
        [J("itemInstanceId")] public string ItemInstanceId { get; set; }
        [J("completed")] public bool Completed { get; set; }
        [J("redeemed")] public bool Redeemed { get; set; }
        [J("started")] public bool Started { get; set; }
    }

    public class Reward
    {
        [J("rewardCategoryHash")] public long RewardCategoryHash { get; set; }
        [J("entries")] public Entry[] Entries { get; set; }
    }

    public class Entry
    {
        [J("rewardEntryHash")] public long RewardEntryHash { get; set; }
        [J("earned")] public bool Earned { get; set; }
        [J("redeemed")] public bool Redeemed { get; set; }
    }

    public class Vendor
    {
        [J("vendorHash")] public long VendorHash { get; set; }
    }

    public class DatumSeasonalArtifact
    {
        [J("artifactHash")] public long ArtifactHash { get; set; }
        [J("pointsUsed")] public long PointsUsed { get; set; }
        [J("resetCount")] public long ResetCount { get; set; }
        [J("tiers")] public Tier[] Tiers { get; set; }
    }

    public class Tier
    {
        [J("tierHash")] public long TierHash { get; set; }
        [J("isUnlocked")] public bool IsUnlocked { get; set; }
        [J("pointsToUnlock")] public long PointsToUnlock { get; set; }
        [J("items")] public TierItem[] Items { get; set; }
    }

    public class TierItem
    {
        [J("itemHash")] public long ItemHash { get; set; }
        [J("isActive")] public bool IsActive { get; set; }
    }

    public class CharacterRecords
    {
        [J("data")] public Dictionary<string, CharacterRecordsDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterRecordsDatum
    {
        [J("featuredRecordHashes")] public long[] FeaturedRecordHashes { get; set; }
        [J("records")] public Dictionary<string, DatumRecord> Records { get; set; }
        [J("recordCategoriesRootNodeHash")] public long RecordCategoriesRootNodeHash { get; set; }
        [J("recordSealsRootNodeHash")] public long RecordSealsRootNodeHash { get; set; }
    }

    public class DatumRecord
    {
        [J("state")] public long State { get; set; }

        [J("objectives", NullValueHandling = N.Ignore)]
        public ObjectiveProgress[] Objectives { get; set; }

        [J("intervalsRedeemedCount")] public long IntervalsRedeemedCount { get; set; }

        [J("rewardVisibilty", NullValueHandling = N.Ignore)]
        public bool[] RewardVisibilty { get; set; }

        [J("intervalObjectives", NullValueHandling = N.Ignore)]
        public ObjectiveProgress[] IntervalObjectives { get; set; }
    }

    public class CharacterRenderData
    {
        [J("data")] public Dictionary<string, CharacterRenderDataDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterRenderDataDatum
    {
        [J("customDyes")] public object[] CustomDyes { get; set; }
        [J("customization")] public Customization Customization { get; set; }
        [J("peerView")] public PeerView PeerView { get; set; }
    }

    public class Customization
    {
        [J("personality")] public long Personality { get; set; }
        [J("face")] public long Face { get; set; }
        [J("skinColor")] public long SkinColor { get; set; }
        [J("lipColor")] public long LipColor { get; set; }
        [J("eyeColor")] public long EyeColor { get; set; }
        [J("hairColors")] public long[] HairColors { get; set; }
        [J("featureColors")] public long[] FeatureColors { get; set; }
        [J("decalColor")] public long DecalColor { get; set; }
        [J("wearHelmet")] public bool WearHelmet { get; set; }
        [J("hairIndex")] public long HairIndex { get; set; }
        [J("featureIndex")] public long FeatureIndex { get; set; }
        [J("decalIndex")] public long DecalIndex { get; set; }
    }

    public class PeerView
    {
        [J("equipment")] public Equipment[] Equipment { get; set; }
    }

    public class Equipment
    {
        [J("itemHash")] public long ItemHash { get; set; }
        [J("dyes")] public Dye[] Dyes { get; set; }
    }

    public class Dye
    {
        [J("channelHash")] public long ChannelHash { get; set; }
        [J("dyeHash")] public long DyeHash { get; set; }
    }

    public class CharacterStringVariables
    {
        [J("data")] public Dictionary<string, CharacterStringVariablesData> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharacterStringVariablesData
    {
        [J("integerValuesByHash")] public Dictionary<string, long> IntegerValuesByHash { get; set; }
    }

    public class CharacterUninstancedItemComponent
    {
        [J("objectives")] public Objectives Objectives { get; set; }
        [J("perks")] public CharacterUninstancedItemComponentPerks Perks { get; set; }
    }

    public class Objectives
    {
        [J("data")] public Dictionary<string, ObjectivesDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class ObjectivesDatum
    {
        [J("objectives")] public ObjectiveProgress[] Objectives { get; set; }
    }

    public class CharacterUninstancedItemComponentPerks
    {
        [J("data")] public MessageData Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class Characters
    {
        [J("data")] public Dictionary<string, CharactersDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class CharactersDatum
    {
        [J("membershipId")] public string MembershipId { get; set; }
        [J("membershipType")] public long MembershipType { get; set; }
        [J("characterId")] public string CharacterId { get; set; }
        [J("dateLastPlayed")] public DateTimeOffset DateLastPlayed { get; set; }
        [J("minutesPlayedThisSession")] public string MinutesPlayedThisSession { get; set; }
        [J("minutesPlayedTotal")] public string MinutesPlayedTotal { get; set; }
        [J("light")] public long Light { get; set; }
        [J("stats")] public Dictionary<string, long> Stats { get; set; }
        [J("raceHash")] public long RaceHash { get; set; }
        [J("genderHash")] public long GenderHash { get; set; }
        [J("classHash")] public long ClassHash { get; set; }
        [J("raceType")] public long RaceType { get; set; }
        [J("classType")] public long ClassType { get; set; }
        [J("genderType")] public long GenderType { get; set; }
        [J("emblemPath")] public string EmblemPath { get; set; }
        [J("emblemBackgroundPath")] public string EmblemBackgroundPath { get; set; }
        [J("emblemHash")] public long EmblemHash { get; set; }
        [J("emblemColor")] public EmblemColor EmblemColor { get; set; }
        [J("levelProgression")] public Ion LevelProgression { get; set; }
        [J("baseCharacterLevel")] public long BaseCharacterLevel { get; set; }
        [J("percentToNextLevel")] public long PercentToNextLevel { get; set; }
        [J("titleRecordHash")] public long TitleRecordHash { get; set; }
    }

    public class EmblemColor
    {
        [J("red")] public long Red { get; set; }
        [J("green")] public long Green { get; set; }
        [J("blue")] public long Blue { get; set; }
        [J("alpha")] public long Alpha { get; set; }
    }

    public class ItemComponents
    {
        [J("instances")] public Instances Instances { get; set; }
        [J("renderData")] public RenderData RenderData { get; set; }
        [J("stats")] public Stats Stats { get; set; }
        [J("sockets")] public Sockets Sockets { get; set; }
        [J("reusablePlugs")] public CharacterPlugSets ReusablePlugs { get; set; }
        [J("plugObjectives")] public PlugObjectives PlugObjectives { get; set; }
        [J("talentGrids")] public TalentGrids TalentGrids { get; set; }
        [J("plugStates")] public PlugStates PlugStates { get; set; }
        [J("objectives")] public Objectives Objectives { get; set; }
        [J("perks")] public ItemComponentsPerks Perks { get; set; }
    }

    public class Instances
    {
        [J("data")] public Dictionary<string, InstancesDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class InstancesDatum
    {
        [J("damageType")] public long DamageType { get; set; }

        [J("primaryStat", NullValueHandling = N.Ignore)]
        public Stat PrimaryStat { get; set; }

        [J("itemLevel")] public long ItemLevel { get; set; }
        [J("quality")] public long Quality { get; set; }
        [J("isEquipped")] public bool IsEquipped { get; set; }
        [J("canEquip")] public bool CanEquip { get; set; }
        [J("equipRequiredLevel")] public long EquipRequiredLevel { get; set; }
        [J("unlockHashesRequiredToEquip")] public long[] UnlockHashesRequiredToEquip { get; set; }
        [J("cannotEquipReason")] public long CannotEquipReason { get; set; }

        [J("energy", NullValueHandling = N.Ignore)]
        public Energy Energy { get; set; }

        [J("damageTypeHash", NullValueHandling = N.Ignore)]
        public long? DamageTypeHash { get; set; }

        [J("breakerType", NullValueHandling = N.Ignore)]
        public long? BreakerType { get; set; }

        [J("breakerTypeHash", NullValueHandling = N.Ignore)]
        public long? BreakerTypeHash { get; set; }
    }

    public class Energy
    {
        [J("energyTypeHash")] public long EnergyTypeHash { get; set; }
        [J("energyType")] public long EnergyType { get; set; }
        [J("energyCapacity")] public long EnergyCapacity { get; set; }
        [J("energyUsed")] public long EnergyUsed { get; set; }
        [J("energyUnused")] public long EnergyUnused { get; set; }
    }

    public abstract partial class Stat
    {
        [J("statHash")] public long StatHash { get; set; }
        [J("value")] public long Value { get; set; }
    }

    public class ItemComponentsPerks
    {
        [J("data")] public Dictionary<string, PerksDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class PerksDatum
    {
        [J("perks")] public Perk[] Perks { get; set; }
    }

    public class Perk
    {
        [J("perkHash")] public long PerkHash { get; set; }
        [J("iconPath")] public string IconPath { get; set; }
        [J("isActive")] public bool IsActive { get; set; }
        [J("visible")] public bool Visible { get; set; }
    }

    public class PlugObjectives
    {
        [J("data")] public Dictionary<string, PlugObjectivesDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class PlugObjectivesDatum
    {
        [J("objectivesPerPlug")] public Dictionary<string, ObjectiveProgress[]> ObjectivesPerPlug { get; set; }
    }

    public class PlugStates
    {
        [J("data")] public Dictionary<string, DatumElement> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class RenderData
    {
        [J("data")] public Dictionary<string, RenderDataDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class RenderDataDatum
    {
        [J("useCustomDyes")] public bool UseCustomDyes { get; set; }
        [J("artRegions")] public Dictionary<string, long> ArtRegions { get; set; }
    }

    public partial class Sockets
    {
        [J("data")] public Dictionary<string, SocketsDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class SocketsDatum
    {
        [J("sockets")] public DatumSocket[] Sockets { get; set; }
    }

    public class DatumSocket
    {
        [J("plugHash", NullValueHandling = N.Ignore)]
        public long? PlugHash { get; set; }

        [J("isEnabled")] public bool IsEnabled { get; set; }
        [J("isVisible")] public bool IsVisible { get; set; }

        [J("enableFailIndexes", NullValueHandling = N.Ignore)]
        public long[] EnableFailIndexes { get; set; }
    }

    public partial class Stats
    {
        [J("data")] public Dictionary<string, StatsDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class StatsDatum
    {
        [J("stats")] public Dictionary<string, Stat> Stats { get; set; }
    }

    public class TalentGrids
    {
        [J("data")] public Dictionary<string, TalentGridsDatum> Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class TalentGridsDatum
    {
        [J("talentGridHash")] public long TalentGridHash { get; set; }
        [J("nodes")] public NodeElement[] Nodes { get; set; }
        [J("isGridComplete")] public bool IsGridComplete { get; set; }
    }

    public class NodeElement
    {
        [J("nodeIndex")] public long NodeIndex { get; set; }
        [J("nodeHash")] public long NodeHash { get; set; }
        [J("state")] public long State { get; set; }
        [J("isActivated")] public bool IsActivated { get; set; }
        [J("stepIndex")] public long StepIndex { get; set; }
        [J("materialsToUpgrade")] public object[] MaterialsToUpgrade { get; set; }
        [J("activationGridLevel")] public long ActivationGridLevel { get; set; }
        [J("progressPercent")] public long ProgressPercent { get; set; }
        [J("hidden")] public bool Hidden { get; set; }
    }

    public class Metrics
    {
        [J("data")] public MetricsData Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class MetricsData
    {
        [J("metrics")] public Dictionary<string, Metric> Metrics { get; set; }
        [J("metricsRootNodeHash")] public long MetricsRootNodeHash { get; set; }
    }

    public class Metric
    {
        [J("invisible")] public bool Invisible { get; set; }
        [J("objectiveProgress")] public ObjectiveProgress ObjectiveProgress { get; set; }
    }

    public class Profile
    {
        [J("data")] public ProfileData Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class ProfileData
    {
        [J("userInfo")] public UserInfo UserInfo { get; set; }
        [J("dateLastPlayed")] public DateTimeOffset DateLastPlayed { get; set; }
        [J("versionsOwned")] public long VersionsOwned { get; set; }
        [J("characterIds")] public string[] CharacterIds { get; set; }
        [J("seasonHashes")] public long[] SeasonHashes { get; set; }
        [J("currentSeasonHash")] public long CurrentSeasonHash { get; set; }
        [J("currentSeasonRewardPowerCap")] public long CurrentSeasonRewardPowerCap { get; set; }
    }

    public class UserInfo
    {
        [J("crossSaveOverride")] public long CrossSaveOverride { get; set; }
        [J("applicableMembershipTypes")] public long[] ApplicableMembershipTypes { get; set; }
        [J("isPublic")] public bool IsPublic { get; set; }
        [J("membershipType")] public long MembershipType { get; set; }
        [J("membershipId")] public string MembershipId { get; set; }
        [J("displayName")] public string DisplayName { get; set; }
        [J("bungieGlobalDisplayName")] public string BungieGlobalDisplayName { get; set; }
        [J("bungieGlobalDisplayNameCode")] public long BungieGlobalDisplayNameCode { get; set; }
    }

    public class ProfileCollectibles
    {
        [J("data")] public ProfileCollectiblesData Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class ProfileCollectiblesData
    {
        [J("recentCollectibleHashes")] public long[] RecentCollectibleHashes { get; set; }
        [J("newnessFlaggedCollectibleHashes")] public long[] NewnessFlaggedCollectibleHashes { get; set; }
        [J("collectibles")] public Dictionary<string, Collectible> Collectibles { get; set; }

        [J("collectionCategoriesRootNodeHash")]
        public long CollectionCategoriesRootNodeHash { get; set; }

        [J("collectionBadgesRootNodeHash")] public long CollectionBadgesRootNodeHash { get; set; }
    }

    public class ProfileKiosks
    {
        [J("data")] public CharacterKiosksData Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class ProfilePlugSets
    {
        [J("data")] public ProfilePlugSetsData Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class ProfilePlugSetsData
    {
        [J("plugs")] public Dictionary<string, DataPlug[]> Plugs { get; set; }
    }

    public class DataPlug
    {
        [J("plugItemHash")] public long PlugItemHash { get; set; }
        [J("canInsert")] public bool CanInsert { get; set; }
        [J("enabled")] public bool Enabled { get; set; }

        [J("plugObjectives", NullValueHandling = N.Ignore)]
        public ObjectiveProgress[] PlugObjectives { get; set; }

        [J("insertFailIndexes", NullValueHandling = N.Ignore)]
        public long[] InsertFailIndexes { get; set; }

        [J("enableFailIndexes", NullValueHandling = N.Ignore)]
        public long[] EnableFailIndexes { get; set; }
    }

    public class ProfilePresentationNodes
    {
        [J("data")] public CharacterPresentationNodesData Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class ProfileProgression
    {
        [J("data")] public ProfileProgressionData Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class ProfileProgressionData
    {
        [J("checklists")] public Dictionary<string, Dictionary<string, bool>> Checklists { get; set; }
        [J("seasonalArtifact")] public DataSeasonalArtifact SeasonalArtifact { get; set; }
    }

    public class DataSeasonalArtifact
    {
        [J("artifactHash")] public long ArtifactHash { get; set; }
        [J("pointProgression")] public Ion PointProgression { get; set; }
        [J("pointsAcquired")] public long PointsAcquired { get; set; }
        [J("powerBonusProgression")] public Ion PowerBonusProgression { get; set; }
        [J("powerBonus")] public long PowerBonus { get; set; }
    }

    public class ProfileRecords
    {
        [J("data")] public ProfileRecordsData Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public class ProfileRecordsData
    {
        [J("score")] public long Score { get; set; }
        [J("activeScore")] public long ActiveScore { get; set; }
        [J("legacyScore")] public long LegacyScore { get; set; }
        [J("lifetimeScore")] public long LifetimeScore { get; set; }
        [J("records")] public Dictionary<string, DataRecord> Records { get; set; }
        [J("recordCategoriesRootNodeHash")] public long RecordCategoriesRootNodeHash { get; set; }
        [J("recordSealsRootNodeHash")] public long RecordSealsRootNodeHash { get; set; }
    }

    public class DataRecord
    {
        [J("state")] public long State { get; set; }
        [J("intervalsRedeemedCount")] public long IntervalsRedeemedCount { get; set; }

        [J("objectives", NullValueHandling = N.Ignore)]
        public ObjectiveProgress[] Objectives { get; set; }

        [J("intervalObjectives", NullValueHandling = N.Ignore)]
        public ObjectiveProgress[] IntervalObjectives { get; set; }

        [J("rewardVisibilty", NullValueHandling = N.Ignore)]
        public bool[] RewardVisibilty { get; set; }

        [J("completedCount", NullValueHandling = N.Ignore)]
        public long? CompletedCount { get; set; }
    }

    public class ProfileStringVariables
    {
        [J("data")] public CharacterStringVariablesData Data { get; set; }
        [J("privacy")] public Components.ComponentPrivacySetting Privacy { get; set; }
    }

    public partial class DestinyProfile
    {
        public static DestinyProfile FromJson(string json)
        {
            return JsonConvert.DeserializeObject<DestinyProfile>(json, Converter.Settings);
        }
    }
}