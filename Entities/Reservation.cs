﻿using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Reservation
    {
        public Guid ReservationID { get; set; }
        public int StoreID { get; set; }
        public DateTime ReservationDate { get; set; }
        public int CustomerNumber { get; set; }
        public short TableNumber { get; set; }
        public short MinutesPrior { get; set; }
        public short GuestCount { get; set; }
        public string? CustomerName { get; set; }
        public string? Note { get; set; }
        public bool HasArrived { get; set; }
        public int ArriveTime { get; set; }
        public string? LongNote { get; set; }
        public short Duration { get; set; }
        public bool HasBeenSeated { get; set; }
        public int HasBeenSeatedTime { get; set; }
    }
}
