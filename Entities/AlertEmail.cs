using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class AlertEmail
    {
        public Guid AlertEmailID { get; set; }
        public string AlertEmailAddress { get; set; } = null!;
        public string AlertEmailFname { get; set; } = null!;
        public string AlertEmailLname { get; set; } = null!;
        public string AlertEmailPhone { get; set; } = null!;
        public string AlertEmailCarrier { get; set; } = null!;
    }
}
