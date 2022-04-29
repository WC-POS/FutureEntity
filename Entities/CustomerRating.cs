using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CustomerRating
    {
        public Guid CustomerRatingID { get; set; }
        public int CustomerNumber { get; set; }
        public DateTime CreatedDateUTC { get; set; }
        public short Rating { get; set; }
        public string? Comment { get; set; }
        public Guid? SaleID { get; set; }
        public Guid? SaleTenderID { get; set; }

        public virtual Sale? Sale { get; set; }
    }
}
