using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class GiftBackup
    {
        public Guid GiftBackupID { get; set; }
        public byte[] ID { get; set; } = null!;
        public byte[] Data { get; set; } = null!;
        public int ProcessorType { get; set; }
        public int Balance { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Processed { get; set; }
        public int StoreID { get; set; }
    }
}
