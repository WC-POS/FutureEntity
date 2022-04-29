using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _vSaleSubCreditCardSum
    {
        public byte MediaIndex { get; set; }
        public int? EmployeeTips { get; set; }
        public int? HouseTips { get; set; }
        public Guid SaleID { get; set; }
        public int StoreID { get; set; }
        public short StartTerminalNumber { get; set; }
        public short TerminalNumber { get; set; }
        public byte SaleSection { get; set; }
        public short TableIndex { get; set; }
        public byte RevenueCenter { get; set; }
        public bool IsCombined { get; set; }
        public byte IsCancelled { get; set; }
        public byte IsTrainMode { get; set; }
        public byte WasRefunded { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
