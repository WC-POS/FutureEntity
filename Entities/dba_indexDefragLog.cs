using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class dba_indexDefragLog
    {
        public int indexDefrag_id { get; set; }
        public int databaseID { get; set; }
        public string databaseName { get; set; } = null!;
        public int objectID { get; set; }
        public string objectName { get; set; } = null!;
        public int indexID { get; set; }
        public string indexName { get; set; } = null!;
        public short partitionNumber { get; set; }
        public double fragmentation { get; set; }
        public int page_count { get; set; }
        public DateTime dateTimeStart { get; set; }
        public DateTime? dateTimeEnd { get; set; }
        public int? durationSeconds { get; set; }
        public string? sqlStatement { get; set; }
        public string? errorMessage { get; set; }
    }
}
