using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class vDBFileHeader
    {
        public Guid DBFileID { get; set; }
        public int FileType { get; set; }
        public DateTime FileDate { get; set; }
        public string FileName { get; set; } = null!;
        public int StoreID { get; set; }
    }
}
