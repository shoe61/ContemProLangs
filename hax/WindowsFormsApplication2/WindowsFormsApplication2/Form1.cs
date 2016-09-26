using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        

         public void button1_Click_1(object sender, EventArgs e)
         {
             Random idx = new Random();
             int x = idx.Next(3);

             List<Image> pictures = new List<Image>();
             for(int i = 0; i < imageList1.Images.Count; i++)
             {
                 pictures.Add(imageList1.Images[i]);
             }

             List<Image> lights = new List<Image>();
             for (int i = 0; i < imageList2.Images.Count; i++)
             {
                 lights.Add(imageList2.Images[i]);
             }


             this.pictureBox1.Image = lights[x];
           
             this.pictureBox2.Image = lights[(x + 1) % 3];

             this.pictureBox3.Image = lights[(x + 2) % 3];

             this.pictureBox4.Image = pictures[x];

             this.pictureBox5.Image = pictures[(x + 2) % 3];

             this.pictureBox6.Image = pictures[(x + 1) % 3];

             if(pictureBox1.Image == lights[2] && pictureBox4.Image == pictures[2])
             {
                 label1.Text = "you are playing for $500.";
             }

             



            

         }

        
    }
}
