using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DinePointOrderType
    {
        public int OrderTypeIndex { get; set; }
        public int StoreID { get; set; }
        public string? OrderType { get; set; }
        public int ForgiveTax { get; set; }
    }
}
