using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SalePM
    {
        public Guid SalePMSID { get; set; }
        public Guid SaleID { get; set; }
        public int PMSIndex { get; set; }
        public string? AccountNumber { get; set; }
        public int AuthAmount { get; set; }
        public int EmployeeTip { get; set; }
        public int HouseTip { get; set; }
        public int MediaIndex { get; set; }
        public string? GuestName { get; set; }
        public int Gratuity { get; set; }
        public int Discount { get; set; }
        public int Bucket1 { get; set; }
        public int Bucket2 { get; set; }
        public int Bucket3 { get; set; }
        public int Bucket4 { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
