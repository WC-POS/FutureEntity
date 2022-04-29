using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Total
    {
        public Guid TotalID { get; set; }
        public int StoreID { get; set; }
        public DateTime TotalDate { get; set; }
        public int TotalType { get; set; }
        public int CheckNumber { get; set; }
        public int TerminalNumber { get; set; }
        public int DrawerNumber { get; set; }
        public int TableNumber { get; set; }
        public int EmpID { get; set; }
        public int Amount { get; set; }
        public int CustomerNumber { get; set; }
        public int MediaIndex { get; set; }
        public string? Description { get; set; }
        public int Section { get; set; }
        public int RevenueCenter { get; set; }
        public int TipEmpID { get; set; }
    }
}
