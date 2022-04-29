using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class VideoCapture
    {
        public Guid VideoCaptureID { get; set; }
        public int StoreID { get; set; }
        public DateTime VideoDate { get; set; }
        public int Action { get; set; }
        public int TerminalNumber { get; set; }
        public int EmpID { get; set; }
        public int CheckNumber { get; set; }
        public int SupervisorID { get; set; }
        public int Data1 { get; set; }
        public int Data2 { get; set; }
        public int DeviceIndex { get; set; }
        public bool IsCompressed { get; set; }
        public bool FirstFrame { get; set; }
        public bool LastFrame { get; set; }
        public int FrameRate { get; set; }
        public int CompressedBytes { get; set; }
        public int UncompressedBytes { get; set; }
        public byte[] Frame { get; set; } = null!;
    }
}
