using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenAutoMenuNextButtonTextTranslation
    {
        public Guid ScreenAutoMenuNextButtonTextTranslationID { get; set; }
        public Guid ScreenAutoMenuID { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual ScreenAutoMenu ScreenAutoMenu { get; set; } = null!;
    }
}
