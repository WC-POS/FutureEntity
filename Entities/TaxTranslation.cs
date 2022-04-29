using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TaxTranslation
    {
        public Guid TaxTranslationID { get; set; }
        public Guid TaxID { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Tax Tax { get; set; } = null!;
    }
}
