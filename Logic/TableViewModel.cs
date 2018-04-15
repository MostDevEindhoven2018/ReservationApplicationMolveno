using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class TableViewModel
    {
        public long ID;                     // 
        public int TableSize;              // Amount of people that can be seated at this table

        public TableViewModel(long id, int tableSize)
        {
            ID = id;
            TableSize = tableSize;
        }
    }
}
