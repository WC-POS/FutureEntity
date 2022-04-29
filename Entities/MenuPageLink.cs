using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MenuPageLink
    {
        public Guid MenuPageLinkID { get; set; }
        public DateTime? CreateStamp { get; set; }
        public int IsActive { get; set; }
        public Guid MenuPageItemID { get; set; }
        public Guid MenuPageGroupID { get; set; }
        public int OrderIndex { get; set; }
        public string Notes { get; set; } = null!;
        public string NameReplace { get; set; } = null!;
    }
}
