using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DashBoardItem
    {
        public Guid DashBoardItemID { get; set; }
        public DateTime? CreateStamp { get; set; }
        public int IsActive { get; set; }
        public Guid DasboardItemType { get; set; }
        public string DasboardItemName { get; set; } = null!;
        public int RefreshInterval { get; set; }
        public Guid DockingCellID { get; set; }
        public int StoreID { get; set; }
    }
}
