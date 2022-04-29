using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class JobCodeDeptMask
    {
        public Guid JobCodeDeptMaskID { get; set; }
        public Guid JobCodeID { get; set; }
        public string Mask { get; set; } = null!;
        public int? Index { get; set; }

        public virtual JobCode JobCode { get; set; } = null!;
    }
}
