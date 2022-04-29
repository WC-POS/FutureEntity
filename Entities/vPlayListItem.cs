using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class vPlayListItem
    {
        public Guid PlaylistItemID { get; set; }
        public string ItemName { get; set; } = null!;
        public string MediaType { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public bool IsEnabled { get; set; }
        public bool LoadContent { get; set; }
    }
}
