



namespace BasicQueuingCashier
{

    public partial class Form1 : Form
    {
        private CashierClass cashier;
        CashierWindowQueueForm cf;
        public Form1()
        {
            InitializeComponent();

            cashier = new CashierClass();
            cf = new CashierWindowQueueForm();
            cf.Show();
        }

        private void btncashier_Click(object sender, EventArgs e)
        {

            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);


        }


    }
}