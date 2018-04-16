﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Logic
{
    public class ReservationModel
    {
        public long ID { get; set; }
        public TableModel TableModel { get; set; }
        public GuestModel GuestModel { get; set; }
        public int PartySize { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool HidePrices { get; set; }
        public string GuestComments { get; set; }

        private static int globalReservationId;

        public ReservationModel(TableModel tableModel, GuestModel guestModel, int partySize, DateTime startTime, DateTime endTime, bool hidePrices, string guestComments)
        {
            ID = Interlocked.Increment(ref globalReservationId);
            TableModel = tableModel;
            GuestModel = guestModel;
            PartySize = partySize;
            StartTime = startTime;
            EndTime = endTime;
            HidePrices = hidePrices;
            GuestComments = guestComments;
        }
    }
}
