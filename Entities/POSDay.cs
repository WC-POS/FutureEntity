using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class POSDay
    {
        public Guid POSDayID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StartEmpID { get; set; }
        public int EndEmpID { get; set; }
        public int BankDeposit { get; set; }
        public string? Comment { get; set; }
        public int StoreID { get; set; }
    }
}
