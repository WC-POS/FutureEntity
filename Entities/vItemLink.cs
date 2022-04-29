using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class vItemLink
    {
        public string ItemName { get; set; } = null!;
        public int IconIndex { get; set; }
        public Guid MenuPageLinkID { get; set; }
        public DateTime? CreateStamp { get; set; }
        public int IsActive { get; set; }
        public Guid MenuPageItemID { get; set; }
        public Guid MenuPageGroupID { get; set; }
        public int OrderIndex { get; set; }
        public string Notes { get; set; } = null!;
        public Guid MenuPageID { get; set; }
        public string NameReplace { get; set; } = null!;
    }
}
