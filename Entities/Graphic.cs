using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Graphic
    {
        public Guid GraphicID { get; set; }
        public int StoreID { get; set; }
        public string GraphicName { get; set; } = null!;
        public byte[] DibData { get; set; } = null!;
        public int GraphicType { get; set; }
    }
}
