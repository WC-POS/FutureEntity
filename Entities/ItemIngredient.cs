using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ItemIngredient
    {
        public Guid ItemIngredientID { get; set; }
        public Guid ItemID { get; set; }
        public string IngredientName { get; set; } = null!;
        public int IngredientIndex { get; set; }
        public int UnitCount { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
