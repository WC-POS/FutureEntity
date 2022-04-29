using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class BackupSetting
    {
        public Guid BackupSettingsID { get; set; }
        public string ZipKey { get; set; } = null!;
        public DateTime BackupTime { get; set; }
        public string BackupName { get; set; } = null!;
        public bool Enabled { get; set; }
        public string EmailOnCompletion { get; set; } = null!;
        public string EmailOnFailure { get; set; } = null!;
    }
}
