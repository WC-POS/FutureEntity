using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class LayoutRoom
    {
        public Guid LayoutRoomID { get; set; }
        public Guid LayoutID { get; set; }
        public int RoomIndex { get; set; }
        public string RoomName { get; set; } = null!;
        public string ImageFile { get; set; } = null!;
        public short PriceLevel { get; set; }

        public virtual Layout Layout { get; set; } = null!;
    }
}
