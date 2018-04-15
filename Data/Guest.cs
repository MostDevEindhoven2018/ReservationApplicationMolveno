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
        public string GuestComment;
        public string HidePrices;

        public Guest(int id, string name, string telephoneNumber, string emailAddress, string guestcomment, string hidePrices)
        {
            ID = id;
            Name = name;
            TelephoneNumber = telephoneNumber;
            EmailAddress = emailAddress;
            GuestComment = guestcomment;
            HidePrices = hidePrices;

        }
    }
}
