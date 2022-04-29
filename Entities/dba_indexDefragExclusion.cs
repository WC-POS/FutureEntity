using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class dba_indexDefragExclusion
    {
        public int databaseID { get; set; }
        public string databaseName { get; set; } = null!;
        public int objectID { get; set; }
        public string objectName { get; set; } = null!;
        public int indexID { get; set; }
        public string indexName { get; set; } = null!;
        public int exclusionMask { get; set; }
    }
}
