using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class InvoiceConfigObject
    {
        public Guid InvoiceConfigObjectID { get; set; }
        public Guid InvoiceConfigID { get; set; }
        public int ObjectIndex { get; set; }
        public int Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string? Data { get; set; }
        public int TextType { get; set; }
        public int TextJustification { get; set; }
        public byte ExtraFields { get; set; }
        public string? Font { get; set; }
        public int TextWidth { get; set; }
        public int Style { get; set; }
        public byte BackgroundColor { get; set; }
        public byte ForeGroundColor { get; set; }

        public virtual InvoiceConfig InvoiceConfig { get; set; } = null!;
    }
}
