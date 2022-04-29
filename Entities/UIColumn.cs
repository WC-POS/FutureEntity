using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class UIColumn
    {
        public Guid UIColumnID { get; set; }
        public Guid UIID { get; set; }
        /// <summary>
        /// A Database Column Name (Must match table)
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Display Order Index
        /// </summary>
        public int Position { get; set; }
        public int State { get; set; }

        public virtual UI UI { get; set; } = null!;
    }
}
