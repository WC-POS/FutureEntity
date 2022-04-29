using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenTextTranslation
    {
        public Guid ScreenTextTranslationID { get; set; }
        public Guid ScreenTextID { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual ScreenText ScreenText { get; set; } = null!;
    }
}
