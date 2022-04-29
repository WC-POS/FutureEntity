using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class EmployeeHintShown
    {
        public Guid EmployeeHintShownID { get; set; }
        public Guid EmployeeID { get; set; }
        public int HintIndex { get; set; }
    }
}
