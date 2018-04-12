using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class FileManager
    {

        public void AddToDB(Reservation reservation)
        {
            // convert all the information from the reservation class to single line strings. Tab deliminated.
            string ResInfo = ConvertToFileLine(reservation);
            string GuestInfo = ConvertToFileLine(reservation.Guest);
            string TableInfo = ConvertToFileLine(reservation.Table);


            // Get all file paths
            string dirPath = Path.Combine(Directory.GetCurrentDirectory(), "DataBase");
            string ReservationFilePath = Path.Combine(dirPath, "Rudimentary_Reservation_DB.csv");
            string TableFilePath = Path.Combine(dirPath, "Rudimentary_Table_DB.csv");
            string GuestFilePath = Path.Combine(dirPath, "Rudimentary_Guest_DB.csv");

            Dictionary<string, string> FileInfoDict = new Dictionary<string, string>
            {
                { ReservationFilePath, ResInfo },
                { GuestFilePath, GuestInfo },
                { TableFilePath, TableInfo }
            };

            foreach (KeyValuePair<string, string> fileInfo in FileInfoDict)
            {

                try
                {
                    // Create the file.
                    using (FileStream fs = File.Open(fileInfo.Key, FileMode.Append))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes(fileInfo.Value);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void ReadDB()
        {
            try
            {
                string dirPath = Path.Combine(Directory.GetCurrentDirectory(), "DataBase");
                string filePath = Path.Combine(dirPath, "RudimentaryDB.csv");

                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void CreateDB()
        {
            string dirPath = Path.Combine(Directory.GetCurrentDirectory(), "DataBase");
            string ReservationFilePath = Path.Combine(dirPath, "Rudimentary_Reservation_DB.csv");
            string TableFilePath = Path.Combine(dirPath, "Rudimentary_Table_DB.csv");
            string GuestFilePath = Path.Combine(dirPath, "Rudimentary_Guest_DB.csv");

            List<string> ListOfDataBaseFilePaths = new List<string> { ReservationFilePath, TableFilePath, GuestFilePath };

            foreach (string path in ListOfDataBaseFilePaths)
            {
                try
                {
                    if (!Directory.Exists(dirPath))
                    {
                        Directory.CreateDirectory(dirPath);
                    }

                    // Delete the file if it exists.
                    if (!File.Exists(path))
                    {
                        // Note that no lock is put on the
                        // file and the possibility exists
                        // that another process could do
                        // something with it between
                        // the calls to Exists and Delete.
                        File.Create(path);
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }


        public string ConvertToFileLine(Reservation r)
        {

            return r.ID.ToString() + "\t" + r.Guest.ID.ToString() + "\t" + r.StartTime + "\t" + r.EndTime +
                "\t" + r.PartySize + "\t" + r.Table;
        }

        public string ConvertToFileLine(Guest g)
        {

            return g.ID.ToString() + "\t" + g.Name + "\t" + g.TelephoneNumber + "\t" + g.EmailAddress;
        }

        public string ConvertToFileLine(Table t)
        {
            return t.ID.ToString() + "\t" + t.TableSize.ToString();
        }
    }
}
