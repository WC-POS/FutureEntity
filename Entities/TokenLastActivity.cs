using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TokenLastActivity
    {
        public string Token { get; set; } = null!;
        public DateTime? LastActive { get; set; }
        public Guid UserId { get; set; }
    }
}
