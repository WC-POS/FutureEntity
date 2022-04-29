using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _vLaborBucket
    {
        public Guid ID { get; set; }
        public decimal? HoursWorked { get; set; }
        public decimal? WagesPaid { get; set; }
        public DateTime? BucketDate { get; set; }
        public int? HourOfDay { get; set; }
        public int? WorkCenter { get; set; }
        public string? HourType { get; set; }
        public int? EmpID { get; set; }
        public int StoreID { get; set; }
        public string? ServingPeriod { get; set; }
        public DateTime? LastUpdated { get; set; }
        public bool? Dirty { get; set; }
    }
}
