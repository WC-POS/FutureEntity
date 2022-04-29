using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _vLaborByServingPeriod
    {
        public decimal? RegWages { get; set; }
        public decimal? RegHours { get; set; }
        public decimal OTWages { get; set; }
        public decimal OTHours { get; set; }
        public decimal MealWages { get; set; }
        public decimal MealHours { get; set; }
        public DateTime? BucketDate { get; set; }
        public string? ServingPeriod { get; set; }
        public int? BucketHour { get; set; }
        public int? BucketDay { get; set; }
        public int? BucketMonth { get; set; }
    }
}
