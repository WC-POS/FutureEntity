using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenEdit
    {
        public Guid ScreenEditID { get; set; }
        public Guid ScreenID { get; set; }
        public int ScreenEditIndex { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public int FontSize { get; set; }

        public virtual Screen Screen { get; set; } = null!;
    }
}
