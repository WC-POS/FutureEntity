using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PAlert
    {
        public PAlert()
        {
            PAlertSettings = new HashSet<PAlertSetting>();
            PAlertTos = new HashSet<PAlertTo>();
        }

        public Guid AlertID { get; set; }
        public int StoreID { get; set; }
        public string AlertName { get; set; } = null!;
        public string AlertType { get; set; } = null!;
        public string? AdditionalEmail { get; set; }
        public DateTime? LastRun { get; set; }
        public bool IsEnabled { get; set; }
        public string ScheduleData { get; set; } = null!;
        public bool ClockedInOnly { get; set; }
        public int FormatType { get; set; }
        public bool RunImmediately { get; set; }

        public virtual ICollection<PAlertSetting> PAlertSettings { get; set; }
        public virtual ICollection<PAlertTo> PAlertTos { get; set; }
    }
}
