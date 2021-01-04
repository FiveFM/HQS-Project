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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbActie_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtSom.Text = "+";
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
            catch (System.Exception) {
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
        public void displayTotal(double Total) {
            txtUitkomst.Text =  Total.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioAftrekken_CheckedChanged(object sender, EventArgs e)
        {
            txtSom.Text = "-";
      checkChecker();
        }

        private void radioVermenigvuldigen_CheckedChanged(object sender, EventArgs e)
        {
            txtSom.Text = "X";
         checkChecker();
        }

        private void radioDelen_CheckedChanged(object sender, EventArgs e)
        {
            txtSom.Text = "/";
       checkChecker();
        }
        private void radiokwadraad_CheckedChanged(object sender, EventArgs e)
        {
            txtSom.Text = "²"; 
            checkChecker();
        }
        private void radioWortelCheckedChanged(object sender, EventArgs e)
        {
            txtSom.Text = "√";
          checkChecker();
            
        }

        public void checkChecker() {
            Console.WriteLine(radioWortel.Checked);
            if(radioWortel.Checked == true) {

            txtGetal2.Enabled = false;
            } else {
                txtGetal2.Enabled = true;
            }
        }

        //Het genereren vam de reeksen. 

        private void radioEven_CheckedChanged(object sender, EventArgs e)
        {
            txtGetal2.Enabled = true;
        }
        // If you reed this, you are nigga.
        private void radioFionacci_CheckedChanged(object sender, EventArgs e){
        }

        private void radioPriem_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnToon_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
