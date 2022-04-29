using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class vSaleItemLink
    {
        public Guid SaleID { get; set; }
        public Guid SaleItemID { get; set; }
        public string? ItemName { get; set; }
        public DateTime? EndDate { get; set; }
        public string? ReceiptDescription { get; set; }
        public short Quantity { get; set; }
        public string Expr1 { get; set; } = null!;
        public string? Department { get; set; }
        public int ActualPrice { get; set; }
        public bool IsSuspend { get; set; }
        public short EmpID { get; set; }
        public int Total { get; set; }
        public int SubTotal { get; set; }
    }
}
