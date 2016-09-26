using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;




namespace WindowsFormsApplication3
{
    public class GameTile
    {
        public int index;              //by which the tile is selected
        public int cash;               //the cash value of the tile
        public int spins;              //bonus spins value of the tile
        public string prize;           //brief description of prize other than cash
        public bool wammy;             //true if a Wammy tile
        public bool bbucks;            //true if Big Bucks tile
        public ImageSource tilepic;    //image on the board

        public GameTile(int indx = 0, int csh =0, int spns = 0, string prze = null, 
            bool wmmy = false, bool bbcks = false, ImageSource tilepic = null)
        {

        }
    
    }
}
