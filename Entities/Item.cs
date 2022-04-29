﻿using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Item
    {
        public Item()
        {
            ItemIngredients = new HashSet<ItemIngredient>();
            ItemMobileExclusions = new HashSet<ItemMobileExclusion>();
            ItemModifiers = new HashSet<ItemModifier>();
            ItemPrices = new HashSet<ItemPrice>();
            ItemPrinters = new HashSet<ItemPrinter>();
            ItemTranslations = new HashSet<ItemTranslation>();
        }

        public Guid ItemID { get; set; }
        public Guid RegionID { get; set; }
        public string ItemName { get; set; } = null!;
        public string ItemDescription { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string UPC { get; set; } = null!;
        public string? ReceiptDesc { get; set; }
        public bool PrintDoubleWide { get; set; }
        public bool PrintAltColor { get; set; }
        public short ItemCount { get; set; }
        public string AlternateItem { get; set; } = null!;
        public short FireDelay { get; set; }
        public bool IsModifier { get; set; }
        public byte OrderPriority { get; set; }
        public bool IsStoreChargeable { get; set; }
        public bool AskForPrice { get; set; }
        public bool TogoSurcharge { get; set; }
        public int ItemCost { get; set; }
        public bool IsScaleable { get; set; }
        public bool IsNotTippable { get; set; }
        public byte PriceIsNegative { get; set; }
        public bool IsPromoItem { get; set; }
        public int BergPLU { get; set; }
        public bool ModifierFollowsParent { get; set; }
        public string? ModifierDescription { get; set; }
        public bool UseModifierMaxSelect { get; set; }
        public short ModifierMaxSelect { get; set; }
        public bool UseModifierMinSelect { get; set; }
        public short ModifierMinSelect { get; set; }
        public bool AllowModifierMaxBypass { get; set; }
        public bool UsePizzaStyle { get; set; }
        public bool IsTimedItem { get; set; }
        public byte TimingIncrement { get; set; }
        public int MinimumPrice { get; set; }
        public byte VDUColor { get; set; }
        public string? ShortDescription { get; set; }
        public byte DefaultCourse { get; set; }
        public int ChineseOutput { get; set; }
        public int TripleHigh { get; set; }
        public int QuadHigh { get; set; }
        public byte[] DiscountFlags { get; set; } = null!;
        public byte TaxFlags { get; set; }
        public byte PrintOptions { get; set; }
        public int RemotePrinters { get; set; }
        public bool AllowZeroPrice { get; set; }
        public int ModifierPriceLevel { get; set; }
        public int ModifierCount { get; set; }
        public int IngredientCount { get; set; }
        public int PrepTime { get; set; }
        public bool MultModPrice { get; set; }
        public int MultAmount { get; set; }
        public bool MultRound { get; set; }
        public bool IsNotGratable { get; set; }
        public int ModifierSortType { get; set; }
        public bool IsUsedOnline { get; set; }
        public string? WebTitle { get; set; }
        public string? WebDescription { get; set; }
        public string? WebThumbPath { get; set; }
        public string? WebImagePath { get; set; }
        public int DisplayIndex { get; set; }
        public int ModDisplayOrder { get; set; }
        public int OverridePrice { get; set; }
        public int SwappedDept { get; set; }
        public int MaxSelectionAllowed { get; set; }
        public bool IsShippable { get; set; }
        public string? ShipWidth { get; set; }
        public string? ShipHeight { get; set; }
        public string? ShipLength { get; set; }
        public bool AddPrepTimeToParent { get; set; }
        public int VDUID { get; set; }
        public int HHColumnCount { get; set; }
        public Guid? WebDepartmentID { get; set; }
        public bool AskID { get; set; }
        public int QuantityMultiplier { get; set; }
        public bool IsModifierGroup { get; set; }
        public byte ModifierPriceRounding { get; set; }
        public bool MobileAskID { get; set; }
        public bool IsMobile { get; set; }
        public Guid? MobileMessageID { get; set; }
        public string? OverrideAutoMenuButtonSettingsGraphic { get; set; }
        public string? AutoMenuText { get; set; }
        public DateTime? AutoMenuStartDate { get; set; }
        public DateTime? AutoMenuEndDate { get; set; }
        public byte ItemGrouping { get; set; }
        public bool IsRequired { get; set; }
        public string? DisplayDescription { get; set; }
        public Guid? ParentItemID { get; set; }
        public Guid? ItemSizeID { get; set; }
        public bool AllowEBT { get; set; }
        public string? ImageName { get; set; }
        public string? BannerImageName { get; set; }
        public string? BannerFooterImageName { get; set; }
        public short ModifierHeaderDisplayType { get; set; }
        public short ModifierFooterDisplayType { get; set; }
        public bool ShowOnKiosk { get; set; }
        public string? ModBannerFooterSelectDesc { get; set; }
        public bool HideSkyTab { get; set; }

        public virtual ICollection<ItemIngredient> ItemIngredients { get; set; }
        public virtual ICollection<ItemMobileExclusion> ItemMobileExclusions { get; set; }
        public virtual ICollection<ItemModifier> ItemModifiers { get; set; }
        public virtual ICollection<ItemPrice> ItemPrices { get; set; }
        public virtual ICollection<ItemPrinter> ItemPrinters { get; set; }
        public virtual ICollection<ItemTranslation> ItemTranslations { get; set; }
    }
}
