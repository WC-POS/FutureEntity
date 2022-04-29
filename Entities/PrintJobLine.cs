using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PrintJobLine
    {
        public Guid PrintLineID { get; set; }
        public Guid PrintJobID { get; set; }
        public int LineIndex { get; set; }
        public string? Text { get; set; }
        public string? RightText { get; set; }
        public string? LeftText { get; set; }
        public int LineLength { get; set; }
        public int PrintOptions { get; set; }
        public string? ItemName { get; set; }
        public int Quantity { get; set; }
        public int Flags { get; set; }
        public int BergPLU { get; set; }
        public int ActualPrice { get; set; }
        public int BasePrice { get; set; }
        public byte VDUColor { get; set; }
        public int? ParentIndex { get; set; }
        public int? PEPLU { get; set; }
        public Guid? SaleItemID { get; set; }
        public Guid? SaleTenderID { get; set; }
        public Guid? SignatureID { get; set; }
        public int Language { get; set; }
        public string? SeparatedText { get; set; }

        public virtual PrintJob PrintJob { get; set; } = null!;
    }
}
