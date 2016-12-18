using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Tree : IAge
    {
        private int rings; // number of rings in tree trunk

        // constructor
        public Tree(int yearPlanted)
        {
            // count number of rings in Tree
            rings = DateTime.Now.Year - yearPlanted;
        }

        // increment rings
        public void AddRing()
        {
            rings++;
        }

        // property Age implementation of interface IAge
        public int Age
        {
            get
            {
                return rings;
            }
        }


        // property Name implementation of interface IAge
        public string Name
        {
            get
            {
                return "Tree";
            }
        }
    }
}
