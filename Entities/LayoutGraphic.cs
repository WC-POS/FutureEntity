using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class LayoutGraphic
    {
        public Guid LayoutGraphicID { get; set; }
        public Guid LayoutID { get; set; }
        public int GraphicIndex { get; set; }
        public short RoomIndex { get; set; }

        public virtual Layout Layout { get; set; } = null!;
    }
}
