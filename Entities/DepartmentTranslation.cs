using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DepartmentTranslation
    {
        public Guid DepartmentTranslationID { get; set; }
        public Guid DepartmentID { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Department Department { get; set; } = null!;
    }
}
