using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data 
{
    public class Reservation
    {
        public int ReservationId { get; set; } //automatically generated
        public int PartySize { get; set; }
        public Guest Guest { get; set; }
        public Table Table { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
