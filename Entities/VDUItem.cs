using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class VDUItem
    {
        public Guid VDUItemID { get; set; }
        public Guid VDUID { get; set; }
        public int TransactionType { get; set; }
        public int BasePrice { get; set; }
        public string? Description { get; set; }
        public short Quantity { get; set; }
        public bool IsModifier { get; set; }
        public int ParentIndex { get; set; }
        public int ItemIndex { get; set; }
        public string? ItemName { get; set; }
        public short Flags { get; set; }
        public int CourseFireDateOffset { get; set; }
        public short CourseFireDelay { get; set; }
        public Guid SaleItemID { get; set; }
        public byte CourseNumber { get; set; }
        public string? Department { get; set; }

        public virtual VDU VDU { get; set; } = null!;
    }
}
