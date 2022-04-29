using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenButton
    {
        public ScreenButton()
        {
            ScreenButtonTranslations = new HashSet<ScreenButtonTranslation>();
        }

        public Guid ScreenButtonID { get; set; }
        public Guid ScreenID { get; set; }
        public int ScreenButtonIndex { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public string? ImageName { get; set; }
        public string? Text { get; set; }
        public int? Data1 { get; set; }

        public virtual Screen Screen { get; set; } = null!;
        public virtual ICollection<ScreenButtonTranslation> ScreenButtonTranslations { get; set; }
    }
}
