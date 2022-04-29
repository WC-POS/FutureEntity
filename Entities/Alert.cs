using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Alert
    {
        public Guid AlertID { get; set; }
        public string AlertName { get; set; } = null!;
        public DateTime LastAlert { get; set; }
        public bool IsEnabled { get; set; }
        public int AlertType { get; set; }
        public string AlertTo { get; set; } = null!;
    }
}
