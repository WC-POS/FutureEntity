using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PunchPair
    {
        public Guid PunchPairID { get; set; }
        public Guid? PunchPairShiftID { get; set; }
        public Guid? PunchPairJobCodeID { get; set; }
        public short EmpID { get; set; }
        public int? StoreID { get; set; }
        public DateTime ShiftDate { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime? RoundedTimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public DateTime? RoundedTimeOut { get; set; }
        public DateTime PayPeriodStart { get; set; }
        public DateTime PayPeriodEnd { get; set; }
        public byte JobCode { get; set; }
        public short InType { get; set; }
        public short? OutType { get; set; }
        public int? BreakIndex { get; set; }
        public decimal RegHours { get; set; }
        public decimal OTHours { get; set; }
        public decimal MealHours { get; set; }
        public decimal RegRate { get; set; }
        public decimal OTRate { get; set; }
        public bool IsDirty { get; set; }
        public string? JobCodeDescription { get; set; }
        public bool IsBreakPaid { get; set; }
        public Guid ShiftID { get; set; }
        public Guid JobCodeSpanID { get; set; }
        public Guid? LaborRuleID { get; set; }
        public decimal Hours { get; set; }
        public decimal Rate { get; set; }
        public decimal Wages { get; set; }
        public bool IsOpen { get; set; }
        public bool IsMeal { get; set; }
        public DateTime? NonRoundedTimeIn { get; set; }
        public DateTime? NonRoundedTimeOut { get; set; }
        public DateTime PayWeekStart { get; set; }
        public DateTime PayWeekEnd { get; set; }
    }
}
