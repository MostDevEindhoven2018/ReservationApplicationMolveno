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
        public void checks()
        {
            //Checking the input entered by the user or checking if nothing was entered
            if (txt_NameGuest.Text == "" && nud_numberOfGuests.Value == 0 && (txt_GuestPhonenumber.Text == "") && (txt_GuestEmail.Text == "") && dtp_arrivingDate.Value < DateTime.Today)
            {
                MessageBox.Show("You have not entered any information.Please enter your name,number of guests,arriving time,date and a phonenumber of email");

            }
            
            else if (txt_NameGuest.Text == "")
            {
                MessageBox.Show("Please enter your name in order to create the reservation.");

            }

            else if (nud_numberOfGuests.Value == 0 || nud_numberOfGuests.Text == "")
            {
                MessageBox.Show("Please enter the number of guests that will be attending this reservation");
            }

            else if ((txt_GuestPhonenumber.Text == "") && (txt_GuestEmail.Text == ""))
            {
                MessageBox.Show("You have not entered any communication contact (phone no/email.Please enter either one of those.");
            }

            else if (dtp_arrivingDate.Value < DateTime.Today)
            {
                MessageBox.Show("You have not selected a date.Please selected one!");
            }

            else if (cmb_Hours.Text == "" && cmb_Minutes.Text == "")
            {
                MessageBox.Show("Please enter the time you will be arriving");
            }


        }

        public ReservationForm()
        {
            InitializeComponent();

            ReservationLogic _ReservationLogic = ReservationLogic.Instance();
            _ReservationLogic.CreateDB();

            cmb_Hours.SelectedIndex = 0;
            cmb_Minutes.SelectedIndex = 0;

        }

        private void bt_reserve_Click(object sender, EventArgs e)
        {
            ReservationLogic.Instance().ProcessReservation(CollectData());

        }



        List<Object> CollectData()
        {
            checks();

            // Collect all data from the form and put it into a list of objects. 
            // No conversions are done yet, this just collects the raw data.
            List<Object> FormData = new List<object>
            {
                txt_NameGuest.Text,                                // Name of Guest, string            0 
                txt_GuestPhonenumber.Text,                         // PhoneNum of Guest, string        1
                txt_GuestEmail.Text,                               // EmailAddress of Guest, string    2
                Convert.ToInt32(nud_numberOfGuests.Value),          // Party size, int                  3
                dtp_arrivingDate.Value.Year,                        // Year, int                        4
                dtp_arrivingDate.Value.Month,                       // Month, int                       5
                dtp_arrivingDate.Value.Day,                         // Day, int                         6
                Convert.ToInt32(cmb_Hours.Text),           // Hour, int                        7
                Convert.ToInt32(cmb_Minutes.Text)          // Minute, int                      8
            };

            return FormData;
        }

        private void bt_ViewReservation_Click(object sender, EventArgs e)
        {
            // Get all ReservationViewModels
            List<ReservationViewModel> AllViewModels = ReservationLogic.Instance().GetAllViewModels();

            // open new form that shows all reservations.
            ReservationViewingForm RVF = new ReservationViewingForm();

            // clear everything 
            RVF.Controls.Clear();

            // Add the headers back
            foreach (Control control in RVF.HeaderLabels)
            {
                RVF.Controls.Add(control);
            }



            int x = 12;
            int y = 50;
            // For each reservation, create a list of every string that we want to present, then fill the labels with that info.
            foreach (ReservationViewModel RVM in AllViewModels)
            {
               

                List<string> ReservationInfo = new List<string>
                {RVM.GuestViewModel.Name,
                RVM.PartySize.ToString(),
                RVM.TableViewModel.ID.ToString(),
                RVM.StartTime.ToString(),
                RVM.EndTime.ToString()
                };

                for(int i = 0; i < ReservationInfo.Count; i++)
                {
                    Label namelabel = new Label();
                    namelabel.Location = new Point(x, y);
                    namelabel.Text = ReservationInfo[i];
                    RVF.Controls.Add(namelabel);

                    x += RVF.HeaderLabels[i+1].Width;
                }

                y += 20;
            }




            RVF.Show();
        }

        private void dtp_arrivingDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_arrivingDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("The date you have selected is in the past");
                dtp_arrivingDate.Value = DateTime.Now;
            }
        }

        private void inputNameGuest_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NameGuest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Numbers are not allowed.Please use letters.");
            }
        }

        private void inputGuestPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Characters are not allowed.Please use numbers.");
            }
        }
    }
}
