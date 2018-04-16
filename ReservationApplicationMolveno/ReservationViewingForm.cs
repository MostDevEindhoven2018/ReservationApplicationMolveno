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
    public partial class ReservationViewingForm : Form
    {
        public List<Control> HeaderLabels = new List<Control>();

        public ReservationViewingForm()
        {
            InitializeComponent();

            

            HeaderLabels = new List<Control>
            {
                lbl_header,
                lbl_GuestName,
                lbl_partySize,
                lbl_tableNum,
                lbl_arrivalTime,
                lbl_EndTime,
                lbl_HidePrices,
                lbl_Comments
                

            };
        }
    }
}
