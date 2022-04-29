using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PendingSale
    {
        public bool AllowPartialAuth { get; set; }
        public int AuthBalance { get; set; }
        public byte[] AuthCardName { get; set; } = null!;
        public byte[] AuthCardNumber { get; set; } = null!;
        public byte[] AuthCardNumberEncrypted { get; set; } = null!;
        public byte[] AuthCardType { get; set; } = null!;
        public short AuthCV2 { get; set; }
        public byte[] AuthCV2StrEncrypted { get; set; } = null!;
        public int AuthDataVersion { get; set; }
        public byte[] AuthEncryptedBlock { get; set; } = null!;
        public byte[] AuthEncryptionKey { get; set; } = null!;
        public byte[] AuthExpirationDateEncrypted { get; set; } = null!;
        public bool AuthIsE2EEncryption { get; set; }
        public int AuthMediaIndex { get; set; }
        public byte[] AuthMSRSwipe { get; set; } = null!;
        public byte[] AuthReferenceData { get; set; } = null!;
        public byte[] AuthReferenceNumber { get; set; } = null!;
        public byte[] AuthResponse { get; set; } = null!;
        public int AuthSource { get; set; }
        public int AuthTipAmount { get; set; }
        public byte[] AuthTrack2Encrypted { get; set; } = null!;
        public int AuthTransactionAmount { get; set; }
        public int AuthZipCode { get; set; }
        public byte CardIndex { get; set; }
        public int CheckNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public bool DoingROA { get; set; }
        public int MSREncryptionType { get; set; }
        public short EmployeeID { get; set; }
        public Guid PendingSaleID { get; set; }
        public bool InOfflineMode { get; set; }
        public bool IsPreAuth { get; set; }
        public bool IsRefund { get; set; }
        public byte[] PublicKey { get; set; } = null!;
        public long PublicKeyLength { get; set; }
        public int NoNonSufficentFundsAmount { get; set; }
        public int RevenueCenter { get; set; }
        public Guid SaleID { get; set; }
        public byte[] Salt { get; set; } = null!;
        public long SaltLength { get; set; }
        public byte[] SessionID { get; set; } = null!;
        public Guid TransactionID { get; set; }
        public bool UseBalance { get; set; }
        public byte OpCode { get; set; }
    }
}
