using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            DisplayCashierQueue(CashierClass.CashierQueue);
          //  listCashierQueue.Refresh();
        }


        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {

                labelnext.Text = CashierClass.CashierQueue.Peek();
                CashierClass.CashierQueue.Dequeue();


            }
            catch (Exception)
            {
                MessageBox.Show(" The list is empty  ", " FINISH ", MessageBoxButtons.OK);
            }

           
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick_1);
            timer.Start();

        }
    }
}
