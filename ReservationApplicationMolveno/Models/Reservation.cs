using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReservationApplicationMolveno
{
    public class Reservation
    {
        public int ReservationId { get; private set; } //automatically generated
        public int PartySize { get; set; }
        public Guest Guest { get; set; }
        public Table Table { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public DateTime EndTime { get; set; }

        private static int globalReservationId;

        public Reservation() { }

        public Reservation(int partySize, Guest guest, DateTime arrivalDate)
        {
            this.ReservationId = Interlocked.Increment(ref globalReservationId);
            this.PartySize = partySize;
            this.Guest = guest;
            this.ArrivalDateTime = arrivalDate;
        }
    }
}
