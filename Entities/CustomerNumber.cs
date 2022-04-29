using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CustomerNumber
    {
        public Guid CustomerNumberID { get; set; }
        public Guid RegionID { get; set; }
        public int CustomerNumber1 { get; set; }
    }
}
