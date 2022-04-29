using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DinePointJobCode
    {
        public int JobCodeIndex { get; set; }
        public int StoreID { get; set; }
        public string JobCodeName { get; set; } = null!;
    }
}
