using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CompulsoryEntree
    {
        public Guid CompulsoryEntreeID { get; set; }
        public string CompulsoryEntreeDepartment { get; set; } = null!;
        public int Index { get; set; }
        public int StoreID { get; set; }
    }
}
