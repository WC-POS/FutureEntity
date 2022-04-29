using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Screen
    {
        public Screen()
        {
            ScreenAds = new HashSet<ScreenAd>();
            ScreenAutoMenus = new HashSet<ScreenAutoMenu>();
            ScreenBanners = new HashSet<ScreenBanner>();
            ScreenBitmaps = new HashSet<ScreenBitmap>();
            ScreenButtons = new HashSet<ScreenButton>();
            ScreenEdits = new HashSet<ScreenEdit>();
            ScreenFrames = new HashSet<ScreenFrame>();
            ScreenHelps = new HashSet<ScreenHelp>();
            ScreenKioskMenus = new HashSet<ScreenKioskMenu>();
            ScreenLists = new HashSet<ScreenList>();
            ScreenTexts = new HashSet<ScreenText>();
        }

        public Guid ScreenID { get; set; }
        public Guid RegionID { get; set; }
        public int ScreenIndex { get; set; }
        public string ScreenName { get; set; } = null!;
        public bool IsRequired { get; set; }
        public string BitmapFile { get; set; } = null!;
        public int ScreenType { get; set; }

        public virtual ICollection<ScreenAd> ScreenAds { get; set; }
        public virtual ICollection<ScreenAutoMenu> ScreenAutoMenus { get; set; }
        public virtual ICollection<ScreenBanner> ScreenBanners { get; set; }
        public virtual ICollection<ScreenBitmap> ScreenBitmaps { get; set; }
        public virtual ICollection<ScreenButton> ScreenButtons { get; set; }
        public virtual ICollection<ScreenEdit> ScreenEdits { get; set; }
        public virtual ICollection<ScreenFrame> ScreenFrames { get; set; }
        public virtual ICollection<ScreenHelp> ScreenHelps { get; set; }
        public virtual ICollection<ScreenKioskMenu> ScreenKioskMenus { get; set; }
        public virtual ICollection<ScreenList> ScreenLists { get; set; }
        public virtual ICollection<ScreenText> ScreenTexts { get; set; }
    }
}
