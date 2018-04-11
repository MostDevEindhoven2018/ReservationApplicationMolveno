using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReservationApplicationMolveno
{
    public class Table
    {
        public int TableId { get; private set; }
        public int TableSize { get; set; }

        private static int globalTableId;

        public Table() { }

        public Table(int maxSize)
        {
            this.TableId = Interlocked.Increment(ref globalTableId);
        }
    }
}
