using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnBereken_Click(object sender, EventArgs e)
        {

            //Get number values
            double num1 = Convert.ToDouble(txtGetal1.Text);
            double num2 = 0;
            try
            {
                num2 = Convert.ToDouble(txtGetal2.Text);
            }
            catch (System.Exception)
            {
            }
            //
            //Add
            if (RadioOptellen.Checked)
            {
                displayTotal(num1 + num2);
            }
            //Multiply
            else if (radioVermenigvuldigen.Checked)
            {
                displayTotal(num1 * num2);
            }
            //Substract
            else if (radioAftrekken.Checked)
            {
                displayTotal(num1 - num2);
            }
            //Divide
            else if (radioDelen.Checked)
            {
                displayTotal(num1 / num2);
            }
            //Squared
            else if (radioKwadraad.Checked)
            {
                displayTotal(Math.Pow(num1, num2));
            }
            //Root
            else if (radioWortel.Checked)
            {
                displayTotal(Math.Sqrt(num1));
            }
        }

        //Calculated value
        public void displayTotal(double Total)
        {
            txtUitkomst.Text = Total.ToString();
        }

        //Close program on click
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_CheckedChanged(object sender, EventArgs e)
        {
            txtSom.Text = "+";
            checkChecker();
        }

        private void substract_CheckedChanged(object sender, EventArgs e)
        {
            txtSom.Text = "-";
            checkChecker();
        }

        private void times_CheckedChanged(object sender, EventArgs e)
        {
            txtSom.Text = "X";
            checkChecker();
        }

        private void divide_CheckedChanged(object sender, EventArgs e)
        {
            txtSom.Text = "/";
            checkChecker();
        }
        private void squared_CheckedChanged(object sender, EventArgs e)
        {

            txtSom.Text = "²";
            checkChecker();
        }
        private void root_CheckedChanged(object sender, EventArgs e)
        {
            txtGetal2.Text = "";
            txtSom.Text = "√";
            checkChecker();
        }

        public void checkChecker()
        {
            if (radioWortel.Checked == true)
            {

                txtGetal2.Enabled = false;
            }
            else
            {
                txtGetal2.Enabled = true;
            }
        }

        //Block text from number input fields
        private void inter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If char is not special char // not a number // not a comma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                //Block input
                e.Handled = true;
            }

            //If comma exists block comma
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                //Block input
                e.Handled = true;
            }
        }

        //Het genereren vam de reeksen. 
        private void btnToon_Click(object sender, EventArgs e)
        {
            //Even
            if (radioEven.Checked)
            {
                tbGenerated.Text = generate_Even(Convert.ToInt32(reeksAmount.Value));
            }
            //Fionacci
            else if (radioFionacci.Checked)
            {
                tbGenerated.Text = generate_Fibonacci(Convert.ToInt32(reeksAmount.Value) + 2);
            }
            //Prime
            else if (radioPriem.Checked)
            {
                tbGenerated.Text = generate_Prime(Convert.ToInt32(reeksAmount.Value));
            }
        }

        //Generate even numbers
        public string generate_Even(int times)
        {
            //Amount of found even numbers
            int found = 0;
            //Empty string to add numbers to
            string even = string.Empty;
            //Random data class
            Random num = new Random();

            //While found isn't times keep looking for new even numbers
            while (found != times)
            {
                //Generate random number
                int random = num.Next(100);
                //Check if that random number is even
                if (random % 2 == 0)
                {
                    //Add to found
                    found++;
                    //Add to even number list
                    even = String.Concat(even, random.ToString() + ", ");
                }
            }
            //Return final even number list as string
            return even.Remove(even.Length - 2);
        }

        //Generate prime numbers
        public string generate_Prime(int times)
        {
            //Amount of found prime numbers
            int found = 0;
            //Empty string to add numbers to
            string prime = string.Empty;
            //Random data class
            Random num = new Random();

            //While found isn't times keep looking for new prime numbers
            while (found != times)
            {
                //Generate random number
                int random = num.Next(10);
                //Check if number is prime number
                if (isPrime(random))
                {

                    //Add to found
                    found++;
                    //Add to prime number list
                    prime = String.Concat(prime, num.Next(10).ToString() + ", ");
                };
            }
            //Return final prime number list as string
            return prime.Remove(prime.Length - 2);
        }

        //Generate Fibonacci numbers
        public string generate_Fibonacci(int times)
        {
            int n1 = 0; int n2 = 1; int n3; int i = 0;
            //Amount of found prime numbers
            int found = 0;
            //Empty string to add numbers to
            string fibonacci = string.Empty;
            //Random data class
            Random num = new Random();

            int number = num.Next(10);
            for (i = 2; i < times; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;

                fibonacci = String.Concat(fibonacci, n3.ToString() + ", ");

                //n3 is true
            }
            return fibonacci.Remove(fibonacci.Length - 2);
        }

        //Check if prime number
        public static bool isPrime(int number)
        {
            //Check if number complies with prime number rules
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            //Check if its even
            var boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            //Return true if number is prime number
            return true;
        }
    }
}
