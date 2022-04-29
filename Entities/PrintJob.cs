using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PrintJob
    {
        public PrintJob()
        {
            PrintJobLines = new HashSet<PrintJobLine>();
        }

        public Guid PrintJobID { get; set; }
        public int StoreID { get; set; }
        public int ToTerminalNumber { get; set; }
        public int ToPrinterNumber { get; set; }
        public string? RerouteDescription { get; set; }
        public bool IsBumped { get; set; }
        public bool IsReprint { get; set; }
        public DateTime PrintDate { get; set; }
        public DateTime? CheckStartDate { get; set; }
        public int CheckNumber { get; set; }
        public int FromTerminalNumber { get; set; }
        public int MaxLines { get; set; }
        public int EmpID { get; set; }
        public string? EmployeeName { get; set; }
        public int SuspendNumber { get; set; }
        public int CourseNumber { get; set; }
        public string? TableDescription { get; set; }
        public string? CheckDescription { get; set; }
        public int CustomerNumber { get; set; }
        public int OrderType { get; set; }
        public bool WasBumped { get; set; }
        public int CheckTotal { get; set; }
        public bool OnHold { get; set; }
        public Guid? SaleID { get; set; }
        public short? SuspendNumberTerminal { get; set; }

        public virtual ICollection<PrintJobLine> PrintJobLines { get; set; }
    }
}
