using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CurrencyConversion
    {
        public CurrencyConversion()
        {
            CurrencyConversionItems = new HashSet<CurrencyConversionItem>();
        }

        public Guid CurrencyConversionID { get; set; }
        public int StoreID { get; set; }
        public string ConversionBaseName { get; set; } = null!;
        public string ConversionBaseShortName { get; set; } = null!;

        public virtual ICollection<CurrencyConversionItem> CurrencyConversionItems { get; set; }
    }
}
