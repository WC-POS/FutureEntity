using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class BeverageCount
    {
        public BeverageCount()
        {
            BeverageCountItems = new HashSet<BeverageCountItem>();
        }

        public Guid BeverageCountID { get; set; }
        public short EmpID { get; set; }
        public short GroupID { get; set; }
        public int InCount { get; set; }
        public int OutCount { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsEndCount { get; set; }
        public string? ComputerName { get; set; }

        public virtual ICollection<BeverageCountItem> BeverageCountItems { get; set; }
    }
}
