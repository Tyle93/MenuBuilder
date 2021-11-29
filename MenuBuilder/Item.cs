using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder {

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute("dbo.item", Namespace = "", IsNullable = false)]
        public class dboitem {

            private string itemIDField;

            private string regionIDField;

            private string itemNameField = "";

            private string itemDescriptionField = "";

            private string departmentField = "";

            private string uPCField = "";

            private string receiptDescField = "";

            private byte printDoubleWideField = 0;

            private byte printAltColorField = 0;

            private sbyte itemCountField = 0;

            private string alternateItemField = "";

            private byte fireDelayField = 0;

            private byte isModifierField = 0;

            private byte orderPriorityField = 0;

            private byte isStoreChargeableField = 0;

            private byte askForPriceField = 0;

            private byte togoSurchargeField = 0;

            private uint itemCostField = 0;

            private byte isScaleableField = 0;

            private byte isNotTippableField = 0;

            private byte priceIsNegativeField = 0;

            private byte isPromoItemField = 0;

            private byte bergPLUField = 0;

            private byte modifierFollowsParentField = 0;

            private string modifierDescriptionField = "";

            private byte useModifierMaxSelectField = 0;

            private byte modifierMaxSelectField = 0;

            private byte useModifierMinSelectField = 0;

            private byte modifierMinSelectField = 0;

            private byte allowModifierMaxBypassField = 0;

            private byte usePizzaStyleField = 0;

            private byte isTimedItemField = 0;

            private byte timingIncrementField = 0;

            private byte minimumPriceField = 0;

            private byte vDUColorField = 0;

            private string shortDescriptionField = "";

            private byte defaultCourseField = 0;

            private byte chineseOutputField = 0;

            private byte tripleHighField = 0;

            private byte quadHighField = 0;

            private string discountFlagsField = "";

            private byte taxFlagsField = 0;

            private byte printOptionsField = 0;

            private byte remotePrintersField = 0;

            private byte allowZeroPriceField = 0;

            private byte modifierPriceLevelField = 0;

            private byte modifierCountField = 0;

            private byte ingredientCountField = 0;

            private byte prepTimeField = 0;

            private byte multModPriceField = 0;

            private byte multAmountField = 0;

            private byte multRoundField = 0;

            private byte isNotGratableField = 0;

            private byte modifierSortTypeField = 0;

            private byte isUsedOnlineField = 0;

            private string webTitleField = "";

            private string webDescriptionField = "";

            private string webThumbPathField = "";

            private string webImagePathField = "";

            private byte displayIndexField = 0;

            private byte modDisplayOrderField = 0;

            private byte overridePriceField = 0;

            private byte swappedDeptField = 0;

            private byte maxSelectionAllowedField = 0;

            private byte isShippableField = 0;

            private string shipWidthField = "";

            private string shipHeightField = "";

            private string shipLengthField = "";

            private byte addPrepTimeToParentField = 0;

            private byte vDUIDField = 0;

            private byte hHColumnCountField = 0;

            private string webDepartmentIDField = "";

            private byte askIDField = 0;

            private byte quantityMultiplierField = 0;

            private byte isModifierGroupField = 0;

            private byte modifierPriceRoundingField = 0;

            private byte mobileAskIDField = 0;

            private byte isMobileField = 0;

            private string mobileMessageIDField = "";

            private string overrideAutoMenuButtonSettingsGraphicField = "";

            private byte itemGroupingField = 0;

            private byte isRequiredField = 0;

            private string displayDescriptionField = "";

            private string parentItemIDField = "";

            private string itemSizeIDField = "";

            private byte allowEBTField = 0;

            private string imageNameField = "";

            private string bannerImageNameField = "";

            private string bannerFooterImageNameField = "";

            private byte modifierHeaderDisplayTypeField = 0;

            private byte modifierFooterDisplayTypeField = 0;

            private byte showOnKioskField = 0;

            private string modBannerFooterSelectDescField = "";

            private byte hideSkyTabField = 0;

            public dboitem(string ID) {
                itemIDField = ID;
                
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ItemID {
                get {
                    return this.itemIDField;
                }
                set {
                    this.itemIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string RegionID {
                get {
                    return this.regionIDField;
                }
                set {
                    this.regionIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ItemName {
                get {
                    return this.itemNameField;
                }
                set {
                    this.itemNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ItemDescription {
                get {
                    return this.itemDescriptionField;
                }
                set {
                    this.itemDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Department {
                get {
                    return this.departmentField;
                }
                set {
                    this.departmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string UPC {
                get {
                    return this.uPCField;
                }
                set {
                    this.uPCField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ReceiptDesc {
                get {
                    return this.receiptDescField;
                }
                set {
                    this.receiptDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte PrintDoubleWide {
                get {
                    return this.printDoubleWideField;
                }
                set {
                    this.printDoubleWideField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte PrintAltColor {
                get {
                    return this.printAltColorField;
                }
                set {
                    this.printAltColorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte ItemCount {
                get {
                    return this.itemCountField;
                }
                set {
                    this.itemCountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string AlternateItem {
                get {
                    return this.alternateItemField;
                }
                set {
                    this.alternateItemField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte FireDelay {
                get {
                    return this.fireDelayField;
                }
                set {
                    this.fireDelayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsModifier {
                get {
                    return this.isModifierField;
                }
                set {
                    this.isModifierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte OrderPriority {
                get {
                    return this.orderPriorityField;
                }
                set {
                    this.orderPriorityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsStoreChargeable {
                get {
                    return this.isStoreChargeableField;
                }
                set {
                    this.isStoreChargeableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte AskForPrice {
                get {
                    return this.askForPriceField;
                }
                set {
                    this.askForPriceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte TogoSurcharge {
                get {
                    return this.togoSurchargeField;
                }
                set {
                    this.togoSurchargeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint ItemCost {
                get {
                    return this.itemCostField;
                }
                set {
                    this.itemCostField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsScaleable {
                get {
                    return this.isScaleableField;
                }
                set {
                    this.isScaleableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsNotTippable {
                get {
                    return this.isNotTippableField;
                }
                set {
                    this.isNotTippableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte PriceIsNegative {
                get {
                    return this.priceIsNegativeField;
                }
                set {
                    this.priceIsNegativeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsPromoItem {
                get {
                    return this.isPromoItemField;
                }
                set {
                    this.isPromoItemField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte BergPLU {
                get {
                    return this.bergPLUField;
                }
                set {
                    this.bergPLUField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ModifierFollowsParent {
                get {
                    return this.modifierFollowsParentField;
                }
                set {
                    this.modifierFollowsParentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ModifierDescription {
                get {
                    return this.modifierDescriptionField;
                }
                set {
                    this.modifierDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte UseModifierMaxSelect {
                get {
                    return this.useModifierMaxSelectField;
                }
                set {
                    this.useModifierMaxSelectField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ModifierMaxSelect {
                get {
                    return this.modifierMaxSelectField;
                }
                set {
                    this.modifierMaxSelectField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte UseModifierMinSelect {
                get {
                    return this.useModifierMinSelectField;
                }
                set {
                    this.useModifierMinSelectField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ModifierMinSelect {
                get {
                    return this.modifierMinSelectField;
                }
                set {
                    this.modifierMinSelectField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte AllowModifierMaxBypass {
                get {
                    return this.allowModifierMaxBypassField;
                }
                set {
                    this.allowModifierMaxBypassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte UsePizzaStyle {
                get {
                    return this.usePizzaStyleField;
                }
                set {
                    this.usePizzaStyleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsTimedItem {
                get {
                    return this.isTimedItemField;
                }
                set {
                    this.isTimedItemField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte TimingIncrement {
                get {
                    return this.timingIncrementField;
                }
                set {
                    this.timingIncrementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte MinimumPrice {
                get {
                    return this.minimumPriceField;
                }
                set {
                    this.minimumPriceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte VDUColor {
                get {
                    return this.vDUColorField;
                }
                set {
                    this.vDUColorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ShortDescription {
                get {
                    return this.shortDescriptionField;
                }
                set {
                    this.shortDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte DefaultCourse {
                get {
                    return this.defaultCourseField;
                }
                set {
                    this.defaultCourseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ChineseOutput {
                get {
                    return this.chineseOutputField;
                }
                set {
                    this.chineseOutputField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte TripleHigh {
                get {
                    return this.tripleHighField;
                }
                set {
                    this.tripleHighField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte QuadHigh {
                get {
                    return this.quadHighField;
                }
                set {
                    this.quadHighField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string DiscountFlags {
                get {
                    return this.discountFlagsField;
                }
                set {
                    this.discountFlagsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte TaxFlags {
                get {
                    return this.taxFlagsField;
                }
                set {
                    this.taxFlagsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte PrintOptions {
                get {
                    return this.printOptionsField;
                }
                set {
                    this.printOptionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte RemotePrinters {
                get {
                    return this.remotePrintersField;
                }
                set {
                    this.remotePrintersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte AllowZeroPrice {
                get {
                    return this.allowZeroPriceField;
                }
                set {
                    this.allowZeroPriceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ModifierPriceLevel {
                get {
                    return this.modifierPriceLevelField;
                }
                set {
                    this.modifierPriceLevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ModifierCount {
                get {
                    return this.modifierCountField;
                }
                set {
                    this.modifierCountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IngredientCount {
                get {
                    return this.ingredientCountField;
                }
                set {
                    this.ingredientCountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte PrepTime {
                get {
                    return this.prepTimeField;
                }
                set {
                    this.prepTimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte MultModPrice {
                get {
                    return this.multModPriceField;
                }
                set {
                    this.multModPriceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte MultAmount {
                get {
                    return this.multAmountField;
                }
                set {
                    this.multAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte MultRound {
                get {
                    return this.multRoundField;
                }
                set {
                    this.multRoundField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsNotGratable {
                get {
                    return this.isNotGratableField;
                }
                set {
                    this.isNotGratableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ModifierSortType {
                get {
                    return this.modifierSortTypeField;
                }
                set {
                    this.modifierSortTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsUsedOnline {
                get {
                    return this.isUsedOnlineField;
                }
                set {
                    this.isUsedOnlineField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string WebTitle {
                get {
                    return this.webTitleField;
                }
                set {
                    this.webTitleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string WebDescription {
                get {
                    return this.webDescriptionField;
                }
                set {
                    this.webDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string WebThumbPath {
                get {
                    return this.webThumbPathField;
                }
                set {
                    this.webThumbPathField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string WebImagePath {
                get {
                    return this.webImagePathField;
                }
                set {
                    this.webImagePathField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte DisplayIndex {
                get {
                    return this.displayIndexField;
                }
                set {
                    this.displayIndexField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ModDisplayOrder {
                get {
                    return this.modDisplayOrderField;
                }
                set {
                    this.modDisplayOrderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte OverridePrice {
                get {
                    return this.overridePriceField;
                }
                set {
                    this.overridePriceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte SwappedDept {
                get {
                    return this.swappedDeptField;
                }
                set {
                    this.swappedDeptField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte MaxSelectionAllowed {
                get {
                    return this.maxSelectionAllowedField;
                }
                set {
                    this.maxSelectionAllowedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsShippable {
                get {
                    return this.isShippableField;
                }
                set {
                    this.isShippableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ShipWidth {
                get {
                    return this.shipWidthField;
                }
                set {
                    this.shipWidthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ShipHeight {
                get {
                    return this.shipHeightField;
                }
                set {
                    this.shipHeightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ShipLength {
                get {
                    return this.shipLengthField;
                }
                set {
                    this.shipLengthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte AddPrepTimeToParent {
                get {
                    return this.addPrepTimeToParentField;
                }
                set {
                    this.addPrepTimeToParentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte VDUID {
                get {
                    return this.vDUIDField;
                }
                set {
                    this.vDUIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte HHColumnCount {
                get {
                    return this.hHColumnCountField;
                }
                set {
                    this.hHColumnCountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string WebDepartmentID {
                get {
                    return this.webDepartmentIDField;
                }
                set {
                    this.webDepartmentIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte AskID {
                get {
                    return this.askIDField;
                }
                set {
                    this.askIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte QuantityMultiplier {
                get {
                    return this.quantityMultiplierField;
                }
                set {
                    this.quantityMultiplierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsModifierGroup {
                get {
                    return this.isModifierGroupField;
                }
                set {
                    this.isModifierGroupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ModifierPriceRounding {
                get {
                    return this.modifierPriceRoundingField;
                }
                set {
                    this.modifierPriceRoundingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte MobileAskID {
                get {
                    return this.mobileAskIDField;
                }
                set {
                    this.mobileAskIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsMobile {
                get {
                    return this.isMobileField;
                }
                set {
                    this.isMobileField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string MobileMessageID {
                get {
                    return this.mobileMessageIDField;
                }
                set {
                    this.mobileMessageIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string OverrideAutoMenuButtonSettingsGraphic {
                get {
                    return this.overrideAutoMenuButtonSettingsGraphicField;
                }
                set {
                    this.overrideAutoMenuButtonSettingsGraphicField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ItemGrouping {
                get {
                    return this.itemGroupingField;
                }
                set {
                    this.itemGroupingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsRequired {
                get {
                    return this.isRequiredField;
                }
                set {
                    this.isRequiredField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string DisplayDescription {
                get {
                    return this.displayDescriptionField;
                }
                set {
                    this.displayDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ParentItemID {
                get {
                    return this.parentItemIDField;
                }
                set {
                    this.parentItemIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ItemSizeID {
                get {
                    return this.itemSizeIDField;
                }
                set {
                    this.itemSizeIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte AllowEBT {
                get {
                    return this.allowEBTField;
                }
                set {
                    this.allowEBTField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ImageName {
                get {
                    return this.imageNameField;
                }
                set {
                    this.imageNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BannerImageName {
                get {
                    return this.bannerImageNameField;
                }
                set {
                    this.bannerImageNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BannerFooterImageName {
                get {
                    return this.bannerFooterImageNameField;
                }
                set {
                    this.bannerFooterImageNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ModifierHeaderDisplayType {
                get {
                    return this.modifierHeaderDisplayTypeField;
                }
                set {
                    this.modifierHeaderDisplayTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ModifierFooterDisplayType {
                get {
                    return this.modifierFooterDisplayTypeField;
                }
                set {
                    this.modifierFooterDisplayTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ShowOnKiosk {
                get {
                    return this.showOnKioskField;
                }
                set {
                    this.showOnKioskField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ModBannerFooterSelectDesc {
                get {
                    return this.modBannerFooterSelectDescField;
                }
                set {
                    this.modBannerFooterSelectDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte HideSkyTab {
                get {
                    return this.hideSkyTabField;
                }
                set {
                    this.hideSkyTabField = value;
                }
            }
        }


}

