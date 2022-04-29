using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace FutureEntity.Entities
{
    public partial class FutureDBContext : DbContext
    {
        private IConfiguration Config;
        public FutureDBContext()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"{AppDomain.CurrentDomain.BaseDirectory}/appsettings.json",false,true);
            Config = builder.Build();
        }

        public FutureDBContext(DbContextOptions<FutureDBContext> options)
            : base(options)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("./appsettings.json",false,true);
            Config = builder.Build();
        }

        public virtual DbSet<Activity> Activities { get; set; } = null!;
        public virtual DbSet<ActivityDetail> ActivityDetails { get; set; } = null!;
        public virtual DbSet<AdDisplay> AdDisplays { get; set; } = null!;
        public virtual DbSet<AdDisplaySchedule> AdDisplaySchedules { get; set; } = null!;
        public virtual DbSet<AdLinkContent> AdLinkContents { get; set; } = null!;
        public virtual DbSet<AdPlayList> AdPlayLists { get; set; } = null!;
        public virtual DbSet<AdPlayListItem> AdPlayListItems { get; set; } = null!;
        public virtual DbSet<AdScheduleGroup> AdScheduleGroups { get; set; } = null!;
        public virtual DbSet<AdScoreLayout> AdScoreLayouts { get; set; } = null!;
        public virtual DbSet<AdTemplateContentLink> AdTemplateContentLinks { get; set; } = null!;
        public virtual DbSet<Alert> Alerts { get; set; } = null!;
        public virtual DbSet<AlertEmail> AlertEmails { get; set; } = null!;
        public virtual DbSet<AlertSetting> AlertSettings { get; set; } = null!;
        public virtual DbSet<AveroID> AveroIDs { get; set; } = null!;
        public virtual DbSet<AveroPayID> AveroPayIDs { get; set; } = null!;
        public virtual DbSet<BackupSetting> BackupSettings { get; set; } = null!;
        public virtual DbSet<BeverageCount> BeverageCounts { get; set; } = null!;
        public virtual DbSet<BeverageCountInfo> BeverageCountInfos { get; set; } = null!;
        public virtual DbSet<BeverageCountItem> BeverageCountItems { get; set; } = null!;
        public virtual DbSet<Break> Breaks { get; set; } = null!;
        public virtual DbSet<BreakJob> BreakJobs { get; set; } = null!;
        public virtual DbSet<BucketTransfer> BucketTransfers { get; set; } = null!;
        public virtual DbSet<BusyIndicatorSchedule> BusyIndicatorSchedules { get; set; } = null!;
        public virtual DbSet<Button> Buttons { get; set; } = null!;
        public virtual DbSet<ButtonTranslation> ButtonTranslations { get; set; } = null!;
        public virtual DbSet<Cashier> Cashiers { get; set; } = null!;
        public virtual DbSet<CheckNumber> CheckNumbers { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<CompulsoryDrink> CompulsoryDrinks { get; set; } = null!;
        public virtual DbSet<CompulsoryEntree> CompulsoryEntrees { get; set; } = null!;
        public virtual DbSet<Configuration> Configurations { get; set; } = null!;
        public virtual DbSet<ConfigurationDevice> ConfigurationDevices { get; set; } = null!;
        public virtual DbSet<ConfigurationSecure> ConfigurationSecures { get; set; } = null!;
        public virtual DbSet<CorporateMessage> CorporateMessages { get; set; } = null!;
        public virtual DbSet<Coupon> Coupons { get; set; } = null!;
        public virtual DbSet<CouponItem> CouponItems { get; set; } = null!;
        public virtual DbSet<CouponTranslation> CouponTranslations { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<CreditBatch> CreditBatches { get; set; } = null!;
        public virtual DbSet<CreditDeviceInfo> CreditDeviceInfos { get; set; } = null!;
        public virtual DbSet<CreditDeviceSaleStatus> CreditDeviceSaleStatuses { get; set; } = null!;
        public virtual DbSet<CurrencyConversion> CurrencyConversions { get; set; } = null!;
        public virtual DbSet<CurrencyConversionItem> CurrencyConversionItems { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerCard> CustomerCards { get; set; } = null!;
        public virtual DbSet<CustomerCharge> CustomerCharges { get; set; } = null!;
        public virtual DbSet<CustomerLastOrder> CustomerLastOrders { get; set; } = null!;
        public virtual DbSet<CustomerNumber> CustomerNumbers { get; set; } = null!;
        public virtual DbSet<CustomerPlan> CustomerPlans { get; set; } = null!;
        public virtual DbSet<CustomerRating> CustomerRatings { get; set; } = null!;
        public virtual DbSet<DBFile> DBFiles { get; set; } = null!;
        public virtual DbSet<DashBoardItem> DashBoardItems { get; set; } = null!;
        public virtual DbSet<DashBoardSetting> DashBoardSettings { get; set; } = null!;
        public virtual DbSet<DashboardWidget> DashboardWidgets { get; set; } = null!;
        public virtual DbSet<DataGroup> DataGroups { get; set; } = null!;
        public virtual DbSet<DataGroupStore> DataGroupStores { get; set; } = null!;
        public virtual DbSet<DataTypeReference> DataTypeReferences { get; set; } = null!;
        public virtual DbSet<DayDivide> DayDivides { get; set; } = null!;
        public virtual DbSet<DeliveryDriver> DeliveryDrivers { get; set; } = null!;
        public virtual DbSet<DeliveryZone> DeliveryZones { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DepartmentMobileExclusion> DepartmentMobileExclusions { get; set; } = null!;
        public virtual DbSet<DepartmentRank> DepartmentRanks { get; set; } = null!;
        public virtual DbSet<DepartmentSchedule> DepartmentSchedules { get; set; } = null!;
        public virtual DbSet<DepartmentTranslation> DepartmentTranslations { get; set; } = null!;
        public virtual DbSet<DinePointConfig> DinePointConfigs { get; set; } = null!;
        public virtual DbSet<DinePointDayDivide> DinePointDayDivides { get; set; } = null!;
        public virtual DbSet<DinePointJobCode> DinePointJobCodes { get; set; } = null!;
        public virtual DbSet<DinePointOrderType> DinePointOrderTypes { get; set; } = null!;
        public virtual DbSet<DinePointRevenueCenter> DinePointRevenueCenters { get; set; } = null!;
        public virtual DbSet<DinePointServingPeriod> DinePointServingPeriods { get; set; } = null!;
        public virtual DbSet<DirtyTable> DirtyTables { get; set; } = null!;
        public virtual DbSet<Discount> Discounts { get; set; } = null!;
        public virtual DbSet<DiscountTranslation> DiscountTranslations { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeAvailability> EmployeeAvailabilities { get; set; } = null!;
        public virtual DbSet<EmployeeAvailabilityRange> EmployeeAvailabilityRanges { get; set; } = null!;
        public virtual DbSet<EmployeeDrawer> EmployeeDrawers { get; set; } = null!;
        public virtual DbSet<EmployeeHintShown> EmployeeHintShowns { get; set; } = null!;
        public virtual DbSet<EmployeeLaborGroupHistory> EmployeeLaborGroupHistories { get; set; } = null!;
        public virtual DbSet<EmployeeRate> EmployeeRates { get; set; } = null!;
        public virtual DbSet<EmployeeTip> EmployeeTips { get; set; } = null!;
        public virtual DbSet<Enterprise> Enterprises { get; set; } = null!;
        public virtual DbSet<EnterpriseEmployee> EnterpriseEmployees { get; set; } = null!;
        public virtual DbSet<EnterpriseSort> EnterpriseSorts { get; set; } = null!;
        public virtual DbSet<EnterpriseSyncExclude> EnterpriseSyncExcludes { get; set; } = null!;
        public virtual DbSet<FollowMe> FollowMes { get; set; } = null!;
        public virtual DbSet<Gift> Gifts { get; set; } = null!;
        public virtual DbSet<GiftBackup> GiftBackups { get; set; } = null!;
        public virtual DbSet<GiftHistory> GiftHistories { get; set; } = null!;
        public virtual DbSet<GiftSeries> GiftSeries { get; set; } = null!;
        public virtual DbSet<GiftSeriesAvailability> GiftSeriesAvailabilities { get; set; } = null!;
        public virtual DbSet<GiftSeriesObject> GiftSeriesObjects { get; set; } = null!;
        public virtual DbSet<GiftUsed> GiftUseds { get; set; } = null!;
        public virtual DbSet<GlobalCashier> GlobalCashiers { get; set; } = null!;
        public virtual DbSet<GrandTotal> GrandTotals { get; set; } = null!;
        public virtual DbSet<Graphic> Graphics { get; set; } = null!;
        public virtual DbSet<Help> Helps { get; set; } = null!;
        public virtual DbSet<Ingredient> Ingredients { get; set; } = null!;
        public virtual DbSet<IngredientInventory> IngredientInventories { get; set; } = null!;
        public virtual DbSet<InternetCreditBatch> InternetCreditBatches { get; set; } = null!;
        public virtual DbSet<InternetCreditBatchArchive> InternetCreditBatchArchives { get; set; } = null!;
        public virtual DbSet<InternetCreditBatchInfo> InternetCreditBatchInfos { get; set; } = null!;
        public virtual DbSet<InvoiceConfig> InvoiceConfigs { get; set; } = null!;
        public virtual DbSet<InvoiceConfigObject> InvoiceConfigObjects { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<ItemDay> ItemDays { get; set; } = null!;
        public virtual DbSet<ItemIngredient> ItemIngredients { get; set; } = null!;
        public virtual DbSet<ItemMobileExclusion> ItemMobileExclusions { get; set; } = null!;
        public virtual DbSet<ItemModifier> ItemModifiers { get; set; } = null!;
        public virtual DbSet<ItemPrice> ItemPrices { get; set; } = null!;
        public virtual DbSet<ItemPrinter> ItemPrinters { get; set; } = null!;
        public virtual DbSet<ItemRank> ItemRanks { get; set; } = null!;
        public virtual DbSet<ItemSize> ItemSizes { get; set; } = null!;
        public virtual DbSet<ItemSold> ItemSolds { get; set; } = null!;
        public virtual DbSet<ItemTranslation> ItemTranslations { get; set; } = null!;
        public virtual DbSet<JobCode> JobCodes { get; set; } = null!;
        public virtual DbSet<JobCodeDeptMask> JobCodeDeptMasks { get; set; } = null!;
        public virtual DbSet<LaborRule> LaborRules { get; set; } = null!;
        public virtual DbSet<LaborRuleSet> LaborRuleSets { get; set; } = null!;
        public virtual DbSet<Layout> Layouts { get; set; } = null!;
        public virtual DbSet<LayoutGraphic> LayoutGraphics { get; set; } = null!;
        public virtual DbSet<LayoutRoom> LayoutRooms { get; set; } = null!;
        public virtual DbSet<LayoutSection> LayoutSections { get; set; } = null!;
        public virtual DbSet<LayoutTable> LayoutTables { get; set; } = null!;
        public virtual DbSet<LayoutText> LayoutTexts { get; set; } = null!;
        public virtual DbSet<LocalSuspend> LocalSuspends { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<LogConfig> LogConfigs { get; set; } = null!;
        public virtual DbSet<MediaTranslation> MediaTranslations { get; set; } = null!;
        public virtual DbSet<Medium> Media { get; set; } = null!;
        public virtual DbSet<MenuHomePageLink> MenuHomePageLinks { get; set; } = null!;
        public virtual DbSet<MenuPage> MenuPages { get; set; } = null!;
        public virtual DbSet<MenuPageGroup> MenuPageGroups { get; set; } = null!;
        public virtual DbSet<MenuPageItem> MenuPageItems { get; set; } = null!;
        public virtual DbSet<MenuPageLink> MenuPageLinks { get; set; } = null!;
        public virtual DbSet<MenuUsage> MenuUsages { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MessageEmployee> MessageEmployees { get; set; } = null!;
        public virtual DbSet<MobileFunctionPermission> MobileFunctionPermissions { get; set; } = null!;
        public virtual DbSet<MobileMessage> MobileMessages { get; set; } = null!;
        public virtual DbSet<MobileTerminal> MobileTerminals { get; set; } = null!;
        public virtual DbSet<MobileTerminalSessionInfo> MobileTerminalSessionInfos { get; set; } = null!;
        public virtual DbSet<MobileTerminalTransaction> MobileTerminalTransactions { get; set; } = null!;
        public virtual DbSet<MobileTerminalTransfer> MobileTerminalTransfers { get; set; } = null!;
        public virtual DbSet<OfflineLoyaltyQueue> OfflineLoyaltyQueues { get; set; } = null!;
        public virtual DbSet<OrderType> OrderTypes { get; set; } = null!;
        public virtual DbSet<OrderType1> OrderTypes1 { get; set; } = null!;
        public virtual DbSet<PAlert> PAlerts { get; set; } = null!;
        public virtual DbSet<PAlertQueue> PAlertQueues { get; set; } = null!;
        public virtual DbSet<PAlertSetting> PAlertSettings { get; set; } = null!;
        public virtual DbSet<PAlertTo> PAlertTos { get; set; } = null!;
        public virtual DbSet<POSDay> POSDays { get; set; } = null!;
        public virtual DbSet<POSShift> POSShifts { get; set; } = null!;
        public virtual DbSet<Pager> Pagers { get; set; } = null!;
        public virtual DbSet<PagerEmployee> PagerEmployees { get; set; } = null!;
        public virtual DbSet<PagerMessageQueue> PagerMessageQueues { get; set; } = null!;
        public virtual DbSet<Paydiant> Paydiants { get; set; } = null!;
        public virtual DbSet<PendingSale> PendingSales { get; set; } = null!;
        public virtual DbSet<PreAuth> PreAuths { get; set; } = null!;
        public virtual DbSet<PrepTime> PrepTimes { get; set; } = null!;
        public virtual DbSet<PriceLevel> PriceLevels { get; set; } = null!;
        public virtual DbSet<PriceSchedule> PriceSchedules { get; set; } = null!;
        public virtual DbSet<PrintJob> PrintJobs { get; set; } = null!;
        public virtual DbSet<PrintJobLine> PrintJobLines { get; set; } = null!;
        public virtual DbSet<PunchPair> PunchPairs { get; set; } = null!;
        public virtual DbSet<Reason> Reasons { get; set; } = null!;
        public virtual DbSet<ReceiptFormat> ReceiptFormats { get; set; } = null!;
        public virtual DbSet<ReceiptFormatItem> ReceiptFormatItems { get; set; } = null!;
        public virtual DbSet<Recipe> Recipes { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<ReportWare> ReportWares { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;
        public virtual DbSet<ResourceLanguage> ResourceLanguages { get; set; } = null!;
        public virtual DbSet<RevenueCenter> RevenueCenters { get; set; } = null!;
        public virtual DbSet<RewardPlan> RewardPlans { get; set; } = null!;
        public virtual DbSet<RewardPlanLevel> RewardPlanLevels { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SaleCoupon> SaleCoupons { get; set; } = null!;
        public virtual DbSet<SaleCreditCard> SaleCreditCards { get; set; } = null!;
        public virtual DbSet<SaleDiscount> SaleDiscounts { get; set; } = null!;
        public virtual DbSet<SaleGiftSold> SaleGiftSolds { get; set; } = null!;
        public virtual DbSet<SaleGiftUsed> SaleGiftUseds { get; set; } = null!;
        public virtual DbSet<SaleItem> SaleItems { get; set; } = null!;
        public virtual DbSet<SaleItemCoupon> SaleItemCoupons { get; set; } = null!;
        public virtual DbSet<SaleItemDiscount> SaleItemDiscounts { get; set; } = null!;
        public virtual DbSet<SaleLoyalty> SaleLoyalties { get; set; } = null!;
        public virtual DbSet<SaleMedium> SaleMedia { get; set; } = null!;
        public virtual DbSet<SalePM> SalePMs { get; set; } = null!;
        public virtual DbSet<SaleShare> SaleShares { get; set; } = null!;
        public virtual DbSet<SaleTax> SaleTaxes { get; set; } = null!;
        public virtual DbSet<SaleTender> SaleTenders { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<ScheduleItem> ScheduleItems { get; set; } = null!;
        public virtual DbSet<ScheduledUpdateMaintenance> ScheduledUpdateMaintenances { get; set; } = null!;
        public virtual DbSet<ScheduledUpdateScheduleGroup> ScheduledUpdateScheduleGroups { get; set; } = null!;
        public virtual DbSet<ScheduledUpdateScheduleGroupUpdate> ScheduledUpdateScheduleGroupUpdates { get; set; } = null!;
        public virtual DbSet<ScheduledUpdateScheduleGroupUpdateSettingChange> ScheduledUpdateScheduleGroupUpdateSettingChanges { get; set; } = null!;
        public virtual DbSet<Screen> Screens { get; set; } = null!;
        public virtual DbSet<ScreenAd> ScreenAds { get; set; } = null!;
        public virtual DbSet<ScreenAutoMenu> ScreenAutoMenus { get; set; } = null!;
        public virtual DbSet<ScreenAutoMenuFilter> ScreenAutoMenuFilters { get; set; } = null!;
        public virtual DbSet<ScreenAutoMenuFilterButtonSetting> ScreenAutoMenuFilterButtonSettings { get; set; } = null!;
        public virtual DbSet<ScreenAutoMenuNextButtonTextTranslation> ScreenAutoMenuNextButtonTextTranslations { get; set; } = null!;
        public virtual DbSet<ScreenAutoMenuPagingButtonSetting> ScreenAutoMenuPagingButtonSettings { get; set; } = null!;
        public virtual DbSet<ScreenAutoMenuPreviousButtonTextTranslation> ScreenAutoMenuPreviousButtonTextTranslations { get; set; } = null!;
        public virtual DbSet<ScreenBanner> ScreenBanners { get; set; } = null!;
        public virtual DbSet<ScreenBitmap> ScreenBitmaps { get; set; } = null!;
        public virtual DbSet<ScreenButton> ScreenButtons { get; set; } = null!;
        public virtual DbSet<ScreenButtonTranslation> ScreenButtonTranslations { get; set; } = null!;
        public virtual DbSet<ScreenEdit> ScreenEdits { get; set; } = null!;
        public virtual DbSet<ScreenFrame> ScreenFrames { get; set; } = null!;
        public virtual DbSet<ScreenHelp> ScreenHelps { get; set; } = null!;
        public virtual DbSet<ScreenKioskMenu> ScreenKioskMenus { get; set; } = null!;
        public virtual DbSet<ScreenKioskMenuFilter> ScreenKioskMenuFilters { get; set; } = null!;
        public virtual DbSet<ScreenKioskMenuNextButtonTextTranslation> ScreenKioskMenuNextButtonTextTranslations { get; set; } = null!;
        public virtual DbSet<ScreenKioskMenuPreviousButtonTextTranslation> ScreenKioskMenuPreviousButtonTextTranslations { get; set; } = null!;
        public virtual DbSet<ScreenList> ScreenLists { get; set; } = null!;
        public virtual DbSet<ScreenText> ScreenTexts { get; set; } = null!;
        public virtual DbSet<ScreenTextTranslation> ScreenTextTranslations { get; set; } = null!;
        public virtual DbSet<SecurityCheck> SecurityChecks { get; set; } = null!;
        public virtual DbSet<ServingPeriod> ServingPeriods { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<Shift> Shifts { get; set; } = null!;
        public virtual DbSet<Shorthand> Shorthands { get; set; } = null!;
        public virtual DbSet<Signature> Signatures { get; set; } = null!;
        public virtual DbSet<SkinSchedule> SkinSchedules { get; set; } = null!;
        public virtual DbSet<Special> Specials { get; set; } = null!;
        public virtual DbSet<SpecialMonth> SpecialMonths { get; set; } = null!;
        public virtual DbSet<SpecialWeek> SpecialWeeks { get; set; } = null!;
        public virtual DbSet<StatusMessage> StatusMessages { get; set; } = null!;
        public virtual DbSet<Store> Stores { get; set; } = null!;
        public virtual DbSet<Sync> Syncs { get; set; } = null!;
        public virtual DbSet<SyncDatum> SyncData { get; set; } = null!;
        public virtual DbSet<TabbedOut> TabbedOuts { get; set; } = null!;
        public virtual DbSet<TabbedOutAlert> TabbedOutAlerts { get; set; } = null!;
        public virtual DbSet<Tare> Tares { get; set; } = null!;
        public virtual DbSet<TareImage> TareImages { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<TaskItem> TaskItems { get; set; } = null!;
        public virtual DbSet<Tax> Taxes { get; set; } = null!;
        public virtual DbSet<TaxSchedule> TaxSchedules { get; set; } = null!;
        public virtual DbSet<TaxTable> TaxTables { get; set; } = null!;
        public virtual DbSet<TaxTranslation> TaxTranslations { get; set; } = null!;
        public virtual DbSet<TempState> TempStates { get; set; } = null!;
        public virtual DbSet<TerminalConfiguration> TerminalConfigurations { get; set; } = null!;
        public virtual DbSet<TimeCard> TimeCards { get; set; } = null!;
        public virtual DbSet<TimedMenu> TimedMenus { get; set; } = null!;
        public virtual DbSet<TimedMenuDay> TimedMenuDays { get; set; } = null!;
        public virtual DbSet<TimedMenuJob> TimedMenuJobs { get; set; } = null!;
        public virtual DbSet<TipPool> TipPools { get; set; } = null!;
        public virtual DbSet<TipPoolContribution> TipPoolContributions { get; set; } = null!;
        public virtual DbSet<TipPoolDistribution> TipPoolDistributions { get; set; } = null!;
        public virtual DbSet<TokenLastActivity> TokenLastActivities { get; set; } = null!;
        public virtual DbSet<Total> Totals { get; set; } = null!;
        public virtual DbSet<Transfer> Transfers { get; set; } = null!;
        public virtual DbSet<UI> UIs { get; set; } = null!;
        public virtual DbSet<UIColumn> UIColumns { get; set; } = null!;
        public virtual DbSet<VDU> VDUs { get; set; } = null!;
        public virtual DbSet<VDUItem> VDUItems { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;
        public virtual DbSet<VendorPurchase> VendorPurchases { get; set; } = null!;
        public virtual DbSet<Version> Versions { get; set; } = null!;
        public virtual DbSet<VideoCapture> VideoCaptures { get; set; } = null!;
        public virtual DbSet<WageHistory> WageHistories { get; set; } = null!;
        public virtual DbSet<WageHistoryWage> WageHistoryWages { get; set; } = null!;
        public virtual DbSet<XMLBucket> XMLBuckets { get; set; } = null!;
        public virtual DbSet<_BackgroundProcess> _BackgroundProcesses { get; set; } = null!;
        public virtual DbSet<_BackgroundProcessLock> _BackgroundProcessLocks { get; set; } = null!;
        public virtual DbSet<_BucketValue> _BucketValues { get; set; } = null!;
        public virtual DbSet<_Calendar> _Calendars { get; set; } = null!;
        public virtual DbSet<_HourOfDay> _HourOfDays { get; set; } = null!;
        public virtual DbSet<_ImportMapping> _ImportMappings { get; set; } = null!;
        public virtual DbSet<_Report> _Reports { get; set; } = null!;
        public virtual DbSet<_ReportCategory> _ReportCategories { get; set; } = null!;
        public virtual DbSet<_ReportDataSource> _ReportDataSources { get; set; } = null!;
        public virtual DbSet<_ReportFormula> _ReportFormulas { get; set; } = null!;
        public virtual DbSet<_ReportGroup> _ReportGroups { get; set; } = null!;
        public virtual DbSet<_ReportGroupLayout> _ReportGroupLayouts { get; set; } = null!;
        public virtual DbSet<_ReportParameter> _ReportParameters { get; set; } = null!;
        public virtual DbSet<_ReportParameterValue> _ReportParameterValues { get; set; } = null!;
        public virtual DbSet<_ReportRole> _ReportRoles { get; set; } = null!;
        public virtual DbSet<_ReportSchedule> _ReportSchedules { get; set; } = null!;
        public virtual DbSet<_ReportTempDatum> _ReportTempData { get; set; } = null!;
        public virtual DbSet<_ScheduledProcess> _ScheduledProcesses { get; set; } = null!;
        public virtual DbSet<_vBucketDataByDateAndTime> _vBucketDataByDateAndTimes { get; set; } = null!;
        public virtual DbSet<_vBucketDataByEmployee> _vBucketDataByEmployees { get; set; } = null!;
        public virtual DbSet<_vBucketDataByJobCode> _vBucketDataByJobCodes { get; set; } = null!;
        public virtual DbSet<_vBucketDataByJobCodeAndEmployee> _vBucketDataByJobCodeAndEmployees { get; set; } = null!;
        public virtual DbSet<_vBucketDataByMediaAndEmployee> _vBucketDataByMediaAndEmployees { get; set; } = null!;
        public virtual DbSet<_vBucketDataByMedium> _vBucketDataByMedia { get; set; } = null!;
        public virtual DbSet<_vBucketDataBySection> _vBucketDataBySections { get; set; } = null!;
        public virtual DbSet<_vBucketDataBySectionAndEmployee> _vBucketDataBySectionAndEmployees { get; set; } = null!;
        public virtual DbSet<_vBucketDataByServingPeriod> _vBucketDataByServingPeriods { get; set; } = null!;
        public virtual DbSet<_vBucketDataByServingPeriodAndEmployee> _vBucketDataByServingPeriodAndEmployees { get; set; } = null!;
        public virtual DbSet<_vCalendarHour> _vCalendarHours { get; set; } = null!;
        public virtual DbSet<_vLaborBucket> _vLaborBuckets { get; set; } = null!;
        public virtual DbSet<_vLaborBucketGrouped> _vLaborBucketGroupeds { get; set; } = null!;
        public virtual DbSet<_vLaborByDateAndTime> _vLaborByDateAndTimes { get; set; } = null!;
        public virtual DbSet<_vLaborByEmployee> _vLaborByEmployees { get; set; } = null!;
        public virtual DbSet<_vLaborByJobCode> _vLaborByJobCodes { get; set; } = null!;
        public virtual DbSet<_vLaborByJobCodeAndEmployee> _vLaborByJobCodeAndEmployees { get; set; } = null!;
        public virtual DbSet<_vLaborBySection> _vLaborBySections { get; set; } = null!;
        public virtual DbSet<_vLaborBySectionAndEmployee> _vLaborBySectionAndEmployees { get; set; } = null!;
        public virtual DbSet<_vLaborByServingPeriod> _vLaborByServingPeriods { get; set; } = null!;
        public virtual DbSet<_vLaborByServingPeriodAndEmployee> _vLaborByServingPeriodAndEmployees { get; set; } = null!;
        public virtual DbSet<_vPunchPairByJobCode> _vPunchPairByJobCodes { get; set; } = null!;
        public virtual DbSet<_vPunchPairByShift> _vPunchPairByShifts { get; set; } = null!;
        public virtual DbSet<_vSaleItemSubTableSum> _vSaleItemSubTableSums { get; set; } = null!;
        public virtual DbSet<_vSaleSection> _vSaleSections { get; set; } = null!;
        public virtual DbSet<_vSaleSubCreditCardSum> _vSaleSubCreditCardSums { get; set; } = null!;
        public virtual DbSet<_vSaleSubMediaSum> _vSaleSubMediaSums { get; set; } = null!;
        public virtual DbSet<_vSaleSubTableSum> _vSaleSubTableSums { get; set; } = null!;
        public virtual DbSet<_vSaleSubTaxSum> _vSaleSubTaxSums { get; set; } = null!;
        public virtual DbSet<_vSaleSubTenderSum> _vSaleSubTenderSums { get; set; } = null!;
        public virtual DbSet<_vSalesByDateAndTime> _vSalesByDateAndTimes { get; set; } = null!;
        public virtual DbSet<_vSalesByItemBucket> _vSalesByItemBuckets { get; set; } = null!;
        public virtual DbSet<_vSalesForEmployeeBucket> _vSalesForEmployeeBuckets { get; set; } = null!;
        public virtual DbSet<_vSalesForLaborBucket> _vSalesForLaborBuckets { get; set; } = null!;
        public virtual DbSet<dba_indexDefragExclusion> dba_indexDefragExclusions { get; set; } = null!;
        public virtual DbSet<dba_indexDefragLog> dba_indexDefragLogs { get; set; } = null!;
        public virtual DbSet<dba_indexDefragStatus> dba_indexDefragStatuses { get; set; } = null!;
        public virtual DbSet<vBottom10Dept> vBottom10Depts { get; set; } = null!;
        public virtual DbSet<vBottom10DeptsPrice> vBottom10DeptsPrices { get; set; } = null!;
        public virtual DbSet<vBottom10Item> vBottom10Items { get; set; } = null!;
        public virtual DbSet<vBottom10ItemsPrice> vBottom10ItemsPrices { get; set; } = null!;
        public virtual DbSet<vButtonMenu> vButtonMenus { get; set; } = null!;
        public virtual DbSet<vContentLink> vContentLinks { get; set; } = null!;
        public virtual DbSet<vCreditBatch> vCreditBatches { get; set; } = null!;
        public virtual DbSet<vDBFileHeader> vDBFileHeaders { get; set; } = null!;
        public virtual DbSet<vDisplaySchedule> vDisplaySchedules { get; set; } = null!;
        public virtual DbSet<vItemLabel> vItemLabels { get; set; } = null!;
        public virtual DbSet<vItemLink> vItemLinks { get; set; } = null!;
        public virtual DbSet<vMenuSchedule> vMenuSchedules { get; set; } = null!;
        public virtual DbSet<vPlayListItem> vPlayListItems { get; set; } = null!;
        public virtual DbSet<vSaleItemLink> vSaleItemLinks { get; set; } = null!;
        public virtual DbSet<vTop10Dept> vTop10Depts { get; set; } = null!;
        public virtual DbSet<vTop10DeptsPrice> vTop10DeptsPrices { get; set; } = null!;
        public virtual DbSet<vTop10Item> vTop10Items { get; set; } = null!;
        public virtual DbSet<vTop10ItemsPrice> vTop10ItemsPrices { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Config.GetConnectionString("FutureDB"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("Activity");

                entity.HasIndex(e => e.Action, "IX_Activity_Action");

                entity.HasIndex(e => e.ActivityDate, "IX_Activity_ActivityDate");

                entity.Property(e => e.ActivityID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ActivityDate).HasColumnType("datetime");

                entity.Property(e => e.Data).HasMaxLength(50);

                entity.Property(e => e.IPAddress).HasMaxLength(45);

                entity.Property(e => e.OAuthAspNetUserId).HasDefaultValueSql("(CONVERT([uniqueidentifier],CONVERT([binary],(0),(0)),(0)))");
            });

            modelBuilder.Entity<ActivityDetail>(entity =>
            {
                entity.ToTable("ActivityDetail");

                entity.Property(e => e.ActivityDetailID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ChangedValue)
                    .HasMaxLength(2048)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OriginalIdentifier)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OriginalValue)
                    .HasMaxLength(2048)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TableName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityDetails)
                    .HasForeignKey(d => d.ActivityID)
                    .HasConstraintName("FK_ActivityDetail_Activity");
            });

            modelBuilder.Entity<AdDisplay>(entity =>
            {
                entity.HasKey(e => e.DisplayID);

                entity.ToTable("AdDisplay");

                entity.Property(e => e.DisplayID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DisplayTitle).HasMaxLength(500);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<AdDisplaySchedule>(entity =>
            {
                entity.HasKey(e => e.DisplayScheduleID);

                entity.ToTable("AdDisplaySchedule");

                entity.HasIndex(e => e.DisplayID, "IX_AdDisplaySchedule");

                entity.Property(e => e.DisplayScheduleID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DaysOfWeek).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdLinkContent>(entity =>
            {
                entity.HasKey(e => e.LinkID);

                entity.ToTable("AdLinkContent");

                entity.Property(e => e.LinkID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TransitionNumber).HasDefaultValueSql("((6))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdPlayList>(entity =>
            {
                entity.HasKey(e => e.PlayListID);

                entity.ToTable("AdPlayList");

                entity.Property(e => e.PlayListID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ImportByName)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ImportTime).HasDefaultValueSql("((10))");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PlayListName).HasMaxLength(50);

                entity.Property(e => e.SyncByFileDate)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SyncFolderPath).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AdPlayListItem>(entity =>
            {
                entity.HasKey(e => e.PlaylistItemID);

                entity.ToTable("AdPlayListItem");

                entity.Property(e => e.PlaylistItemID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.LoadContent)
                    .IsRequired()
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.MediaType)
                    .HasMaxLength(50)
                    .HasComment("0=jpg,1=gif,2=mp4,3=png,4=swf");

                entity.Property(e => e.OriginalFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdScheduleGroup>(entity =>
            {
                entity.HasKey(e => e.GroupID);

                entity.ToTable("AdScheduleGroup");

                entity.Property(e => e.GroupID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ByRange)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdScoreLayout>(entity =>
            {
                entity.HasKey(e => e.DesignID);

                entity.ToTable("AdScoreLayout");

                entity.Property(e => e.DesignID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BackgroundColor).HasMaxLength(10);

                entity.Property(e => e.DrawModifiers)
                    .IsRequired()
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.EvenRowBackgroundColor).HasMaxLength(10);

                entity.Property(e => e.EvenRowFontColor).HasMaxLength(10);

                entity.Property(e => e.FontColor).HasMaxLength(10);

                entity.Property(e => e.FontFamily)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FontWeight)
                    .IsRequired()
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.HeaderLineColor).HasMaxLength(10);

                entity.Property(e => e.LeftColumnHeader).HasMaxLength(50);

                entity.Property(e => e.OddRowBackgroundColor).HasMaxLength(10);

                entity.Property(e => e.OddRowFontColor).HasMaxLength(10);

                entity.Property(e => e.RightColumnHeader).HasMaxLength(50);

                entity.Property(e => e.StageColor)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TotalColumnHeaderText).HasMaxLength(50);

                entity.Property(e => e.TotalLineColor).HasMaxLength(10);
            });

            modelBuilder.Entity<AdTemplateContentLink>(entity =>
            {
                entity.HasKey(e => e.LinkTemplateID)
                    .HasName("PK_AdScoreContentLink");

                entity.ToTable("AdTemplateContentLink");

                entity.Property(e => e.LinkTemplateID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<Alert>(entity =>
            {
                entity.ToTable("Alert");

                entity.Property(e => e.AlertID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AlertName).HasMaxLength(50);

                entity.Property(e => e.LastAlert).HasColumnType("datetime");
            });

            modelBuilder.Entity<AlertEmail>(entity =>
            {
                entity.ToTable("AlertEmail");

                entity.Property(e => e.AlertEmailID).ValueGeneratedNever();

                entity.Property(e => e.AlertEmailAddress).HasMaxLength(250);

                entity.Property(e => e.AlertEmailCarrier).HasMaxLength(20);

                entity.Property(e => e.AlertEmailFname).HasMaxLength(50);

                entity.Property(e => e.AlertEmailLname).HasMaxLength(50);

                entity.Property(e => e.AlertEmailPhone).HasMaxLength(25);
            });

            modelBuilder.Entity<AlertSetting>(entity =>
            {
                entity.HasKey(e => e.AlertSettingsID)
                    .HasName("PK_AlertSettings");

                entity.ToTable("AlertSetting");

                entity.HasIndex(e => e.AlertID, "IX_AlertSetting");

                entity.Property(e => e.AlertSettingsID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AlertFieldName)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AlertFieldValue).HasDefaultValueSql("('')");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdateStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<AveroID>(entity =>
            {
                entity.ToTable("AveroID");

                entity.Property(e => e.name).HasMaxLength(50);
            });

            modelBuilder.Entity<AveroPayID>(entity =>
            {
                entity.HasKey(e => e.RowNum)
                    .HasName("PK__AveroPay__4F4A6852F12BBD49");

                entity.ToTable("AveroPayID");

                entity.Property(e => e.MediaID).HasMaxLength(40);

                entity.Property(e => e.MediaName).HasMaxLength(20);

                entity.Property(e => e.UpdatedOn)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BackupSetting>(entity =>
            {
                entity.HasKey(e => e.BackupSettingsID);

                entity.Property(e => e.BackupSettingsID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BackupName).HasMaxLength(50);

                entity.Property(e => e.BackupTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BeverageCount>(entity =>
            {
                entity.ToTable("BeverageCount");

                entity.Property(e => e.BeverageCountID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BeverageCountInfo>(entity =>
            {
                entity.ToTable("BeverageCountInfo");

                entity.Property(e => e.BeverageCountInfoID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EnteredTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BeverageCountItem>(entity =>
            {
                entity.ToTable("BeverageCountItem");

                entity.Property(e => e.BeverageCountItemID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.InCount).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutCount).HasDefaultValueSql("((-1))");

                entity.HasOne(d => d.BeverageCount)
                    .WithMany(p => p.BeverageCountItems)
                    .HasForeignKey(d => d.BeverageCountID)
                    .HasConstraintName("FK_BeverageCountItem_BeverageCount");
            });

            modelBuilder.Entity<Break>(entity =>
            {
                entity.ToTable("Break");

                entity.Property(e => e.BreakID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BreakName).HasMaxLength(50);
            });

            modelBuilder.Entity<BreakJob>(entity =>
            {
                entity.ToTable("BreakJob");

                entity.HasIndex(e => e.BreakID, "IX_BreakJob");

                entity.Property(e => e.BreakJobID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Break)
                    .WithMany(p => p.BreakJobs)
                    .HasForeignKey(d => d.BreakID)
                    .HasConstraintName("FK_BreakJob_Break");
            });

            modelBuilder.Entity<BucketTransfer>(entity =>
            {
                entity.ToTable("BucketTransfer");

                entity.Property(e => e.BucketTransferID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BucketType).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Key1).HasMaxLength(50);

                entity.Property(e => e.Key2).HasMaxLength(50);

                entity.Property(e => e.Key3).HasMaxLength(50);

                entity.Property(e => e.Key4).HasMaxLength(50);

                entity.Property(e => e.Key5).HasMaxLength(50);

                entity.Property(e => e.Key6).HasMaxLength(50);
            });

            modelBuilder.Entity<BusyIndicatorSchedule>(entity =>
            {
                entity.ToTable("BusyIndicatorSchedule");

                entity.Property(e => e.BusyIndicatorScheduleID).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Button>(entity =>
            {
                entity.ToTable("Button");

                entity.HasIndex(e => new { e.RegionID, e.Menu }, "IX_Button");

                entity.Property(e => e.ButtonID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ButtonName).HasMaxLength(32);

                entity.Property(e => e.Data).HasMaxLength(512);

                entity.Property(e => e.FontFaceName).HasMaxLength(50);

                entity.Property(e => e.GraphicName).HasMaxLength(50);

                entity.Property(e => e.Menu).HasMaxLength(20);

                entity.Property(e => e.ShowSkinStylization)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ButtonTranslation>(entity =>
            {
                entity.ToTable("ButtonTranslation");

                entity.Property(e => e.ButtonTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Button)
                    .WithMany(p => p.ButtonTranslations)
                    .HasForeignKey(d => d.ButtonID)
                    .HasConstraintName("FK_ButtonTranslation_Button");
            });

            modelBuilder.Entity<Cashier>(entity =>
            {
                entity.ToTable("Cashier");

                entity.Property(e => e.CashierID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Cashier1)
                    .HasMaxLength(32)
                    .HasColumnName("Cashier");
            });

            modelBuilder.Entity<CheckNumber>(entity =>
            {
                entity.HasKey(e => e.NextSaleID)
                    .HasName("PK_NextSaleNumber");

                entity.ToTable("CheckNumber");

                entity.HasIndex(e => e.StoreID, "IX_CheckNumber");

                entity.Property(e => e.NextSaleID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TicketNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.TicketNumberLastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.HasIndex(e => new { e.RegionID, e.ClassIndex }, "IX_Class");

                entity.Property(e => e.ClassID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ADPPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.APSPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AbraPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Accardis)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AdDriver)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AssignClasses)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.CBSPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CallerId)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CallerIdCom)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CanViewAutoReport)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ChefTec)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ClassName).HasMaxLength(20);

                entity.Property(e => e.ClassSecurity).HasColumnType("text");

                entity.Property(e => e.CostGuard)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreditCardModule)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DataTranCCAM)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DeductIT)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FoodTrak)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GreatPlainsGL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GreatPlainsPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HeartlandPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InternetCCAM)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mas90GL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mas90Payroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLink)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkGL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkSalesInterval)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PayChexPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PayPeriodRefDate).HasColumnType("datetime");

                entity.Property(e => e.PeachtreeGL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PurgeOldData)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuickBooksPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuickbooksGL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SaaShrPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ScoreboardDriver)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VduDriver)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.X10Driver)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CompulsoryDrink>(entity =>
            {
                entity.ToTable("CompulsoryDrink");

                entity.Property(e => e.CompulsoryDrinkID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CompulsoryDrinkDepartment)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CompulsoryEntree>(entity =>
            {
                entity.ToTable("CompulsoryEntree");

                entity.Property(e => e.CompulsoryEntreeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CompulsoryEntreeDepartment)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.ToTable("Configuration");

                entity.Property(e => e.ConfigurationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Parameter).HasMaxLength(50);

                entity.Property(e => e.ParameterIndex2).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Section).HasMaxLength(50);
            });

            modelBuilder.Entity<ConfigurationDevice>(entity =>
            {
                entity.ToTable("ConfigurationDevice");

                entity.Property(e => e.ConfigurationDeviceID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ConfigurationSecure>(entity =>
            {
                entity.ToTable("ConfigurationSecure");

                entity.Property(e => e.ConfigurationSecureID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Parameter).HasMaxLength(50);

                entity.Property(e => e.ParameterIndex2).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Section).HasMaxLength(50);

                entity.Property(e => e.Value)
                    .HasMaxLength(4096)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CorporateMessage>(entity =>
            {
                entity.ToTable("CorporateMessage");

                entity.Property(e => e.CorporateMessageID).ValueGeneratedNever();

                entity.Property(e => e.ApplicationName).HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.ToTable("Coupon");

                entity.Property(e => e.CouponID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CouponName).HasMaxLength(20);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Text).HasMaxLength(512);

                entity.Property(e => e.UPC).HasMaxLength(32);

                entity.Property(e => e.WebRedemptionCode).HasMaxLength(16);
            });

            modelBuilder.Entity<CouponItem>(entity =>
            {
                entity.ToTable("CouponItem");

                entity.HasIndex(e => e.CouponID, "IX_CouponItem");

                entity.Property(e => e.CouponItemID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponItems)
                    .HasForeignKey(d => d.CouponID)
                    .HasConstraintName("FK_CouponItem_Coupon");
            });

            modelBuilder.Entity<CouponTranslation>(entity =>
            {
                entity.ToTable("CouponTranslation");

                entity.Property(e => e.CouponTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponTranslations)
                    .HasForeignKey(d => d.CouponID)
                    .HasConstraintName("FK_CouponTranslation_Coupon");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CreditBatch>(entity =>
            {
                entity.HasKey(e => e.BatchID);

                entity.ToTable("CreditBatch");

                entity.HasIndex(e => e.DataVersion, "IX_CreditBatch_DataVersion");

                entity.Property(e => e.BatchID).ValueGeneratedNever();

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.AppCd)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.AuthorizeDate).HasColumnType("datetime");

                entity.Property(e => e.BatchRecord)
                    .HasMaxLength(520)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CreditDeviceInfo>(entity =>
            {
                entity.ToTable("CreditDeviceInfo");

                entity.Property(e => e.CreditDeviceInfoID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<CreditDeviceSaleStatus>(entity =>
            {
                entity.ToTable("CreditDeviceSaleStatus");

                entity.Property(e => e.CreditDeviceSaleStatusID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Info).HasMaxLength(40);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CurrencyConversion>(entity =>
            {
                entity.ToTable("CurrencyConversion");

                entity.Property(e => e.CurrencyConversionID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ConversionBaseName).HasMaxLength(32);

                entity.Property(e => e.ConversionBaseShortName).HasMaxLength(4);
            });

            modelBuilder.Entity<CurrencyConversionItem>(entity =>
            {
                entity.ToTable("CurrencyConversionItem");

                entity.HasIndex(e => e.CurrencyConversionID, "IX_CurrencyConversionItem");

                entity.Property(e => e.CurrencyConversionItemID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ConversionName).HasMaxLength(32);

                entity.Property(e => e.ConversionRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ConversionShortName).HasMaxLength(4);

                entity.HasOne(d => d.CurrencyConversion)
                    .WithMany(p => p.CurrencyConversionItems)
                    .HasForeignKey(d => d.CurrencyConversionID)
                    .HasConstraintName("FK_CurrencyConversionItem_CurrencyConversion");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasIndex(e => new { e.CustomerNumber, e.StoreID }, "IX_Customer")
                    .IsUnique();

                entity.HasIndex(e => new { e.UserData, e.LastName, e.FirstName }, "IX_Customer_1");

                entity.HasIndex(e => e.Badge, "IX_Customer_Badge");

                entity.HasIndex(e => new { e.LastName, e.FirstName }, "IX_Customer_Name");

                entity.HasIndex(e => e.CustomerNumber, "IX_Customer_Number");

                entity.HasIndex(e => new { e.Phone, e.LastName, e.FirstName }, "IX_Customer_Phone");

                entity.Property(e => e.CustomerID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address1).HasMaxLength(64);

                entity.Property(e => e.Address2).HasMaxLength(64);

                entity.Property(e => e.BCItems)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Badge).HasMaxLength(40);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(16);

                entity.Property(e => e.Comments).HasMaxLength(600);

                entity.Property(e => e.Company).HasMaxLength(32);

                entity.Property(e => e.CustomerCard).HasMaxLength(16);

                entity.Property(e => e.Directions).HasMaxLength(600);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Extension).HasMaxLength(6);

                entity.Property(e => e.Extension2).HasMaxLength(6);

                entity.Property(e => e.Extension3).HasMaxLength(6);

                entity.Property(e => e.Extension4).HasMaxLength(6);

                entity.Property(e => e.Extension5).HasMaxLength(6);

                entity.Property(e => e.FPBuffer).HasMaxLength(6000);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.MiddleInitial)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.Phone2).HasMaxLength(16);

                entity.Property(e => e.Phone3).HasMaxLength(16);

                entity.Property(e => e.Phone4).HasMaxLength(16);

                entity.Property(e => e.Phone5).HasMaxLength(16);

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.UserData).HasMaxLength(20);

                entity.Property(e => e.Zip).HasMaxLength(16);
            });

            modelBuilder.Entity<CustomerCard>(entity =>
            {
                entity.ToTable("CustomerCard");

                entity.HasIndex(e => e.CustomerID, "IX_CustomerCard");

                entity.HasIndex(e => e.DataVersion, "IX_CustomerCard_DataVersion");

                entity.Property(e => e.CustomerCardID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreditCard)
                    .HasMaxLength(136)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EncryptedBlock)
                    .HasMaxLength(232)
                    .IsFixedLength();

                entity.Property(e => e.EncryptedRawSwipe)
                    .HasMaxLength(1024)
                    .IsFixedLength();

                entity.Property(e => e.EncryptionKey)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.VaultID)
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCards)
                    .HasForeignKey(d => d.CustomerID)
                    .HasConstraintName("FKS_CustomerCard_Customer");
            });

            modelBuilder.Entity<CustomerCharge>(entity =>
            {
                entity.ToTable("CustomerCharge");

                entity.HasIndex(e => e.CustomerNumber, "IX_CustomerCharge");

                entity.Property(e => e.CustomerChargeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ChargeDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerLastOrder>(entity =>
            {
                entity.HasKey(e => e.CustomerOrderID);

                entity.ToTable("CustomerLastOrder");

                entity.HasIndex(e => e.CustomerID, "IX_CustomerLastOrder");

                entity.Property(e => e.CustomerOrderID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.SettleDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerLastOrders)
                    .HasForeignKey(d => d.CustomerID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CustomerLastOrder_Customer");
            });

            modelBuilder.Entity<CustomerNumber>(entity =>
            {
                entity.ToTable("CustomerNumber");

                entity.Property(e => e.CustomerNumberID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CustomerNumber1).HasColumnName("CustomerNumber");
            });

            modelBuilder.Entity<CustomerPlan>(entity =>
            {
                entity.ToTable("CustomerPlan");

                entity.HasIndex(e => e.CustomerID, "IX_CustomerPlan");

                entity.Property(e => e.CustomerPlanID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPlans)
                    .HasForeignKey(d => d.CustomerID)
                    .HasConstraintName("FK_CustomerPlan_Customer");
            });

            modelBuilder.Entity<CustomerRating>(entity =>
            {
                entity.ToTable("CustomerRating");

                entity.Property(e => e.CustomerRatingID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Comment).HasMaxLength(128);

                entity.Property(e => e.CreatedDateUTC).HasColumnType("datetime");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.CustomerRatings)
                    .HasForeignKey(d => d.SaleID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CustomerRating_Sale");
            });

            modelBuilder.Entity<DBFile>(entity =>
            {
                entity.ToTable("DBFile");

                entity.HasIndex(e => new { e.FileType, e.FileName }, "IX_DBFile");

                entity.Property(e => e.DBFileID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FileDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(50);
            });

            modelBuilder.Entity<DashBoardItem>(entity =>
            {
                entity.ToTable("DashBoardItem");

                entity.Property(e => e.DashBoardItemID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.DasboardItemName).HasMaxLength(150);
            });

            modelBuilder.Entity<DashBoardSetting>(entity =>
            {
                entity.HasKey(e => e.DashBoardSettingsID);

                entity.Property(e => e.DashBoardSettingsID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.DashFieldName)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DashFieldValue).HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<DashboardWidget>(entity =>
            {
                entity.ToTable("DashboardWidget");

                entity.Property(e => e.DashboardWidgetID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DashboardWidgets)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_DashboardWidget_Employee");
            });

            modelBuilder.Entity<DataGroup>(entity =>
            {
                entity.ToTable("DataGroup");

                entity.Property(e => e.DataGroupID).ValueGeneratedNever();

                entity.Property(e => e.AppliedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ScheduleGroup)
                    .WithMany(p => p.DataGroups)
                    .HasForeignKey(d => d.ScheduleGroupID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DataGroup_ScheduledUpdateScheduleGroup");
            });

            modelBuilder.Entity<DataGroupStore>(entity =>
            {
                entity.ToTable("DataGroupStore");

                entity.Property(e => e.DataGroupStoreID).ValueGeneratedNever();

                entity.HasOne(d => d.DataGroup)
                    .WithMany(p => p.DataGroupStores)
                    .HasForeignKey(d => d.DataGroupID)
                    .HasConstraintName("DataGroupStore_DataGroupID_FK");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.DataGroupStores)
                    .HasForeignKey(d => d.StoreID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DataGroupStore_StoreID_FK");
            });

            modelBuilder.Entity<DataTypeReference>(entity =>
            {
                entity.HasKey(e => e.DataTypeID)
                    .HasName("PK_DataType");

                entity.ToTable("DataTypeReference");

                entity.Property(e => e.DataTypeID).ValueGeneratedNever();

                entity.Property(e => e.DataType)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'String')");

                entity.Property(e => e.SqlDataType)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'nvarchar')");
            });

            modelBuilder.Entity<DayDivide>(entity =>
            {
                entity.ToTable("DayDivide");

                entity.Property(e => e.DayDivideDateTime).HasColumnType("datetime");

                entity.Property(e => e.DayDivideDateTimeNXT).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeliveryDriver>(entity =>
            {
                entity.HasKey(e => e.DriverID);

                entity.ToTable("DeliveryDriver");

                entity.Property(e => e.DriverID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(20);
            });

            modelBuilder.Entity<DeliveryZone>(entity =>
            {
                entity.ToTable("DeliveryZone");

                entity.Property(e => e.DeliveryZoneID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ZoneName).HasMaxLength(32);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.HasIndex(e => new { e.RegionID, e.DepartmentName }, "IX_Department");

                entity.Property(e => e.DepartmentID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DepartmentDescription).HasMaxLength(30);

                entity.Property(e => e.DepartmentName).HasMaxLength(10);

                entity.Property(e => e.GroupName).HasMaxLength(30);

                entity.Property(e => e.ImageName).HasMaxLength(20);

                entity.Property(e => e.OverrideAutoMenuButtonSettingsGraphic).HasMaxLength(50);

                entity.Property(e => e.WebImagePath).HasMaxLength(254);

                entity.Property(e => e.WebThumbPath).HasMaxLength(254);

                entity.Property(e => e.WebTitle).HasMaxLength(30);
            });

            modelBuilder.Entity<DepartmentMobileExclusion>(entity =>
            {
                entity.ToTable("DepartmentMobileExclusion");

                entity.HasIndex(e => e.EmpID, "IX_DepartmentMobileExclusion_EmpID");

                entity.Property(e => e.DepartmentMobileExclusionID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentMobileExclusions)
                    .HasForeignKey(d => d.DepartmentID)
                    .HasConstraintName("FK_DepartmentMobileExclusion_Department");
            });

            modelBuilder.Entity<DepartmentRank>(entity =>
            {
                entity.ToTable("DepartmentRank");

                entity.Property(e => e.DepartmentRankID).ValueGeneratedNever();
            });

            modelBuilder.Entity<DepartmentSchedule>(entity =>
            {
                entity.ToTable("DepartmentSchedule");

                entity.HasIndex(e => e.DepartmentID, "IX_DepartmentSchedule");

                entity.Property(e => e.DepartmentScheduleID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentSchedules)
                    .HasForeignKey(d => d.DepartmentID)
                    .HasConstraintName("FK_DepartmentSchedule_Department");
            });

            modelBuilder.Entity<DepartmentTranslation>(entity =>
            {
                entity.ToTable("DepartmentTranslation");

                entity.Property(e => e.DepartmentTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentTranslations)
                    .HasForeignKey(d => d.DepartmentID)
                    .HasConstraintName("FK_DepartmentTranslation_Department");
            });

            modelBuilder.Entity<DinePointConfig>(entity =>
            {
                entity.HasKey(e => e.StoreID);

                entity.ToTable("DinePointConfig");

                entity.Property(e => e.StoreID).ValueGeneratedNever();

                entity.Property(e => e.DayDivide).HasColumnType("datetime");
            });

            modelBuilder.Entity<DinePointDayDivide>(entity =>
            {
                entity.HasKey(e => e.BusinessDate)
                    .HasName("PK_DinePointDayDivide_1");

                entity.ToTable("DinePointDayDivide");

                entity.Property(e => e.BusinessDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DinePointJobCode>(entity =>
            {
                entity.HasKey(e => e.JobCodeIndex);

                entity.ToTable("DinePointJobCode");

                entity.Property(e => e.JobCodeIndex).ValueGeneratedNever();

                entity.Property(e => e.JobCodeName).HasMaxLength(50);
            });

            modelBuilder.Entity<DinePointOrderType>(entity =>
            {
                entity.HasKey(e => e.OrderTypeIndex);

                entity.ToTable("DinePointOrderType");

                entity.Property(e => e.OrderTypeIndex).ValueGeneratedNever();

                entity.Property(e => e.OrderType).HasMaxLength(50);
            });

            modelBuilder.Entity<DinePointRevenueCenter>(entity =>
            {
                entity.HasKey(e => e.RevenueCenterIndex);

                entity.ToTable("DinePointRevenueCenter");

                entity.Property(e => e.RevenueCenterIndex).ValueGeneratedNever();

                entity.Property(e => e.RevenueCenter).HasMaxLength(50);
            });

            modelBuilder.Entity<DinePointServingPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodIndex);

                entity.ToTable("DinePointServingPeriod");

                entity.Property(e => e.PeriodIndex).ValueGeneratedNever();

                entity.Property(e => e.PeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.PeriodName).HasMaxLength(50);

                entity.Property(e => e.PeriodStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<DirtyTable>(entity =>
            {
                entity.ToTable("DirtyTable");

                entity.HasIndex(e => e.StoreID, "IX_DirtyTable");

                entity.Property(e => e.DirtyTableID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("Discount");

                entity.Property(e => e.DiscountID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DiscountName).HasMaxLength(20);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Text).HasMaxLength(512);
            });

            modelBuilder.Entity<DiscountTranslation>(entity =>
            {
                entity.ToTable("DiscountTranslation");

                entity.Property(e => e.DiscountTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountTranslations)
                    .HasForeignKey(d => d.DiscountID)
                    .HasConstraintName("FK_DiscountTranslation_Discount");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => new { e.EmpID, e.StoreID }, "IX_Employee")
                    .IsUnique();

                entity.HasIndex(e => new { e.StoreID, e.FrontEndPassword }, "IX_Employee_Login");

                entity.Property(e => e.EmployeeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address).HasMaxLength(64);

                entity.Property(e => e.BackOfficeHash1)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficeHash2)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficeHash3)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficeHash4)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficePassword1)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficePassword2)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficePassword3)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficePassword4)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Badge).HasMaxLength(40);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CellPhone).HasMaxLength(16);

                entity.Property(e => e.City).HasMaxLength(16);

                entity.Property(e => e.CloudUserInviteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FingerPrintData).HasMaxLength(6000);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.FrontEndHash)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.FrontEndPassword)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.IceName).HasMaxLength(20);

                entity.Property(e => e.IcePhone).HasMaxLength(16);

                entity.Property(e => e.LastBadPWDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.LockedOut).HasColumnType("datetime");

                entity.Property(e => e.MiddleInitial)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Notes).HasMaxLength(600);

                entity.Property(e => e.PasswordChanged).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.SSN)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Salt)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.UserInfo).HasMaxLength(40);

                entity.Property(e => e.Zip).HasMaxLength(16);
            });

            modelBuilder.Entity<EmployeeAvailability>(entity =>
            {
                entity.ToTable("EmployeeAvailability");

                entity.HasIndex(e => new { e.EmpID, e.StoreID }, "IX_EmployeeAvailability");

                entity.Property(e => e.EmployeeAvailabilityID).ValueGeneratedNever();

                entity.Property(e => e.Weekly)
                    .HasMaxLength(336)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EmployeeAvailabilityRange>(entity =>
            {
                entity.ToTable("EmployeeAvailabilityRange");

                entity.HasIndex(e => e.EmployeeAvailabilityID, "IX_EmployeeAvailabilityRange");

                entity.Property(e => e.EmployeeAvailabilityRangeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.RangeDescription).HasMaxLength(32);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.EmployeeAvailability)
                    .WithMany(p => p.EmployeeAvailabilityRanges)
                    .HasForeignKey(d => d.EmployeeAvailabilityID)
                    .HasConstraintName("FK_EmployeeAvailabilityRange_EmployeeAvailabilityRange");
            });

            modelBuilder.Entity<EmployeeDrawer>(entity =>
            {
                entity.ToTable("EmployeeDrawer");

                entity.HasIndex(e => e.EmployeeID, "IX_EmployeeDrawer");

                entity.Property(e => e.EmployeeDrawerID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeDrawers)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_EmployeeDrawer_Employee");
            });

            modelBuilder.Entity<EmployeeHintShown>(entity =>
            {
                entity.ToTable("EmployeeHintShown");

                entity.Property(e => e.EmployeeHintShownID).ValueGeneratedNever();
            });

            modelBuilder.Entity<EmployeeLaborGroupHistory>(entity =>
            {
                entity.HasKey(e => e.LaborGroupHistoryID);

                entity.ToTable("EmployeeLaborGroupHistory");

                entity.Property(e => e.LaborGroupHistoryID).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeRate>(entity =>
            {
                entity.ToTable("EmployeeRate");

                entity.HasIndex(e => e.EmployeeID, "IX_EmployeeRate");

                entity.Property(e => e.EmployeeRateID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeRates)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_EmployeeWage_Employee");
            });

            modelBuilder.Entity<EmployeeTip>(entity =>
            {
                entity.ToTable("EmployeeTip");

                entity.Property(e => e.EmployeeTipID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TipDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Enterprise>(entity =>
            {
                entity.HasKey(e => e.EntID);

                entity.ToTable("Enterprise");

                entity.Property(e => e.EntID).ValueGeneratedNever();

                entity.Property(e => e.APIKey).HasMaxLength(200);

                entity.Property(e => e.EmailPassword).HasMaxLength(40);

                entity.Property(e => e.EmailPasswordEnc)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.EmailServer).HasMaxLength(65);

                entity.Property(e => e.EmailUser).HasMaxLength(40);

                entity.Property(e => e.EnterpriseName).HasMaxLength(65);
            });

            modelBuilder.Entity<EnterpriseEmployee>(entity =>
            {
                entity.ToTable("EnterpriseEmployee");

                entity.Property(e => e.EnterpriseEmployeeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ADPPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.APSPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AbraPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Accardis)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address).HasMaxLength(64);

                entity.Property(e => e.BackOfficeHash)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CBSPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ChefTec)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.City).HasMaxLength(16);

                entity.Property(e => e.CostGuard)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DeductIT)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EncryptedPassword)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.EndofDay)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EntFrontEnd)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EntICRpt)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EnterpriseBulkDownloader)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.FoodTrak)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GCReconciliation)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GreatPlainsGL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GreatPlainsPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HeartlandPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.Mas90GL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mas90Payroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLink)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkGL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkSalesInterval)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MiddleInitial)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NeedPasswordEncryption)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PayChexPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PeachtreeGL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.PurgeOldData)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuickBooksPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuickbooksGL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ResetDatabase)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SSN)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.SaaShrPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Salt)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.ServiceManager)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.UserInfo).HasMaxLength(40);

                entity.Property(e => e.WSExprt)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WSImprt)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WinSched)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Zip).HasMaxLength(16);
            });

            modelBuilder.Entity<EnterpriseSort>(entity =>
            {
                entity.ToTable("EnterpriseSort");

                entity.Property(e => e.EnterpriseSortID).ValueGeneratedNever();

                entity.Property(e => e.FileName).HasMaxLength(256);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EnterpriseSyncExclude>(entity =>
            {
                entity.ToTable("EnterpriseSyncExclude");

                entity.Property(e => e.EnterpriseSyncExcludeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Destination).HasDefaultValueSql("((-1))");

                entity.Property(e => e.TableID).HasDefaultValueSql("((-10))");
            });

            modelBuilder.Entity<FollowMe>(entity =>
            {
                entity.ToTable("FollowMe");

                entity.Property(e => e.FollowMeID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<Gift>(entity =>
            {
                entity.ToTable("Gift");

                entity.Property(e => e.GiftID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DestroyDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.FromName).HasMaxLength(50);

                entity.Property(e => e.GiftNumber).HasMaxLength(16);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Prefix).HasMaxLength(16);

                entity.Property(e => e.StoreNumber).HasMaxLength(8);

                entity.Property(e => e.Suffix).HasMaxLength(16);

                entity.Property(e => e.Swipe).HasMaxLength(48);

                entity.Property(e => e.ToName).HasMaxLength(50);
            });

            modelBuilder.Entity<GiftBackup>(entity =>
            {
                entity.HasKey(e => e.GiftBackupID);

                entity.ToTable("GiftBackup");

                entity.Property(e => e.GiftBackupID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Data)
                    .HasMaxLength(512)
                    .IsFixedLength();

                entity.Property(e => e.ID)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<GiftHistory>(entity =>
            {
                entity.ToTable("GiftHistory");

                entity.Property(e => e.GiftHistoryID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.HasOne(d => d.Gift)
                    .WithMany(p => p.GiftHistories)
                    .HasForeignKey(d => d.GiftID)
                    .HasConstraintName("FK_GiftHistory_Gift");
            });

            modelBuilder.Entity<GiftSeries>(entity =>
            {
                entity.Property(e => e.GiftSeriesID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DiscountFlags)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.Prefix).HasMaxLength(16);

                entity.Property(e => e.SeriesName).HasMaxLength(32);

                entity.Property(e => e.Suffix).HasMaxLength(16);
            });

            modelBuilder.Entity<GiftSeriesAvailability>(entity =>
            {
                entity.ToTable("GiftSeriesAvailability");

                entity.HasIndex(e => e.GiftSeriesID, "IX_GiftSeriesAvailability");

                entity.Property(e => e.GiftSeriesAvailabilityID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.GiftSeries)
                    .WithMany(p => p.GiftSeriesAvailabilities)
                    .HasForeignKey(d => d.GiftSeriesID)
                    .HasConstraintName("FK_GiftSeriesAvailability_GiftSeries");
            });

            modelBuilder.Entity<GiftSeriesObject>(entity =>
            {
                entity.ToTable("GiftSeriesObject");

                entity.HasIndex(e => e.GiftSeriesID, "IX_GiftSeriesObject");

                entity.Property(e => e.GiftSeriesObjectID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Data).HasMaxLength(80);

                entity.Property(e => e.FontName).HasMaxLength(30);

                entity.HasOne(d => d.GiftSeries)
                    .WithMany(p => p.GiftSeriesObjects)
                    .HasForeignKey(d => d.GiftSeriesID)
                    .HasConstraintName("FK_GiftSeriesObject_GiftSeries");
            });

            modelBuilder.Entity<GiftUsed>(entity =>
            {
                entity.ToTable("GiftUsed");

                entity.Property(e => e.GiftUsedID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Gift)
                    .WithMany(p => p.GiftUseds)
                    .HasForeignKey(d => d.GiftID)
                    .HasConstraintName("FK_GiftUsed_Gift");
            });

            modelBuilder.Entity<GlobalCashier>(entity =>
            {
                entity.ToTable("GlobalCashier");

                entity.Property(e => e.GlobalCashierID).ValueGeneratedNever();

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GrandTotal>(entity =>
            {
                entity.ToTable("GrandTotal");

                entity.Property(e => e.GrandTotalID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TerminalNumber).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<Graphic>(entity =>
            {
                entity.ToTable("Graphic");

                entity.Property(e => e.GraphicID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GraphicName).HasMaxLength(20);
            });

            modelBuilder.Entity<Help>(entity =>
            {
                entity.ToTable("Help");

                entity.Property(e => e.HelpID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.HelpName).HasMaxLength(20);

                entity.Property(e => e.HelpText).HasMaxLength(2021);
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("Ingredient");

                entity.Property(e => e.IngredientID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CaseName).HasMaxLength(12);

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.IngredientDescription).HasMaxLength(32);

                entity.Property(e => e.IngredientName).HasMaxLength(32);

                entity.Property(e => e.PackageName).HasMaxLength(12);

                entity.Property(e => e.Vendor).HasMaxLength(20);
            });

            modelBuilder.Entity<IngredientInventory>(entity =>
            {
                entity.ToTable("IngredientInventory");

                entity.HasIndex(e => e.IngredientID, "IX_IngredientInventory");

                entity.Property(e => e.IngredientInventoryID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Location).HasMaxLength(20);

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.IngredientInventories)
                    .HasForeignKey(d => d.IngredientID)
                    .HasConstraintName("FK_IngredientInventory_Ingredient");
            });

            modelBuilder.Entity<InternetCreditBatch>(entity =>
            {
                entity.HasKey(e => e.InternetBatchID);

                entity.ToTable("InternetCreditBatch");

                entity.HasIndex(e => e.DataVersion, "IX_InternetCreditBatch_DataVersion");

                entity.Property(e => e.InternetBatchID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.AdditionalInfo)
                    .HasMaxLength(512)
                    .IsFixedLength();

                entity.Property(e => e.ApprovalCode)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.MerchantID)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceData)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Track2)
                    .HasMaxLength(48)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();
            });

            modelBuilder.Entity<InternetCreditBatchArchive>(entity =>
            {
                entity.HasKey(e => e.CreditBatchArchiveID)
                    .HasName("PK_CreditBatchArchive");

                entity.ToTable("InternetCreditBatchArchive");

                entity.Property(e => e.CreditBatchArchiveID).ValueGeneratedNever();

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.MerchantID)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<InternetCreditBatchInfo>(entity =>
            {
                entity.ToTable("InternetCreditBatchInfo");

                entity.Property(e => e.InternetCreditBatchInfoID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<InvoiceConfig>(entity =>
            {
                entity.ToTable("InvoiceConfig");

                entity.Property(e => e.InvoiceConfigID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<InvoiceConfigObject>(entity =>
            {
                entity.ToTable("InvoiceConfigObject");

                entity.HasIndex(e => e.InvoiceConfigID, "IX_InvoiceConfigObject");

                entity.Property(e => e.InvoiceConfigObjectID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Data).HasMaxLength(80);

                entity.Property(e => e.Font).HasMaxLength(30);

                entity.HasOne(d => d.InvoiceConfig)
                    .WithMany(p => p.InvoiceConfigObjects)
                    .HasForeignKey(d => d.InvoiceConfigID)
                    .HasConstraintName("FK_InvoiceConfigObject_InvoiceConfig");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Item");

                entity.HasIndex(e => new { e.ItemName, e.RegionID }, "IX_Item")
                    .IsUnique();

                entity.Property(e => e.ItemID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AlternateItem).HasMaxLength(32);

                entity.Property(e => e.AutoMenuEndDate).HasColumnType("datetime");

                entity.Property(e => e.AutoMenuStartDate).HasColumnType("datetime");

                entity.Property(e => e.BannerFooterImageName).HasMaxLength(20);

                entity.Property(e => e.BannerImageName).HasMaxLength(20);

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.DiscountFlags)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.DisplayDescription).HasMaxLength(140);

                entity.Property(e => e.ImageName).HasMaxLength(20);

                entity.Property(e => e.ItemCount).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ItemDescription).HasMaxLength(30);

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ModBannerFooterSelectDesc).HasMaxLength(100);

                entity.Property(e => e.ModifierDescription).HasMaxLength(30);

                entity.Property(e => e.OverrideAutoMenuButtonSettingsGraphic).HasMaxLength(50);

                entity.Property(e => e.ReceiptDesc).HasMaxLength(20);

                entity.Property(e => e.ShipHeight).HasMaxLength(5);

                entity.Property(e => e.ShipLength)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipWidth).HasMaxLength(5);

                entity.Property(e => e.ShortDescription).HasMaxLength(5);

                entity.Property(e => e.UPC).HasMaxLength(32);

                entity.Property(e => e.WebImagePath).HasMaxLength(254);

                entity.Property(e => e.WebThumbPath).HasMaxLength(254);

                entity.Property(e => e.WebTitle).HasMaxLength(30);
            });

            modelBuilder.Entity<ItemDay>(entity =>
            {
                entity.ToTable("ItemDay");

                entity.HasIndex(e => e.ItemID, "IX_ItemDay");

                entity.Property(e => e.ItemDayID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemIngredient>(entity =>
            {
                entity.ToTable("ItemIngredient");

                entity.HasIndex(e => e.ItemID, "IX_ItemIngredient");

                entity.Property(e => e.ItemIngredientID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.IngredientName).HasMaxLength(33);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemIngredients)
                    .HasForeignKey(d => d.ItemID)
                    .HasConstraintName("FK_ItemIngredient_Item");
            });

            modelBuilder.Entity<ItemMobileExclusion>(entity =>
            {
                entity.ToTable("ItemMobileExclusion");

                entity.HasIndex(e => e.EmpID, "IX_ItemMobileExclusion_EmpID");

                entity.HasIndex(e => e.ItemID, "IX_ItemMobileExclusion_ItemID");

                entity.Property(e => e.ItemMobileExclusionID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemMobileExclusions)
                    .HasForeignKey(d => d.ItemID)
                    .HasConstraintName("FK_ItemMobileExclusion_Item");
            });

            modelBuilder.Entity<ItemModifier>(entity =>
            {
                entity.ToTable("ItemModifier");

                entity.HasIndex(e => e.ItemID, "IX_ItemModifier");

                entity.Property(e => e.ItemModifierID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ModifierName).HasMaxLength(33);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemModifiers)
                    .HasForeignKey(d => d.ItemID)
                    .HasConstraintName("FK_ItemModifier_Item");
            });

            modelBuilder.Entity<ItemPrice>(entity =>
            {
                entity.ToTable("ItemPrice");

                entity.HasIndex(e => e.ItemID, "IX_ItemPrice");

                entity.Property(e => e.ItemPriceID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemPrices)
                    .HasForeignKey(d => d.ItemID)
                    .HasConstraintName("FK_ItemPriceSchedule_Item");
            });

            modelBuilder.Entity<ItemPrinter>(entity =>
            {
                entity.ToTable("ItemPrinter");

                entity.HasIndex(e => e.ItemID, "IX_ItemPrinter");

                entity.Property(e => e.ItemPrinterID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemPrinters)
                    .HasForeignKey(d => d.ItemID)
                    .HasConstraintName("FK_ItemPrinter_Item");
            });

            modelBuilder.Entity<ItemRank>(entity =>
            {
                entity.ToTable("ItemRank");

                entity.Property(e => e.ItemRankID).ValueGeneratedNever();
            });

            modelBuilder.Entity<ItemSize>(entity =>
            {
                entity.ToTable("ItemSize");

                entity.Property(e => e.ItemSizeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ItemDescriptionPrefix)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceiptDescriptionPrefix)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ItemSold>(entity =>
            {
                entity.ToTable("ItemSold");

                entity.Property(e => e.ItemSoldID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Department).HasMaxLength(11);

                entity.Property(e => e.ItemDescription).HasMaxLength(31);

                entity.Property(e => e.ItemName).HasMaxLength(33);

                entity.Property(e => e.SoldDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemTranslation>(entity =>
            {
                entity.ToTable("ItemTranslation");

                entity.Property(e => e.ItemTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemTranslations)
                    .HasForeignKey(d => d.ItemID)
                    .HasConstraintName("FK_ItemTranslation_Item");
            });

            modelBuilder.Entity<JobCode>(entity =>
            {
                entity.ToTable("JobCode");

                entity.Property(e => e.JobCodeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LaborGroup).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<JobCodeDeptMask>(entity =>
            {
                entity.ToTable("JobCodeDeptMask");

                entity.Property(e => e.JobCodeDeptMaskID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Mask)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.JobCode)
                    .WithMany(p => p.JobCodeDeptMasks)
                    .HasForeignKey(d => d.JobCodeID)
                    .HasConstraintName("FK_JobCodeDeptMask_JobCode");
            });

            modelBuilder.Entity<LaborRule>(entity =>
            {
                entity.ToTable("LaborRule");

                entity.Property(e => e.LaborRuleID).ValueGeneratedNever();

                entity.Property(e => e.Modifier).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.RateCutoff).HasColumnType("decimal(11, 4)");

                entity.HasOne(d => d.LaborRuleSet)
                    .WithMany(p => p.LaborRules)
                    .HasForeignKey(d => d.LaborRuleSetID)
                    .HasConstraintName("FK_LaborRule_LaborRuleSet");
            });

            modelBuilder.Entity<LaborRuleSet>(entity =>
            {
                entity.ToTable("LaborRuleSet");

                entity.Property(e => e.LaborRuleSetID).ValueGeneratedNever();

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Layout>(entity =>
            {
                entity.ToTable("Layout");

                entity.Property(e => e.LayoutID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LayoutGraphic>(entity =>
            {
                entity.ToTable("LayoutGraphic");

                entity.HasIndex(e => e.LayoutID, "IX_LayoutGraphic");

                entity.Property(e => e.LayoutGraphicID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutGraphics)
                    .HasForeignKey(d => d.LayoutID)
                    .HasConstraintName("FK_LayoutGraphic_Layout");
            });

            modelBuilder.Entity<LayoutRoom>(entity =>
            {
                entity.ToTable("LayoutRoom");

                entity.HasIndex(e => e.LayoutID, "IX_LayoutRoom");

                entity.Property(e => e.LayoutRoomID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ImageFile).HasMaxLength(128);

                entity.Property(e => e.RoomName).HasMaxLength(20);

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutRooms)
                    .HasForeignKey(d => d.LayoutID)
                    .HasConstraintName("FK_LayoutRoom_Layout");
            });

            modelBuilder.Entity<LayoutSection>(entity =>
            {
                entity.ToTable("LayoutSection");

                entity.HasIndex(e => e.LayoutID, "IX_LayoutSection");

                entity.Property(e => e.LayoutSectionID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CommonMenuName)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustomerRequiredFields).HasMaxLength(512);

                entity.Property(e => e.HandheldCommonMenuName)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HandheldHomeMenuName).HasMaxLength(20);

                entity.Property(e => e.HomeMenuName).HasMaxLength(20);

                entity.Property(e => e.SectionName).HasMaxLength(20);

                entity.Property(e => e.SkipModsMask).HasMaxLength(32);

                entity.Property(e => e.SkipOrderPrinter).HasMaxLength(512);

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutSections)
                    .HasForeignKey(d => d.LayoutID)
                    .HasConstraintName("FK_LayoutSection_Layout");
            });

            modelBuilder.Entity<LayoutTable>(entity =>
            {
                entity.ToTable("LayoutTable");

                entity.HasIndex(e => e.LayoutID, "IX_LayoutTable");

                entity.Property(e => e.LayoutTableID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TableName).HasMaxLength(50);

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutTables)
                    .HasForeignKey(d => d.LayoutID)
                    .HasConstraintName("FK_LayoutTable_Layout");
            });

            modelBuilder.Entity<LayoutText>(entity =>
            {
                entity.ToTable("LayoutText");

                entity.HasIndex(e => e.LayoutID, "IX_LayoutText");

                entity.Property(e => e.LayoutTextID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FontFaceName).HasMaxLength(32);

                entity.Property(e => e.Text).HasMaxLength(65);

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutTexts)
                    .HasForeignKey(d => d.LayoutID)
                    .HasConstraintName("FK_LayoutText_Layout");
            });

            modelBuilder.Entity<LocalSuspend>(entity =>
            {
                entity.HasKey(e => e.TerminalNumber);

                entity.ToTable("LocalSuspend");

                entity.Property(e => e.TerminalNumber).ValueGeneratedNever();
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.HasIndex(e => e.LogDate, "IX_Log");

                entity.Property(e => e.LogID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Application).HasMaxLength(64);

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message).HasMaxLength(4000);
            });

            modelBuilder.Entity<LogConfig>(entity =>
            {
                entity.ToTable("LogConfig");

                entity.Property(e => e.LogConfigID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Application)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogLevel).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MediaTranslation>(entity =>
            {
                entity.ToTable("MediaTranslation");

                entity.Property(e => e.MediaTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.MediaTranslations)
                    .HasForeignKey(d => d.MediaID)
                    .HasConstraintName("FK_MediaTranslation_Media");
            });

            modelBuilder.Entity<Medium>(entity =>
            {
                entity.HasKey(e => e.MediaID);

                entity.HasIndex(e => e.RegionID, "IX_Media");

                entity.Property(e => e.MediaID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AllowedTerminals).HasMaxLength(13);

                entity.Property(e => e.FontFaceName).HasMaxLength(32);

                entity.Property(e => e.MediaName).HasMaxLength(20);

                entity.Property(e => e.PMSAccount).HasMaxLength(20);
            });

            modelBuilder.Entity<MenuHomePageLink>(entity =>
            {
                entity.HasKey(e => e.HomePageLinkID)
                    .HasName("PK_HomePageLink");

                entity.ToTable("MenuHomePageLink");

                entity.Property(e => e.HomePageLinkID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.HasOne(d => d.MenuPage)
                    .WithMany(p => p.MenuHomePageLinks)
                    .HasForeignKey(d => d.MenuPageID)
                    .HasConstraintName("FK_MenuHomePageLink_MenuPage");
            });

            modelBuilder.Entity<MenuPage>(entity =>
            {
                entity.ToTable("MenuPage");

                entity.Property(e => e.MenuPageID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AssignedUser).HasDefaultValueSql("('')");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.PageName).HasMaxLength(250);

                entity.Property(e => e.SavedXML).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MenuPageGroup>(entity =>
            {
                entity.ToTable("MenuPageGroup");

                entity.Property(e => e.MenuPageGroupID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.GroupName).HasMaxLength(450);

                entity.HasOne(d => d.MenuPage)
                    .WithMany(p => p.MenuPageGroups)
                    .HasForeignKey(d => d.MenuPageID)
                    .HasConstraintName("FK_MenuPageGroup_MenuPage");
            });

            modelBuilder.Entity<MenuPageItem>(entity =>
            {
                entity.ToTable("MenuPageItem");

                entity.Property(e => e.MenuPageItemID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ClassColumnName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.Executable).HasMaxLength(2000);

                entity.Property(e => e.ItemName).HasMaxLength(450);
            });

            modelBuilder.Entity<MenuPageLink>(entity =>
            {
                entity.ToTable("MenuPageLink");

                entity.Property(e => e.MenuPageLinkID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.NameReplace).HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(1000);
            });

            modelBuilder.Entity<MenuUsage>(entity =>
            {
                entity.ToTable("MenuUsage");

                entity.Property(e => e.MenuUsageID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.PageTitle).HasMaxLength(50);

                entity.Property(e => e.RelativePath).HasMaxLength(100);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MenuUsages)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_MenuUsage_Employee");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.MessageID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.MessageDate).HasColumnType("datetime");

                entity.Property(e => e.MessageName).HasMaxLength(20);

                entity.Property(e => e.MessageStartDate).HasColumnType("datetime");

                entity.Property(e => e.MessageText).HasMaxLength(468);
            });

            modelBuilder.Entity<MessageEmployee>(entity =>
            {
                entity.ToTable("MessageEmployee");

                entity.HasIndex(e => e.MessageID, "IX_MessageEmployee");

                entity.Property(e => e.MessageEmployeeID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageEmployees)
                    .HasForeignKey(d => d.MessageID)
                    .HasConstraintName("FK_MessageEmployee_Message");
            });

            modelBuilder.Entity<MobileFunctionPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionID);

                entity.ToTable("MobileFunctionPermission");

                entity.Property(e => e.PermissionID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FunctionName).HasMaxLength(50);
            });

            modelBuilder.Entity<MobileMessage>(entity =>
            {
                entity.ToTable("MobileMessage");

                entity.Property(e => e.MobileMessageID).ValueGeneratedNever();

                entity.Property(e => e.MessageText).HasMaxLength(200);
            });

            modelBuilder.Entity<MobileTerminal>(entity =>
            {
                entity.HasKey(e => e.MobileTerminalID)
                    .IsClustered(false);

                entity.ToTable("MobileTerminal");

                entity.Property(e => e.MobileTerminalID).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.LastKnownIP)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MobileTerminalSessionInfo>(entity =>
            {
                entity.ToTable("MobileTerminalSessionInfo");

                entity.HasIndex(e => e.SessionID, "IX_MobileTerminalSessionInfo_SessionID")
                    .IsUnique();

                entity.Property(e => e.MobileTerminalSessionInfoID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BinaryData).HasMaxLength(2048);

                entity.Property(e => e.BinaryData2).HasMaxLength(2048);

                entity.Property(e => e.InsertDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.SessionID)
                    .HasMaxLength(21)
                    .IsFixedLength();

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.HasOne(d => d.MobileTerminal)
                    .WithMany(p => p.MobileTerminalSessionInfos)
                    .HasForeignKey(d => d.MobileTerminalID)
                    .HasConstraintName("FK_MobileTerminalSessionInfo_MobileTerminalID");
            });

            modelBuilder.Entity<MobileTerminalTransaction>(entity =>
            {
                entity.ToTable("MobileTerminalTransaction");

                entity.Property(e => e.MobileTerminalTransactionID).ValueGeneratedNever();

                entity.Property(e => e.Response).HasMaxLength(2048);

                entity.Property(e => e.SessionID)
                    .HasMaxLength(21)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MobileTerminalTransfer>(entity =>
            {
                entity.ToTable("MobileTerminalTransfer");

                entity.Property(e => e.MobileTerminalTransferID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Data).HasColumnType("ntext");
            });

            modelBuilder.Entity<OfflineLoyaltyQueue>(entity =>
            {
                entity.ToTable("OfflineLoyaltyQueue");

                entity.Property(e => e.OfflineLoyaltyQueueID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.ToTable("OrderType");

                entity.Property(e => e.OrderTypeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description)
                    .HasMaxLength(19)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderFooter)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderHeader)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<OrderType1>(entity =>
            {
                entity.HasKey(e => e.OrderTypeIndex);

                entity.ToTable("OrderTypes");

                entity.Property(e => e.OrderTypeIndex).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ShippingServiceType)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.WebDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<PAlert>(entity =>
            {
                entity.HasKey(e => e.AlertID);

                entity.ToTable("PAlert");

                entity.Property(e => e.AlertID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AlertName).HasMaxLength(100);

                entity.Property(e => e.AlertType).HasMaxLength(50);

                entity.Property(e => e.LastRun).HasColumnType("datetime");
            });

            modelBuilder.Entity<PAlertQueue>(entity =>
            {
                entity.HasKey(e => e.AlertQueueID);

                entity.ToTable("PAlertQueue");

                entity.Property(e => e.AlertQueueID).ValueGeneratedNever();

                entity.Property(e => e.AltBodyMimeType).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(254);

                entity.Property(e => e.QueueDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(200);
            });

            modelBuilder.Entity<PAlertSetting>(entity =>
            {
                entity.HasKey(e => e.AlertSettingID);

                entity.ToTable("PAlertSetting");

                entity.Property(e => e.AlertSettingID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Setting).HasMaxLength(50);

                entity.HasOne(d => d.Alert)
                    .WithMany(p => p.PAlertSettings)
                    .HasForeignKey(d => d.AlertID)
                    .HasConstraintName("FK_PAlertSetting_PAlert");
            });

            modelBuilder.Entity<PAlertTo>(entity =>
            {
                entity.HasKey(e => e.AlertEmpID)
                    .HasName("PK_PAlertEmp");

                entity.ToTable("PAlertTo");

                entity.Property(e => e.AlertEmpID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Alert)
                    .WithMany(p => p.PAlertTos)
                    .HasForeignKey(d => d.AlertID)
                    .HasConstraintName("FK_PAlertTo_PAlert");
            });

            modelBuilder.Entity<POSDay>(entity =>
            {
                entity.ToTable("POSDay");

                entity.Property(e => e.POSDayID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<POSShift>(entity =>
            {
                entity.ToTable("POSShift");

                entity.Property(e => e.POSShiftID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pager>(entity =>
            {
                entity.ToTable("Pager");

                entity.Property(e => e.PagerID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.PagerDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<PagerEmployee>(entity =>
            {
                entity.ToTable("PagerEmployee");

                entity.Property(e => e.PagerEmployeeID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Pager)
                    .WithMany(p => p.PagerEmployees)
                    .HasForeignKey(d => d.PagerID)
                    .HasConstraintName("FK_PagerEmployee_Pager");
            });

            modelBuilder.Entity<PagerMessageQueue>(entity =>
            {
                entity.ToTable("PagerMessageQueue");

                entity.Property(e => e.PagerMessageQueueID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message).HasMaxLength(512);

                entity.HasOne(d => d.Pager)
                    .WithMany(p => p.PagerMessageQueues)
                    .HasForeignKey(d => d.PagerID)
                    .HasConstraintName("FK_PagerMessageQueue_Pager");
            });

            modelBuilder.Entity<Paydiant>(entity =>
            {
                entity.ToTable("Paydiant");

                entity.Property(e => e.PaydiantID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GatewayURL)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MerchantID).HasMaxLength(100);

                entity.Property(e => e.MerchantKey)
                    .HasMaxLength(264)
                    .IsFixedLength();

                entity.Property(e => e.StoreLocationID)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TerminalID)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WebServiceURL)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PendingSale>(entity =>
            {
                entity.ToTable("PendingSale");

                entity.Property(e => e.PendingSaleID).ValueGeneratedNever();

                entity.Property(e => e.AuthCV2StrEncrypted)
                    .HasMaxLength(384)
                    .IsFixedLength();

                entity.Property(e => e.AuthCardName)
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.AuthCardNumber)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.AuthCardNumberEncrypted)
                    .HasMaxLength(384)
                    .IsFixedLength();

                entity.Property(e => e.AuthCardType)
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.AuthEncryptedBlock)
                    .HasMaxLength(233)
                    .IsFixedLength();

                entity.Property(e => e.AuthEncryptionKey)
                    .HasMaxLength(41)
                    .IsFixedLength();

                entity.Property(e => e.AuthExpirationDateEncrypted)
                    .HasMaxLength(384)
                    .IsFixedLength();

                entity.Property(e => e.AuthMSRSwipe)
                    .HasMaxLength(512)
                    .IsFixedLength();

                entity.Property(e => e.AuthReferenceData)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.AuthReferenceNumber)
                    .HasMaxLength(17)
                    .IsFixedLength();

                entity.Property(e => e.AuthResponse)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.AuthTrack2Encrypted)
                    .HasMaxLength(384)
                    .IsFixedLength();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.PublicKey)
                    .HasMaxLength(2048)
                    .IsFixedLength();

                entity.Property(e => e.Salt)
                    .HasMaxLength(384)
                    .IsFixedLength();

                entity.Property(e => e.SessionID)
                    .HasMaxLength(21)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PreAuth>(entity =>
            {
                entity.ToTable("PreAuth");

                entity.HasIndex(e => e.DataVersion, "IX_PreAuth_DataVersion");

                entity.Property(e => e.PreAuthID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcqRefData)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.AuthResponse)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.CardName)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EMVAID)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVARC)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVApplicationData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVCVM)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVEntryMethod)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVIAD)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVTSI)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVTVR)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EncryptedBlock)
                    .HasMaxLength(232)
                    .IsFixedLength();

                entity.Property(e => e.EncryptedRawSwipe)
                    .HasMaxLength(1024)
                    .IsFixedLength();

                entity.Property(e => e.EncryptionKey)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.PreAuthDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Track2)
                    .HasMaxLength(48)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.VaultID)
                    .HasMaxLength(128)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrepTime>(entity =>
            {
                entity.ToTable("PrepTime");

                entity.Property(e => e.PrepTimeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PriceLevel>(entity =>
            {
                entity.ToTable("PriceLevel");

                entity.Property(e => e.PriceLevelID).ValueGeneratedNever();

                entity.Property(e => e.PriceLevelName).HasMaxLength(50);
            });

            modelBuilder.Entity<PriceSchedule>(entity =>
            {
                entity.ToTable("PriceSchedule");

                entity.Property(e => e.PriceScheduleID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.PriceScheduleName).HasMaxLength(30);
            });

            modelBuilder.Entity<PrintJob>(entity =>
            {
                entity.ToTable("PrintJob");

                entity.HasIndex(e => new { e.ToTerminalNumber, e.OnHold, e.StoreID }, "IX_PrintJob");

                entity.Property(e => e.PrintJobID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CheckDescription).HasMaxLength(15);

                entity.Property(e => e.CheckStartDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName).HasMaxLength(64);

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.RerouteDescription).HasMaxLength(33);

                entity.Property(e => e.TableDescription).HasMaxLength(32);
            });

            modelBuilder.Entity<PrintJobLine>(entity =>
            {
                entity.HasKey(e => e.PrintLineID)
                    .HasName("PK_PrintQueueLine");

                entity.ToTable("PrintJobLine");

                entity.HasIndex(e => e.PrintJobID, "IX_PrintJobLine");

                entity.Property(e => e.PrintLineID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemName).HasMaxLength(33);

                entity.Property(e => e.LeftText).HasMaxLength(128);

                entity.Property(e => e.RightText).HasMaxLength(128);

                entity.Property(e => e.SeparatedText)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Text).HasMaxLength(128);

                entity.HasOne(d => d.PrintJob)
                    .WithMany(p => p.PrintJobLines)
                    .HasForeignKey(d => d.PrintJobID)
                    .HasConstraintName("FK_PrintJobLine_PrintJob");
            });

            modelBuilder.Entity<PunchPair>(entity =>
            {
                entity.ToTable("PunchPair");

                entity.HasIndex(e => e.EmpID, "IX_PunchPair_EmpID");

                entity.HasIndex(e => e.NonRoundedTimeIn, "IX_PunchPair_NonRoundedTimeIn");

                entity.HasIndex(e => e.NonRoundedTimeOut, "IX_PunchPair_NonRoundedTimeOut");

                entity.HasIndex(e => e.PayPeriodEnd, "IX_PunchPair_PayPeriodEnd");

                entity.HasIndex(e => e.PayPeriodStart, "IX_PunchPair_PayPeriodStart");

                entity.HasIndex(e => e.PayWeekEnd, "IX_PunchPair_PayWeekEnd");

                entity.HasIndex(e => e.PayWeekStart, "IX_PunchPair_PayWeekStart");

                entity.HasIndex(e => e.TimeIn, "IX_PunchPair_TimeIn");

                entity.HasIndex(e => e.TimeOut, "IX_PunchPair_TimeOut");

                entity.Property(e => e.PunchPairID).ValueGeneratedNever();

                entity.Property(e => e.Hours).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.JobCodeDescription).HasMaxLength(20);

                entity.Property(e => e.JobCodeSpanID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.MealHours).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.NonRoundedTimeIn).HasColumnType("datetime");

                entity.Property(e => e.NonRoundedTimeOut).HasColumnType("datetime");

                entity.Property(e => e.OTHours).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.OTRate).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.PayPeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.PayPeriodStart).HasColumnType("datetime");

                entity.Property(e => e.PayWeekEnd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01')");

                entity.Property(e => e.PayWeekStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01')");

                entity.Property(e => e.Rate).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.RegRate).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.RoundedTimeIn).HasColumnType("datetime");

                entity.Property(e => e.RoundedTimeOut).HasColumnType("datetime");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.ShiftID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.Wages).HasColumnType("decimal(11, 4)");
            });

            modelBuilder.Entity<Reason>(entity =>
            {
                entity.ToTable("Reason");

                entity.Property(e => e.ReasonID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ReasonName).HasMaxLength(32);
            });

            modelBuilder.Entity<ReceiptFormat>(entity =>
            {
                entity.ToTable("ReceiptFormat");

                entity.Property(e => e.ReceiptFormatID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<ReceiptFormatItem>(entity =>
            {
                entity.ToTable("ReceiptFormatItem");

                entity.Property(e => e.ReceiptFormatItemID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ReceiptName).HasMaxLength(50);

                entity.HasOne(d => d.ReceiptFormat)
                    .WithMany(p => p.ReceiptFormatItems)
                    .HasForeignKey(d => d.ReceiptFormatID)
                    .HasConstraintName("FK_ReceiptFormatItem_ReceiptFormat");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.ToTable("Recipe");

                entity.Property(e => e.RecipeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.Recipe1)
                    .HasMaxLength(1000)
                    .HasColumnName("Recipe");

                entity.Property(e => e.RecipeName).HasMaxLength(32);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region");

                entity.Property(e => e.RegionID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Area).HasMaxLength(30);

                entity.Property(e => e.RegionDescription).HasMaxLength(32);

                entity.Property(e => e.RegionName).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportWare>(entity =>
            {
                entity.ToTable("ReportWare");

                entity.Property(e => e.ReportWareID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Item)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation");

                entity.HasIndex(e => new { e.StoreID, e.ReservationDate }, "IX_Reservation_Store_Date");

                entity.Property(e => e.ReservationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CustomerName).HasMaxLength(64);

                entity.Property(e => e.LongNote).HasMaxLength(512);

                entity.Property(e => e.Note).HasMaxLength(20);

                entity.Property(e => e.ReservationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ResourceLanguage>(entity =>
            {
                entity.ToTable("ResourceLanguage");

                entity.Property(e => e.ResourceLanguageID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);
            });

            modelBuilder.Entity<RevenueCenter>(entity =>
            {
                entity.ToTable("RevenueCenter");

                entity.Property(e => e.RevenueCenterID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CCAMIP)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.CreditModuleID)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.CreditModuleKey)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasDefaultValueSql("('')");

                entity.Property(e => e.MerchantID)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.TerminalID)
                    .HasMaxLength(24)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RewardPlan>(entity =>
            {
                entity.ToTable("RewardPlan");

                entity.Property(e => e.RewardPlanID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.RewardPlanName).HasMaxLength(20);
            });

            modelBuilder.Entity<RewardPlanLevel>(entity =>
            {
                entity.ToTable("RewardPlanLevel");

                entity.HasIndex(e => e.RewardPlanID, "IX_RewardPlanLevel");

                entity.Property(e => e.RewardPlanLevelID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemMask).HasMaxLength(32);

                entity.Property(e => e.SkipDepartmentMask).HasMaxLength(50);

                entity.HasOne(d => d.RewardPlan)
                    .WithMany(p => p.RewardPlanLevels)
                    .HasForeignKey(d => d.RewardPlanID)
                    .HasConstraintName("FK_RewardPlanLevel_RewardPlan");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("Sale");

                entity.HasIndex(e => new { e.StoreID, e.IsSuspend }, "IX_Sale");

                entity.HasIndex(e => e.CheckNumber, "IX_Sale_CheckNumber");

                entity.HasIndex(e => e.CurrentEmpID, "IX_Sale_CurrentEmpID");

                entity.HasIndex(e => e.DataVersion, "IX_Sale_DataVersion");

                entity.HasIndex(e => e.EndDate, "IX_Sale_FinishDate");

                entity.HasIndex(e => e.IsSuspend, "IX_Sale_IsSuspend");

                entity.HasIndex(e => e.ReOpenCheckNumber, "IX_Sale_ReOpenCheckNumber");

                entity.HasIndex(e => e.StartDate, "IX_Sale_StartDate");

                entity.HasIndex(e => new { e.StoreID, e.IsSuspend, e.CurrentEmpID }, "IX_Sale_SuspendList");

                entity.HasIndex(e => e.SuspendNumber, "IX_Sale_SuspendNumber");

                entity.HasIndex(e => new { e.IsSuspend, e.TerminalNumber }, "IX_Sale_TerminalSuspends");

                entity.Property(e => e.SaleID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AssignDriverDate).HasColumnType("datetime");

                entity.Property(e => e.BucketProcessDate).HasColumnType("datetime");

                entity.Property(e => e.CheckDescription).HasMaxLength(50);

                entity.Property(e => e.CustomerAddress).HasMaxLength(65);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.DriverName).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FanConnectCustomerAccount).HasMaxLength(40);

                entity.Property(e => e.FanConnectTransactionID).HasMaxLength(40);

                entity.Property(e => e.IsWebOrderComplete).HasComment("");

                entity.Property(e => e.LevelUpUUID)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MozartOrderNumber).HasMaxLength(50);

                entity.Property(e => e.PaydiantCheckoutToken)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaydiantTransactionRefID)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PreAuthResponse)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.PreCardName)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.PreCardNum)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.PreEMVAID)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVARC)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVApplicationLabel)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVCVM)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVEntryMethod)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVIAD)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVTSI)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVTVR)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEncryptedBlock)
                    .HasMaxLength(232)
                    .IsFixedLength();

                entity.Property(e => e.PreEncryptedRawSwipe)
                    .HasMaxLength(1024)
                    .IsFixedLength();

                entity.Property(e => e.PreEncryptionKey)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.PreExpirationDate)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.PreProcessData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreReferenceData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreReferenceNumber)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.PreTrack2)
                    .HasMaxLength(48)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.PreVaultID)
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.PreZip)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.PromisedDate).HasColumnType("datetime");

                entity.Property(e => e.ReportPreAuthResponse).HasMaxLength(40);

                entity.Property(e => e.ReportPreCardName).HasMaxLength(40);

                entity.Property(e => e.ReportPreCardNumber).HasMaxLength(40);

                entity.Property(e => e.ReportPreCardType).HasMaxLength(40);

                entity.Property(e => e.ReportPreTranID).HasMaxLength(40);

                entity.Property(e => e.ReportPreZipCode).HasMaxLength(40);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TabOutCode).HasMaxLength(10);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.WebAddress1).HasMaxLength(65);

                entity.Property(e => e.WebAddress2).HasMaxLength(65);

                entity.Property(e => e.WebCity).HasMaxLength(50);

                entity.Property(e => e.WebComment).HasMaxLength(600);

                entity.Property(e => e.WebEmail).HasMaxLength(255);

                entity.Property(e => e.WebFirstName).HasMaxLength(50);

                entity.Property(e => e.WebLastName).HasMaxLength(50);

                entity.Property(e => e.WebPhone).HasMaxLength(50);

                entity.Property(e => e.WebState).HasMaxLength(2);

                entity.Property(e => e.WebZip).HasMaxLength(50);
            });

            modelBuilder.Entity<SaleCoupon>(entity =>
            {
                entity.ToTable("SaleCoupon");

                entity.HasIndex(e => e.SaleID, "IX_SaleCoupon");

                entity.Property(e => e.SaleCouponID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleCoupons)
                    .HasForeignKey(d => d.SaleID)
                    .HasConstraintName("FK_SaleCoupon_Sale");
            });

            modelBuilder.Entity<SaleCreditCard>(entity =>
            {
                entity.ToTable("SaleCreditCard");

                entity.HasIndex(e => e.SaleID, "IX_SaleCreditCard");

                entity.HasIndex(e => e.DataVersion, "IX_SaleCreditCard_DataVersion");

                entity.Property(e => e.SaleCreditCardID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AuthResponse)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BankGCICExchRate).HasMaxLength(12);

                entity.Property(e => e.BankGCIssueCurr).HasMaxLength(8);

                entity.Property(e => e.CardName)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.CardNum)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EMVAID)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVARC)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVApplicationLabel)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVCVM)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVEntryMethod)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVIAD)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVTSI)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EMVTVR)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.EncryptedBlock)
                    .HasMaxLength(232)
                    .IsFixedLength();

                entity.Property(e => e.EncryptedRawSwipe)
                    .HasMaxLength(1024)
                    .IsFixedLength();

                entity.Property(e => e.EncryptionKey)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.OfflineID).HasMaxLength(128);

                entity.Property(e => e.ProcessData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.ReportAuthResponse).HasMaxLength(40);

                entity.Property(e => e.ReportCardName).HasMaxLength(40);

                entity.Property(e => e.ReportCardNumber).HasMaxLength(40);

                entity.Property(e => e.ReportCardType).HasMaxLength(40);

                entity.Property(e => e.ReportTranID).HasMaxLength(40);

                entity.Property(e => e.ReportZipCode).HasMaxLength(40);

                entity.Property(e => e.VaultID)
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleCreditCards)
                    .HasForeignKey(d => d.SaleID)
                    .HasConstraintName("FK_SaleCreditCard_Sale");
            });

            modelBuilder.Entity<SaleDiscount>(entity =>
            {
                entity.ToTable("SaleDiscount");

                entity.HasIndex(e => e.SaleID, "IX_SaleDiscount");

                entity.Property(e => e.SaleDiscountID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ReasonDescription).HasMaxLength(32);

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleDiscounts)
                    .HasForeignKey(d => d.SaleID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaleDiscount_Sale");
            });

            modelBuilder.Entity<SaleGiftSold>(entity =>
            {
                entity.ToTable("SaleGiftSold");

                entity.HasIndex(e => e.SaleID, "IX_SaleGiftSold");

                entity.Property(e => e.SaleGiftSoldID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GiftNumber)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleGiftSolds)
                    .HasForeignKey(d => d.SaleID)
                    .HasConstraintName("FK_SaleGiftSold_Sale");
            });

            modelBuilder.Entity<SaleGiftUsed>(entity =>
            {
                entity.ToTable("SaleGiftUsed");

                entity.HasIndex(e => e.SaleID, "IX_SaleGiftUsed");

                entity.Property(e => e.SaleGiftUsedID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GiftNumber).HasMaxLength(16);

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleGiftUseds)
                    .HasForeignKey(d => d.SaleID)
                    .HasConstraintName("FK_SaleGiftUsed_Sale");
            });

            modelBuilder.Entity<SaleItem>(entity =>
            {
                entity.ToTable("SaleItem");

                entity.HasIndex(e => e.SaleID, "IX_SaleItem");

                entity.HasIndex(e => new { e.SplitQuantity, e.SplitParentID }, "IX_SplitParentID");

                entity.Property(e => e.SaleItemID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.BankAuthCode).HasMaxLength(24);

                entity.Property(e => e.BankAuthorizationCode).HasMaxLength(24);

                entity.Property(e => e.BankRefNumber).HasMaxLength(128);

                entity.Property(e => e.CouponApplied)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.DiscountApplied)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.DiscountFlags)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.FanConnectCustomerAccount).HasMaxLength(40);

                entity.Property(e => e.GiftCardNum).HasMaxLength(16);

                entity.Property(e => e.HasRemoteDescription)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ModifierGroupItem).HasMaxLength(32);

                entity.Property(e => e.PriceLevelName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PriceScheduleName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);

                entity.Property(e => e.ShortDescription).HasMaxLength(6);

                entity.Property(e => e.SoldDate).HasColumnType("datetime");

                entity.Property(e => e.SplitLevel)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.TimedEndDate).HasColumnType("datetime");

                entity.Property(e => e.TimedStartDate).HasColumnType("datetime");

                entity.Property(e => e.Translation).HasMaxLength(50);

                entity.Property(e => e.UPC)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VoidDate).HasColumnType("datetime");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleItems)
                    .HasForeignKey(d => d.SaleID)
                    .HasConstraintName("FK_SaleItem_Sale1");
            });

            modelBuilder.Entity<SaleItemCoupon>(entity =>
            {
                entity.ToTable("SaleItemCoupon");

                entity.HasIndex(e => e.SaleItemID, "IX_SaleItemCoupon");

                entity.Property(e => e.SaleItemCouponID).ValueGeneratedNever();

                entity.HasOne(d => d.SaleItem)
                    .WithMany(p => p.SaleItemCoupons)
                    .HasForeignKey(d => d.SaleItemID)
                    .HasConstraintName("FK_SaleItemCoupon_SaleItem");
            });

            modelBuilder.Entity<SaleItemDiscount>(entity =>
            {
                entity.ToTable("SaleItemDiscount");

                entity.HasIndex(e => e.SaleItemID, "IX_SaleItemDiscount");

                entity.Property(e => e.SaleItemDiscountID).ValueGeneratedNever();

                entity.HasOne(d => d.SaleItem)
                    .WithMany(p => p.SaleItemDiscounts)
                    .HasForeignKey(d => d.SaleItemID)
                    .HasConstraintName("FK_SaleItemDiscount_SaleItem");
            });

            modelBuilder.Entity<SaleLoyalty>(entity =>
            {
                entity.ToTable("SaleLoyalty");

                entity.Property(e => e.SaleLoyaltyID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rating).HasMaxLength(50);

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleLoyalties)
                    .HasForeignKey(d => d.SaleID)
                    .HasConstraintName("FK_SaleLoyalty_Sale");
            });

            modelBuilder.Entity<SaleMedium>(entity =>
            {
                entity.HasKey(e => e.SaleMediaID);

                entity.Property(e => e.SaleMediaID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleMedia)
                    .HasForeignKey(d => d.SaleID)
                    .HasConstraintName("FK_SaleMedia_Sale");
            });

            modelBuilder.Entity<SalePM>(entity =>
            {
                entity.HasKey(e => e.SalePMSID)
                    .HasName("PK_EJPMSUsed");

                entity.ToTable("SalePMS");

                entity.HasIndex(e => e.SaleID, "IX_SalePMSUsed");

                entity.Property(e => e.SalePMSID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.GuestName).HasMaxLength(50);

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SalePMs)
                    .HasForeignKey(d => d.SaleID)
                    .HasConstraintName("FK_SalePMS_Sale");
            });

            modelBuilder.Entity<SaleShare>(entity =>
            {
                entity.ToTable("SaleShare");

                entity.HasIndex(e => e.SaleID, "IX_SaleShare");

                entity.Property(e => e.SaleShareID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleShares)
                    .HasForeignKey(d => d.SaleID)
                    .HasConstraintName("FK_SaleShare_Sale");
            });

            modelBuilder.Entity<SaleTax>(entity =>
            {
                entity.ToTable("SaleTax");

                entity.HasIndex(e => e.SaleID, "IX_SaleTax");

                entity.Property(e => e.SaleTaxID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleTaxes)
                    .HasForeignKey(d => d.SaleID)
                    .HasConstraintName("FK_SaleTax_Sale");
            });

            modelBuilder.Entity<SaleTender>(entity =>
            {
                entity.ToTable("SaleTender");

                entity.HasIndex(e => e.SaleID, "IX_SaleTender");

                entity.Property(e => e.SaleTenderID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.MediaMemo)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleTenders)
                    .HasForeignKey(d => d.SaleID)
                    .HasConstraintName("FK_SaleTender_Sale");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.ScheduleID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ScheduleDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ScheduleItem>(entity =>
            {
                entity.ToTable("ScheduleItem");

                entity.HasIndex(e => e.ScheduleID, "IX_ScheduleItem");

                entity.Property(e => e.ScheduleItemID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ShiftDescription).HasMaxLength(20);

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.ScheduleItems)
                    .HasForeignKey(d => d.ScheduleID)
                    .HasConstraintName("FK_ScheduleItem_Schedule");
            });

            modelBuilder.Entity<ScheduledUpdateMaintenance>(entity =>
            {
                entity.ToTable("ScheduledUpdateMaintenance");

                entity.Property(e => e.ScheduledUpdateMaintenanceID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Maintenance)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrimaryTable)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ScheduledUpdateScheduleGroup>(entity =>
            {
                entity.HasKey(e => e.ScheduleGroupID)
                    .HasName("PK_ScheduleGroupID");

                entity.ToTable("ScheduledUpdateScheduleGroup");

                entity.Property(e => e.ScheduleGroupID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ScheduleGroupDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ScheduleGroupName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ScheduledUpdateScheduleGroupUpdate>(entity =>
            {
                entity.HasKey(e => e.ScheduledUpdateUpdateID)
                    .HasName("PK_ScheduledUpdateUpdate");

                entity.ToTable("ScheduledUpdateScheduleGroupUpdate");

                entity.Property(e => e.ScheduledUpdateUpdateID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.ScheduleGroup)
                    .WithMany(p => p.ScheduledUpdateScheduleGroupUpdates)
                    .HasForeignKey(d => d.ScheduleGroupID)
                    .HasConstraintName("FK_ScheduledUpdateUpdate_ScheduledUpdateScheduleGroup");

                entity.HasOne(d => d.ScheduledUpdateMaintenance)
                    .WithMany(p => p.ScheduledUpdateScheduleGroupUpdates)
                    .HasForeignKey(d => d.ScheduledUpdateMaintenanceID)
                    .HasConstraintName("FK_ScheduledUpdateUpdate_ScheduledUpdateMaintenance");
            });

            modelBuilder.Entity<ScheduledUpdateScheduleGroupUpdateSettingChange>(entity =>
            {
                entity.HasKey(e => e.ScheduledUpdateSettingChangeID)
                    .HasName("PK_ScheduledUpdateSettingChange");

                entity.ToTable("ScheduledUpdateScheduleGroupUpdateSettingChange");

                entity.Property(e => e.ScheduledUpdateSettingChangeID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewValue).HasDefaultValueSql("('')");

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OriginalFieldID)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PreviousValue).HasDefaultValueSql("('')");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.DataType)
                    .WithMany(p => p.ScheduledUpdateScheduleGroupUpdateSettingChanges)
                    .HasForeignKey(d => d.DataTypeID)
                    .HasConstraintName("FK_ScheduledUpdateSettingChange_DataType");

                entity.HasOne(d => d.ScheduledUpdateUpdate)
                    .WithMany(p => p.ScheduledUpdateScheduleGroupUpdateSettingChanges)
                    .HasForeignKey(d => d.ScheduledUpdateUpdateID)
                    .HasConstraintName("FK_ScheduledUpdateSettingChange_ScheduledUpdateUpdate");
            });

            modelBuilder.Entity<Screen>(entity =>
            {
                entity.ToTable("Screen");

                entity.HasIndex(e => new { e.RegionID, e.ScreenIndex }, "IX_Screen");

                entity.Property(e => e.ScreenID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BitmapFile)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ScreenName).HasMaxLength(40);
            });

            modelBuilder.Entity<ScreenAd>(entity =>
            {
                entity.ToTable("ScreenAd");

                entity.Property(e => e.ScreenAdID).ValueGeneratedNever();

                entity.Property(e => e.Location).HasMaxLength(260);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenAds)
                    .HasForeignKey(d => d.ScreenID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Screen_ScreenAd");
            });

            modelBuilder.Entity<ScreenAutoMenu>(entity =>
            {
                entity.ToTable("ScreenAutoMenu");

                entity.HasIndex(e => e.ScreenID, "IX_ScreenAutoMenu");

                entity.Property(e => e.ScreenAutoMenuID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DepartmentTextSource).HasMaxLength(40);

                entity.Property(e => e.ItemTextSource).HasMaxLength(40);

                entity.Property(e => e.NextButtonText).HasMaxLength(40);

                entity.Property(e => e.Opacity)
                    .HasColumnType("decimal(2, 1)")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.PreviousButtonText).HasMaxLength(40);

                entity.Property(e => e.ScreenAutoMenuName).HasMaxLength(40);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenAutoMenus)
                    .HasForeignKey(d => d.ScreenID)
                    .HasConstraintName("FK_ScreenAutoMenu_Screen");
            });

            modelBuilder.Entity<ScreenAutoMenuFilter>(entity =>
            {
                entity.ToTable("ScreenAutoMenuFilter");

                entity.Property(e => e.ScreenAutoMenuFilterID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DepartmentGroupFilter).HasMaxLength(30);

                entity.Property(e => e.DepartmentNameFilter).HasMaxLength(10);

                entity.Property(e => e.FilterMax).HasMaxLength(32);

                entity.Property(e => e.ItemNameFilter).HasMaxLength(32);

                entity.Property(e => e.ItemUPCFilter).HasMaxLength(32);

                entity.Property(e => e.MenuFilter).HasMaxLength(20);

                entity.Property(e => e.ProcessItemBuffer)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReplaceItemBuffer)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ScreenAutoMenu)
                    .WithMany(p => p.ScreenAutoMenuFilters)
                    .HasForeignKey(d => d.ScreenAutoMenuID)
                    .HasConstraintName("FK_ScreenAutoMenuFilter_ScreenAutoMenu");
            });

            modelBuilder.Entity<ScreenAutoMenuFilterButtonSetting>(entity =>
            {
                entity.HasKey(e => e.ScreenAutoMenuFilterButtonSettingsID);

                entity.Property(e => e.ScreenAutoMenuFilterButtonSettingsID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FontFaceName).HasMaxLength(50);

                entity.Property(e => e.GraphicName).HasMaxLength(50);

                entity.HasOne(d => d.ScreenAutoMenuFilter)
                    .WithMany(p => p.ScreenAutoMenuFilterButtonSettings)
                    .HasForeignKey(d => d.ScreenAutoMenuFilterID)
                    .HasConstraintName("FK_ScreenAutoMenuFilterButtonSettings_ScreenAutoMenuFilter");
            });

            modelBuilder.Entity<ScreenAutoMenuNextButtonTextTranslation>(entity =>
            {
                entity.ToTable("ScreenAutoMenuNextButtonTextTranslation");

                entity.Property(e => e.ScreenAutoMenuNextButtonTextTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.ScreenAutoMenu)
                    .WithMany(p => p.ScreenAutoMenuNextButtonTextTranslations)
                    .HasForeignKey(d => d.ScreenAutoMenuID)
                    .HasConstraintName("FK_ScreenAutoMenuNextButtonTextTranslation_ScreenAutoMenu");
            });

            modelBuilder.Entity<ScreenAutoMenuPagingButtonSetting>(entity =>
            {
                entity.HasKey(e => e.ScreenAutoMenuPagingButtonSettingsID);

                entity.Property(e => e.ScreenAutoMenuPagingButtonSettingsID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FontFaceName).HasMaxLength(50);

                entity.Property(e => e.GraphicName).HasMaxLength(50);

                entity.HasOne(d => d.ScreenAutoMenu)
                    .WithMany(p => p.ScreenAutoMenuPagingButtonSettings)
                    .HasForeignKey(d => d.ScreenAutoMenuID)
                    .HasConstraintName("FK_ScreenAutoMenuPagingButtonSettings_ScreenAutoMenu");
            });

            modelBuilder.Entity<ScreenAutoMenuPreviousButtonTextTranslation>(entity =>
            {
                entity.ToTable("ScreenAutoMenuPreviousButtonTextTranslation");

                entity.Property(e => e.ScreenAutoMenuPreviousButtonTextTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.ScreenAutoMenu)
                    .WithMany(p => p.ScreenAutoMenuPreviousButtonTextTranslations)
                    .HasForeignKey(d => d.ScreenAutoMenuID)
                    .HasConstraintName("FK_ScreenAutoMenuPreviousButtonTextTranslation_ScreenAutoMenu");
            });

            modelBuilder.Entity<ScreenBanner>(entity =>
            {
                entity.ToTable("ScreenBanner");

                entity.HasIndex(e => e.ScreenID, "IX_ScreenBanner");

                entity.Property(e => e.ScreenBannerID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenBanners)
                    .HasForeignKey(d => d.ScreenID)
                    .HasConstraintName("FK_ScreenBanner_Screen");
            });

            modelBuilder.Entity<ScreenBitmap>(entity =>
            {
                entity.ToTable("ScreenBitmap");

                entity.HasIndex(e => e.ScreenID, "IX_ScreenBitmap");

                entity.Property(e => e.ScreenBitmapID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BitmapFile).HasMaxLength(128);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenBitmaps)
                    .HasForeignKey(d => d.ScreenID)
                    .HasConstraintName("FK_ScreenBitmap_Screen");
            });

            modelBuilder.Entity<ScreenButton>(entity =>
            {
                entity.ToTable("ScreenButton");

                entity.HasIndex(e => e.ScreenID, "IX_ScreenButton");

                entity.Property(e => e.ScreenButtonID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Data1).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageName).HasMaxLength(20);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenButtons)
                    .HasForeignKey(d => d.ScreenID)
                    .HasConstraintName("FK_ScreenButton_Screen");
            });

            modelBuilder.Entity<ScreenButtonTranslation>(entity =>
            {
                entity.ToTable("ScreenButtonTranslation");

                entity.Property(e => e.ScreenButtonTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.ScreenButton)
                    .WithMany(p => p.ScreenButtonTranslations)
                    .HasForeignKey(d => d.ScreenButtonID)
                    .HasConstraintName("FK_ScreenButtonTranslation_ScreenButton");
            });

            modelBuilder.Entity<ScreenEdit>(entity =>
            {
                entity.ToTable("ScreenEdit");

                entity.HasIndex(e => e.ScreenID, "IX_ScreenEdit");

                entity.Property(e => e.ScreenEditID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FontSize).HasDefaultValueSql("((19))");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenEdits)
                    .HasForeignKey(d => d.ScreenID)
                    .HasConstraintName("FK_ScreenEdit_Screen");
            });

            modelBuilder.Entity<ScreenFrame>(entity =>
            {
                entity.ToTable("ScreenFrame");

                entity.HasIndex(e => e.ScreenID, "IX_ScreenFrame");

                entity.Property(e => e.ScreenFrameID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenFrames)
                    .HasForeignKey(d => d.ScreenID)
                    .HasConstraintName("FK_ScreenFrame_Screen");
            });

            modelBuilder.Entity<ScreenHelp>(entity =>
            {
                entity.ToTable("ScreenHelp");

                entity.HasIndex(e => e.ScreenID, "IX_ScreenHelp");

                entity.Property(e => e.ScreenHelpID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Topic).HasMaxLength(40);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenHelps)
                    .HasForeignKey(d => d.ScreenID)
                    .HasConstraintName("FK_ScreenHelp_Screen");
            });

            modelBuilder.Entity<ScreenKioskMenu>(entity =>
            {
                entity.ToTable("ScreenKioskMenu");

                entity.HasIndex(e => e.ScreenID, "IX_ScreenKioskMenu");

                entity.Property(e => e.ScreenKioskMenuID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GotoScreenIndex).HasDefaultValueSql("((-1))");

                entity.Property(e => e.KioskMenuName).HasMaxLength(40);

                entity.Property(e => e.PageNextImageName).HasMaxLength(50);

                entity.Property(e => e.PageNextText).HasMaxLength(40);

                entity.Property(e => e.PagePreviousImageName).HasMaxLength(50);

                entity.Property(e => e.PagePreviousText).HasMaxLength(40);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenKioskMenus)
                    .HasForeignKey(d => d.ScreenID)
                    .HasConstraintName("FK_ScreenKioskMenu_Screen");
            });

            modelBuilder.Entity<ScreenKioskMenuFilter>(entity =>
            {
                entity.ToTable("ScreenKioskMenuFilter");

                entity.Property(e => e.ScreenKioskMenuFilterID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DepartmentGroupFilter).HasMaxLength(30);

                entity.Property(e => e.DepartmentNameFilter).HasMaxLength(10);

                entity.Property(e => e.Filter).HasMaxLength(50);

                entity.Property(e => e.FilterEnd).HasMaxLength(50);

                entity.Property(e => e.ItemNameFilter).HasMaxLength(32);

                entity.Property(e => e.ItemUPCFilter).HasMaxLength(32);

                entity.HasOne(d => d.ScreenKioskMenu)
                    .WithMany(p => p.ScreenKioskMenuFilters)
                    .HasForeignKey(d => d.ScreenKioskMenuID)
                    .HasConstraintName("FK_ScreenKioskMenuFilter_ScreenKioskMenu");
            });

            modelBuilder.Entity<ScreenKioskMenuNextButtonTextTranslation>(entity =>
            {
                entity.ToTable("ScreenKioskMenuNextButtonTextTranslation");

                entity.Property(e => e.ScreenKioskMenuNextButtonTextTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.ScreenKioskMenu)
                    .WithMany(p => p.ScreenKioskMenuNextButtonTextTranslations)
                    .HasForeignKey(d => d.ScreenKioskMenuID)
                    .HasConstraintName("FK_ScreenKioskMenuNextButtonTextTranslation_ScreenKioskMenu");
            });

            modelBuilder.Entity<ScreenKioskMenuPreviousButtonTextTranslation>(entity =>
            {
                entity.ToTable("ScreenKioskMenuPreviousButtonTextTranslation");

                entity.Property(e => e.ScreenKioskMenuPreviousButtonTextTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.ScreenKioskMenu)
                    .WithMany(p => p.ScreenKioskMenuPreviousButtonTextTranslations)
                    .HasForeignKey(d => d.ScreenKioskMenuID)
                    .HasConstraintName("FK_ScreenKioskMenuPreviousButtonTextTranslation_ScreenKioskMenu");
            });

            modelBuilder.Entity<ScreenList>(entity =>
            {
                entity.ToTable("ScreenList");

                entity.HasIndex(e => e.ScreenID, "IX_ScreenList");

                entity.Property(e => e.ScreenListID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenLists)
                    .HasForeignKey(d => d.ScreenID)
                    .HasConstraintName("FK_ScreenList_Screen");
            });

            modelBuilder.Entity<ScreenText>(entity =>
            {
                entity.ToTable("ScreenText");

                entity.HasIndex(e => e.ScreenID, "IX_ScreenText");

                entity.Property(e => e.ScreenTextID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FontSize).HasDefaultValueSql("((19))");

                entity.Property(e => e.Text).HasMaxLength(40);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenTexts)
                    .HasForeignKey(d => d.ScreenID)
                    .HasConstraintName("FK_ScreenText_Screen");
            });

            modelBuilder.Entity<ScreenTextTranslation>(entity =>
            {
                entity.ToTable("ScreenTextTranslation");

                entity.Property(e => e.ScreenTextTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.ScreenText)
                    .WithMany(p => p.ScreenTextTranslations)
                    .HasForeignKey(d => d.ScreenTextID)
                    .HasConstraintName("FK_ScreenTextTranslation_ScreenText");
            });

            modelBuilder.Entity<SecurityCheck>(entity =>
            {
                entity.ToTable("SecurityCheck");

                entity.Property(e => e.SecurityCheckID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FileName)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.Path)
                    .HasMaxLength(128)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ServingPeriod>(entity =>
            {
                entity.ToTable("ServingPeriod");

                entity.Property(e => e.ServingPeriodID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description)
                    .HasMaxLength(27)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("Session");

                entity.Property(e => e.SessionID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.lastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.sessionDate).HasColumnType("datetime");

                entity.Property(e => e.sessionKey).HasMaxLength(200);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("Shift");

                entity.Property(e => e.ShiftID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ShiftDescription).HasMaxLength(32);
            });

            modelBuilder.Entity<Shorthand>(entity =>
            {
                entity.ToTable("Shorthand");

                entity.Property(e => e.ShorthandID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ShortCode).HasMaxLength(32);
            });

            modelBuilder.Entity<Signature>(entity =>
            {
                entity.ToTable("Signature");

                entity.Property(e => e.SignatureID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SignatureDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SkinSchedule>(entity =>
            {
                entity.ToTable("SkinSchedule");

                entity.Property(e => e.SkinScheduleID).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Special>(entity =>
            {
                entity.ToTable("Special");

                entity.Property(e => e.SpecialID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SpecialName).HasMaxLength(32);
            });

            modelBuilder.Entity<SpecialMonth>(entity =>
            {
                entity.ToTable("SpecialMonth");

                entity.HasIndex(e => e.SpecialID, "IX_SpecialMonth");

                entity.Property(e => e.SpecialMonthID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.HasOne(d => d.Special)
                    .WithMany(p => p.SpecialMonths)
                    .HasForeignKey(d => d.SpecialID)
                    .HasConstraintName("FK_SpecialMonth_Special");
            });

            modelBuilder.Entity<SpecialWeek>(entity =>
            {
                entity.ToTable("SpecialWeek");

                entity.HasIndex(e => e.SpecialID, "IX_SpecialWeek");

                entity.Property(e => e.SpecialWeekID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.HasOne(d => d.Special)
                    .WithMany(p => p.SpecialWeeks)
                    .HasForeignKey(d => d.SpecialID)
                    .HasConstraintName("FK_SpecialWeek_Special");
            });

            modelBuilder.Entity<StatusMessage>(entity =>
            {
                entity.ToTable("StatusMessage");

                entity.Property(e => e.StatusMessageID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(512);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store");

                entity.Property(e => e.StoreID).ValueGeneratedNever();

                entity.Property(e => e.APIKey).HasMaxLength(200);

                entity.Property(e => e.StoreDescription).HasMaxLength(32);

                entity.Property(e => e.StoreName).HasMaxLength(8);
            });

            modelBuilder.Entity<Sync>(entity =>
            {
                entity.ToTable("Sync");

                entity.Property(e => e.SyncID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'I')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SyncDatum>(entity =>
            {
                entity.HasKey(e => e.SyncDataID);

                entity.HasIndex(e => e.SyncID, "IX_SyncData");

                entity.Property(e => e.SyncDataID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Sync)
                    .WithMany(p => p.SyncData)
                    .HasForeignKey(d => d.SyncID)
                    .HasConstraintName("FK_SyncData_Sync");
            });

            modelBuilder.Entity<TabbedOut>(entity =>
            {
                entity.HasKey(e => e.TabOutID);

                entity.ToTable("TabbedOut");

                entity.HasIndex(e => e.DataVersion, "IX_TabbedOut_DataVersion");

                entity.Property(e => e.TabOutID).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.AuthResponse)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.CardName)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.CardNum)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PreAuthResponse)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.TabOutCode).HasMaxLength(10);

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<TabbedOutAlert>(entity =>
            {
                entity.HasKey(e => e.MessageID);

                entity.ToTable("TabbedOutAlert");

                entity.Property(e => e.MessageID).ValueGeneratedNever();

                entity.Property(e => e.Message).HasMaxLength(2000);

                entity.Property(e => e.TabOutCode).HasMaxLength(10);
            });

            modelBuilder.Entity<Tare>(entity =>
            {
                entity.ToTable("Tare");

                entity.Property(e => e.TareID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description)
                    .HasMaxLength(27)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TareImage>(entity =>
            {
                entity.ToTable("TareImage");

                entity.Property(e => e.TareImageID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ImageName).HasMaxLength(20);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task");

                entity.Property(e => e.TaskID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<TaskItem>(entity =>
            {
                entity.ToTable("TaskItem");

                entity.HasIndex(e => e.TaskID, "IX_TaskItem");

                entity.Property(e => e.TaskItemID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ProgramName).HasMaxLength(100);

                entity.Property(e => e.RunDate).HasColumnType("datetime");

                entity.Property(e => e.TaskDescription).HasMaxLength(100);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskItems)
                    .HasForeignKey(d => d.TaskID)
                    .HasConstraintName("FK_TaskItem_Task");
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.ToTable("Tax");

                entity.Property(e => e.TaxID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TaxName).HasMaxLength(64);
            });

            modelBuilder.Entity<TaxSchedule>(entity =>
            {
                entity.ToTable("TaxSchedule");

                entity.HasIndex(e => e.TaxID, "IX_TaxSchedule");

                entity.Property(e => e.TaxScheduleID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.TaxSchedules)
                    .HasForeignKey(d => d.TaxID)
                    .HasConstraintName("FKS_TaxSchedule_Tax");
            });

            modelBuilder.Entity<TaxTable>(entity =>
            {
                entity.ToTable("TaxTable");

                entity.HasIndex(e => e.TaxID, "IX_TaxTable");

                entity.Property(e => e.TaxTableID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.TaxTables)
                    .HasForeignKey(d => d.TaxID)
                    .HasConstraintName("FKS_TaxTable_Tax");
            });

            modelBuilder.Entity<TaxTranslation>(entity =>
            {
                entity.ToTable("TaxTranslation");

                entity.Property(e => e.TaxTranslationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.TaxTranslations)
                    .HasForeignKey(d => d.TaxID)
                    .HasConstraintName("FK_TaxTranslation_Tax");
            });

            modelBuilder.Entity<TempState>(entity =>
            {
                entity.ToTable("TempState");

                entity.Property(e => e.TempStateID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PermanentID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<TerminalConfiguration>(entity =>
            {
                entity.ToTable("TerminalConfiguration");

                entity.Property(e => e.TerminalConfigurationID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ConfigurationXML).HasColumnType("ntext");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TimeCard>(entity =>
            {
                entity.ToTable("TimeCard");

                entity.HasIndex(e => new { e.CardDate, e.PunchType }, "IX_CardDatePunchType");

                entity.HasIndex(e => new { e.StoreID, e.EmpID, e.CardDate }, "IX_TimeCard");

                entity.Property(e => e.TimeCardID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CardDate).HasColumnType("datetime");

                entity.Property(e => e.IsUpdate)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PaycomExportDate).HasColumnType("datetime");

                entity.Property(e => e.RoundedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TimedMenu>(entity =>
            {
                entity.ToTable("TimedMenu");

                entity.Property(e => e.TimedMenuID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<TimedMenuDay>(entity =>
            {
                entity.ToTable("TimedMenuDay");

                entity.HasIndex(e => e.TimedMenuID, "IX_TimedMenuDay");

                entity.Property(e => e.TimedMenuDayID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CommonMenuName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TerminalNumber).HasDefaultValueSql("((99))");

                entity.HasOne(d => d.TimedMenu)
                    .WithMany(p => p.TimedMenuDays)
                    .HasForeignKey(d => d.TimedMenuID)
                    .HasConstraintName("FK_TimedMenuDay_TimedMenu");
            });

            modelBuilder.Entity<TimedMenuJob>(entity =>
            {
                entity.ToTable("TimedMenuJob");

                entity.HasIndex(e => e.TimedMenuID, "IX_TimedMenuJob");

                entity.Property(e => e.TimedMenuJobID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.TimedMenu)
                    .WithMany(p => p.TimedMenuJobs)
                    .HasForeignKey(d => d.TimedMenuID)
                    .HasConstraintName("FK_TimedMenuJob_TimedMenu");
            });

            modelBuilder.Entity<TipPool>(entity =>
            {
                entity.ToTable("TipPool");

                entity.Property(e => e.TipPoolID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Days).HasDefaultValueSql("(0xFF)");

                entity.Property(e => e.TipPoolName).HasMaxLength(255);
            });

            modelBuilder.Entity<TipPoolContribution>(entity =>
            {
                entity.ToTable("TipPoolContribution");

                entity.Property(e => e.TipPoolContributionID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Percentage).HasDefaultValueSql("((0.0))");

                entity.HasOne(d => d.TipPool)
                    .WithMany(p => p.TipPoolContributions)
                    .HasForeignKey(d => d.TipPoolID)
                    .HasConstraintName("FK_TipPoolContribution_TipPool");
            });

            modelBuilder.Entity<TipPoolDistribution>(entity =>
            {
                entity.ToTable("TipPoolDistribution");

                entity.Property(e => e.TipPoolDistributionID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Percentage).HasDefaultValueSql("((0.0))");

                entity.HasOne(d => d.TipPool)
                    .WithMany(p => p.TipPoolDistributions)
                    .HasForeignKey(d => d.TipPoolID)
                    .HasConstraintName("FK_TipPoolDistribution_TipPool");
            });

            modelBuilder.Entity<TokenLastActivity>(entity =>
            {
                entity.HasKey(e => e.Token);

                entity.ToTable("TokenLastActivity");

                entity.Property(e => e.Token)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastActive).HasColumnType("datetime");
            });

            modelBuilder.Entity<Total>(entity =>
            {
                entity.ToTable("Total");

                entity.HasIndex(e => e.TotalDate, "IX_Total");

                entity.Property(e => e.TotalID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description).HasMaxLength(32);

                entity.Property(e => e.TotalDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.ToTable("Transfer");

                entity.HasIndex(e => new { e.ToTerminalNumber, e.ProcessOnServer, e.RetryCount }, "IX_Transfer");

                entity.Property(e => e.TransferID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Data).HasColumnType("ntext");
            });

            modelBuilder.Entity<UI>(entity =>
            {
                entity.ToTable("UI");

                entity.HasIndex(e => e.Name, "UIName_Unique")
                    .IsUnique();

                entity.Property(e => e.UIID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<UIColumn>(entity =>
            {
                entity.ToTable("UIColumn");

                entity.Property(e => e.UIColumnID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("A Database Column Name (Must match table)");

                entity.Property(e => e.Position).HasComment("Display Order Index");

                entity.HasOne(d => d.UI)
                    .WithMany(p => p.UIColumns)
                    .HasForeignKey(d => d.UIID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UIColumn_UIColumn");
            });

            modelBuilder.Entity<VDU>(entity =>
            {
                entity.ToTable("VDU");

                entity.Property(e => e.VDUID).ValueGeneratedNever();

                entity.Property(e => e.CheckDescription).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.PromiseTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VDUItem>(entity =>
            {
                entity.ToTable("VDUItem");

                entity.Property(e => e.VDUItemID).ValueGeneratedNever();

                entity.Property(e => e.Department)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(20);

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.SaleItemID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.VDU)
                    .WithMany(p => p.VDUItems)
                    .HasForeignKey(d => d.VDUID)
                    .HasConstraintName("FK_VDUItem_VDU");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor");

                entity.Property(e => e.VendorID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address).HasMaxLength(64);

                entity.Property(e => e.City).HasMaxLength(16);

                entity.Property(e => e.Fax).HasMaxLength(16);

                entity.Property(e => e.Notes).HasMaxLength(420);

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.VendorName).HasMaxLength(20);

                entity.Property(e => e.Zip).HasMaxLength(16);
            });

            modelBuilder.Entity<VendorPurchase>(entity =>
            {
                entity.ToTable("VendorPurchase");

                entity.Property(e => e.VendorPurchaseID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceivedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorPurchases)
                    .HasForeignKey(d => d.VendorID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VendorPurchase_Vendor");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.ToTable("Version");

                entity.Property(e => e.VersionID).ValueGeneratedNever();
            });

            modelBuilder.Entity<VideoCapture>(entity =>
            {
                entity.ToTable("VideoCapture");

                entity.Property(e => e.VideoCaptureID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.VideoDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WageHistory>(entity =>
            {
                entity.ToTable("WageHistory");

                entity.Property(e => e.WageHistoryID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.WageDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WageHistoryWage>(entity =>
            {
                entity.ToTable("WageHistoryWage");

                entity.HasIndex(e => e.WageHistoryID, "IX_WageHistoryWage");

                entity.Property(e => e.WageHistoryWageID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.WageHistory)
                    .WithMany(p => p.WageHistoryWages)
                    .HasForeignKey(d => d.WageHistoryID)
                    .HasConstraintName("FK_WageHistoryWage_WageHistory");
            });

            modelBuilder.Entity<XMLBucket>(entity =>
            {
                entity.HasKey(e => e.XMLBucketsID);

                entity.Property(e => e.XMLBucketsID).ValueGeneratedNever();

                entity.Property(e => e.BusinessDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.XML).HasDefaultValueSql("('')");

                entity.Property(e => e.XML2).HasColumnType("xml");
            });

            modelBuilder.Entity<_BackgroundProcess>(entity =>
            {
                entity.HasKey(e => e.BackgroundProcessID);

                entity.ToTable("_BackgroundProcess");

                entity.Property(e => e.BackgroundProcessID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BackgroundProcessName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<_BackgroundProcessLock>(entity =>
            {
                entity.HasKey(e => e.BackgroundProcessLockId);

                entity.ToTable("_BackgroundProcessLock");

                entity.HasIndex(e => e.BackgroundProcessName, "UQ__BackgroundProcessLock_BackgroundProcessName")
                    .IsUnique();

                entity.Property(e => e.BackgroundProcessLockId).ValueGeneratedNever();

                entity.Property(e => e.BackgroundProcessName).HasMaxLength(50);

                entity.Property(e => e.LockingApplication)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<_BucketValue>(entity =>
            {
                entity.HasIndex(e => e.Key1, "IX__BucketValues_Key1");

                entity.HasIndex(e => e.Key2, "IX__BucketValues_Key2");

                entity.HasIndex(e => e.Key3, "IX__BucketValues_Key3");

                entity.HasIndex(e => e.Key4, "IX__BucketValues_Key4");

                entity.HasIndex(e => e.Key5, "IX__BucketValues_Key5");

                entity.HasIndex(e => e.Key6, "IX__BucketValues_Key6");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BucketType).HasMaxLength(150);

                entity.Property(e => e.BucketValue1).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue10).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue11).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue12).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue13).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue14).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue15).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue16).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue17).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue18).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue19).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue2).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue20).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue3).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue4).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue5).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue6).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue7).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue8).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketValue9).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Key1).HasMaxLength(150);

                entity.Property(e => e.Key2).HasMaxLength(150);

                entity.Property(e => e.Key3).HasMaxLength(150);

                entity.Property(e => e.Key4).HasMaxLength(150);

                entity.Property(e => e.Key5).HasMaxLength(150);

                entity.Property(e => e.Key6).HasMaxLength(150);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.StoreID).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<_Calendar>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.ToTable("_Calendar");

                entity.HasIndex(e => e.Date, "IX__Calendar_Date");

                entity.HasIndex(e => e.DayOfWeek, "IX__Calendar_DayOfWeek");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FirstOfMonth).HasColumnType("date");

                entity.Property(e => e.FirstOfYear).HasColumnType("date");

                entity.Property(e => e.MonthName).HasMaxLength(9);
            });

            modelBuilder.Entity<_HourOfDay>(entity =>
            {
                entity.HasKey(e => e.Hour);

                entity.ToTable("_HourOfDay");

                entity.HasIndex(e => e.Hour, "IX__HourOfDay_Hour");

                entity.Property(e => e.Hour).ValueGeneratedNever();
            });

            modelBuilder.Entity<_ImportMapping>(entity =>
            {
                entity.HasKey(e => e.ImportMappingID);

                entity.ToTable("_ImportMapping");

                entity.Property(e => e.ImportMappingID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Identifier).HasMaxLength(50);
            });

            modelBuilder.Entity<_Report>(entity =>
            {
                entity.HasKey(e => e.ReportID);

                entity.ToTable("_Report");

                entity.HasIndex(e => e.ReportCategoryID, "IX_ReportCategoryID");

                entity.Property(e => e.ReportID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastEdited).HasColumnType("datetime");

                entity.HasOne(d => d.ReportCategory)
                    .WithMany(p => p._Reports)
                    .HasForeignKey(d => d.ReportCategoryID);
            });

            modelBuilder.Entity<_ReportCategory>(entity =>
            {
                entity.HasKey(e => e.ReportCategoryID);

                entity.ToTable("_ReportCategory");

                entity.Property(e => e.ReportCategoryID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<_ReportDataSource>(entity =>
            {
                entity.HasKey(e => e.ReportDataSourceID);

                entity.ToTable("_ReportDataSource");

                entity.Property(e => e.ReportDataSourceID).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<_ReportFormula>(entity =>
            {
                entity.ToTable("_ReportFormula");

                entity.HasIndex(e => e.ReportID, "IX_ReportID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p._ReportFormulas)
                    .HasForeignKey(d => d.ReportID)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<_ReportGroup>(entity =>
            {
                entity.HasKey(e => e.ReportGroupID);

                entity.ToTable("_ReportGroup");

                entity.Property(e => e.ReportGroupID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<_ReportGroupLayout>(entity =>
            {
                entity.HasKey(e => e.ReportGroupLayoutID)
                    .HasName("PK_ReportGroupLayout");

                entity.ToTable("_ReportGroupLayout");

                entity.HasIndex(e => e.ReportGroupID, "IX_ReportGroupID");

                entity.Property(e => e.ReportGroupLayoutID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.ReportGroup)
                    .WithMany(p => p._ReportGroupLayouts)
                    .HasForeignKey(d => d.ReportGroupID);
            });

            modelBuilder.Entity<_ReportParameter>(entity =>
            {
                entity.HasKey(e => e.ReportParameterID);

                entity.ToTable("_ReportParameter");

                entity.HasIndex(e => e.ReportID, "IX_ReportID");

                entity.Property(e => e.ReportParameterID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p._ReportParameters)
                    .HasForeignKey(d => d.ReportID)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<_ReportParameterValue>(entity =>
            {
                entity.HasKey(e => e.ReportParameterValuesID);

                entity.Property(e => e.ReportParameterValuesID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ParameterValues).HasMaxLength(4000);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p._ReportParameterValues)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK__ReportParameterValues_Employee");
            });

            modelBuilder.Entity<_ReportRole>(entity =>
            {
                entity.HasKey(e => e.ReportRoleID);

                entity.ToTable("_ReportRole");

                entity.Property(e => e.ReportRoleID).ValueGeneratedNever();
            });

            modelBuilder.Entity<_ReportSchedule>(entity =>
            {
                entity.HasKey(e => e.ReportScheduleID);

                entity.ToTable("_ReportSchedule");

                entity.HasIndex(e => e.ReportID, "IX_ReportID");

                entity.Property(e => e.ReportScheduleID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AppendTimestampToFile)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ScheduleString).HasMaxLength(48);

                entity.Property(e => e.ScheduleValues).HasDefaultValueSql("(' ')");

                entity.Property(e => e.SelectedPrinter).HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<_ReportTempDatum>(entity =>
            {
                entity.HasKey(e => e.TempStateID)
                    .HasName("PK_ReportTempData");

                entity.Property(e => e.TempStateID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<_ScheduledProcess>(entity =>
            {
                entity.HasKey(e => e.ScheduledProcessID);

                entity.ToTable("_ScheduledProcess");

                entity.Property(e => e.ScheduledProcessID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastQueued).HasColumnType("datetime");

                entity.Property(e => e.LastRun).HasColumnType("datetime");

                entity.Property(e => e.ScheduleString)
                    .HasMaxLength(48)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ScheduledProcessName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<_vBucketDataByDateAndTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vBucketDataByDateAndTime");

                entity.Property(e => e.BankGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CustomerPaymentTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.GiftCertificateTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.LevelUpGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleCount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.VoidTotal).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vBucketDataByEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vBucketDataByEmployee");

                entity.Property(e => e.BankGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.CashTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ChargeTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ChargedCardTendersWithTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CustomerCount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CustomerPaymentTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.DeclaredTipsDirect).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.DeclaredTipsIndirect).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.DriverServiceChargeTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.GiftCertificateTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.LevelUpGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OtherTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleCount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ServiceChargeTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TaxTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TenderTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.VoidTotal).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vBucketDataByJobCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vBucketDataByJobCode");

                entity.Property(e => e.BankGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerPaymentTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.GiftCertificateTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.LevelUpGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.VoidTotal).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vBucketDataByJobCodeAndEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vBucketDataByJobCodeAndEmployee");

                entity.Property(e => e.BankGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerPaymentTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.GiftCertificateTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.LevelUpGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.VoidTotal).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vBucketDataByMediaAndEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vBucketDataByMediaAndEmployee");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.DeclaredTipsDirect).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DeclaredTipsIndirect).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.ServingPeriod).HasMaxLength(150);

                entity.Property(e => e.TenderTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TenderTotalWithTips).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Tips).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<_vBucketDataByMedium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vBucketDataByMedia");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.DeclaredTipsDirect).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.DeclaredTipsIndirect).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ServingPeriod).HasMaxLength(150);

                entity.Property(e => e.TenderTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TenderTotalWithTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.Tips).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vBucketDataBySection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vBucketDataBySection");

                entity.Property(e => e.BankGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerPaymentTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.GiftCertificateTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.LevelUpGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.VoidTotal).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vBucketDataBySectionAndEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vBucketDataBySectionAndEmployee");

                entity.Property(e => e.BankGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerPaymentTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.GiftCertificateTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.LevelUpGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.VoidTotal).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vBucketDataByServingPeriod>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vBucketDataByServingPeriod");

                entity.Property(e => e.BankGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.CashTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ChargeTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ChargedCardTendersWithTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CustomerCount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CustomerPaymentTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.DeclaredTipsDirect).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.DeclaredTipsIndirect).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.DriverServiceChargeTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.GiftCertificateTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.LevelUpGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OtherTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleCount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ServiceChargeTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ServingPeriod).HasMaxLength(150);

                entity.Property(e => e.TaxTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TenderTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.VoidTotal).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vBucketDataByServingPeriodAndEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vBucketDataByServingPeriodAndEmployee");

                entity.Property(e => e.BankGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.CashTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ChargeTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ChargedCardTendersWithTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CustomerCount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CustomerPaymentTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.DeclaredTipsDirect).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.DeclaredTipsIndirect).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.DriverServiceChargeTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.LevelUpGiftCardTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OtherTips).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleCount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SaleTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.Section).HasMaxLength(150);

                entity.Property(e => e.ServiceChargeTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TaxTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TenderTotal).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.VoidTotal).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vCalendarHour>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vCalendarHour");

                entity.Property(e => e.HourEnd).HasColumnType("datetime");

                entity.Property(e => e.HourStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<_vLaborBucket>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vLaborBucket");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.HourType).HasMaxLength(150);

                entity.Property(e => e.HoursWorked).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.ServingPeriod).HasMaxLength(150);

                entity.Property(e => e.WagesPaid).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<_vLaborBucketGrouped>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vLaborBucketGrouped");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ServingPeriod).HasMaxLength(150);
            });

            modelBuilder.Entity<_vLaborByDateAndTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vLaborByDateAndTime");

                entity.Property(e => e.BreakHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BreakPaidHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BreakWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.LaborHour).HasColumnType("datetime");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vLaborByEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vLaborByEmployee");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vLaborByJobCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vLaborByJobCode");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vLaborByJobCodeAndEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vLaborByJobCodeAndEmployee");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vLaborBySection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vLaborBySection");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vLaborBySectionAndEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vLaborBySectionAndEmployee");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<_vLaborByServingPeriod>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vLaborByServingPeriod");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ServingPeriod).HasMaxLength(150);
            });

            modelBuilder.Entity<_vLaborByServingPeriodAndEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vLaborByServingPeriodAndEmployee");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MealWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ServingPeriod).HasMaxLength(150);
            });

            modelBuilder.Entity<_vPunchPairByJobCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vPunchPairByJobCode");

                entity.Property(e => e.JobCodeDescription).HasMaxLength(20);

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.NonRoundedTimeIn).HasColumnType("datetime");

                entity.Property(e => e.NonRoundedTimeOut).HasColumnType("datetime");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");
            });

            modelBuilder.Entity<_vPunchPairByShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vPunchPairByShift");

                entity.Property(e => e.MealHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.NonRoundedTimeIn).HasColumnType("datetime");

                entity.Property(e => e.NonRoundedTimeOut).HasColumnType("datetime");

                entity.Property(e => e.OTHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OTWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");
            });

            modelBuilder.Entity<_vSaleItemSubTableSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSaleItemSubTableSum");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.BankAuthCode).HasMaxLength(24);

                entity.Property(e => e.BankAuthorizationCode).HasMaxLength(24);

                entity.Property(e => e.BankRefNumber).HasMaxLength(128);

                entity.Property(e => e.CouponApplied)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.DiscountApplied)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.DiscountFlags)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.GiftCardNum).HasMaxLength(16);

                entity.Property(e => e.HasRemoteDescription)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ModifierGroupItem).HasMaxLength(32);

                entity.Property(e => e.PriceLevelName).HasMaxLength(50);

                entity.Property(e => e.PriceScheduleName).HasMaxLength(50);

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);

                entity.Property(e => e.ShortDescription).HasMaxLength(6);

                entity.Property(e => e.SoldDate).HasColumnType("datetime");

                entity.Property(e => e.SplitLevel)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.TimedEndDate).HasColumnType("datetime");

                entity.Property(e => e.TimedStartDate).HasColumnType("datetime");

                entity.Property(e => e.UPC).HasMaxLength(32);

                entity.Property(e => e.VoidDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<_vSaleSection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSaleSection");

                entity.Property(e => e.CommonMenuName).HasMaxLength(20);

                entity.Property(e => e.CustomerRequiredFields).HasMaxLength(512);

                entity.Property(e => e.HandheldCommonMenuName).HasMaxLength(20);

                entity.Property(e => e.HandheldHomeMenuName).HasMaxLength(20);

                entity.Property(e => e.HomeMenuName).HasMaxLength(20);

                entity.Property(e => e.SectionName).HasMaxLength(20);

                entity.Property(e => e.SkipModsMask).HasMaxLength(32);

                entity.Property(e => e.SkipOrderPrinter).HasMaxLength(512);
            });

            modelBuilder.Entity<_vSaleSubCreditCardSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSaleSubCreditCardSum");

                entity.Property(e => e.EndDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<_vSaleSubMediaSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSaleSubMediaSum");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<_vSaleSubTableSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSaleSubTableSum");

                entity.Property(e => e.AssignDriverDate).HasColumnType("datetime");

                entity.Property(e => e.BucketProcessDate).HasColumnType("datetime");

                entity.Property(e => e.CheckDescription).HasMaxLength(50);

                entity.Property(e => e.CustomerAddress).HasMaxLength(65);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.DriverName).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FanConnectCustomerAccount).HasMaxLength(40);

                entity.Property(e => e.FanConnectTransactionID).HasMaxLength(40);

                entity.Property(e => e.LevelUpUUID).HasMaxLength(64);

                entity.Property(e => e.MozartOrderNumber).HasMaxLength(50);

                entity.Property(e => e.PaydiantCheckoutToken).HasMaxLength(255);

                entity.Property(e => e.PaydiantTransactionRefID).HasMaxLength(255);

                entity.Property(e => e.PreAuthResponse)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.PreCardName)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.PreCardNum)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVAID)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVARC)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVApplicationLabel)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVCVM)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVEntryMethod)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVIAD)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVTSI)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEMVTVR)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreEncryptedBlock)
                    .HasMaxLength(232)
                    .IsFixedLength();

                entity.Property(e => e.PreEncryptedRawSwipe)
                    .HasMaxLength(1024)
                    .IsFixedLength();

                entity.Property(e => e.PreEncryptionKey)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.PreExpirationDate)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.PreProcessData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreReferenceData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreReferenceNumber)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.PreTrack2)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreVaultID)
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.PreZip)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.PromisedDate).HasColumnType("datetime");

                entity.Property(e => e.ReportPreAuthResponse).HasMaxLength(40);

                entity.Property(e => e.ReportPreCardName).HasMaxLength(40);

                entity.Property(e => e.ReportPreCardNumber).HasMaxLength(40);

                entity.Property(e => e.ReportPreCardType).HasMaxLength(40);

                entity.Property(e => e.ReportPreTranID).HasMaxLength(40);

                entity.Property(e => e.ReportPreZipCode).HasMaxLength(40);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TabOutCode).HasMaxLength(10);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.WebAddress1).HasMaxLength(65);

                entity.Property(e => e.WebAddress2).HasMaxLength(65);

                entity.Property(e => e.WebCity).HasMaxLength(50);

                entity.Property(e => e.WebComment).HasMaxLength(600);

                entity.Property(e => e.WebEmail).HasMaxLength(255);

                entity.Property(e => e.WebFirstName).HasMaxLength(50);

                entity.Property(e => e.WebLastName).HasMaxLength(50);

                entity.Property(e => e.WebPhone).HasMaxLength(50);

                entity.Property(e => e.WebState).HasMaxLength(2);

                entity.Property(e => e.WebZip).HasMaxLength(50);
            });

            modelBuilder.Entity<_vSaleSubTaxSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSaleSubTaxSum");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<_vSaleSubTenderSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSaleSubTenderSum");

                entity.Property(e => e.EndDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<_vSalesByDateAndTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSalesByDateAndTime");

                entity.Property(e => e.SaleHour).HasColumnType("datetime");
            });

            modelBuilder.Entity<_vSalesByItemBucket>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSalesByItemBucket");

                entity.Property(e => e.BankGiftCardTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CustomerPaymentTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DriverServiceChargeTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GiftCertificateTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.LevelUpGiftCardTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SaleCount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SaleTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ServiceChargeTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ServingPeriod).HasMaxLength(150);

                entity.Property(e => e.TaxTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VoidTotal).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<_vSalesForEmployeeBucket>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSalesForEmployeeBucket");

                entity.Property(e => e.BankGiftCardTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.CashTips).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ChargeTips).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ChargedCardTendersWithTips).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CustomerCount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CustomerPaymentTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DeclaredTipsDirect).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DeclaredTipsIndirect).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DriverServiceChargeTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GiftCertificateTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.LevelUpGiftCardTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OtherTips).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SaleCount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SaleTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ServiceChargeTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ServingPeriod).HasMaxLength(150);

                entity.Property(e => e.TaxTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TenderTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VoidTotal).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<_vSalesForLaborBucket>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSalesForLaborBucket");

                entity.Property(e => e.BankGiftCardTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BucketDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CustomerPaymentTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DriverServiceChargeTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GiftCertificateTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.LevelUpGiftCardTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SaleCount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SaleTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ServiceChargeTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ServingPeriod).HasMaxLength(150);

                entity.Property(e => e.TaxTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VoidTotal).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<dba_indexDefragExclusion>(entity =>
            {
                entity.HasKey(e => new { e.databaseID, e.objectID, e.indexID })
                    .HasName("PK_indexDefragExclusion_v40");

                entity.ToTable("dba_indexDefragExclusion");

                entity.Property(e => e.databaseName).HasMaxLength(128);

                entity.Property(e => e.indexName).HasMaxLength(128);

                entity.Property(e => e.objectName).HasMaxLength(128);
            });

            modelBuilder.Entity<dba_indexDefragLog>(entity =>
            {
                entity.HasKey(e => e.indexDefrag_id)
                    .HasName("PK_indexDefragLog_v40");

                entity.ToTable("dba_indexDefragLog");

                entity.Property(e => e.databaseName).HasMaxLength(128);

                entity.Property(e => e.dateTimeEnd).HasColumnType("datetime");

                entity.Property(e => e.dateTimeStart).HasColumnType("datetime");

                entity.Property(e => e.errorMessage)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.indexName).HasMaxLength(128);

                entity.Property(e => e.objectName).HasMaxLength(128);

                entity.Property(e => e.sqlStatement)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dba_indexDefragStatus>(entity =>
            {
                entity.HasKey(e => new { e.databaseID, e.objectID, e.indexID, e.partitionNumber })
                    .HasName("PK_indexDefragStatus_v40");

                entity.ToTable("dba_indexDefragStatus");

                entity.Property(e => e.databaseName).HasMaxLength(128);

                entity.Property(e => e.defragDate).HasColumnType("datetime");

                entity.Property(e => e.indexName).HasMaxLength(128);

                entity.Property(e => e.objectName).HasMaxLength(128);

                entity.Property(e => e.scanDate).HasColumnType("datetime");

                entity.Property(e => e.schemaName).HasMaxLength(128);
            });

            modelBuilder.Entity<vBottom10Dept>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBottom10Depts");

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.EndDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<vBottom10DeptsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBottom10DeptsPrice");

                entity.Property(e => e.Department).HasMaxLength(10);
            });

            modelBuilder.Entity<vBottom10Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBottom10Items");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);
            });

            modelBuilder.Entity<vBottom10ItemsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBottom10ItemsPrice");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);
            });

            modelBuilder.Entity<vButtonMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vButtonMenu");

                entity.Property(e => e.Menu).HasMaxLength(20);
            });

            modelBuilder.Entity<vContentLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vContentLink");

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<vCreditBatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCreditBatch");
            });

            modelBuilder.Entity<vDBFileHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDBFileHeader");

                entity.Property(e => e.FileDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(50);
            });

            modelBuilder.Entity<vDisplaySchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDisplaySchedule");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.PlayListName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<vItemLabel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemLabel");

                entity.Property(e => e.ItemDescription).HasMaxLength(30);

                entity.Property(e => e.UPC).HasMaxLength(32);
            });

            modelBuilder.Entity<vItemLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemLink");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.ItemName).HasMaxLength(450);

                entity.Property(e => e.NameReplace).HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(1000);
            });

            modelBuilder.Entity<vMenuSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMenuSchedule");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<vPlayListItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPlayListItem");

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.MediaType).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<vSaleItemLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSaleItemLink");

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Expr1).HasMaxLength(32);

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);
            });

            modelBuilder.Entity<vTop10Dept>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTop10Depts");

                entity.Property(e => e.Department).HasMaxLength(10);
            });

            modelBuilder.Entity<vTop10DeptsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTop10DeptsPrice");

                entity.Property(e => e.Department).HasMaxLength(10);
            });

            modelBuilder.Entity<vTop10Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTop10Items");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);
            });

            modelBuilder.Entity<vTop10ItemsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTop10ItemsPrice");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
