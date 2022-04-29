using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ActivityDetail
    {
        public Guid ActivityDetailID { get; set; }
        public Guid ActivityID { get; set; }
        public string TableName { get; set; } = null!;
        public string PropertyName { get; set; } = null!;
        public string OriginalValue { get; set; } = null!;
        public string ChangedValue { get; set; } = null!;
        public string OriginalIdentifier { get; set; } = null!;

        public virtual Activity Activity { get; set; } = null!;
    }
}
