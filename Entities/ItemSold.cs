using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ItemSold
    {
        public Guid ItemSoldID { get; set; }
        public int StoreID { get; set; }
        public DateTime SoldDate { get; set; }
        public int Quantity { get; set; }
        public string ItemName { get; set; } = null!;
        public string ItemDescription { get; set; } = null!;
        public string Department { get; set; } = null!;
        public int TerminalNumber { get; set; }
        public int TableNumber { get; set; }
        public int EmpID { get; set; }
        public int CheckNumber { get; set; }
        public int SupervisorID { get; set; }
        public bool IsModifier { get; set; }
        public int Price { get; set; }
    }
}
