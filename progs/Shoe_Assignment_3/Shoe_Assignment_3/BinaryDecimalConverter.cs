//Scott Schumacher
//9-15-2016
//FileName: BinaryDecimalConverter.cs
//This program invites the user to enter a binary integer in a text box and
//to then click a button; this event triggers the button's event handler,
//which converts the binary number to its decimal equivalent and displays
//the result in a label.


using System;
using System.Windows.Forms;

namespace Shoe_Assignment_3
{
    public partial class BinaryDecimalConverter : Form
    {
        public BinaryDecimalConverter()
        {
            InitializeComponent();
        }
        //event handler for button:
        private void convertButton_Click(object sender, EventArgs e)
        {
            //read input string from text box; parse as integer
            int binNum = int.Parse(binaryIntegerTextBox.Text);
 
            //count the digits to control loop below
            int numDigits = binaryIntegerTextBox.Text.Length;

            //declare variable for output
            int decNum = 0;

            //with each iteration of the loop, strip off trailing digit by 
            //performing modulus followed by integer division by ten
            for(int i = 0; i < numDigits; i++)
            {
                int opr = binNum % 10;
                binNum /= 10;
                
                //This loop is necessary to ensure that a zero in the one's place
                //(positionally, the 2 to the power 0 place) is not computed as 1.
                if(opr > 0)
                    {
                        decNum += (int)(Math.Pow((double)opr * 2, (double)i));
                    }
            }
            //output directed to label
            resultLabel.Text = decNum.ToString();
        }
    }
}
