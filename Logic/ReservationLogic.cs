using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Logic
{
    public class ReservationLogic
    {
        FileManager _fileManager = new FileManager();

        public void CreateDB()
        {
            _fileManager.CreateDB();
        }

        public void AddToDB() //Reservation reservation)
        {
            Guest testGuest = new Guest(1, "George", "065838203","HerpaDurp@hotmail.com");
            Table testTable = new Table(1, 6);
            Reservation test = new Reservation(1, testTable, testGuest, 5, DateTime.Now, DateTime.Now);

            _fileManager.AddToDB(test);
        }

    }
}
