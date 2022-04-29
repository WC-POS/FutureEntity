using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MenuPage
    {
        public MenuPage()
        {
            MenuHomePageLinks = new HashSet<MenuHomePageLink>();
            MenuPageGroups = new HashSet<MenuPageGroup>();
        }

        public Guid MenuPageID { get; set; }
        public int IsActive { get; set; }
        public DateTime? CreateStamp { get; set; }
        public string PageName { get; set; } = null!;
        public int SecLevel { get; set; }
        public int IconIndex { get; set; }
        public int OrderIndex { get; set; }
        public int ButtonType { get; set; }
        public int FunctionType { get; set; }
        public int TabParentFunctionType { get; set; }
        public string SavedXML { get; set; } = null!;
        public string AssignedUser { get; set; } = null!;
        public int StoreID { get; set; }

        public virtual ICollection<MenuHomePageLink> MenuHomePageLinks { get; set; }
        public virtual ICollection<MenuPageGroup> MenuPageGroups { get; set; }
    }
}
