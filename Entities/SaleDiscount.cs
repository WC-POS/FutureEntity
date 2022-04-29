﻿using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SaleDiscount
    {
        public Guid SaleDiscountID { get; set; }
        public Guid? SaleID { get; set; }
        public int DiscountIndex { get; set; }
        public int Dollar { get; set; }
        public int Amount { get; set; }
        public int ReasonIndex { get; set; }
        public int MaxAmount { get; set; }
        public string? ReasonDescription { get; set; }

        public virtual Sale? Sale { get; set; }
    }
}
