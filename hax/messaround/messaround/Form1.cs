using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messaround
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int binNum = int.Parse(textBox1.Text);
            int numDigits = textBox1.Text.Length;
            int decNum = 0;

            for(int i=0; i<numDigits; i++)
            {
                int opr = binNum % 10;
                binNum -= opr;
                binNum /= 10;
                if(opr > 0)
                {
                    decNum += (int)(Math.Pow((double)opr * 2, (double)i));
                }
                
            }
            string answer = numDigits.ToString();
            label1.Text = decNum.ToString();
        }
    }
}
