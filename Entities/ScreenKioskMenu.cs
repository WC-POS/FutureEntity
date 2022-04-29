using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenKioskMenu
    {
        public ScreenKioskMenu()
        {
            ScreenKioskMenuFilters = new HashSet<ScreenKioskMenuFilter>();
            ScreenKioskMenuNextButtonTextTranslations = new HashSet<ScreenKioskMenuNextButtonTextTranslation>();
            ScreenKioskMenuPreviousButtonTextTranslations = new HashSet<ScreenKioskMenuPreviousButtonTextTranslation>();
        }

        public Guid ScreenKioskMenuID { get; set; }
        public Guid ScreenID { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public string? KioskMenuName { get; set; }
        public int KioskMenuIndex { get; set; }
        public short ButtonHorizontalSpacing { get; set; }
        public short ButtonVerticalSpacing { get; set; }
        public short Type { get; set; }
        public int ButtonWidth { get; set; }
        public int ButtonHeight { get; set; }
        public int PageDirectionHeight { get; set; }
        public int PageDirectionWidth { get; set; }
        public int PageHorizontalSpacing { get; set; }
        public int PageVerticalSpacing { get; set; }
        public short PageNextDirection { get; set; }
        public short PagePreviousDirection { get; set; }
        public int PageSize { get; set; }
        public string? PageNextImageName { get; set; }
        public string? PagePreviousImageName { get; set; }
        public string? PageNextText { get; set; }
        public string? PagePreviousText { get; set; }
        public int GotoScreenIndex { get; set; }

        public virtual Screen Screen { get; set; } = null!;
        public virtual ICollection<ScreenKioskMenuFilter> ScreenKioskMenuFilters { get; set; }
        public virtual ICollection<ScreenKioskMenuNextButtonTextTranslation> ScreenKioskMenuNextButtonTextTranslations { get; set; }
        public virtual ICollection<ScreenKioskMenuPreviousButtonTextTranslation> ScreenKioskMenuPreviousButtonTextTranslations { get; set; }
    }
}
