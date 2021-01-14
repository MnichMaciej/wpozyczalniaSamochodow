using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wypozyczalniaSamochodow;

namespace wypozyczalniaSamochodow
{
    public partial class CarConditionPanel : UserControl
    {
        Reservation reservation;
        public CarConditionPanel()
        {
            InitializeComponent();
            finePanel.Hide();
        }

        public void Show(Reservation reservation)
        {
            this.reservation = reservation;
            Show();
            BringToFront();
        }

        private async void save(object sender, EventArgs e)
        {
            if (fineCheckbox.Checked)
            {
                Fine fine = new Fine();
                await saveFine(fine).ContinueWith( async task =>
                {
                    int fineId = (int)task.Result;
                    reservation.fineId = fineId;
                    reservation._checked = true;
                    await DatabaseService.updateReservation(reservation);
                });
            }
            if (!efficientCheckbox.Checked)
            {
                Car car = new Car();
                car.registrationNumber = reservation.registrationNumber;
                car.carEfficiency = efficientCheckbox.Checked;
                await DatabaseService.updateCar(car);
            }
            Hide();
        }

        private async Task<long> saveFine(Fine fine)
        {
            fine.fineCost = (double)cost.Value;
            fine.fineDescription = description.Text;
            finePanel.Hide();
            return await DatabaseService.insertFine(fine);

        }

        private void fineCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (fineCheckbox.Checked)
            {
                finePanel.Show();
            }
        }
    }
}
