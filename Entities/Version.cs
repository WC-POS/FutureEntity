using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Version
    {
        public Guid VersionID { get; set; }
        public int StoreID { get; set; }
        public int CodeVersion { get; set; }
        public int DatabaseVersion { get; set; }
        public int CodeMajor { get; set; }
        public int CodeMinor { get; set; }
        public int CodeRevision { get; set; }
        public int CodeBuild { get; set; }
        public int CodePatch { get; set; }
    }
}
