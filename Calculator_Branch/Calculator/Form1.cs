using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Calculator
{
    public partial class HQS_Calculator : MaterialForm

    {
        public HQS_Calculator()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void radioSelect(object sender, EventArgs e)
        {
            //Get number values
            double num1 = 0;
            double num2 = 0;
            try
            {
                num1 = Convert.ToDouble(txtGetal1.Text);
                num2 = Convert.ToDouble(txtGetal2.Text);
            }
            catch (System.Exception)
            {
            }


            foreach (RadioButton button in ActionBox.Controls.OfType<RadioButton>())
            {
                if (button.Checked)
                {
                    int caseID = Convert.ToInt32(button.Tag);
                    switch (caseID)
                    {
                        case 1:
                            checkChecker();
                            break;
                        case 2:
                            checkChecker();
                            break;
                        case 3:
                            checkChecker();
                            break;
                        case 4:
                            checkChecker();
                            break;
                        case 5:
                            checkChecker();
                            break;
                        case 6:
                            checkChecker();
                            break;
                    }
                }
            }
        }

        private void calc_Click(object sender, EventArgs e)
        {
            //Get number values
            double num1 = 0;
            double num2 = 0;
            try
            {
                num1 = Convert.ToDouble(txtGetal1.Text);
                num2 = Convert.ToDouble(txtGetal2.Text);
            }
            catch (System.Exception)
            {
            }

            foreach (RadioButton button in ActionBox.Controls.OfType<RadioButton>())
            {
                if (button.Checked)
                {
                    int caseID = Convert.ToInt32(button.Tag);
                    switch (caseID)
                    {
                        case 1:
                            txtUitkomst.Text = (num1 + num2).ToString();
                            break;
                        case 2:
                            txtUitkomst.Text = (num1 - num2).ToString();
                            break;
                        case 3:
                            txtUitkomst.Text = (num1 * num2).ToString();
                            break;
                        case 4:
                            if(num1 == 0 || num2 ==0)
                            {
                                MessageBox.Show("Can't divide by 0");
                                return;
                            }
                            txtUitkomst.Text = (num1 / num2).ToString();
                            break;
                        case 5:
                            txtUitkomst.Text = (Math.Pow(num1, num2)).ToString();
                            break;
                        case 6:
                            txtUitkomst.Text = (Math.Sqrt(num1)).ToString();
                            break;
                    }
                }
            }
        }

        public void checkChecker()
        {

            //Re-Enter the numbers
            updateCalc();

            //If root is selected only allow input of getal1
            if (radio6.Checked == true)
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
            
            if (radioEven.Checked)
            {
                tbGenerated.Text = generate_Even(Convert.ToInt32(reeksAmount.Value));
            }
            
            else if (radioFionacci.Checked)
            {
                tbGenerated.Text = generate_Fibonacci(Convert.ToInt32(reeksAmount.Value) + 2);
            }
            
            else if (radioPriem.Checked)
            {
                tbGenerated.Text = generate_Prime(Convert.ToInt32(reeksAmount.Value));
            }
        }

        //Generate even numbers
        public string generate_Even(int times)
        {
            int i = 1, found = 0;
            string even = string.Empty;
            while (found != times)
            {
                if (i % 2 == 0)
                {
                    found++;
                    even = String.Concat(even, i.ToString() + ", ");
                }
                i++;
            }
            return even.Remove(even.Length - 2);
        }

        //Generate prime numbers
        public string generate_Prime(int times)
        {
            int i = 1, found = 0;
            string prime = string.Empty;

            while (found != times)
            {
                if (isPrime(i))
                {

                    found++;
                    prime = String.Concat(prime, i.ToString() + ", ");
                };
                i++;
            }
            return prime.Remove(prime.Length - 2);
        }

        //Generate Fibonacci numbers
        public string generate_Fibonacci(int times)
        {
            int found = 0; 
            long n1 = 0, n2 = 1, n3;
            string fibonacci = string.Empty;

            if(times > 0)
            {
                found++;
                fibonacci = String.Concat(fibonacci, n1.ToString() + ", ");
            }
            if (times > 1)
            {
                found++;
                fibonacci = String.Concat(fibonacci, n2.ToString() + ", ");
            }

            while (found != times)
            {
                found++;
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                fibonacci = String.Concat(fibonacci, n3.ToString() + ", ");
            }
            return fibonacci.Remove(fibonacci.Length - 2);
        }

        //Check if prime
        public static bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Run change calc function on text edit of Getal1 & Getal2
        public void inter_TextChanged(object sender, EventArgs e)
        {
            updateCalc();
        }

        //Enter calc values into calculation preview textbox
        public void updateCalc()
        { 
            foreach (RadioButton button in ActionBox.Controls.OfType<RadioButton>())
            {
                if (button.Checked)
                {
                    int caseID = Convert.ToInt32(button.Tag);
                    switch (caseID)
                    {
                        case 1:
                            txtSom.Text = txtGetal1.Text + "+" + txtGetal2.Text;
                            break;
                        case 2:
                            txtSom.Text = txtGetal1.Text + "-" + txtGetal2.Text;
                            break;
                        case 3:
                            txtSom.Text = txtGetal1.Text + "*" + txtGetal2.Text;
                            break;
                        case 4:
                            txtSom.Text = txtGetal1.Text + "/" + txtGetal2.Text;
                            break;
                        case 5:
                            txtSom.Text = txtGetal1.Text + "²" + txtGetal2.Text;
                            break;
                        case 6:
                            txtSom.Text = txtGetal1.Text + "√";
                            break;
                    }
                }
            }
        }
    }
}
