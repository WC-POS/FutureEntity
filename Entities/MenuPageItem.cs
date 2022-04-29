using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MenuPageItem
    {
        public Guid MenuPageItemID { get; set; }
        public int IsActive { get; set; }
        public DateTime? CreateStamp { get; set; }
        public string ItemName { get; set; } = null!;
        public string Executable { get; set; } = null!;
        public int ExecutableType { get; set; }
        public string ClassColumnName { get; set; } = null!;
        public Guid MenuPageGroupID { get; set; }
        public int SecLevel { get; set; }
        public int IconIndex { get; set; }
        public int OrderIndex { get; set; }
        public int DisplayMode { get; set; }
    }
}
