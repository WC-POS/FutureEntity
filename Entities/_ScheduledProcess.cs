using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ScheduledProcess
    {
        public Guid ScheduledProcessID { get; set; }
        public string ScheduledProcessName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public byte[]? Parameters { get; set; }
        public string? ScheduleString { get; set; }
        public Guid EmployeeID { get; set; }
        public DateTime? LastRun { get; set; }
        public DateTime? LastQueued { get; set; }
    }
}
