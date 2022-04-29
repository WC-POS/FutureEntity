using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class VDU
    {
        public VDU()
        {
            VDUItems = new HashSet<VDUItem>();
        }

        public Guid VDUID { get; set; }
        public int TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ToPrinterNumber { get; set; }
        public short TerminalNumber { get; set; }
        public int CheckNumber { get; set; }
        public int EmpID { get; set; }
        public byte OrderType { get; set; }
        public short TableIndex { get; set; }
        public int Total { get; set; }
        public string? CustomerName { get; set; }
        public int CustomerCount { get; set; }
        public int SubTotal { get; set; }
        public DateTime? PromiseTime { get; set; }
        public byte CheckStatus { get; set; }
        public short OrderTakerEmpID { get; set; }
        public string? CheckDescription { get; set; }

        public virtual ICollection<VDUItem> VDUItems { get; set; }
    }
}
