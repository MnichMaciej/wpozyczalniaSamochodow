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
    public partial class CustomerClient : UserControl
    {
        public Account acc;
        public CustomerClient()
        {
            InitializeComponent();
            carRentalPanel1.Hide();
            carReturnPanel1.Hide();
            finePanel1.Hide();
            reservationPanel1.Hide();
        }
        public void show(Account account)
        {
            acc = account;
        }

        public void openCarRentalPanel(Account account)
        {
            carRentalPanel1.show(account);
        }

        public void openCarReturnPanel(Account account)
        {
            carReturnPanel1.show(account);

        }

        public void openFinePanel(Account account)
        {
            finePanel1.showPanel(account);

        }

        public void openReservationPanel(Account account)
        {
            reservationPanel1.show(account);

        }

        //metoday zostały dodane ze względu na wymagania frameworka Windows.Forms
        //są uruchamiane gdy użytkownik użyje danego przycisku
        private void CarReturnPanelButton_Click(object sender, EventArgs e)
        {
            openCarReturnPanel(acc);
        }

        private void reservationPanelButton_Click(object sender, EventArgs e)
        {
            openReservationPanel(acc);
        }

        private void FinePanelButton_Click(object sender, EventArgs e)
        {
            openFinePanel(acc);
        }

        private void CarRentalPanelButton_Click(object sender, EventArgs e)
        {
            openCarRentalPanel(acc);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}