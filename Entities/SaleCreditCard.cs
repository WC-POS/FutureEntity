using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SaleCreditCard
    {
        public Guid SaleCreditCardID { get; set; }
        public Guid SaleID { get; set; }
        public int CardIndex { get; set; }
        public byte[]? CardNum { get; set; }
        public byte[]? ExpirationDate { get; set; }
        public byte[]? AuthResponse { get; set; }
        public byte[]? CardName { get; set; }
        public byte[]? ReferenceNumber { get; set; }
        public int AuthorizeAmount { get; set; }
        public int EmployeeTips { get; set; }
        public int HouseTips { get; set; }
        public byte MediaIndex { get; set; }
        public byte CardType { get; set; }
        public byte TipTerm { get; set; }
        public int UKRefNo { get; set; }
        public int BGCBalance { get; set; }
        public string? BankGCIssueCurr { get; set; }
        public int BankGCICPrevBal { get; set; }
        public int BankGCICEndBal { get; set; }
        public string? BankGCICExchRate { get; set; }
        public bool IsE2EEncryption { get; set; }
        public byte[]? EncryptedBlock { get; set; }
        public byte[]? EncryptionKey { get; set; }
        public int CardSource { get; set; }
        public bool WasRefunded { get; set; }
        public int DataVersion { get; set; }
        public Guid? DataID { get; set; }
        public byte[]? EncryptedRawSwipe { get; set; }
        public Guid? SignatureID { get; set; }
        public bool IsMoneris { get; set; }
        public byte[]? VaultID { get; set; }
        public byte[]? ReferenceData { get; set; }
        public byte[]? ProcessData { get; set; }
        public byte[]? EMVApplicationLabel { get; set; }
        public byte[]? EMVAID { get; set; }
        public byte[]? EMVTVR { get; set; }
        public byte[]? EMVIAD { get; set; }
        public byte[]? EMVTSI { get; set; }
        public byte[]? EMVARC { get; set; }
        public byte[]? EMVCVM { get; set; }
        public byte[]? EMVEntryMethod { get; set; }
        public byte[]? ZipCode { get; set; }
        public string? OfflineID { get; set; }
        public bool IsOffline { get; set; }
        public byte OfflineTerminal { get; set; }
        public bool IsReturn { get; set; }
        public string? ReportCardNumber { get; set; }
        public string? ReportCardName { get; set; }
        public string? ReportAuthResponse { get; set; }
        public string? ReportTranID { get; set; }
        public string? ReportZipCode { get; set; }
        public string? ReportCardType { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
