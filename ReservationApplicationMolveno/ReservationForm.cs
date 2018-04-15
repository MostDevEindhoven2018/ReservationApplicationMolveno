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
        private ReservationLogic _ReservationLogic;

        public ReservationForm()
        {
            InitializeComponent();

            _ReservationLogic = new ReservationLogic();
            _ReservationLogic.CreateDB();
            dd_arrivingHour.Text = "21";
            dd_arrivingMinute.Text = "00";

            // Adds 0 till 23 hours to the combobox with the reservation time
            for (int i = 0; i <= 23; i++)
            {
                if (i < 10)
                {
                    dd_arrivingHour.Items.Add("0" + i);
                }
                else
                {
                    dd_arrivingHour.Items.Add(i);
                }

            }
            
            for (int i = 0; i < 60; i += 15)
            {
                if (i == 0)
                {
                    dd_arrivingMinute.Items.Add("00");
                }
                else
                {
                    dd_arrivingMinute.Items.Add(i);
                }
            }
        }

        private void bt_reserve_Click(object sender, EventArgs e)
        {
            guest = new Guest();
            reserve = new Reservation();
            
            _ReservationLogic.AddToDB(tb_guestName.Text, tb_guestPhone.Text,
                tb_guestEmail.Text, Convert.ToInt32(nud_numberOfGuests.Value), JoinDateTime(), 
                inputCommentGuest.Text, OptionHidePrices());

            // https://stackoverflow.com/questions/15569641/reset-all-the-items-in-a-form
            // Makes a new instance of the form and loads it
            //ReservationForm NewForm = new ReservationForm();
            //NewForm.Show();
            //this.Dispose(false);

            this.Clear();
        }

        private void Clear()
        {
            dtp_arrivingDate.Value = DateTime.Today;
            dd_arrivingHour.Text = DateTime.Now.TimeOfDay.ToString();
            dd_arrivingHour.Text = "21";
            dd_arrivingMinute.Text = "00";
            nud_numberOfGuests.Value = 4;
            tb_guestName.Clear();
            tb_guestPhone.Clear();
            tb_guestEmail.Clear();
            cb_hidePrices.Checked = false;
        }

        private string OptionHidePrices()
        {
            try
            {
                if (cb_hidePrices.Checked == true)
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
                int hour = Convert.ToInt32(dd_arrivingHour.Text);
                int minutes = Convert.ToInt32(dd_arrivingMinute.Text);
                DateTime a_date = new DateTime(year, month, day, hour, minutes, 0);
                return a_date;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return DateTime.Now;
            }
        }
    }
}
