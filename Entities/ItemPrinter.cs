using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ItemPrinter
    {
        public Guid ItemPrinterID { get; set; }
        public Guid ItemID { get; set; }
        public int PrinterIndex { get; set; }
        public string? ReceiptDescription { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
