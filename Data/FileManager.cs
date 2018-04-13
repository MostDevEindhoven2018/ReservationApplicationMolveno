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
            List<string> FilePaths = GetFilePaths();


            Dictionary<string, string> FileInfoDict = new Dictionary<string, string>
            {
                { FilePaths[1], ResInfo },
                { FilePaths[2], TableInfo },
                { FilePaths[3], GuestInfo }
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



        public List<string> ReadDB(int ReservationId)
        {
            List<string> DBStringList = new List<string>();

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
            List<string> FilePaths = GetFilePaths();

            Dictionary<string, string> FileHeaders = new Dictionary<string, string>
            {
                {FilePaths[1], "Reservation_ID, Guest_ID, Start_Time, End_Time , Party_Size , Table_Number"},
                {FilePaths[2], "Table_Number , Table_Size"},
                {FilePaths[3], "Guest_ID , Guest_Name , Telephone_Number , Email_Address"}
            };

            if (!Directory.Exists(FilePaths[0]))
            {
                Directory.CreateDirectory(FilePaths[0]);
            }

            foreach (KeyValuePair<string, string> fileInfo in FileHeaders)
            {
                if (!File.Exists(fileInfo.Key))
                {
                    //try
                    //{
                    //    // Create the file.
                    //    using (FileStream fs = File.Create(fileInfo.Key))
                    //    {
                    //        Byte[] info = new UTF8Encoding(true).GetBytes(fileInfo.Value);
                    //        // Add some information to the file.
                    //        fs.Write(info, 0, info.Length);
                    //        fs.Flush();
                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    Console.WriteLine(ex.ToString());
                    //}

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


        private List<string> GetFilePaths()
        {

            string dirPath = Path.Combine(Directory.GetCurrentDirectory(), "DataBase");
            string ReservationFilePath = Path.Combine(dirPath, "Rudimentary_Reservation_DB.csv");
            string TableFilePath = Path.Combine(dirPath, "Rudimentary_Table_DB.csv");
            string GuestFilePath = Path.Combine(dirPath, "Rudimentary_Guest_DB.csv");

            List<string> FilePathArray = new List<string> { dirPath, ReservationFilePath, TableFilePath, GuestFilePath };

            return FilePathArray;
        }


        public string ConvertToFileLine(Reservation r)
        {

            return r.ID.ToString() + "," + r.Guest.ID.ToString() + "," + r.StartTime + "," + r.EndTime +
                "," + r.PartySize + "," + r.Table.ID.ToString();
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
