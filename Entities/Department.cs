using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Department
    {
        public Department()
        {
            DepartmentMobileExclusions = new HashSet<DepartmentMobileExclusion>();
            DepartmentSchedules = new HashSet<DepartmentSchedule>();
            DepartmentTranslations = new HashSet<DepartmentTranslation>();
        }

        public Guid DepartmentID { get; set; }
        public Guid RegionID { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? DepartmentDescription { get; set; }
        public string? GroupName { get; set; }
        public bool IsHash { get; set; }
        public byte PMSBucketNumber { get; set; }
        public bool IsUsedOnline { get; set; }
        public string? WebTitle { get; set; }
        public string? WebDescription { get; set; }
        public string? WebThumbPath { get; set; }
        public string? WebImagePath { get; set; }
        public bool IsDefault { get; set; }
        public int DisplayIndex { get; set; }
        public bool IsParent { get; set; }
        public Guid? ParentDepartmentID { get; set; }
        public int VDUID { get; set; }
        public bool AskID { get; set; }
        public int QuantityMultiplier { get; set; }
        public bool MobileAskID { get; set; }
        public bool IsMobile { get; set; }
        public Guid? MobileMessageID { get; set; }
        public string? OverrideAutoMenuButtonSettingsGraphic { get; set; }
        public bool IsRequired { get; set; }
        public bool AllowEBT { get; set; }
        public string? ImageName { get; set; }
        public bool HideSkyTab { get; set; }

        public virtual ICollection<DepartmentMobileExclusion> DepartmentMobileExclusions { get; set; }
        public virtual ICollection<DepartmentSchedule> DepartmentSchedules { get; set; }
        public virtual ICollection<DepartmentTranslation> DepartmentTranslations { get; set; }
    }
}
