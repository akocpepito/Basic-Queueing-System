using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Queueing_System
{
    public partial class QueueingForm : Form
    {
        private CashierClass cashier;

        public QueueingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();

            CashierWindowQueueForm cwqf = new CashierWindowQueueForm();
            cwqf.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            

            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);


        }
    }
}
