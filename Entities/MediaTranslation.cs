using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MediaTranslation
    {
        public Guid MediaTranslationID { get; set; }
        public Guid MediaID { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Medium Media { get; set; } = null!;
    }
}
