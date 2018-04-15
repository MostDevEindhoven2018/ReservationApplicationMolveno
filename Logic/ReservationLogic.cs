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
            Guest testGuest = new Guest(1, "Mathijs", "0610101001","Lololol@hotmail.com");
            Table testTable = new Table(1, 6);
            Reservation test = new Reservation(1, testTable, testGuest, 6, DateTime.Now, DateTime.Now);

            _fileManager.AddToDB(test);
        }

        public void GetCompleteDB()
        {
            // get the file. 
            _fileManager.ReadDB(1);
            GetAllGuests();
            GetAllTables();
            GetAllReservations();
        }

        private List<Guest> GetAllGuests()
        {
            List<Guest> GuestList = new List<Guest>();
            List<string> AllGuestInfos = _fileManager.ReadDB(FileManager.FilePaths.Guest);
            foreach (string GuestInfo in AllGuestInfos)
            {
                string[] guestInfoArray = GuestInfo.Split(',');
                long.TryParse(guestInfoArray[0], out long guest_ID);
                Guest guest = new Guest(guest_ID, guestInfoArray[1], guestInfoArray[2], guestInfoArray[3] );

                GuestList.Add(guest);
            }

            return GuestList;
        }

        private List<Table> GetAllTables()
        {
            List<Table> TableList = new List<Table>();
            List<string> AllTableInfos = _fileManager.ReadDB(FileManager.FilePaths.Table);
            foreach (string TableInfo in AllTableInfos)
            {
                string[] TableInfoArray = TableInfo.Split(',');
                long.TryParse(TableInfoArray[0], out long Table_ID);
                int.TryParse(TableInfoArray[1], out int TableSize);
                Table table = new Table(Table_ID, TableSize);

                TableList.Add(table);

            }

            return TableList;
        }

        private List<Reservation> GetAllReservations()
        {
            List<Reservation> GuestList = new List<Reservation>();
            List<string> AllReservationInfos = _fileManager.ReadDB(FileManager.FilePaths.Reservation);
            foreach (string ReservationInfo in AllReservationInfos)
            {
                string[] ReservationInfoArray = ReservationInfo.Split(',');
                long.TryParse(ReservationInfoArray[0], out long ReservationID);
                long.TryParse(ReservationInfoArray[1], out long TableID);
                long.TryParse(ReservationInfoArray[2], out long GuestID);
                int.TryParse(ReservationInfoArray[3], out int PartySize);
                DateTime.TryParse(ReservationInfoArray[4], out DateTime StartTime);
                DateTime.TryParse(ReservationInfoArray[5], out DateTime EndTime);


                Reservation reservation = new Reservation(ReservationID, TableID, GuestID, PartySize, StartTime, EndTime);

                GuestList.Add(reservation);

            }

            return GuestList;
        }



        private List<string> AllTables()
        {
            return _fileManager.ReadDB(FileManager.FilePaths.Table);
        }

        private List<string> AllReservations()
        {
            return _fileManager.ReadDB(FileManager.FilePaths.Reservation);
        }

    }
}
