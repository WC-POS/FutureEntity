using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ReceiptFormat
    {
        public ReceiptFormat()
        {
            ReceiptFormatItems = new HashSet<ReceiptFormatItem>();
        }

        public Guid ReceiptFormatID { get; set; }
        public int StoreID { get; set; }
        public int TerminalNumber { get; set; }
        public int ReceiptType { get; set; }

        public virtual ICollection<ReceiptFormatItem> ReceiptFormatItems { get; set; }
    }
}
