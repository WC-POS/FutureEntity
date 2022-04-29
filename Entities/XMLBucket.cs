using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class XMLBucket
    {
        public Guid XMLBucketsID { get; set; }
        public int StoreID { get; set; }
        public DateTime BusinessDate { get; set; }
        public bool IsPartial { get; set; }
        public int Version { get; set; }
        public int BucketType { get; set; }
        public string XML { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public string? XML2 { get; set; }
    }
}
