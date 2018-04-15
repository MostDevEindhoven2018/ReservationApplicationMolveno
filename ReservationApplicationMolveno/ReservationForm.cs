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

            ReservationLogic _ReservationLogic = ReservationLogic.Instance();
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
            ReservationLogic.Instance().CreateReservationModel(CollectData());

        }

        

        List<Object> CollectData()
        {
            // Collect all data from the form and put it into a list of objects. 
            // No conversions are done yet, this just collects the raw data.
            List<Object> FormData = new List<object>
            {
                inputNameGuest.Text,                                // Name of Guest, string            0 
                inputGuestPhoneNumber.Text,                         // PhoneNum of Guest, string        1
                inputGuestEmail.Text,                               // EmailAddress of Guest, string    2
                Convert.ToInt32(nud_numberOfGuests.Value),          // Party size, int                  3
                dtp_arrivingDate.Value.Year,                        // Year, int                        4
                dtp_arrivingDate.Value.Month,                       // Month, int                       5
                dtp_arrivingDate.Value.Day,                         // Day, int                         6
                Convert.ToInt32(inputBeginTimeHour.Text),           // Hour, int                        7
                Convert.ToInt32(inputBeginTimeMinute.Text)          // Minute, int                      8
            };

            return FormData;
        }
}
}
