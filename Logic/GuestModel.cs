using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Logic
{
    public class GuestModel
    {
        public long ID;
        public string Name;
        public string TelephoneNumber;
        public string EmailAddress;

        private static int globalGuestId;


        public GuestModel(string name, string telephoneNumber, string emailAddress)
        {
            ID = Interlocked.Increment(ref globalGuestId);
            Name = name;
            TelephoneNumber = telephoneNumber;
            EmailAddress = emailAddress;

        }
    }
}
