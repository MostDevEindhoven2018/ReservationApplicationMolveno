using Microsoft.VisualStudio.TestTools.UnitTesting;
// Namespace system?
using System;

namespace MolvenoReservationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Valid_InputBeginTime()
        {
            // BeginTime is not a time in the past
            // arrange
            int expected = -1;
            int inputHour = 21;
            int inputMinutes = 38;
            // Define outside if loop, can use it outside loop
            string inputTime;


            if (inputHour < 10 && inputMinutes < 10)
            {
                inputTime = $"0{Convert.ToString(inputHour)}:0{Convert.ToString(inputMinutes)}";
                Console.WriteLine(inputTime);
            }
            else if (inputHour < 10)
            {
                inputTime = $"0{Convert.ToString(inputHour)}:{Convert.ToString(inputMinutes)}";
                Console.WriteLine(inputTime);
            }
            else if (inputMinutes < 10)
            {
                inputTime = $"{Convert.ToString(inputHour)}:0{Convert.ToString(inputMinutes)}";
                Console.WriteLine(inputTime);
            }
            else
            {
                inputTime = $"{Convert.ToString(inputHour)}:{Convert.ToString(inputMinutes)}";
                Console.WriteLine(inputTime);

            }

            // act // some method?
            // https://stackoverflow.com/questions/10290187/how-to-compare-time-part-of-datetime
            // https://forums.asp.net/t/1025431.aspx?How+to+compare+Time+in+C+
            // Compare time t1 and t2
            // i = -1 means t1 < t2 ; i=0 equal; 1 t1>t2 
            DateTime t1 = DateTime.Now;
            DateTime t2 = Convert.ToDateTime(inputTime);

            int i = TimeSpan.Compare(t1.TimeOfDay, t2.TimeOfDay);

            // assert
            Assert.AreEqual(expected, i);

        }
    }
}
