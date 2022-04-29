using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class dba_indexDefragStatus
    {
        public int databaseID { get; set; }
        public string databaseName { get; set; } = null!;
        public int objectID { get; set; }
        public int indexID { get; set; }
        public short partitionNumber { get; set; }
        public double fragmentation { get; set; }
        public int page_count { get; set; }
        public long range_scan_count { get; set; }
        public string? schemaName { get; set; }
        public string? objectName { get; set; }
        public string? indexName { get; set; }
        public DateTime scanDate { get; set; }
        public DateTime? defragDate { get; set; }
        public bool printStatus { get; set; }
        public int exclusionMask { get; set; }
    }
}
