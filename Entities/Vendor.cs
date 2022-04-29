using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Vendor
    {
        public Vendor()
        {
            VendorPurchases = new HashSet<VendorPurchase>();
        }

        public Guid VendorID { get; set; }
        public int StoreID { get; set; }
        public string VendorName { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Notes { get; set; }

        public virtual ICollection<VendorPurchase> VendorPurchases { get; set; }
    }
}
