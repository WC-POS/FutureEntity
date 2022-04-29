using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class EmployeeAvailability
    {
        public EmployeeAvailability()
        {
            EmployeeAvailabilityRanges = new HashSet<EmployeeAvailabilityRange>();
        }

        public Guid EmployeeAvailabilityID { get; set; }
        public int EmpID { get; set; }
        public int StoreID { get; set; }
        public byte[]? Weekly { get; set; }
        public int RangeUsed { get; set; }

        public virtual ICollection<EmployeeAvailabilityRange> EmployeeAvailabilityRanges { get; set; }
    }
}
