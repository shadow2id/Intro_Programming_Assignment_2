using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyanLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This code close the application
            Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //This code shows a picture of me when clicked
            picMe.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //This code hides the picture Box and Information label
            picMe.Hide();
            lblInformation.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //This code hides the pictureBox, Information label
            picMe.Hide();
            lblInformation.Hide();

            //This code clears the Sum and Product labels
            lblSum.ResetText();
            lblProduct.ResetText();

            //This code clears the text Boxes number 1 and 2
            txtBoxNumber1.ResetText();
            txtBoxNumber2.ResetText();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            //This code shows the Information label
            lblInformation.Show();

        }

        private void picMe_Click(object sender, EventArgs e)
        {
            //This code creates a message box with my name as the title and a description of the picture
            MessageBox.Show("This a picture of me in class.", "Ron Ryan");
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            //This code converts the entered numbers from string to int
            int num1 = (Int32.Parse(txtBoxNumber1.Text));
            int num2 = (Int32.Parse(txtBoxNumber2.Text));

            //This code subtracts the numbers
            int sum = num1 - num2;
            //This code divides the numbers
            int product = num1 / num2;

            //This code displays the product of the multiplied numbers in the Product label
            lblProduct.Text = product.ToString();
            //This code displays the sum of the added numbers in the Sum label
            lblSum.Text = sum.ToString();
        }
    }
}
