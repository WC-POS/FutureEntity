using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _vSalesForEmployeeBucket
    {
        public Guid ID { get; set; }
        public decimal? SaleTotal { get; set; }
        public decimal? SaleCount { get; set; }
        public decimal? CustomerCount { get; set; }
        public decimal? TaxTotal { get; set; }
        public decimal? GiftCertificateTotal { get; set; }
        public decimal? BankGiftCardTotal { get; set; }
        public decimal? LevelUpGiftCardTotal { get; set; }
        public decimal? CustomerPaymentTotal { get; set; }
        public decimal? ServiceChargeTotal { get; set; }
        public decimal? DriverServiceChargeTotal { get; set; }
        public decimal? VoidTotal { get; set; }
        public decimal? CashTips { get; set; }
        public decimal? ChargeTips { get; set; }
        public decimal? OtherTips { get; set; }
        public decimal? DeclaredTipsDirect { get; set; }
        public decimal? DeclaredTipsIndirect { get; set; }
        public decimal? ChargedCardTendersWithTips { get; set; }
        public decimal? TenderTotal { get; set; }
        public DateTime? BucketDate { get; set; }
        public int? HourOfDay { get; set; }
        public int? EmpID { get; set; }
        public int StoreID { get; set; }
        public string? ServingPeriod { get; set; }
        public DateTime? LastUpdated { get; set; }
        public bool? Dirty { get; set; }
    }
}
