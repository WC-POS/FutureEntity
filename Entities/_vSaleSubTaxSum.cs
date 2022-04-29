using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _vSaleSubTaxSum
    {
        public int TaxIndex { get; set; }
        public int? OriginalTax { get; set; }
        public int? WorkTax { get; set; }
        public byte TogoFTax { get; set; }
        public byte ForgiveTaxMask { get; set; }
        public byte OrderType { get; set; }
        public short StartTerminalNumber { get; set; }
        public byte SaleSection { get; set; }
        public byte RevenueCenter { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCombined { get; set; }
        public int StoreID { get; set; }
        public Guid SaleID { get; set; }
        public short TerminalNumber { get; set; }
        public short TableIndex { get; set; }
        public byte IsCancelled { get; set; }
        public byte IsTrainMode { get; set; }
        public byte WasRefunded { get; set; }
        public DateTime StartDate { get; set; }
    }
}
