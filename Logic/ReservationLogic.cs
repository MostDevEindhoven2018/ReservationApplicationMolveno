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

        public void AddToDB(string guestName, string guestTelephoneNumber, 
            string guestEmailAddress, int tablePartySize, 
            DateTime reservationBegintime, string guestComment, string hidePrices) //Reservation reservation)
        {
            

            Guest testGuest = new Guest(1, "Mathijs", "0610101001","Lololol@hotmail.com", "Comments", "Do not hide prices");
            testGuest.Name = guestName;
            testGuest.TelephoneNumber = guestTelephoneNumber;
            testGuest.EmailAddress = guestEmailAddress;
            testGuest.GuestComment = guestComment;
            testGuest.HidePrices = hidePrices;

            Table testTable = new Table(1, 6);
            testTable.TableSize = tablePartySize;

            TimeSpan block = new TimeSpan(0,2,0,0);

            DateTime endReservationTime = reservationBegintime + block;

            Reservation test = new Reservation(1, testTable, testGuest, 6, DateTime.Now, DateTime.Now);
            test.PartySize = tablePartySize;
            test.StartTime = reservationBegintime;
            test.EndTime = endReservationTime;

            _fileManager.AddToDB(test);
        }

        public void ReadFromDB()
        {
            // get the file. 
            //_fileManager.ReadDB();
        }

    }
}
