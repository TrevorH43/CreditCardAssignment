using System.ComponentModel;
using System.Text;

namespace CreditCardAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;

            var fileName = "states.txt";
            if (File.Exists(fileName))
            {
                StreamReader textFile = new StreamReader(fileName);
                string states;
                while ((states = textFile.ReadLine()) != null)
                {
                    stateListBox.Items.Add(states);
                }
                textFile.Close();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                StringBuilder sb = new StringBuilder();




                MessageBox.Show(sb.ToString(), "Text Entry");
            }
            else
            {
                MessageBox.Show("Please correct entry errors.", "Entry Errors",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                errorProvider.SetError(nameTextBox, "Name is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(nameTextBox, "");
                e.Cancel = false;
            }
        }

        private void addressTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (addressTextBox.Text.Length == 0)
            {
                errorProvider.SetError(addressTextBox, "Address is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(addressTextBox, "");
                e.Cancel = false;
            }
        }

        private void cityTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cityTextBox.Text.Length == 0)
            {
                errorProvider.SetError(cityTextBox, "City is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cityTextBox, "");
                e.Cancel = false;
            }
        }

        private void postalCodeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (postalCodeTextBox.Text.Length == 0)
            {
                errorProvider.SetError(postalCodeTextBox, "Postal code is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(postalCodeTextBox, "");
                e.Cancel = false;
            }
        }

        private void emailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (emailTextBox.Text.Length == 0)
            {
                errorProvider.SetError(emailTextBox, "Email is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(emailTextBox, "");
                e.Cancel = false;
            }
        }
        private void securityCodeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (securityCodeTextBox.Text.Length == 0)
            {
                errorProvider.SetError(securityCodeTextBox, "Security code is required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(securityCodeTextBox, "");
                e.Cancel = false;
            }
        }

        private void creditCardTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (creditCardTextBox.Text.Length == 0)
            {
                errorProvider.SetError(creditCardTextBox, "Credit card number is required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(creditCardTextBox, "");
                e.Cancel = false;
            }
        }

        private void creditCardTextBox_TextChanged(object sender, EventArgs e)
        {
            int sum = 0, d;
            string num = "7992739871";
            int a = 0;

            for (int i = num.Length - 2; i >= 0; i--)
            {
                d = Convert.ToInt32(num.Substring(i, 1));
                if (a % 2 == 0)
                    d = d * 2;
                if (d > 9)
                    d -= 9;
                sum += d;
                a++;
            }

            if ((10 - (sum % 10) == Convert.ToInt32(num.Substring(num.Length - 1))))
                Console.WriteLine("valid");

            Console.WriteLine("sum of digits of the number" + sum);
        }


        private void stateListBox_Validating(object sender, CancelEventArgs e)
        {
            if (stateListBox.SelectedIndex == -1)
            {
                errorProvider.SetError(stateListBox, "Please select a state");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(stateListBox, "");
                e.Cancel = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}