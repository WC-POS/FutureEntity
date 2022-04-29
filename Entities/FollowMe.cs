using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class FollowMe
    {
        public Guid FollowMeID { get; set; }
        public Guid SaleID { get; set; }
        public Guid EmployeeID { get; set; }
        public short CurrentTerminal { get; set; }
        public short RequestTermimal { get; set; }
        public short State { get; set; }
    }
}
