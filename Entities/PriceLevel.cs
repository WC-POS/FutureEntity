using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PriceLevel
    {
        public Guid PriceLevelID { get; set; }
        public int StoreID { get; set; }
        public int PriceLevelIndex { get; set; }
        public string PriceLevelName { get; set; } = null!;
    }
}
