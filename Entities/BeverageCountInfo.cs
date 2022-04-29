using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class BeverageCountInfo
    {
        public Guid BeverageCountInfoID { get; set; }
        public short EmpID { get; set; }
        public short CountType { get; set; }
        public DateTime EnteredTime { get; set; }
    }
}
