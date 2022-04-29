using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class BucketTransfer
    {
        public Guid BucketTransferID { get; set; }
        public DateTime CreateDate { get; set; }
        public string BucketType { get; set; } = null!;
        public int StoreID { get; set; }
        public string? Key1 { get; set; }
        public string? Key2 { get; set; }
        public string? Key3 { get; set; }
        public string? Key4 { get; set; }
        public string? Key5 { get; set; }
        public string? Key6 { get; set; }
    }
}
