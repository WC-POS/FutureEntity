using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenKioskMenuPreviousButtonTextTranslation
    {
        public Guid ScreenKioskMenuPreviousButtonTextTranslationID { get; set; }
        public Guid ScreenKioskMenuID { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual ScreenKioskMenu ScreenKioskMenu { get; set; } = null!;
    }
}
