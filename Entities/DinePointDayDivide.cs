using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DinePointDayDivide
    {
        public DateTime BusinessDate { get; set; }
        public int StoreID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
