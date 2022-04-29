using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DeliveryDriver
    {
        public Guid DriverID { get; set; }
        public int StoreID { get; set; }
        public int EmpID { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public byte InOutStatus { get; set; }
        public DateTime? LastDate { get; set; }
    }
}
