using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class vItemLabel
    {
        public string ItemDescription { get; set; } = null!;
        public string UPC { get; set; } = null!;
        public int DefaultPrice { get; set; }
    }
}
