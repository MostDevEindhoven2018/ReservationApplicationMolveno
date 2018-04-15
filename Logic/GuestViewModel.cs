using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class GuestViewModel
    {
        public long ID;
        public string Name;
        public string TelephoneNumber;
        public string EmailAddress;

        public GuestViewModel(long id, string name, string telephoneNumber, string emailAddress)
        {
            ID = id;
            Name = name;
            TelephoneNumber = telephoneNumber;
            EmailAddress = emailAddress;

        }
    }
}
