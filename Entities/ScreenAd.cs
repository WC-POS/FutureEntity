using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenAd
    {
        public Guid ScreenAdID { get; set; }
        public Guid ScreenID { get; set; }
        public int ScreenAdIndex { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public int Duration { get; set; }
        public int Stretch { get; set; }
        public int Transition { get; set; }
        public string? Location { get; set; }

        public virtual Screen Screen { get; set; } = null!;
    }
}
