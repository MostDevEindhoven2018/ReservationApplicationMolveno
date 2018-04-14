using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class ReservationModel
    {
        public long ID { get; set; }
        public long TableID { get; set; }
        public long GuestID { get; set; }
        public int PartySize { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public ReservationModel(long guestId, int partySize, DateTime startTime)
        {
            ID = id;
            TableID = tableId;
            GuestID = guestId;
            PartySize = partySize;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
