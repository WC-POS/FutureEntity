using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class LayoutTable
    {
        public Guid LayoutTableID { get; set; }
        public Guid LayoutID { get; set; }
        public int TableIndex { get; set; }
        public string TableName { get; set; } = null!;
        public byte ShapeType { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public byte SeatCount { get; set; }
        public int SectionIndex { get; set; }
        public bool IsNonSmoking { get; set; }
        public int JoinTableIndex { get; set; }
        public bool IsX10Enabled { get; set; }
        public byte X10HouseCode { get; set; }
        public byte X10DeviceCode { get; set; }
        public int RoomIndex { get; set; }

        public virtual Layout Layout { get; set; } = null!;
    }
}
