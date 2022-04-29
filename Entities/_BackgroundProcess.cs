using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _BackgroundProcess
    {
        public Guid BackgroundProcessID { get; set; }
        public string BackgroundProcessName { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public byte[]? Parameters { get; set; }
        public Guid EmployeeID { get; set; }
        public int Status { get; set; }
        public string? Messages { get; set; }
        public Guid? ScheduleID { get; set; }
        public int? Reason { get; set; }
    }
}
