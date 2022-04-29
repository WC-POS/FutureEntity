using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SaleTax
    {
        public Guid SaleTaxID { get; set; }
        public Guid SaleID { get; set; }
        public int TaxIndex { get; set; }
        public int WorkTax { get; set; }
        public int OrigionalTax { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
