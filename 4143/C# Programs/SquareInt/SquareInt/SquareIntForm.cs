using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SquareInt
{
    public partial class SquareIntForm : Form
    {
        public SquareIntForm
            ()
        {
            InitializeComponent();
        }

        // Square method definition
        int Square(int y)
        {
            return y * y; // return square of y
        } // end method Square


        private void calculateButton_Click(object sender, EventArgs e)
        {
            int result;
            outputLabel.Text = "";

            // loop 10 times
            for (int counter = 1; counter <= 10; counter++)
            {
                // calculate square of counter and store in result
                result = Square(counter);

                // append result to output string
                outputLabel.Text += "The square of " + counter +
                   " is " + result + "\n";
            }

        }// end calculateButton_Click
    }// end of class SquareInt 
}


