using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ReportSchedule
    {
        public Guid ReportScheduleID { get; set; }
        public Guid ReportID { get; set; }
        public string ScheduleName { get; set; } = null!;
        public byte[]? PrintOptions { get; set; }
        public string? ExportFilePath { get; set; }
        public string? EmailFrom { get; set; }
        public string? EmailTo { get; set; }
        public string? EmailSubject { get; set; }
        public string? EmailBody { get; set; }
        public string? EmailHTMLFilePath { get; set; }
        public string? ScheduleString { get; set; }
        public Guid ProcessID { get; set; }
        public byte[]? Parameters { get; set; }
        public string ReportName { get; set; } = null!;
        public byte[]? Layouts { get; set; }
        public bool ZipExport { get; set; }
        public string ScheduleValues { get; set; } = null!;
        public string SelectedPrinter { get; set; } = null!;
        public string? OutputOptionsJson { get; set; }
        public string? FileFormatsJson { get; set; }
        public bool? AppendTimestampToFile { get; set; }
    }
}
