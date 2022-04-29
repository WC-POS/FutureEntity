using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _Calendar
    {
        public DateTime Date { get; set; }
        public byte? Day { get; set; }
        public byte? Month { get; set; }
        public DateTime? FirstOfMonth { get; set; }
        public string? MonthName { get; set; }
        public byte? Week { get; set; }
        public byte? DayOfWeek { get; set; }
        public byte? Quarter { get; set; }
        public short? Year { get; set; }
        public DateTime? FirstOfYear { get; set; }
    }
}
