using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Activity
    {
        public Activity()
        {
            ActivityDetails = new HashSet<ActivityDetail>();
        }

        public Guid ActivityID { get; set; }
        public int StoreID { get; set; }
        public DateTime ActivityDate { get; set; }
        public int Action { get; set; }
        public int TerminalNumber { get; set; }
        public int TableNumber { get; set; }
        public int CheckNumber { get; set; }
        public int EmpID { get; set; }
        public int SupervisorID { get; set; }
        public int Data1 { get; set; }
        public int Data2 { get; set; }
        public string? Data { get; set; }
        public byte SmallData { get; set; }
        public string? IPAddress { get; set; }
        public Guid OAuthAspNetUserId { get; set; }

        public virtual ICollection<ActivityDetail> ActivityDetails { get; set; }
    }
}
