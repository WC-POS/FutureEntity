using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MenuPageGroup
    {
        public Guid MenuPageGroupID { get; set; }
        public int IsActive { get; set; }
        public Guid MenuPageID { get; set; }
        public DateTime? CreateStamp { get; set; }
        public string GroupName { get; set; } = null!;
        public int GroupFunctionType { get; set; }
        public int ParentMenuPageGroupID { get; set; }
        public int SecLevel { get; set; }
        public int OrderIndex { get; set; }
        public int DisplayMode { get; set; }

        public virtual MenuPage MenuPage { get; set; } = null!;
    }
}
