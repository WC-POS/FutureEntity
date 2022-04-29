using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class EnterpriseSort
    {
        public Guid EnterpriseSortID { get; set; }
        public int FileType { get; set; }
        public DateTime UpdateDate { get; set; }
        public int StoreID { get; set; }
        public string FileName { get; set; } = null!;
    }
}
