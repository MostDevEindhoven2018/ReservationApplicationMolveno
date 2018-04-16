using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;

namespace Logic
{
    public class ReservationLogic
    {
        private static ReservationLogic _instance;

        protected ReservationLogic()
        {
        }

        public static ReservationLogic Instance()
        {
            if (_instance == null)
            {
                _instance = new ReservationLogic();
            }

            return _instance;
        }


        FileManager _fileManager = FileManager.Instance();

        int DurationOfReservation { get; set; } = 2;    // Two hours for now. This will be set through some configuration stuff and will be editable by admins (Klaas).

        int TableIndex;                                 // For now, when we look for an available table, we simply loop through all tables 
                                                        // without checking for existing reservations. This will obviously be changed to a fancy checking system.



        public void CreateDB()
        {
            _fileManager.CreateDB();
        }


        //******************************************Sending data to database*******************************************

        public void ProcessReservation(List<object> rawReservationData)
        {
            ReservationModel prelimRM = CreateReservationModel(rawReservationData);
            // Below here, do all kinds of fancy pantsy tests and checks and such

            

            // If and when all is well, convert the ReservationModel to a Reservation, and send it to the database
            Reservation FinalisedReservation = CreateReservation(prelimRM);
            AddToDB(FinalisedReservation);
        }

        public void AddToDB(Reservation res) //Reservation reservation)
        {
            Guest guest = res.Guest;

            _fileManager.AddReservationToDB(res, guest);
        }
        //                                          create the Reservation Classes

        public Guest CreateGuest(GuestModel guestModel)
        {
            Guest resultGuest = new Guest(guestModel.ID, guestModel.Name, guestModel.TelephoneNumber, guestModel.EmailAddress);

            return resultGuest;
        }

        public Table CreateTable(TableModel tableModel)
        {
            Table resultTable = new Table(tableModel.ID, tableModel.TableSize);

            return resultTable;
        }


        public Reservation CreateReservation(ReservationModel resModel)
        {
            Guest resultGuest = CreateGuest(resModel.GuestModel);
            Table resultTable = CreateTable(resModel.TableModel);


            Reservation resultReservation = new Reservation(resModel.ID, resultTable, resultGuest, resModel.PartySize, resModel.StartTime, resModel.EndTime, resModel.HidePrices, resModel.GuestComments);
            return resultReservation;
        }

        //                                          create the Model Classes


        public GuestModel CreateGuestModel(List<object> rawReservationData)
        {
            // Using the first part of the raw data from the CollectData() method, fully construct the GuestModel. ID is set internally without using arguments.
            GuestModel guestModel = new GuestModel((string)rawReservationData[0], (string)rawReservationData[1], (string)rawReservationData[2]);

            return guestModel;
        }


        public ReservationModel CreateReservationModel(List<object> rawReservationData)
        {
            // Construct GuestModel
            GuestModel guestModel = CreateGuestModel(rawReservationData);

            // Get the party size from the raw data
            int partySize = (int)rawReservationData[3];

            // Using the second part of the raw data from the CollectData() method, get the arrival time of the guests.
            DateTime arrivalTime = JoinDateTime(rawReservationData);

            // Calculate the end time by creating a new date time, completely the same as the starttime, but adding DurationOfReservation to the Hour part.
            // TODO: check whether or not arrivalTime.Hour + DurationOfReservation is within opening hours of the restaurant.
            DateTime endTime = new DateTime(arrivalTime.Year, arrivalTime.Month, arrivalTime.Day, arrivalTime.Hour + DurationOfReservation, arrivalTime.Minute, 0);

            // Find an available table and assign it to the ReservationModel.
            TableModel tableModel = GetAvailableTable();


            bool hidePrices = (bool)rawReservationData[10];

            string guestComments = (string)rawReservationData[9];

            // check whether or not the comments is empty
            if(guestComments == null)
            {
                guestComments = "-";
            }

            // using everything, construct the ReservationModel. ID is set internally without using arguments.
            ReservationModel resModel = new ReservationModel(tableModel, guestModel, partySize, arrivalTime, endTime, hidePrices, guestComments);

            // Now we have everything, 
            return resModel;
        }


        private TableModel GetAvailableTable()
        {
            // This will get a lot easier using an actual database. For now, we need to first get all tables, and assign one of the not reserved tables to the reservation.


            // First get all tables
            List<Table> allTables = GetAllTables();

            // For now, lets just index through the tables using the table index.
            // TODO: Make an actual CheckForAvailability or something.
            if (TableIndex >= allTables.Count)
            {
                TableIndex = 0;
            }

            Table currentTable = allTables[TableIndex++];

            // Convert currentTable to a TableModel. This seems weird, and it kind of is... But using a TableModel instead of Table, makes sure that all compounds of 
            // the ReservationModel reside in the Logic layer, and not in the data layer. However unlikely it is, we might want to change stuff from the tables,
            // and if so, we would probably want to do that in the logic layer, and not in the data layer. For now, this convertion indeed is super silly, I agree.
            TableModel currentTableModel = new TableModel(currentTable.ID, currentTable.TableSize);

            return currentTableModel;
        }





        private DateTime JoinDateTime(List<object> rawData)
        {
            try
            {

                DateTime a_date = new DateTime((int)rawData[4], (int)rawData[5], (int)rawData[6], (int)rawData[7], (int)rawData[8], 0);
                return a_date;
            }
            catch
            {
                throw new Exception($"Date not found at {(int)rawData[4]}, {(int)rawData[5]}, {(int)rawData[6]}, {(int)rawData[7]}, {(int)rawData[8]}");
            }
        }



        //                                          create the ViewModel Classes

        public ReservationViewModel CreateReservationViewModel(Reservation reservation)
        {
            GuestViewModel resultGuestViewModel = CreateGuestViewModel(reservation.Guest);
            TableViewModel resultTableViewModel = CreateTableViewModel(reservation.Table);


            ReservationViewModel resultReservationViewModel = new ReservationViewModel(reservation.ID, resultTableViewModel, resultGuestViewModel, 
                reservation.PartySize, reservation.StartTime, reservation.EndTime, reservation.HidePrices, reservation.GuestComments);
            return resultReservationViewModel;
        }

        private TableViewModel CreateTableViewModel(Table table)
        {
            TableViewModel resultTableViewModel = new TableViewModel(table.ID, table.TableSize);

            return resultTableViewModel;
        }

        private GuestViewModel CreateGuestViewModel(Guest guest)
        {
            GuestViewModel resultGuestViewModel = new GuestViewModel(guest.ID, guest.Name, guest.TelephoneNumber, guest.EmailAddress);

            return resultGuestViewModel;
        }



        //******************************************Retrieving data from database*******************************************
        public List<ReservationViewModel> GetAllViewModels()
        {
            List<ReservationViewModel> resultList = new List<ReservationViewModel>();
            foreach(Reservation res in GetCompleteDB())
            {
                ReservationViewModel RVM = CreateReservationViewModel(res);

                resultList.Add(RVM);
            }
            return resultList;
        }





        public List<Reservation> GetCompleteDB()
        {
            
            return GetAllReservations();
        }

        private List<Guest> GetAllGuests()
        {
            List<Guest> GuestList = new List<Guest>();
            List<string> AllGuestInfos = _fileManager.ReadDB(FileManager.FilePaths.Guest);
            foreach (string GuestInfo in AllGuestInfos)
            {
                string[] guestInfoArray = GuestInfo.Split(',');
                long.TryParse(guestInfoArray[0], out long guest_ID);
                Guest guest = new Guest(guest_ID, guestInfoArray[1], guestInfoArray[2], guestInfoArray[3]);

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
                long.TryParse(ReservationInfoArray[1], out long GuestID);
                DateTime.TryParse(ReservationInfoArray[2], out DateTime StartTime);
                DateTime.TryParse(ReservationInfoArray[3], out DateTime EndTime);
                int.TryParse(ReservationInfoArray[4], out int PartySize);
                long.TryParse(ReservationInfoArray[5], out long TableID);
                bool.TryParse(ReservationInfoArray[6], out bool HidePrices);
                string GuestComments = ReservationInfoArray[7];

                Table table = GetAllTables().Single(findTable => findTable.ID == TableID);
                Guest guest = GetAllGuests().Single(findGuest => findGuest.ID == GuestID);

                Reservation reservation = new Reservation(ReservationID, table, guest, PartySize, StartTime, EndTime, HidePrices, GuestComments);

                GuestList.Add(reservation);
            }
            return GuestList;
        }
    }
}
