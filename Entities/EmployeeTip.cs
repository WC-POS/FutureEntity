using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class EmployeeTip
    {
        public Guid EmployeeTipID { get; set; }
        public int StoreID { get; set; }
        public short IsFinalized { get; set; }
        public int EmpID { get; set; }
        public int CheckNumber { get; set; }
        public short MediaIndex { get; set; }
        public int Amount { get; set; }
        public int Declared { get; set; }
        public DateTime TipDate { get; set; }
        public int SharedEmpID { get; set; }
        public bool IsEndOfShift { get; set; }
    }
}
