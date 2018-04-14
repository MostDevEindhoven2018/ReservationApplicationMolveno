using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using System.Windows.Forms;

namespace ReservationApplicationMolveno
{
    public partial class ReservationForm : Form
    {

        public ReservationForm()
        {
            InitializeComponent();

            ReservationLogic _ReservationLogic = new ReservationLogic();
            _ReservationLogic.CreateDB();


            // Adds 0 till 23 hours to the combobox with the reservation time
            for (int i = 0; i <= 23; i++)
            {
                if (i < 10)
                {
                    inputBeginTimeHour.Items.Add("0" + i);
                }
                else
                {
                    inputBeginTimeHour.Items.Add(i);
                }

            }

            for (int i = 0; i < 60; i += 15)
            {
                if (i == 0)
                {
                    inputBeginTimeMinute.Items.Add("00");
                }
                else
                {
                    inputBeginTimeMinute.Items.Add(i);
                }
            }
        }

        private void bt_reserve_Click(object sender, EventArgs e)
        {
            CollectData();

        }

        private DateTime JoinDateTime()
        {
            try
            {
                int year = dtp_arrivingDate.Value.Year;
                int month = dtp_arrivingDate.Value.Month;
                int day = dtp_arrivingDate.Value.Day;
                int hour = Convert.ToInt32(inputBeginTimeHour.Text);
                int minutes = Convert.ToInt32(inputBeginTimeMinute.Text);
                DateTime a_date = new DateTime(year, month, day, hour, minutes, 0);
                return a_date;
            }
            catch
            {
                return new DateTime(1970, 1, 1, 0, 0, 0);
            }
        }

        List<Object> CollectData()
        {
            List<Object> FormData = new List<object>
            {
                inputNameGuest.Text,                                // Name of Guest, string
                inputGuestPhoneNumber.Text,                         // PhoneNum of Guest, string
                inputGuestEmail.Text,                               // EmailAddress of Guest, string
                Convert.ToInt32(nud_numberOfGuests.Value),          // Party size, int
                JoinDateTime()                                      // Arrival time, DateTime
            };

            return FormData;
        }
    }
}
