using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DepartmentRank
    {
        public Guid DepartmentRankID { get; set; }
        public Guid DepartmentID { get; set; }
        public int Rank { get; set; }
    }
}
