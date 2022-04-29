using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ItemRank
    {
        public Guid ItemRankID { get; set; }
        public Guid ItemID { get; set; }
        public int Rank { get; set; }
    }
}
