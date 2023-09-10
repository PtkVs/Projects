using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Total;
        string option;

        decimal a;
        decimal b;
        decimal num1;
        decimal num2;        
        decimal result;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text; // txtDisplay.Text = txtDisplay.Text + "1"; yesari garda pani hunxa direct code mai value rakhne rather than taking what is from the txt of button
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            
            txtDisplay.Text = txtDisplay.Text + "2";
        }


        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
            option = ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            decimal.TryParse(txtDisplay.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out a);
            num1 = a;

            //  txtDisplay.Text = txtDisplay.Text + btnAdd.Text; kaam xaina as + sign audaina cz clear gariraxu 


            txtDisplay.Clear();  //classic calu ko jasto banaune ho vane         
        }  
        

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            //txtDisplay.Text = txtDisplay.Text + btnSubstract.Text;
            option = "-";
            decimal.TryParse(txtDisplay.Text, out a);
            num1 = a;
            txtDisplay.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            // txtDisplay.Text = txtDisplay.Text + btnMultiply.Text;
            option = "*";
            decimal.TryParse(txtDisplay.Text, out a);
            num1 = a;
            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //  txtDisplay.Text = txtDisplay.Text + btnDivide.Text;
            option = "/";
            decimal.TryParse(txtDisplay.Text, out a);  
            num1 = a;
            txtDisplay.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

            if (option.Equals("+")) //option == "+" same ho
            {
                decimal.TryParse(txtDisplay.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out b);
                num2 = b;
                result = num1 + num2;
            }

            if (option.Equals("-"))
            {
                decimal.TryParse(txtDisplay.Text, out b);
                num2 = b;
                result = num1 - num2;
            }

            if (option.Equals("*"))
            {
                decimal.TryParse(txtDisplay.Text, out b);
                num2 = b;
                result = num1 * num2;
            }

            if (option.Equals("/"))
            {
                decimal.TryParse(txtDisplay.Text, out b);
                num2 = b;
                result = num1 / num2;
            }



            
            Total = result.ToString();
            txtDisplay.Text = Total;
            
            

        } 

           
            /*
                decimal.TryParse(txtDisplay.Text, out b);
                num2 = b;
                result = Calculate(num1, num2, option);
                Total = result.ToString();
                txtDisplay.Text = Total; 
        } 

            private decimal Calculate(decimal x, decimal y, string opt)
            {
               decimal result = 0;
                switch (opt)
                {
                    case "+":
                        result = x + y;
                        break;
                    case "-":
                        result = x - y;
                        break;
                    case "*":
                        result = x * y;
                        break;
                    case "/":
                        result = x / y;
                        break;
                }
                return result;
            }  */
        
    }
}