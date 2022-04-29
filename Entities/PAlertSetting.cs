using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PAlertSetting
    {
        public Guid AlertSettingID { get; set; }
        public Guid AlertID { get; set; }
        public string Setting { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual PAlert Alert { get; set; } = null!;
    }
}
