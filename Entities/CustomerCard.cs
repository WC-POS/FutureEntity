using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CustomerCard
    {
        public Guid CustomerCardID { get; set; }
        public Guid CustomerID { get; set; }
        public int CardIndex { get; set; }
        public int CardSource { get; set; }
        public byte[] CreditCard { get; set; } = null!;
        public bool IsE2EEncryption { get; set; }
        public byte[]? EncryptedBlock { get; set; }
        public byte[]? EncryptionKey { get; set; }
        public int DataVersion { get; set; }
        public Guid? DataID { get; set; }
        public byte[]? EncryptedRawSwipe { get; set; }
        public byte[]? VaultID { get; set; }
        public int VaultMediaIndex { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
