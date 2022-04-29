using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TareImage
    {
        public Guid TareImageID { get; set; }
        public int StoreID { get; set; }
        public int TerminalNumber { get; set; }
        public int TareImageIndex { get; set; }
        public string ImageName { get; set; } = null!;
    }
}
