using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ConfigurationSecure
    {
        public Guid ConfigurationSecureID { get; set; }
        public int StoreID { get; set; }
        public int TerminalNumber { get; set; }
        public string Section { get; set; } = null!;
        public string Parameter { get; set; } = null!;
        public int ParameterIndex { get; set; }
        public byte[] Value { get; set; } = null!;
        public int ParameterIndex2 { get; set; }
        public int DataType { get; set; }
        public Guid? DeviceID { get; set; }
    }
}
