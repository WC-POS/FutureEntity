using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class vContentLink
    {
        public Guid LinkID { get; set; }
        public Guid PlayListID { get; set; }
        public Guid PlaylistItemID { get; set; }
        public int MediaDisplayTime { get; set; }
        public int TransitionNumber { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int ItemOrder { get; set; }
        public bool IsEnabled { get; set; }
        public int MediaType { get; set; }
        public Guid LinkPlayListItemID { get; set; }
        public string ItemName { get; set; } = null!;
    }
}
