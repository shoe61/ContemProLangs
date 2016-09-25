using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random idx = new Random();
            int x = idx.Next(12);
            Random intvl = new Random();
            int intval = intvl.Next(5);
            
            pictureBox1.Image = imageList1.Images[x];
            pictureBox3.Image = imageList1.Images[(x + 2) % 11];
            pictureBox4.Image = imageList1.Images[(x + 4) % 11];
            pictureBox5.Image = imageList1.Images[(x + 6) % 11];
            pictureBox6.Image = imageList1.Images[(x + 8) % 11];
            pictureBox7.Image = imageList1.Images[(x + 10) % 11];
            pictureBox8.Image = imageList1.Images[(x + 12) % 11];
            pictureBox9.Image = imageList1.Images[(x + 14) % 11];
            pictureBox10.Image = imageList1.Images[(x + 16) % 11];
            pictureBox11.Image = imageList1.Images[(x + 18) % 11];
            pictureBox12.Image = imageList1.Images[(x + 20) % 11];
            pictureBox13.Image = imageList1.Images[(x + 22) % 11];
            pictureBox14.Image = imageList1.Images[(x + 24) % 11];
            pictureBox15.Image = imageList1.Images[(x + 26) % 11];
            pictureBox16.Image = imageList1.Images[(x + 28) % 11];
            pictureBox17.Image = imageList1.Images[(x + 30) % 11];
            pictureBox18.Image = imageList1.Images[(x + 32) % 11];
            pictureBox19.Image = imageList1.Images[(x + 34) % 11];

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        


      
    }
}
