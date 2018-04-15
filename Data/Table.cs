using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Table
    {
        public long ID;                     // 
        public int TableSize;              // Amount of people that can be seated at this table

        public Table(long id, int tableSize)
        {
            ID = id;
            TableSize = tableSize;
        }
        
    }
}
