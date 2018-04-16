using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class FileManager
    {
        private static FileManager _instance;

        protected FileManager()
        {
        }

        public static FileManager Instance()
        {
            if (_instance == null)
            {
                _instance = new FileManager();

            }

            return _instance;
        }


        public enum FilePaths
        {
            Folder,
            Reservation,
            Table,
            Guest
        }


        public void AddReservationToDB(Reservation reservation, Guest guest)
        {
            // convert all the information from the reservation class to single line strings. Tab deliminated.
            string ResInfo = ConvertToFileLine(reservation);
            string GuestInfo = ConvertToFileLine(guest);


            // Get all file paths
            

            Dictionary<string, string> FileInfoDict = new Dictionary<string, string>
            {
                { GetFilePath(FilePaths.Reservation), ResInfo },
                { GetFilePath(FilePaths.Guest), GuestInfo } 
            };

            foreach (KeyValuePair<string, string> fileInfo in FileInfoDict)
            {

                try
                {
                    using (StreamWriter fs = new StreamWriter(fileInfo.Key, true))
                    {
                        // Add some information to the file.
                        fs.WriteLine(fileInfo.Value);
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }



        public List<string> ReadDB(FilePaths fp)
        {
            List<string> DBStringList = new List<string>();

            try
            {
                string dirPath = Path.Combine(Directory.GetCurrentDirectory(), "DataBase");
                string filePath = GetFilePath(fp);



                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(filePath))
                {
                    // Cut out the header by reading it and not doing anything with it.
                    sr.ReadLine();

                    // Actually read the file.
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        DBStringList.Add(s);
                    }

                    return DBStringList;
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return DBStringList;
            }
        }

        public void CreateDB()
        {
           

            Dictionary<string, string> FileHeaders = new Dictionary<string, string>
            {
                {GetFilePath(FilePaths.Reservation), "Reservation_ID, Guest_ID, Start_Time, End_Time , Party_Size , Table_Number , Hide_Prices , Guest_Comments"},
                {GetFilePath(FilePaths.Table), "Table_Number , Table_Size"},
                {GetFilePath(FilePaths.Guest), "Guest_ID , Guest_Name , Telephone_Number , Email_Address"}
            };

            if (!Directory.Exists(GetFilePath(FilePaths.Folder)))
            {
                Directory.CreateDirectory(GetFilePath(FilePaths.Folder));
            }

            foreach (KeyValuePair<string, string> fileInfo in FileHeaders)
            {
                if (!File.Exists(fileInfo.Key))
                {
                    try
                    {
                        // Create the file.
                        using (StreamWriter fs = new StreamWriter(fileInfo.Key, true))
                        {
                            // Add some information to the file.
                            fs.WriteLine(fileInfo.Value);
                        }

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }


        private string GetFilePath(FilePaths fp)
        {
            string dirPath = Path.Combine(Directory.GetCurrentDirectory(), "DataBase");
            string resultString = "";

            switch (fp)
            {
                case FilePaths.Folder:
                    resultString = dirPath;
                    break;
                case FilePaths.Reservation:
                    resultString = Path.Combine(dirPath, "Rudimentary_Reservation_DB.csv");
                    break;
                case FilePaths.Table:
                    resultString = Path.Combine(dirPath, "Rudimentary_Table_DB.csv");
                    break;
                case FilePaths.Guest:
                    resultString = Path.Combine(dirPath, "Rudimentary_Guest_DB.csv");
                    break;
                default:
                    throw new Exception($"Unknown Enumerate value detected: {fp}");
            }
            return resultString;
        }
        


        public string ConvertToFileLine(Reservation r)
        {

            return r.ID.ToString() + "," + r.Guest.ID.ToString() + "," + r.StartTime + "," + r.EndTime +
                "," + r.PartySize + "," + r.Table.ID.ToString() + "," + r.HidePrices.ToString() + "," + r.GuestComments;
        }

        public string ConvertToFileLine(Guest g)
        {

            return g.ID.ToString() + "," + g.Name + "," + g.TelephoneNumber + "," + g.EmailAddress;
        }

        public string ConvertToFileLine(Table t)
        {
            return t.ID.ToString() + "," + t.TableSize.ToString();
        }
    }
}
