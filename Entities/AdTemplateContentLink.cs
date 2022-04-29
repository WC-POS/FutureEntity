using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class AdTemplateContentLink
    {
        public Guid LinkTemplateID { get; set; }
        public Guid PlaylistItemID { get; set; }
        public Guid TemplateID { get; set; }
        public int ContentIDTag { get; set; }
        public int Display { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
