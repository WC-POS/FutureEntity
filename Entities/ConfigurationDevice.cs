using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ConfigurationDevice
    {
        public Guid ConfigurationDeviceID { get; set; }
        public int Type { get; set; }
        public string Name { get; set; } = null!;
        public int Number { get; set; }
        public int StoreID { get; set; }
        public int SettingsType { get; set; }
        public int TerminalNumber { get; set; }
    }
}
