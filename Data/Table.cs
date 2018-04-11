using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Table
    {
        public int ID;                     // 
        public int TableSize;              // Amount of people that can be seated at this table

        public Table(int id, int tableSize)
        {
            ID = id;
            TableSize = tableSize;
        }
        
    }
}
