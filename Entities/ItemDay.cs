using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ItemDay
    {
        public Guid ItemDayID { get; set; }
        public Guid ItemID { get; set; }
        public Guid DepartmentID { get; set; }
        public DateTime Date { get; set; }
    }
}
