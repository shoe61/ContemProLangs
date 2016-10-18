using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class InterfaceForm : Form
    {
        public InterfaceForm()
        {
            InitializeComponent();

            Tree tree = new Tree(1978);
            Person person = new Person("Bob", "Jones", 1971);

            // create array of IAge references
            IAge[] iAgeArray = new IAge[2];

            // iAgeArray[ 0 ] refers to Tree object polymorphically
            iAgeArray[0] = (IAge) tree;

            // iAgeArray[ 1 ] refers to Person object polymorphically
            iAgeArray[1] = person;

            // display tree information
            string output = tree + ": " + tree.Name + "\nAge is " +
               tree.Age + "\n\n";

            // display person information
            output += person + ": " + person.Name + "\nAge is: "
               + person.Age + "\n\n";

            // display name and age for each IAge object in iAgeArray
            foreach (IAge ageReference in iAgeArray)
            {
                output += ageReference.Name + ": Age is " +
                   ageReference.Age + "\n";
            }

            MessageBox.Show(output, "Demonstrating Polymorphism");
        }
    }
}
