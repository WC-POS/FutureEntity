using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenButtonTranslation
    {
        public Guid ScreenButtonTranslationID { get; set; }
        public Guid ScreenButtonID { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual ScreenButton ScreenButton { get; set; } = null!;
    }
}
