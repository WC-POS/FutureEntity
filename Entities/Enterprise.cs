using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Enterprise
    {
        public Guid EntID { get; set; }
        public int ServerIPAddress { get; set; }
        public int CustomerLevel { get; set; }
        public int GiftLevel { get; set; }
        public string EnterpriseName { get; set; } = null!;
        public int CountryCode { get; set; }
        public string? APIKey { get; set; }
        public string? EmailServer { get; set; }
        public string? EmailUser { get; set; }
        public string? EmailPassword { get; set; }
        public int EmailPort { get; set; }
        public bool EmailUseSSL { get; set; }
        public byte[]? EmailPasswordEnc { get; set; }
    }
}
