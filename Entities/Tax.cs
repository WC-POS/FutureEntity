using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Tax
    {
        public Tax()
        {
            TaxSchedules = new HashSet<TaxSchedule>();
            TaxTables = new HashSet<TaxTable>();
            TaxTranslations = new HashSet<TaxTranslation>();
        }

        public Guid TaxID { get; set; }
        public int StoreID { get; set; }
        public short TaxIndex { get; set; }
        public string TaxName { get; set; } = null!;
        public short TaxType { get; set; }
        public bool IsVAT { get; set; }
        public bool AddOddPennies { get; set; }
        public int NoTaxUnder { get; set; }
        public short CalculationType { get; set; }
        public int TaxPercent { get; set; }
        public short RoundingType { get; set; }
        public short LastUpToIndex { get; set; }
        public int ScheduledDays { get; set; }
        public bool DoNotIncludeInDisplayedTotal { get; set; }
        public bool IncludeInAlternateDisplayTotal { get; set; }
        public bool UseItemPriceForAlternateTotal { get; set; }
        public bool ForgiveAlternateTotalTaxOnSmartVat { get; set; }
        public bool UseFloridaCalculation { get; set; }
        public bool IsSurchargeTax { get; set; }
        public byte TaxFlags { get; set; }

        public virtual ICollection<TaxSchedule> TaxSchedules { get; set; }
        public virtual ICollection<TaxTable> TaxTables { get; set; }
        public virtual ICollection<TaxTranslation> TaxTranslations { get; set; }
    }
}
