using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class EmployeeLaborGroupHistory
    {
        public Guid LaborGroupHistoryID { get; set; }
        public Guid LaborGroupID { get; set; }
        public DateTime Date { get; set; }
        public short EmpID { get; set; }
    }
}
