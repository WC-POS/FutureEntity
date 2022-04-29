using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MenuHomePageLink
    {
        public Guid HomePageLinkID { get; set; }
        public DateTime? CreateStamp { get; set; }
        public int EmpID { get; set; }
        public Guid MenuPageID { get; set; }

        public virtual MenuPage MenuPage { get; set; } = null!;
    }
}
