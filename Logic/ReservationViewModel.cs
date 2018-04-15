using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class ReservationViewModel
    {
        public long ID { get; set; }
        public TableViewModel TableViewModel { get; set; }
        public GuestViewModel GuestViewModel { get; set; }
        public int PartySize { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public ReservationViewModel(long id, TableViewModel tableViewModel, GuestViewModel guestViewModel, int partySize, DateTime startTime, DateTime endTime)
        {
            ID = id;
            TableViewModel = tableViewModel;
            GuestViewModel = guestViewModel;
            PartySize = partySize;
            StartTime = startTime;
            EndTime = endTime;
        }

    }
}
