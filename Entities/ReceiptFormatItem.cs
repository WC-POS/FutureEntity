using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ReceiptFormatItem
    {
        public Guid ReceiptFormatItemID { get; set; }
        public Guid ReceiptFormatID { get; set; }
        public string ReceiptName { get; set; } = null!;
        public string? Format { get; set; }

        public virtual ReceiptFormat ReceiptFormat { get; set; } = null!;
    }
}
