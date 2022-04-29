using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PreAuth
    {
        public Guid PreAuthID { get; set; }
        public int StoreID { get; set; }
        public DateTime PreAuthDate { get; set; }
        public int CheckNumber { get; set; }
        public byte[] CardNumber { get; set; } = null!;
        public byte[] ExpirationDate { get; set; } = null!;
        public byte[] AuthResponse { get; set; } = null!;
        public byte[] CardName { get; set; } = null!;
        public byte[] AcqRefData { get; set; } = null!;
        public int Amount { get; set; }
        public bool UsedToSettle { get; set; }
        public int MediaIndex { get; set; }
        public byte[]? Track2 { get; set; }
        public Guid SaleID { get; set; }
        public bool IsE2EEncryption { get; set; }
        public byte[]? EncryptedBlock { get; set; }
        public byte[]? EncryptionKey { get; set; }
        public int CardSource { get; set; }
        public byte[]? ReferenceNumber { get; set; }
        public int DataVersion { get; set; }
        public Guid? DataID { get; set; }
        public byte[]? EncryptedRawSwipe { get; set; }
        public byte[]? VaultID { get; set; }
        public byte[]? ReferenceData { get; set; }
        public byte[]? ProcessData { get; set; }
        public byte[]? EMVApplicationData { get; set; }
        public byte[]? EMVAID { get; set; }
        public byte[]? EMVTVR { get; set; }
        public byte[]? EMVIAD { get; set; }
        public byte[]? EMVTSI { get; set; }
        public byte[]? EMVARC { get; set; }
        public byte[]? EMVCVM { get; set; }
        public byte[]? EMVEntryMethod { get; set; }
    }
}
