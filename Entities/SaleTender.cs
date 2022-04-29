using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SaleTender
    {
        public Guid SaleTenderID { get; set; }
        public Guid SaleID { get; set; }
        public int TenderIndex { get; set; }
        public int MediaIndex { get; set; }
        public int Amount { get; set; }
        public int ForeignIndex { get; set; }
        public int ForeignAmount { get; set; }
        public int Customer { get; set; }
        public int EmployeeTip { get; set; }
        public int HouseTip { get; set; }
        public bool UseTipCalc { get; set; }
        public Guid? SignatureID { get; set; }
        public string? MediaMemo { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
