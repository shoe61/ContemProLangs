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

        private void button1_Click(object sender, EventArgs e)
        {
            //use separate randomly generated numbers for tiles and lights
            Random idx = new Random();
            int x = idx.Next(18);
            int y = idx.Next(18);

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
            

            //randomly assign 17 gray and 1 yellow (lit) lite boxes
            this.pictureBox1.Image = lights[x];
            this.pictureBox2.Image = lights[(x + 1) % 18];
            this.pictureBox3.Image = lights[(x + 2) % 18];
            this.pictureBox4.Image = lights[(x + 3) % 18];
            this.pictureBox5.Image = lights[(x + 4) % 18];
            this.pictureBox6.Image = lights[(x + 5) % 18];
            this.pictureBox7.Image = lights[(x + 6) % 18];
            this.pictureBox8.Image = lights[(x + 7) % 18];
            this.pictureBox9.Image = lights[(x + 8) % 18];
            this.pictureBox10.Image = lights[(x + 9) % 18];
            this.pictureBox11.Image = lights[(x + 10) % 18];
            this.pictureBox12.Image = lights[(x + 11) % 18];
            this.pictureBox13.Image = lights[(x + 12) % 18];
            this.pictureBox14.Image = lights[(x + 13) % 18];
            this.pictureBox15.Image = lights[(x + 14) % 18];
            this.pictureBox16.Image = lights[(x + 15) % 18];
            this.pictureBox17.Image = lights[(x + 16) % 18];
            this.pictureBox18.Image = lights[(x + 17) % 18];

            //randomly assign 18 game tiles
            this.pictureBox19.Image = tiles[y];
            this.pictureBox20.Image = tiles[(y + 1) % 18];
            this.pictureBox21.Image = tiles[(y + 2) % 18];
            this.pictureBox22.Image = tiles[(y + 3) % 18];
            this.pictureBox23.Image = tiles[(y + 4) % 18];
            this.pictureBox24.Image = tiles[(y + 5) % 18];
            this.pictureBox25.Image = tiles[(y + 6) % 18];
            this.pictureBox26.Image = tiles[(y + 7) % 18];
            this.pictureBox27.Image = tiles[(y + 8) % 18];
            this.pictureBox28.Image = tiles[(y + 9) % 18];
            this.pictureBox29.Image = tiles[(y + 10) % 18];
            this.pictureBox30.Image = tiles[(y + 11) % 18];
            this.pictureBox31.Image = tiles[(y + 12) % 18];
            this.pictureBox32.Image = tiles[(y + 13) % 18];
            this.pictureBox33.Image = tiles[(y + 14) % 18];
            this.pictureBox34.Image = tiles[(y + 15) % 18];
            this.pictureBox35.Image = tiles[(y + 16) % 18];
            this.pictureBox36.Image = tiles[(y + 17) % 18];

            //These are the arrays of the picture boxes, as opposed to the arrays
            //of images. Here we associate the light (active) picture box with 
            //the game tile that appears inside it.

            PictureBox[] lites = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4,
            pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11,
            pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17,
            pictureBox18};

            PictureBox[] gameTiles = new PictureBox[] { pictureBox19, pictureBox20, pictureBox21, 
            pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27,
            pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33, 
            pictureBox34, pictureBox35, pictureBox36};

            //"hit" is the index at which the active ("lit up") tile is found in lites[]
            int hit = 0;
            for(int i = 0; i < 18; i++)
            {
                if(lites[i].Image == lights[17])
                {
                    hit = i ;    // index plus one is the picture box number
                }
            }

            //diagnostic
                        
            if( gameTiles[hit].Image == tiles[0])
            {
                int cashMoney = dollars[0];
                int newSpins = spins[0];
                bool ohNoWammy = wammy[0];
                bool bigMoney = bigBucks[0];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
             }

            else if (gameTiles[hit].Image == tiles[1])
            {
                int cashMoney = dollars[1];
                int newSpins = spins[1];
                bool ohNoWammy = wammy[1];
                bool bigMoney = bigBucks[1];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            else if (gameTiles[hit].Image == tiles[2])
            {
                int cashMoney = dollars[2];
                int newSpins = spins[2];
                bool ohNoWammy = wammy[2];
                bool bigMoney = bigBucks[2];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            else if (gameTiles[hit].Image == tiles[3])
            {
                int cashMoney = dollars[3];
                int newSpins = spins[3];
                bool ohNoWammy = wammy[3];
                bool bigMoney = bigBucks[3];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            else if (gameTiles[hit].Image == tiles[4])
            {
                int cashMoney = dollars[4];
                int newSpins = spins[4];
                bool ohNoWammy = wammy[4];
                bool bigMoney = bigBucks[4];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            else if (gameTiles[hit].Image == tiles[5])
            {
                int cashMoney = dollars[5];
                int newSpins = spins[5];
                bool ohNoWammy = wammy[5];
                bool bigMoney = bigBucks[5];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            else if  (gameTiles[hit].Image == tiles[6])
            {
                int cashMoney = dollars[6];
                int newSpins = spins[6];
                bool ohNoWammy = wammy[6];
                bool bigMoney = bigBucks[6];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            else if (gameTiles[hit].Image == tiles[7])
            {
                int cashMoney = dollars[7];
                int newSpins = spins[7];
                bool ohNoWammy = wammy[7];
                bool bigMoney = bigBucks[7];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[8])
            {
                int cashMoney = dollars[8];
                int newSpins = spins[8];
                bool ohNoWammy = wammy[8];
                bool bigMoney = bigBucks[8];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[9])
            {
                int cashMoney = dollars[9];
                int newSpins = spins[9];
                bool ohNoWammy = wammy[9];
                bool bigMoney = bigBucks[9];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[10])
            {
                int cashMoney = dollars[10];
                int newSpins = spins[10];
                bool ohNoWammy = wammy[10];
                bool bigMoney = bigBucks[10];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[11])
            {
                int cashMoney = dollars[11];
                int newSpins = spins[11];
                bool ohNoWammy = wammy[11];
                bool bigMoney = bigBucks[11];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[12])
            {
                int cashMoney = dollars[12];
                int newSpins = spins[12];
                bool ohNoWammy = wammy[12];
                bool bigMoney = bigBucks[12];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[13])
            {
                int cashMoney = dollars[13];
                int newSpins = spins[13];
                bool ohNoWammy = wammy[13];
                bool bigMoney = bigBucks[1];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[14])
            {
                int cashMoney = dollars[14];
                int newSpins = spins[14];
                bool ohNoWammy = wammy[14];
                bool bigMoney = bigBucks[14];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[15])
            {
                int cashMoney = dollars[15];
                int newSpins = spins[15];
                bool ohNoWammy = wammy[15];
                bool bigMoney = bigBucks[15];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[16])
            {
                int cashMoney = dollars[16];
                int newSpins = spins[16];
                bool ohNoWammy = wammy[16];
                bool bigMoney = bigBucks[16];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[17])
            {
                int cashMoney = dollars[17];
                int newSpins = spins[17];
                bool ohNoWammy = wammy[17];
                bool bigMoney = bigBucks[17];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[18])
            {
                int cashMoney = dollars[18];
                int newSpins = spins[18];
                bool ohNoWammy = wammy[18];
                bool bigMoney = bigBucks[18];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[19])
            {
                int cashMoney = dollars[19];
                int newSpins = spins[19];
                bool ohNoWammy = wammy[19];
                bool bigMoney = bigBucks[19];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[20])
            {
                int cashMoney = dollars[20];
                int newSpins = spins[20];
                bool ohNoWammy = wammy[20];
                bool bigMoney = bigBucks[20];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[21])
            {
                int cashMoney = dollars[21];
                int newSpins = spins[21];
                bool ohNoWammy = wammy[21];
                bool bigMoney = bigBucks[21];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[22])
            {
                int cashMoney = dollars[22];
                int newSpins = spins[22];
                bool ohNoWammy = wammy[22];
                bool bigMoney = bigBucks[22];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[23])
            {
                int cashMoney = dollars[23];
                int newSpins = spins[23];
                bool ohNoWammy = wammy[23];
                bool bigMoney = bigBucks[23];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[24])
            {
                int cashMoney = dollars[24];
                int newSpins = spins[24];
                bool ohNoWammy = wammy[24];
                bool bigMoney = bigBucks[24];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[25])
            {
                int cashMoney = dollars[25];
                int newSpins = spins[25];
                bool ohNoWammy = wammy[25];
                bool bigMoney = bigBucks[25];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[26])
            {
                int cashMoney = dollars[26];
                int newSpins = spins[26];
                bool ohNoWammy = wammy[26];
                bool bigMoney = bigBucks[26];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[27])
            {
                int cashMoney = dollars[27];
                int newSpins = spins[27];
                bool ohNoWammy = wammy[27];
                bool bigMoney = bigBucks[27];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[28])
            {
                int cashMoney = dollars[28];
                int newSpins = spins[28];
                bool ohNoWammy = wammy[28];
                bool bigMoney = bigBucks[28];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[29])
            {
                int cashMoney = dollars[29];
                int newSpins = spins[29];
                bool ohNoWammy = wammy[29];
                bool bigMoney = bigBucks[29];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[30])
            {
                int cashMoney = dollars[30];
                int newSpins = spins[30];
                bool ohNoWammy = wammy[30];
                bool bigMoney = bigBucks[30];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[31])
            {
                int cashMoney = dollars[31];
                int newSpins = spins[31];
                bool ohNoWammy = wammy[31];
                bool bigMoney = bigBucks[31];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[32])
            {
                int cashMoney = dollars[32];
                int newSpins = spins[32];
                bool ohNoWammy = wammy[32];
                bool bigMoney = bigBucks[32];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[33])
            {
                int cashMoney = dollars[33];
                int newSpins = spins[33];
                bool ohNoWammy = wammy[33];
                bool bigMoney = bigBucks[33];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[34])
            {
                int cashMoney = dollars[34];
                int newSpins = spins[34];
                bool ohNoWammy = wammy[34];
                bool bigMoney = bigBucks[34];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[35])
            {
                int cashMoney = dollars[35];
                int newSpins = spins[35];
                bool ohNoWammy = wammy[35];
                bool bigMoney = bigBucks[35];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[36])
            {
                int cashMoney = dollars[36];
                int newSpins = spins[36];
                bool ohNoWammy = wammy[36];
                bool bigMoney = bigBucks[36];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[37])
            {
                int cashMoney = dollars[37];
                int newSpins = spins[37];
                bool ohNoWammy = wammy[37];
                bool bigMoney = bigBucks[37];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[38])
            {
                int cashMoney = dollars[38];
                int newSpins = spins[38];
                bool ohNoWammy = wammy[38];
                bool bigMoney = bigBucks[38];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[39])
            {
                int cashMoney = dollars[39];
                int newSpins = spins[39];
                bool ohNoWammy = wammy[39];
                bool bigMoney = bigBucks[39];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[40])
            {
                int cashMoney = dollars[40];
                int newSpins = spins[40];
                bool ohNoWammy = wammy[40];
                bool bigMoney = bigBucks[40];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }

            if (gameTiles[hit].Image == tiles[41])
            {
                int cashMoney = dollars[41];
                int newSpins = spins[41];
                bool ohNoWammy = wammy[41];
                bool bigMoney = bigBucks[41];
                this.displayer(cashMoney, newSpins, ohNoWammy, bigMoney);
            }


         }
        private void displayer(int cash, int nuspins, bool wam, bool bigD)
        {
            label2.Text = "dollars: " + cash + "\nspins: " + nuspins +
                            "\nwammy: " + wam + "\nbig bucks: " + bigD;
        }

      
    }
}
