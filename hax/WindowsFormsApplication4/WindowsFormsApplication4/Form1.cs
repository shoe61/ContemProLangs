using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        public void button1_Click(object sender, EventArgs e)
        {
            //use separate randomly generated numbers for tiles and lights
            Random idx = new Random();
            int x = idx.Next(18);
            int y = idx.Next(42);

            //create tiles array and load from tileList
            List<Image> tiles = new List<Image>();

            for(int i = 0; i < tileList.Images.Count; i++)
            {
                tiles.Add(tileList.Images[i]);
            }

            //create lights array and load from liteList
            List<Image> lights = new List<Image>();

            for(int i = 0; i < lightList.Images.Count; i++)
            {
                lights.Add(lightList.Images[i]);
            }

            //list of dollar values indexed to images in tiles array
            List<int> dollars = new List<int>();
            dollars.Add(0);     // 0- big bucks
            dollars.Add(0);     // 1- wammy
            dollars.Add(470);   
            dollars.Add(500);
            dollars.Add(500);   // 4- plus one spin
            dollars.Add(0);     // 5- wamm
            dollars.Add(525);
            dollars.Add(530);
            dollars.Add(0);     // 8- wammy
            dollars.Add(650);
            dollars.Add(0);     // 10- wammy
            dollars.Add(740);
            dollars.Add(750);
            dollars.Add(750);   // 13- plus one spin
            dollars.Add(800);
            dollars.Add(0);     // 15- wammy
            dollars.Add(900);
            dollars.Add(1000);
            dollars.Add(1000);  // 18- plus one spin
            dollars.Add(1100);
            dollars.Add(1200);
            dollars.Add(1250);
            dollars.Add(1300);
            dollars.Add(1400);  // 23
            dollars.Add(1500);
            dollars.Add(1500);  // 25- plus one spin
            dollars.Add(1600);
            dollars.Add(1750);
            dollars.Add(1750);  // 28- plus one spin
            dollars.Add(1900);
            dollars.Add(2000);
            dollars.Add(2000);  // 31- plus one spin
            dollars.Add(2250);
            dollars.Add(2500);
            dollars.Add(2500);  // 34- plus one spin
            dollars.Add(2750);
            dollars.Add(3000);
            dollars.Add(3000);  // 37- plus one spin
            dollars.Add(3500);
            dollars.Add(4000);
            dollars.Add(4000);  // 40- plus one spin
            dollars.Add(0);     // 41- wammy

            //list of spins indexed to tiles array
            List<int> spins = new List<int>();
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);
            spins.Add(1);       // 4
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);       //8
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);
            spins.Add(1);       //13
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);
            spins.Add(1);       //18
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);       //22
            spins.Add(0);
            spins.Add(0);
            spins.Add(1);       //25
            spins.Add(0);
            spins.Add(0);
            spins.Add(1);       //28
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);
            spins.Add(0);
            spins.Add(1);       //34
            spins.Add(0);
            spins.Add(0);
            spins.Add(1);       //37
            spins.Add(0);
            spins.Add(0);
            spins.Add(1);       //40
            spins.Add(0);
            
            //boolean list of Wammies
            List<bool> wammy = new List<bool>();
            wammy.Add(false);
            wammy.Add(true);    // 1  
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(true);    //5
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(true);    //8
            wammy.Add(false);
            wammy.Add(true);    //10
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(true);    //15
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);   //20   
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);   //25
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);   //30
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);   //35
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);
            wammy.Add(false);   //40
            wammy.Add(true);    //41
            
            //boolean list of big bucks
            List<bool> bigBucks = new List<bool>();
            bigBucks.Add(true);     // 0 the only one
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);    // 5
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);    // 10
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);    // 15
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);    // 20
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);    //25
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);    // 30
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);    // 35
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);
            bigBucks.Add(false);    // 40
            bigBucks.Add(false);    // 41
            

            //These are the arrays of the picture boxes, as opposed to the arrays
            //of images. Here we associate the light (active) picture box with 
            //the game tile that appears inside it.

            PictureBox[] lites = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4,
            pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11,
            pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17,
            pictureBox18};

            //randomly assign 17 gray and 1 yellow (lit) lite boxes
            foreach(PictureBox pictureBox in lites)
            {
               pictureBox.Image = lights[(x % 18)];
               x++;
            }

            PictureBox[] gameTiles = new PictureBox[] { pictureBox19, pictureBox20, pictureBox21, 
            pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27,
            pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33, 
            pictureBox34, pictureBox35, pictureBox36};

            //randomly assign 18 game tiles
            foreach (PictureBox pictureBox in gameTiles)
            {
                pictureBox.Image = tiles[(y % 42)];
                y++;
            }

            //"hit" is the index at which the active ("lit up") tile is found in lites[]
            int hit = 0;
            for(int i = 0; i < 18; i++)
            {
                if(lites[i].Image == lights[17])
                {
                    hit = i ;    // index plus one is the picture box number
                }
            }


            Image target = gameTiles[hit].Image;
            int tgtd = tiles.IndexOf(target);
            this.lookUp(tgtd, dollars, spins, wammy, bigBucks);

         }

        public void lookUp(int indx, List<int> dols, List<int> spns, List<bool> wmmy, List<bool> bbks)
        {
            int cashMoney = dols[indx];
            int newSpins = spns[indx];
            bool ohNoWammy =wmmy[indx];
            bool bigMoney = bbks[indx];
            this.displayer(indx, cashMoney, newSpins, ohNoWammy, bigMoney);
        }

        private void displayer(int indx, int cash, int nuspins, bool wam, bool bigD)
        {
            label2.Text = "index: " + indx + "\ndollars: " + cash + "\nspins: " + nuspins +
                            "\nwammy: " + wam + "\nbig bucks: " + bigD;
        }
          
    }
}
