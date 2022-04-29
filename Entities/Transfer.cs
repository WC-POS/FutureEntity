using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Transfer
    {
        public Guid TransferID { get; set; }
        public DateTime CreateDate { get; set; }
        public int TransferType { get; set; }
        public int Destination { get; set; }
        public int ToStoreID { get; set; }
        public int FromStoreID { get; set; }
        public int ToTerminalNumber { get; set; }
        public int FromTerminalNumber { get; set; }
        public string? Data { get; set; }
        public int DBTableNumber { get; set; }
        public Guid DBRecordID { get; set; }
        public bool ProcessOnServer { get; set; }
        public int RetryCount { get; set; }
    }
}
