using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TerminalConfiguration
    {
        public Guid TerminalConfigurationID { get; set; }
        public short TerminalNumber { get; set; }
        public DateTime LastUpdate { get; set; }
        public int StoreID { get; set; }
        public string? ConfigurationXML { get; set; }
    }
}
