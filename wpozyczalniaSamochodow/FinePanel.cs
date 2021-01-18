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
    public partial class FinePanel : UserControl
    {
        Account account;
        List<Fine> fines = new List<Fine>();
        public FinePanel()
        {
            InitializeComponent();
        }
        public void showPanel(Account acc)
        {
            account = acc;
            fineTable.Rows.Clear();
            getFinesList(account);
            Show();
        }

        private void hide(object sender, EventArgs e)
        {
            Hide();
        }

        private async void getFinesList(Account acc)
        {
            await DatabaseService.getFines(acc).ContinueWith(task =>
            {
                fines = task.Result;
                foreach (Fine fine in fines)
                {
                    if (fineTable.InvokeRequired)
                        fineTable.Invoke(new Action(() => addFineTableRow(fine)));
                    else
                        addFineTableRow(fine);

                }
            });
        }

        //metoda 'addFineTableRow' została dodana ze względu na wymagania frameworka Windows.Forms
        //wypełnienia tabeli danymi
        private void addFineTableRow(Fine fine)
        {
            var index = fineTable.Rows.Add();
            fineTable.Rows[index].Cells["id"].Value = fine.fineId;
            fineTable.Rows[index].Cells["cost"].Value = fine.fineCost;
            fineTable.Rows[index].Cells["description"].Value = fine.fineDescription;
        }
    }
}
