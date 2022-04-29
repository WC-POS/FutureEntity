using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _vBucketDataBySection
    {
        public decimal SaleTotal { get; set; }
        public decimal GiftCertificateTotal { get; set; }
        public decimal BankGiftCardTotal { get; set; }
        public decimal LevelUpGiftCardTotal { get; set; }
        public decimal CustomerPaymentTotal { get; set; }
        public decimal VoidTotal { get; set; }
        public decimal RegWages { get; set; }
        public decimal RegHours { get; set; }
        public decimal OTWages { get; set; }
        public decimal OTHours { get; set; }
        public decimal MealWages { get; set; }
        public decimal MealHours { get; set; }
        public int? StoreID { get; set; }
        public int? Section { get; set; }
        public DateTime? BucketDate { get; set; }
        public int? BucketHour { get; set; }
        public int? BucketDay { get; set; }
        public int? BucketMonth { get; set; }
    }
}
