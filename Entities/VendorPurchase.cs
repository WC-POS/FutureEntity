using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class VendorPurchase
    {
        public Guid VendorPurchaseID { get; set; }
        public int StoreID { get; set; }
        public Guid? VendorID { get; set; }
        public string ItemName { get; set; } = null!;
        public int ItemCount { get; set; }
        public DateTime ReceivedDate { get; set; }
        public bool IsRemoval { get; set; }
        public string DepartmentName { get; set; } = null!;

        public virtual Vendor? Vendor { get; set; }
    }
}
