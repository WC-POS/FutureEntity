using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class AdPlayListItem
    {
        public Guid PlaylistItemID { get; set; }
        public string ItemName { get; set; } = null!;
        /// <summary>
        /// 0=jpg,1=gif,2=mp4,3=png,4=swf
        /// </summary>
        public string MediaType { get; set; } = null!;
        public byte[] MediaFile { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? LoadContent { get; set; }
        public string OriginalFileName { get; set; } = null!;
    }
}
