using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MessageEmployee
    {
        public Guid MessageEmployeeID { get; set; }
        public Guid MessageID { get; set; }
        public int MessageEmployeeIndex { get; set; }
        public int EmployeeID { get; set; }

        public virtual Message Message { get; set; } = null!;
    }
}
