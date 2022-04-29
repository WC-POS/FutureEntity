﻿using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class POSShift
    {
        public Guid POSShiftID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short TerminalNumber { get; set; }
        public int DrawerNumber { get; set; }
        public int StartEmpID { get; set; }
        public int EndEmpID { get; set; }
        public int StartAmount { get; set; }
        public int EndAmount { get; set; }
        public int FloatAmount { get; set; }
        public int StoreID { get; set; }
        public short ShiftType { get; set; }
    }
}
