using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenAutoMenu
    {
        public ScreenAutoMenu()
        {
            ScreenAutoMenuFilters = new HashSet<ScreenAutoMenuFilter>();
            ScreenAutoMenuNextButtonTextTranslations = new HashSet<ScreenAutoMenuNextButtonTextTranslation>();
            ScreenAutoMenuPagingButtonSettings = new HashSet<ScreenAutoMenuPagingButtonSetting>();
            ScreenAutoMenuPreviousButtonTextTranslations = new HashSet<ScreenAutoMenuPreviousButtonTextTranslation>();
        }

        public Guid ScreenAutoMenuID { get; set; }
        public Guid ScreenID { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public string? ScreenAutoMenuName { get; set; }
        public int ScreenAutoMenuIndex { get; set; }
        public short ButtonHorizontalSpacing { get; set; }
        public short ButtonVerticalSpacing { get; set; }
        public byte PagingStyle { get; set; }
        public byte DepartmentStyle { get; set; }
        public bool GroupFilters { get; set; }
        public string? PreviousButtonText { get; set; }
        public string? NextButtonText { get; set; }
        public string? ItemTextSource { get; set; }
        public string? DepartmentTextSource { get; set; }
        public bool? AllowItemGraphicOverride { get; set; }
        public bool? AutoSizeSpacingInEditor { get; set; }
        public int MenuButtonHorizontalSpacing { get; set; }
        public int MenuButtonVerticalSpacing { get; set; }
        public int MenuSeparation { get; set; }
        public decimal Opacity { get; set; }

        public virtual Screen Screen { get; set; } = null!;
        public virtual ICollection<ScreenAutoMenuFilter> ScreenAutoMenuFilters { get; set; }
        public virtual ICollection<ScreenAutoMenuNextButtonTextTranslation> ScreenAutoMenuNextButtonTextTranslations { get; set; }
        public virtual ICollection<ScreenAutoMenuPagingButtonSetting> ScreenAutoMenuPagingButtonSettings { get; set; }
        public virtual ICollection<ScreenAutoMenuPreviousButtonTextTranslation> ScreenAutoMenuPreviousButtonTextTranslations { get; set; }
    }
}
