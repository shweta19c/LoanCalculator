namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        decimal loan_amount = 0.00m;
        int number_of_months = 0;
        decimal interest_rate = 0.005m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            //assign new values to the variables
            /*
            try { 
            loan_amount = decimal.Parse( txt_LoanAmount.Text);
            number_of_months = int.Parse(txt_NumberOfMonths.Text);
            interest_rate = decimal.Parse( txt_InterestRate.Text);
            }
            catch {
                MessageBox.Show("Please enter a number here.");
            }
            */

            if (decimal.TryParse(txt_LoanAmount.Text, out loan_amount))
            {
                if (int.TryParse(txt_NumberOfMonths.Text, out number_of_months))
                {
                    if (decimal.TryParse(txt_InterestRate.Text, out interest_rate))
                    {
                        //success

                        //calculate the loan
                        int counter = 0;
                        while (counter < number_of_months)
                        {
                            loan_amount = loan_amount + loan_amount * interest_rate;
                            listBox1.Items.Add("At month " + counter + " the loan is " + loan_amount.ToString("c"));
                            //counter = counter + 1;
                            counter++;
                        }
                        //Done with the while loop
                        txt_FinalValue.Text = loan_amount.ToString("c");
                    }
                }
            }


            // MessageBox.Show("You entered " + loan_amount + " Rs amount with months = " + number_of_months + " months and rate = " + interest_rate + " interest rate");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_FinalValue.Text = "";
            txt_InterestRate.Text = "";
            txt_LoanAmount.Text = "";
            txt_NumberOfMonths.Text = "";
            listBox1.Items.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
