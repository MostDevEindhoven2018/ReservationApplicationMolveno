using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace ReservationApplicationMolveno
{
    public partial class ReservationForm : Form
    {
        private Guest guest;
        private Reservation reserve;

        public ReservationForm()
        {
            InitializeComponent();



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
            guest = new Guest();
            reserve = new Reservation();

            ReservationLogic _ReservationLogic = new ReservationLogic();
            _ReservationLogic.CreateDB();
            _ReservationLogic.AddToDB(inputNameGuest.Text, inputGuestPhoneNumber.Text,
                inputGuestEmail.Text, Convert.ToInt32(nud_numberOfGuests.Value), JoinDateTime(), 
                inputCommentGuest.Text, OptionHidePrices());

            // https://stackoverflow.com/questions/15569641/reset-all-the-items-in-a-form
            // Makes a new instance of the form and loads it
            ReservationForm NewForm = new ReservationForm();
            NewForm.Show();
            this.Dispose(false);



        }

        private string OptionHidePrices()
        {
            try
            {
                if (inputOptionHidePrices.Checked == true)
                {
                    string hide = "Please hide prices";
                    return hide;
                }
                else
                {
                    string notHide = "Please do not hide prices";
                    return notHide;
                }
            }
            catch
            {
                string error = "Please confirm if guest want to hide prices";
                return error;
            }
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
            catch           {
                return new DateTime(1970, 1, 1, 0, 0, 0);
            }
        }

        //void collectData()
        //{
        //    reserve.Guest.Name = inputNameGuest.Text;
        //    reserve.Guest.PhoneNumber = inputGuestPhoneNumber.Text;
        //    reserve.Guest.Email = inputGuestEmail.Text;
        //    reserve.PartySize = Convert.ToInt32(nud_numberOfGuests.Value);
        //    reserve.ArrivalDateTime = JoinDateTime();




        //}
    }
}
