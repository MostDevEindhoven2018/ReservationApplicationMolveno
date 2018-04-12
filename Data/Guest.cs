using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Guest
    {
        public int ID;
        public string Name;
        public string TelephoneNumber;
        public string EmailAddress;

        public Guest(int id, string name, string telephoneNumber, string emailAddress)
        {
            ID = id;
            Name = name;
            TelephoneNumber = telephoneNumber;
            EmailAddress = emailAddress;

        }
    }
}
