using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApplicationMolveno
{
    public class ReservationManager
    {
        public List<Reservation> ResList { get; set; }

        public ReservationManager()
        {
            ResList = new List<Reservation>();
        }

        public void AddReservation(Reservation res)
        {
            this.ResList.Add(res);
        }
    }
}
