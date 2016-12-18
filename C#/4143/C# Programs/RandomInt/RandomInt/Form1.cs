using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomInt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            int value;
            string output = "";

            Random randomInteger = new Random();

            // loop 20 times
            for (int i = 1; i <= 20; i++)
            {
                // pick random integer between 1 and 6
                value = randomInteger.Next(1, 7);
                output += value + " "; // append value to output

                // if counter divisible by 5, append newline
                if (i % 5 == 0)
                    output += "\n";
            } // end for structure 
            MessageBox.Show(output, "20 Random Numbers from 1 to 6",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
