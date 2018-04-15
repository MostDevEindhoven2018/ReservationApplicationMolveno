using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Logic
{
    public class TableModel
    {

        public long ID { get; private set; }
        public int TableSize { get; set; }
        public bool Reserved { get; set; } = false;

        private static int globalTableId;

        public TableModel() { }

        public TableModel(int maxSize)
        {
            ID = Interlocked.Increment(ref globalTableId);
            TableSize = maxSize;
        }

        public TableModel(long id, int maxSize)
        {
            ID = id;
            TableSize = maxSize;
        }
    }
}
