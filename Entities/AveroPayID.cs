using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class AveroPayID
    {
        public int RowNum { get; set; }
        public string? MediaID { get; set; }
        public int? MediaIndex { get; set; }
        public string? MediaName { get; set; }
        public int? Factor { get; set; }
        public int? OldIndex { get; set; }
        public int? NewIndex { get; set; }
        public string? UpdatedOn { get; set; }
        public bool? Active { get; set; }
        public short? SpecialOption { get; set; }
    }
}
