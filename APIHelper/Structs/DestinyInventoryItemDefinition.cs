using System.Collections.Generic;

namespace APIHelper.Structs
{
    public class DestinyInventoryItemDefinition
    {
        public class IconSequence
        {
            public List<string> frames { get; set; }
        }

        public class DisplayProperties
        {
            public string description { get; set; }
            public string name { get; set; }
            public string icon { get; set; }
            public List<IconSequence> iconSequences { get; set; }
            public bool hasIcon { get; set; }
        }

        public class TooltipNotification
        {
            public string displayString { get; set; }
            public string displayStyle { get; set; }
        }

        public class BackgroundColor
        {
            public long colorHash { get; set; }
            public long red { get; set; }
            public long green { get; set; }
            public long blue { get; set; }
            public long alpha { get; set; }
        }

        public class Action
        {
            public string verbName { get; set; }
            public string verbDescription { get; set; }
            public bool isPositive { get; set; }
            public long requiredCooldownSeconds { get; set; }
            public List<object> requiredItems { get; set; }
            public List<object> progressionRewards { get; set; }
            public string actionTypeLabel { get; set; }
            public long rewardSheetHash { get; set; }
            public long rewardItemHash { get; set; }
            public long rewardSiteHash { get; set; }
            public long requiredCooldownHash { get; set; }
            public bool deleteOnAction { get; set; }
            public bool consumeEntireStack { get; set; }
            public bool useOnAcquire { get; set; }
        }

        public class Inventory
        {
            public long maxStackSize { get; set; }
            public long bucketTypeHash { get; set; }
            public long recoveryBucketTypeHash { get; set; }
            public long tierTypeHash { get; set; }
            public bool isInstanceItem { get; set; }
            public bool nonTransferrableOriginal { get; set; }
            public string tierTypeName { get; set; }
            public long tierType { get; set; }
            public string expirationTooltip { get; set; }
            public string expiredInActivityMessage { get; set; }
            public string expiredInOrbitMessage { get; set; }
            public bool suppressExpirationWhenObjectivesComplete { get; set; }
        }

        public class PerObjectiveDisplayProperty
        {
            public bool displayOnItemPreviewScreen { get; set; }
        }

        public class Objectives
        {
            public List<long> objectiveHashes { get; set; }
            public List<long> displayActivityHashes { get; set; }
            public bool requireFullObjectiveCompletion { get; set; }
            public long questlineItemHash { get; set; }
            public string narrative { get; set; }
            public string objectiveVerbName { get; set; }
            public string questTypeIdentifier { get; set; }
            public long questTypeHash { get; set; }
            public long completionRewardSiteHash { get; set; }
            public long nextQuestStepRewardSiteHash { get; set; }
            public long timestampUnlockValueHash { get; set; }
            public bool isGlobalObjectiveItem { get; set; }
            public bool useOnObjectiveCompletion { get; set; }
            public long inhibitCompletionUnlockValueHash { get; set; }
            public List<PerObjectiveDisplayProperty> perObjectiveDisplayProperties { get; set; }
            public bool displayAsStatTracker { get; set; }
        }

        public class Plug
        {
            public List<object> insertionRules { get; set; }
            public string plugCategoryIdentifier { get; set; }
            public long plugCategoryHash { get; set; }
            public bool onActionRecreateSelf { get; set; }
            public long actionRewardSiteHash { get; set; }
            public long actionRewardItemOverrideHash { get; set; }
            public long insertionMaterialRequirementHash { get; set; }
            public long previewItemOverrideHash { get; set; }
            public long enabledMaterialRequirementHash { get; set; }
            public List<object> enabledRules { get; set; }
            public string uiPlugLabel { get; set; }
            public long plugStyle { get; set; }
            public long plugAvailability { get; set; }
            public string alternateUiPlugLabel { get; set; }
            public long alternatePlugStyle { get; set; }
            public bool isDummyPlug { get; set; }
            public bool applyStatsToSocketOwnerItem { get; set; }
        }

        public class Perk
        {
            public string requirementDisplayString { get; set; }
            public long perkHash { get; set; }
            public long perkVisibility { get; set; }
        }

        public class Root
        {
            public DisplayProperties displayProperties { get; set; }
            public List<TooltipNotification> tooltipNotifications { get; set; }
            public BackgroundColor backgroundColor { get; set; }
            public string itemTypeDisplayName { get; set; }
            public string flavorText { get; set; }
            public string uiItemDisplayStyle { get; set; }
            public string itemTypeAndTierDisplayName { get; set; }
            public string displaySource { get; set; }
            public string tooltipStyle { get; set; }
            public Action action { get; set; }
            public Inventory inventory { get; set; }
            public Objectives objectives { get; set; }
            public Plug plug { get; set; }
            public long acquireRewardSiteHash { get; set; }
            public long acquireUnlockHash { get; set; }
            public List<object> investmentStats { get; set; }
            public List<Perk> perks { get; set; }
            public long summaryItemHash { get; set; }
            public bool allowActions { get; set; }
            public bool doesPostmasterPullHaveSideEffects { get; set; }
            public bool nonTransferrable { get; set; }
            public List<long> itemCategoryHashes { get; set; }
            public long specialItemType { get; set; }
            public long itemType { get; set; }
            public long itemSubType { get; set; }
            public long classType { get; set; }
            public long breakerType { get; set; }
            public bool equippable { get; set; }
            public long defaultDamageType { get; set; }
            public bool isWrapper { get; set; }
            public long hash { get; set; }
            public long index { get; set; }
            public bool redacted { get; set; }
            public bool blacklisted { get; set; }
        }
    }
}