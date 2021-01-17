using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wypozyczalniaSamochodow
{
    public partial class ReservationEditingPanel : UserControl
    {
        Reservation reservation;
        public ReservationEditingPanel()
        {
            InitializeComponent();
        }

        public void show(Reservation res)
        {
            reservation = res;
            Show();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dateFromPicker_ValueChanged(object sender, EventArgs e)
        {
            reservation.dateBegin = changeDateFormat(dateFromPicker.Value.Date.ToString());
            dateToPicker.MinDate = dateFromPicker.Value.AddDays(1);
        }

        private void dateToPicker_ValueChanged(object sender, EventArgs e)
        {
            reservation.dateEnd = changeDateFormat(dateToPicker.Value.Date.ToString());
            dateFromPicker.MaxDate = dateToPicker.Value.AddDays(-1);
        }

        public string changeDateFormat(string date)
        {
            return String.Join("-", date.Split(' ')[0].Split('.').Reverse());
        }
    }

    
}
