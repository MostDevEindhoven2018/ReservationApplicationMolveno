using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationApplicationMolveno
{
    public partial class formReservation : Form
    {
        Reservation reserve=new Reservation();
        Guest guest1 = new Guest();
        Table table = new Table();

        public formReservation()
        {
            InitializeComponent();

            
            for (int i = 0; i <= 59; i++)
            {
                if (i < 10)
                {
                    string hours = "0" + i.ToString();
                    inputBeginTimeMinute.Items.Add(hours);
                }
                else
                {
                    string hours = i.ToString();
                    inputBeginTimeMinute.Items.Add(hours);
                }
            }


        }

        /*The createDateTime function  convert the date and time from string to int and sets 
        them together so that the DateTime type can get them*/
        DateTime createDateTime()
        {
            int year = dtp_arrivingDate.Value.Year;
            int month = dtp_arrivingDate.Value.Month;
            int day = dtp_arrivingDate.Value.Day;
            int hour = Convert.ToInt32(inputBeginTimeHour.Text);
            int minutes = Convert.ToInt32(inputBeginTimeMinute.Text);
            DateTime a_date = new DateTime(year, month, day, hour, minutes, 0);
            return a_date;
        }

        /*The collectData function gather all the information from the form and stores them
         the fields of the Reservation class {FYI: the Reservation class includes the Guest and
         Table classes}*/
        void collectData()
        {
            reserve.guest.guestName = inputNameGuest.Text;
            reserve.guest.guestPhoneno = inputGuestPhoneNumber.Text;
            reserve.guest.guestEmail = inputGuestEmail.Text;
            reserve.partySize = Convert.ToInt32(nud_numberOfGuests.Value);
            DateTime dateandTime = createDateTime();
            reserve.StartTime = dateandTime;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNumberOfGuests_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOptionHidePrices_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCommentOwner_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputSendReservation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void inputBeginTimeHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void inputNumberOfGuests_SelectedIndexChanged(object sender, EventArgs e)
        {            
            
        }

        private void inputSendReservation_MouseClick(object sender, MouseEventArgs e)
        {
            collectData();
        }

        private void inputNameGuest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
