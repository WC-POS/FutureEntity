using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CurrencyConversionItem
    {
        public Guid CurrencyConversionItemID { get; set; }
        public Guid CurrencyConversionID { get; set; }
        public int ConversionIndex { get; set; }
        public string ConversionName { get; set; } = null!;
        public string ConversionShortName { get; set; } = null!;
        public decimal ConversionRate { get; set; }

        public virtual CurrencyConversion CurrencyConversion { get; set; } = null!;
    }
}
