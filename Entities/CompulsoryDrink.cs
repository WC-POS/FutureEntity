using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CompulsoryDrink
    {
        public Guid CompulsoryDrinkID { get; set; }
        public string CompulsoryDrinkDepartment { get; set; } = null!;
        public int Index { get; set; }
        public int StoreID { get; set; }
    }
}
