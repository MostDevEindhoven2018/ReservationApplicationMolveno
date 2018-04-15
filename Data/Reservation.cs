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
        public Table Table { get; set; }
        public Guest Guest {  get; set; }
        public int PartySize {  get; set; }
        public DateTime StartTime {  get; set; }
        public DateTime EndTime {  get; set; }

        public Reservation(long id, Table table, Guest guest, int partySize, DateTime startTime, DateTime endTime)
        {
            ID = id;
            Table = table;
            Guest = guest;
            PartySize = partySize;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
