using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Shorthand
    {
        public Guid ShorthandID { get; set; }
        public string ShortCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public string? Modifiers { get; set; }
    }
}
