using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data 
{
    public class Reservation
    {
        public long ID { get; set; }
        public long TableID {  get; set; }
        public long GuestID {  get; set; }
        public int PartySize {  get; set; }
        public DateTime StartTime {  get; set; }
        public DateTime EndTime {  get; set; }

        public Reservation(long id, long tableId, long guestId, int partySize, DateTime startTime, DateTime endTime)
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
