using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Help
    {
        public Guid HelpID { get; set; }
        public Guid RegionID { get; set; }
        public string HelpName { get; set; } = null!;
        public string HelpText { get; set; } = null!;
    }
}
