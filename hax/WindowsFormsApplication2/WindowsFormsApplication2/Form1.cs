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
             //using separate random numbers for the two pictureBox arrays
             Random idx = new Random();
             int x = idx.Next(3);
             int y = idx.Next(3);

             //load images from list into pictures array
             List<Image> pictures = new List<Image>();
             for(int i = 0; i < imageList1.Images.Count; i++)
             {
                 pictures.Add(imageList1.Images[i]);
             }

             //load the background images (lights) into a separate array
             List<Image> lights = new List<Image>();
             for (int i = 0; i < imageList2.Images.Count; i++)
             {
                 lights.Add(imageList2.Images[i]);
             }

             //list of dollar values indexed to images in array pictures
             List<int> dollars = new List<int>();
             dollars.Add(0);
             dollars.Add(0);
             dollars.Add(500);

             //list of spins indexed to array pictures
             List<int>spins = new List<int>();
             spins.Add(0);
             spins.Add(0);
             spins.Add(0);
              

             this.pictureBox1.Image = lights[x];
             this.pictureBox2.Image = lights[(x + 1) % 3];
             this.pictureBox3.Image = lights[(x + 2) % 3];
             this.pictureBox4.Image = pictures[y];
             this.pictureBox5.Image = pictures[(y + 2) % 3];
             this.pictureBox6.Image = pictures[(y + 1) % 3];

             //these are arrays of the picture boxes; they associate the background (light) 
             //with the corresponding game tile
             PictureBox[] lites = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3 };
             PictureBox[] tiles = new PictureBox[] { pictureBox4, pictureBox5, pictureBox6 };

             //"hit" is the index at which the lit up tile is found
             int hit = 0;

             for (int i = 0; i < 3; i++)
             {
                 if(lites[i].Image == lights[2])
                 {
                     hit = i + 1; //pictureBox(hit): this will find where the yellow lit up tile is.
                     //add 3 (or 18) and you'll have the index of the corresponding tile.
                 }
             }

             //diagnostic tool
             label2.Text = "HIT: " + hit;

             //find the characteristics of the tile corresponding to the hit:
             if(tiles[hit - 1].Image == pictures[2])
             {
                 label1.Text = "you're playing for " + dollars[2] + "dollars!";
             }

             if (tiles[hit - 1].Image == pictures[1])
             {
                 label1.Text = "Oh No! You've been Wammied!";
             }

             if(tiles[hit - 1].Image == pictures[0])
             {
                 label1.Text = "Now you're playing for BIG BUCKS!";
             }

         }
 
    }
}
