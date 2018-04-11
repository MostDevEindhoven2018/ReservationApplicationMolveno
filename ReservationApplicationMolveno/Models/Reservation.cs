using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApplicationMolveno
{
    public class Reservation
    {
        public int reservationID; //automatically generated
        public int partySize { get; set; }
        public Guest guest {get; set;}
        public Table table { get; set; }
        public DateTime StartTime;
        public DateTime EndTime;

        public Reservation()
        {
            guest = new Guest();
        }
    }
}
