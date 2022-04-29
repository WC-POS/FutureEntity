using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenHelp
    {
        public Guid ScreenHelpID { get; set; }
        public Guid ScreenID { get; set; }
        public int ScreenHelpIndex { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public string? Topic { get; set; }

        public virtual Screen Screen { get; set; } = null!;
    }
}
