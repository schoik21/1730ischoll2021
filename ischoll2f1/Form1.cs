using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ischoll2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //decimal subtotal = 0m;
            //decimal discountPercent = 0m;

            // #1 if
            //subtotal = Decimal.Parse(input1ATextBox.Text);
            //if (subtotal >= 100m)
            //    discountPercent = 0.2m;
            //result1TextBox.Text = discountPercent.ToString("n2");
            result1TextBox.Text = Ex2fCalculations.Calc01(input1ATextBox.Text);

            // #2 if {block}
            //subtotal = Decimal.Parse(input2ATextBox.Text);
            //string status = "Standard rate: ";
            //if (subtotal >= 100m)
            //{
            //    discountPercent = 0.2m;
            //    status = "Bulk rate: ";
            //}
            //result2TextBox.Text = status + discountPercent.ToString("n2");
            result2TextBox.Text = Ex2fCalculations.Calc02(input2ATextBox.Text);

            // #3 if else
            //subtotal = Decimal.Parse(input3ATextBox.Text);
            //discountPercent = 0m;
            //if (subtotal >= 100m)
            //    discountPercent = 0.2m;
            //else
            //    discountPercent = 0.1m;
            //result3TextBox.Text = discountPercent.ToString("n2");
            result3TextBox.Text = Ex2fCalculations.Calc03(input3ATextBox.Text);

            // #4 if else if
            //subtotal = Decimal.Parse(input4ATextBox.Text);
            //discountPercent = 0m;
            //if (subtotal >= 100 && subtotal < 200)
            //    discountPercent = 0.2m;
            //else if (subtotal >= 200m && subtotal < 300)
            //    discountPercent = 0.3m;
            //else if (subtotal >= 300m)
            //    discountPercent = 0.4m;
            //else
            //    discountPercent = 0.1m;
            //result4TextBox.Text = discountPercent.ToString("n2");
            result4TextBox.Text = Ex2fCalculations.Calc04(input4ATextBox.Text);


            // #5 Better range test
            //subtotal = Decimal.Parse(input5ATextBox.Text);
            //discountPercent = 0m;
            //if (subtotal >= 300)
            //    discountPercent = 0.4m;
            //else if (subtotal >= 200m)
            //    discountPercent = 0.3m;
            //else if (subtotal >= 100m)
            //    discountPercent = 0.2m;
            //else
            //    discountPercent = 0.1m;
            //result5TextBox.Text = discountPercent.ToString("n2");
            result5TextBox.Text = Ex2fCalculations.Calc05(input5ATextBox.Text);

            // #6 nested if statements
            //subtotal = Decimal.Parse(input6ATextBox.Text);
            //string customerType = input6BTextBox.Text;
            //discountPercent = 0m;
            //if (customerType == "R")
            //{
            //    if (subtotal >= 100m)
            //        discountPercent = 0.2m;
            //    else
            //        discountPercent = 0.1m;

            //}
            //else   // customerType isn't "R"
            //    discountPercent = 0.4m;
            //result6TextBox.Text = discountPercent.ToString("n2");
            result6TextBox.Text = Ex2fCalculations.Calc06(input6ATextBox.Text, input6BTextBox.Text);

            // #7 input validation 
            result7TextBox.Text = Ex2fCalculations.Calc07(input7ATextBox.Text);

            //// #8 input validation, calculate total and shipping 
            ////      shipping = $5.00 for orders under $50.00
            //result8TextBox.Text = Ex2fCalculations.Calc08(input8ATextBox.Text, input8BTextBox.Text);

            //// #9  input validation, result = 0.1 * difference 
            //result9TextBox.Text = Ex2fCalculations.Calc09(input9ATextBox.Text, input9BTextBox.Text);

            //// #10 Validate input, divide large num by small
            //// Both numbers must be > 0
            //result10TextBox.Text = Ex2fCalculations.Calc10(input10ATextBox.Text, input10BTextBox.Text);
        }
    }
}
