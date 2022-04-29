using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class UI
    {
        public UI()
        {
            UIColumns = new HashSet<UIColumn>();
        }

        public Guid UIID { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<UIColumn> UIColumns { get; set; }
    }
}
