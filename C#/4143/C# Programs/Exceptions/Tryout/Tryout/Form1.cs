using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tryout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DO NOT ENTER a number larger than 2147483647 (largest 32 bit int) will crash
                int i = Convert.ToInt32(intBox.Text);
                outLabel.Text = "Converted to 32 bit int  " + i + "\n";

                long k = Convert.ToInt64(intBox.Text);
                outLabel.Text += "Converted to 64 bit long  " + k + "\n";

                //CANNOT DO THIS, will not compile
                //int j = Convert.ToInt64(intBox.Text);
                //outLabel.Text += "Converted to 64 bit int  " + j+ "\n";

                int m = (int)Convert.ToInt64(intBox.Text);
                outLabel.Text += "Converted to 64 bit and cast to int  " + m + "\n";
            }

            catch (OverflowException o)
            {
                MessageBox.Show("You must enter a number smaller than 2,147,483,648\n\n" + o.ToString(),
                    "Invalid Number Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
