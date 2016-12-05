using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Shoe_Program_7C
{
    public partial class PracticeForm : Form
    {
        // Filestream object, BinaryFormatter reader, string variable for file name, and a record
        private FileStream input, output;
        private BinaryFormatter fileReader = new BinaryFormatter();
        private BinaryFormatter writer = new BinaryFormatter();
        public static string workFile;
        Record tempo = new Record();

        //default constructer**********************************************************************      

        public PracticeForm()
        {
            InitializeComponent();
            
        }

        //parameterized constructer****************************************************************

        public PracticeForm(string workfile)
        {
            InitializeComponent();
            workFile = workfile;
            // Remove the Close menu item.
            //this.menuManager = new SystemMenuManager(this, SystemMenuManager.MenuItemState.Removed)
        }

        //displayInv method reads and displays records from the file*******************************

        public void displayInv()
        {
            // create filestream object to get read access
            using (input = new FileStream(workFile, FileMode.Open, FileAccess.ReadWrite))
            {
                // go to beginning of file
                input.Seek(0, SeekOrigin.Begin);

                // deserialize and display listBox
                try
                {
                    // iterate over filestream object input, opening a record and appending it to the list
                    while (input.Position < input.Length)
                    {
                        // get next Record from file
                        Record newRec = (Record)fileReader.Deserialize(input);
                        if (newRec == null) continue;

                        // store Record values in temporary string array
                        string[] values = new string[] { newRec.ID.ToString(), newRec.Name.ToString(), 
                            newRec.QtyReq.ToString(), newRec.Qty.ToString(), newRec.Practice.ToString() };

                        // display in ListBox
                        inventoryListBx.Items.Add((values[0].PadRight(16)) + "\t" + (values[1].PadRight(30))
                            + "\t" + (values[2].PadRight(16)) + "\t" + (values[3].PadRight(16)) + "\t" + values[4]);
                    }
                }

                catch (IOException)
                {
                    MessageBox.Show("oops.");
                }
            }
        }

        // getUpdate displays changes made in EntryForm********************************************

        public void getUpdate(string update)
        {
            inventoryListBx.Items.Add(update);
        }

        // getDelete updates the ListBox display to reflect deletions******************************

        public void getDelete(int idx)
        {
            try 
            {
                inventoryListBx.Items.RemoveAt(idx);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You must select an item to delete.");
            }
            
        }

        // writeFile is called whenever a close  or save command is issued*************************

        public void writeFile()
        {
            // open the filestream and binary formatter
            using (output = new FileStream(workFile, FileMode.Create, FileAccess.Write))
            {
                // loop through listBox items, creating a new record from each line and serializing that 
                // record to the file.

                for (int idx = 0; idx < inventoryListBx.Items.Count; idx++)
                {
                    // read the line
                    var line = inventoryListBx.Items[idx].ToString();

                    // parse the (tab separated) string to display elements in the appropriate rich text box
                    string[] split = line.Split('\t');

                    // create the record from the elements of split[]
                    tempo.ID = int.Parse(split[0]);
                    tempo.Name = split[1];
                    tempo.QtyReq = int.Parse(split[2]);
                    tempo.Qty = int.Parse(split[3]);
                    tempo.Practice = split[4];

                    // write to the file
                    writer.Serialize(output, tempo);
                }
            }
        }
    }
}
