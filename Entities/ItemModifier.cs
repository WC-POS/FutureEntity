using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ItemModifier
    {
        public Guid ItemModifierID { get; set; }
        public Guid ItemID { get; set; }
        public int ModifierIndex { get; set; }
        public string ModifierName { get; set; } = null!;
        public bool IsSelected { get; set; }
        public bool IsWildcard { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
