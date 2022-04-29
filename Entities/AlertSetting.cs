using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class AlertSetting
    {
        public Guid AlertSettingsID { get; set; }
        public string AlertFieldName { get; set; } = null!;
        public string AlertFieldValue { get; set; } = null!;
        public int IsActive { get; set; }
        public DateTime CreateStamp { get; set; }
        public DateTime UpdateStamp { get; set; }
        public Guid AlertID { get; set; }
    }
}
