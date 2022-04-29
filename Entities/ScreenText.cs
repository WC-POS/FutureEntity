using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenText
    {
        public ScreenText()
        {
            ScreenTextTranslations = new HashSet<ScreenTextTranslation>();
        }

        public Guid ScreenTextID { get; set; }
        public Guid ScreenID { get; set; }
        public int ScreenTextIndex { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public string? Text { get; set; }
        public int FontSize { get; set; }

        public virtual Screen Screen { get; set; } = null!;
        public virtual ICollection<ScreenTextTranslation> ScreenTextTranslations { get; set; }
    }
}
