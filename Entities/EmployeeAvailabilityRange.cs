using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class EmployeeAvailabilityRange
    {
        public Guid EmployeeAvailabilityRangeID { get; set; }
        public Guid EmployeeAvailabilityID { get; set; }
        public int RangeIndex { get; set; }
        public string RangeDescription { get; set; } = null!;
        public byte RangeType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual EmployeeAvailability EmployeeAvailability { get; set; } = null!;
    }
}
