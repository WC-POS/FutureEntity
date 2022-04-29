using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _vSaleSubMediaSum
    {
        public byte OvertMedia { get; set; }
        public bool OvertenderIsTips { get; set; }
        public byte OvertenderOption { get; set; }
        public int MediaIndex { get; set; }
        public int? Amount { get; set; }
        public int? HeaderGratuityAmount { get; set; }
        public int? HeaderServiceChargeAmount { get; set; }
        public int? HeaderOvertAmount { get; set; }
        public int? RecordCount { get; set; }
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
        public DateTime StartDate { get; set; }
    }
}
