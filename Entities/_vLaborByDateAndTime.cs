using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _vLaborByDateAndTime
    {
        public DateTime? LaborHour { get; set; }
        public decimal BreakHours { get; set; }
        public decimal BreakPaidHours { get; set; }
        public decimal RegHours { get; set; }
        public decimal OTHours { get; set; }
        public decimal MealHours { get; set; }
        public decimal BreakWages { get; set; }
        public decimal RegWages { get; set; }
        public decimal OTWages { get; set; }
    }
}
