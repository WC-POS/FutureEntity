using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DashBoardSetting
    {
        public Guid DashBoardSettingsID { get; set; }
        public string DashFieldName { get; set; } = null!;
        public string DashFieldValue { get; set; } = null!;
        public int IsActive { get; set; }
        public DateTime? CreateStamp { get; set; }
        public DateTime? UpdateStamp { get; set; }
        public Guid dashItemPanelID { get; set; }
        public int StoreID { get; set; }
    }
}
