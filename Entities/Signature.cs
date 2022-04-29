﻿using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Signature
    {
        public Guid SignatureID { get; set; }
        public int StoreID { get; set; }
        public int CheckNumber { get; set; }
        public int SuspendNumber { get; set; }
        public DateTime SignatureDate { get; set; }
        public int CardIndex { get; set; }
        public int MediaIndex { get; set; }
        public int CustomerNumber { get; set; }
        public int MinX { get; set; }
        public int MaxX { get; set; }
        public int MinY { get; set; }
        public int MaxY { get; set; }
        public int ElementCount { get; set; }
        public int Amount { get; set; }
        public byte[] Data { get; set; } = null!;
        public int DataType { get; set; }
    }
}
