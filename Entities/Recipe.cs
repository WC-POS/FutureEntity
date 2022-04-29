using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Recipe
    {
        public Guid RecipeID { get; set; }
        public Guid RegionID { get; set; }
        public string RecipeName { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public string Recipe1 { get; set; } = null!;
    }
}
