using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PrepTime
    {
        public Guid PrepTimeID { get; set; }
        public int StoreID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Quantity { get; set; }
        public string ItemName { get; set; } = null!;
    }
}
