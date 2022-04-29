using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _vPunchPairByJobCode
    {
        public Guid JobCodeSpanID { get; set; }
        public Guid ShiftID { get; set; }
        public short EmpID { get; set; }
        public byte JobCode { get; set; }
        public string? JobCodeDescription { get; set; }
        public int? StoreID { get; set; }
        public DateTime ShiftDate { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? NonRoundedTimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public DateTime? NonRoundedTimeOut { get; set; }
        public decimal? RegHours { get; set; }
        public decimal? OTHours { get; set; }
        public decimal? MealHours { get; set; }
        public decimal? RegWages { get; set; }
        public decimal? OTWages { get; set; }
        public int? PunchPairCount { get; set; }
    }
}
