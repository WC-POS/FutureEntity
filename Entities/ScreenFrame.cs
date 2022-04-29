using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenFrame
    {
        public Guid ScreenFrameID { get; set; }
        public Guid ScreenID { get; set; }
        public int ScreenFrameIndex { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }

        public virtual Screen Screen { get; set; } = null!;
    }
}
