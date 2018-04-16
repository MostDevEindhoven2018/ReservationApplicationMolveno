using System;
using System.Collections.Generic;
using System.Drawing;
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
            ReservationLogic.Instance().ProcessReservation(CollectData());

        }



        List<Object> CollectData()
        {
            // Collect all data from the form and put it into a list of objects. 
            // No conversions are done yet, this just collects the raw data.
            List<Object> FormData = new List<object>
            {
                txt_NameGuest.Text,                                // Name of Guest, string            0 
                inputGuestPhoneNumber.Text,                         // PhoneNum of Guest, string        1
                inputGuestEmail.Text,                               // EmailAddress of Guest, string    2
                Convert.ToInt32(nud_numberOfGuests.Value),          // Party size, int                  3
                dtp_arrivingDate.Value.Year,                        // Year, int                        4
                dtp_arrivingDate.Value.Month,                       // Month, int                       5
                dtp_arrivingDate.Value.Day,                         // Day, int                         6
                Convert.ToInt32(inputBeginTimeHour.Text),           // Hour, int                        7
                Convert.ToInt32(inputBeginTimeMinute.Text),         // Minute, int                      8
                inputCommentGuest.Text,                             // User comments, string            9
                inputOptionHidePrices.Checked                       // hide prices, bool                10
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
                RVM.EndTime.ToString(),
                RVM.HidePrices.ToString(),
                RVM.GuestComments.ToString()
            };
                

                for(int i = 0; i < ReservationInfo.Count; i++)
                {
                    x = RVF.HeaderLabels[i + 1].Location.X;

                    Label ResLabel = new Label();
                    ResLabel.Location = new Point(x, y);
                    ResLabel.AutoSize = true;
                    ResLabel.Text = ReservationInfo[i];
                    RVF.Controls.Add(ResLabel);
                }

                x = 12;
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
