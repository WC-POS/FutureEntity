using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SecurityCheck
    {
        public Guid SecurityCheckID { get; set; }
        public int Type { get; set; }
        public byte[]? Path { get; set; }
        public byte[]? FileName { get; set; }
    }
}
