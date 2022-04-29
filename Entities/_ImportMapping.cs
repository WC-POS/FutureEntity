using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ImportMapping
    {
        public Guid ImportMappingID { get; set; }
        public string Description { get; set; } = null!;
        public string Identifier { get; set; } = null!;
        public int? RowsToSkip { get; set; }
        public string? FieldMappings { get; set; }
        public bool IsReadOnly { get; set; }
    }
}
