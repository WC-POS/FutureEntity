using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SaleMedium
    {
        public Guid SaleMediaID { get; set; }
        public Guid SaleID { get; set; }
        public int MediaIndex { get; set; }
        public int Amount { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
