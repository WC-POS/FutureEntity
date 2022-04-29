using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class IngredientInventory
    {
        public Guid IngredientInventoryID { get; set; }
        public int IngredientInventoryIndex { get; set; }
        public Guid IngredientID { get; set; }
        public string Location { get; set; } = null!;
        public int UnitCount { get; set; }
        public int PackageCount { get; set; }
        public int CaseCount { get; set; }

        public virtual Ingredient Ingredient { get; set; } = null!;
    }
}
