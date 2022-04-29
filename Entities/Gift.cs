using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Gift
    {
        public Gift()
        {
            GiftHistories = new HashSet<GiftHistory>();
            GiftUseds = new HashSet<GiftUsed>();
        }

        public Guid GiftID { get; set; }
        public int StoreID { get; set; }
        public byte SeriesIndex { get; set; }
        public string GiftNumber { get; set; } = null!;
        public string? Swipe { get; set; }
        public string? Prefix { get; set; }
        public string? Suffix { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? DestroyDate { get; set; }
        public int Amount { get; set; }
        public string? FromName { get; set; }
        public string? ToName { get; set; }
        public int CheckCount { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? StoreNumber { get; set; }
        public Guid RegionID { get; set; }
        public int HistoryCount { get; set; }

        public virtual ICollection<GiftHistory> GiftHistories { get; set; }
        public virtual ICollection<GiftUsed> GiftUseds { get; set; }
    }
}
