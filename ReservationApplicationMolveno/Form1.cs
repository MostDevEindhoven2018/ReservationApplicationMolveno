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
        public formReservation()
        {
            InitializeComponent();

            // Adjusted from https://social.msdn.microsoft.com/Forums/en-US/03255b04-536e-4905-85cb-d28a5f851828/combobox-items-addrange-from-0-to-c?forum=csharplanguage
            // Adds 1 till 10 to the combobox with number of guests
            for (int i = 1; i <= 10; i++)
            {
                string numbers = i.ToString();
                inputNumberOfGuests.Items.Add(numbers);
            }
            // Adds the string "more" to the combobox with the number of guests when there will be more than 10 guests for the reservation
            inputNumberOfGuests.Items.Add("More");

            // Adds 0 till 23 hours to the combobox with the reservation time
            for (int i = 0; i <= 23; i++)
            {
                if (i < 10)
                {
                    string hours = "0"+i.ToString();
                    inputBeginTimeHour.Items.Add(hours);
                }
                else
                {
                    string hours = i.ToString();
                    inputBeginTimeHour.Items.Add(hours);
                }
                                
            }

            // Adds 0 till 59 to the combobox with the reservation time
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
    }
}
