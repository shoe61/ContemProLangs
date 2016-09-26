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
            int x = idx.Next(42);
                        
            pictureBox1.Image = imageList1.Images[x];
            pictureBox3.Image = imageList1.Images[(x + 2) % 42];
            pictureBox4.Image = imageList1.Images[(x + 4) % 42];
            pictureBox5.Image = imageList1.Images[(x + 6) % 42];
            pictureBox6.Image = imageList1.Images[(x + 8) % 42];
            pictureBox7.Image = imageList1.Images[(x + 10) % 42];
            pictureBox8.Image = imageList1.Images[(x + 12) % 42];
            pictureBox9.Image = imageList1.Images[(x + 14) % 42];
            pictureBox10.Image = imageList1.Images[(x + 16) % 42];
            pictureBox11.Image = imageList1.Images[(x + 18) % 42];
            pictureBox12.Image = imageList1.Images[(x + 20) % 42];
            pictureBox13.Image = imageList1.Images[(x + 22) % 42];
            pictureBox14.Image = imageList1.Images[(x + 24) % 42];
            pictureBox15.Image = imageList1.Images[(x + 26) % 42];
            pictureBox16.Image = imageList1.Images[(x + 28) % 42];
            pictureBox17.Image = imageList1.Images[(x + 30) % 42];
            pictureBox18.Image = imageList1.Images[(x + 32) % 42];
            pictureBox19.Image = imageList1.Images[(x + 34) % 42];

          
            Random lit = new Random();
            int lite = lit.Next(18);

            pictureBox21.Image = imageList2.Images[lite];
            pictureBox22.Image = imageList2.Images[(lite + 1) % 18];
            pictureBox23.Image = imageList2.Images[(lite + 2) % 18];
            pictureBox24.Image = imageList2.Images[(lite + 3) % 18];
            pictureBox25.Image = imageList2.Images[(lite + 4) % 18];
            pictureBox26.Image = imageList2.Images[(lite + 5) % 18];
            pictureBox27.Image = imageList2.Images[(lite + 6) % 18];
            pictureBox28.Image = imageList2.Images[(lite + 7) % 18];
            pictureBox29.Image = imageList2.Images[(lite + 8) % 18];
            pictureBox30.Image = imageList2.Images[(lite + 9) % 18];
            pictureBox31.Image = imageList2.Images[(lite + 10) % 18];
            pictureBox32.Image = imageList2.Images[(lite + 11) % 18];
            pictureBox33.Image = imageList2.Images[(lite + 12) % 18];
            pictureBox34.Image = imageList2.Images[(lite + 13) % 18];
            pictureBox35.Image = imageList2.Images[(lite + 14) % 18];
            pictureBox36.Image = imageList2.Images[(lite + 15) % 18];
            pictureBox37.Image = imageList2.Images[(lite + 16) % 18];
            pictureBox38.Image = imageList2.Images[(lite + 17) % 18];
            
        }

      

        

        


      
    }
}
