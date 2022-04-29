using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TaxTable
    {
        public Guid TaxTableID { get; set; }
        public Guid TaxID { get; set; }
        public int TaxTableIndex { get; set; }
        public int UpToAmount { get; set; }
        public int TaxAmount { get; set; }

        public virtual Tax Tax { get; set; } = null!;
    }
}
