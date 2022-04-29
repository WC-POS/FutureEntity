using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            IngredientInventories = new HashSet<IngredientInventory>();
        }

        public Guid IngredientID { get; set; }
        public int StoreID { get; set; }
        public string IngredientName { get; set; } = null!;
        public string IngredientDescription { get; set; } = null!;
        public string Vendor { get; set; } = null!;
        public byte MeasureType { get; set; }
        public int UnitsInPackage { get; set; }
        public int PackagesInCase { get; set; }
        public int CostPerUnit { get; set; }
        public int ReorderUnitAt { get; set; }
        public int ReorderPackageAt { get; set; }
        public int ReorderCaseAt { get; set; }
        public int ReorderUnitQuantity { get; set; }
        public int ReorderPackageQuantity { get; set; }
        public int ReorderCaseQuantity { get; set; }
        public string? CaseName { get; set; }
        public string? PackageName { get; set; }
        public string Department { get; set; } = null!;
        public int RetailPerUnit { get; set; }

        public virtual ICollection<IngredientInventory> IngredientInventories { get; set; }
    }
}
