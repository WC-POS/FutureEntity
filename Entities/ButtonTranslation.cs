using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ButtonTranslation
    {
        public Guid ButtonTranslationID { get; set; }
        public Guid ButtonID { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Button Button { get; set; } = null!;
    }
}
