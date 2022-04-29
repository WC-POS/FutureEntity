using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SaleItemDiscount
    {
        public Guid SaleItemDiscountID { get; set; }
        public Guid SaleItemID { get; set; }
        public short ItemIndex { get; set; }
        public int DiscountIndex { get; set; }
        public int Amount { get; set; }
        public int EmpID { get; set; }
        public int ApprovedByEmpID { get; set; }

        public virtual SaleItem SaleItem { get; set; } = null!;
    }
}
