/* Scott Schumacher
 * Medical Supplies.cs
 * 6 December 2016
 * This class defines the entry form, which is used for inserting new items and updating existing 
 * entries. It is instantiated with the active child form identified and closes when changes to that
 * child form's inventory are complete.
 * 
 */

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
    public partial class EntryForm : Form
    {
        BinaryFormatter writer = new BinaryFormatter();
        PracticeForm child;
        private int idx;
        string line;

        // Default Constructor********************************************************************

        public EntryForm()
        {
            InitializeComponent();
            
        }

        // Parameterized constructor for specific clinic type and update option********************

        public EntryForm(PracticeForm child, bool update)
        {
            InitializeComponent();

            string workfile = MedicalSupplies.workFile; // identifies the input file

            this.child = child;

            // the practice name will be displayed as a reminder to the operator
            this.practiceRichTextBox.Text = child.Text;

            // if boolean update is true, display the selected record in this form's 
            // rich text boxesfor editing
            if(update == true)
            {
                // get the index of the selected line
                idx = child.inventoryListBx.SelectedIndex;
                
                try // make sure a record is selected; can't update null object
                {
                    // read the line as a string
                    line = child.inventoryListBx.Items[idx].ToString();

                    // parse the (tab separated) string to display elements in the appropriate rich
                    // text box
                    string[] split = line.Split('\t');

                    // display the indexed elements of 'split' in the text boxes
                    this.idRichTextBox.Text = split[0];
                    this.nameRichTextBox.Text = split[1];
                    this.qtyReqRichTextBox.Text = split[2];
                    this.qtyRichTextBox.Text = split[3];
                }

                catch(ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Please select a record to update.");
                    this.Close();
                }
            }
        }

        // when the user is finished or changes his or her mind, exit the form********************

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // provide for insertion of additional entries*********************************************

        private void InsertButton_Click(object sender, EventArgs e)
        {
            //update the child form's table
            if (child != null)
            {
                child.getUpdate(this.idRichTextBox.Text.PadRight(16) + "\t"
                    + this.nameRichTextBox.Text.PadRight(30) + "\t"
                    + this.qtyReqRichTextBox.Text.PadRight(16) + "\t" 
                    + this.qtyRichTextBox.Text.PadRight(16) + "\t" 
                    + this.practiceRichTextBox.Text);
            }

            // clear the rich text boxes in case of another entry
            this.idRichTextBox.Text = "";
            this.nameRichTextBox.Text = "";
            this.qtyReqRichTextBox.Text = "";
            this.qtyRichTextBox.Text = "";
        }

        // provides for alteration of existing entry***********************************************

        private void updateButton_Click(object sender, EventArgs e)
        {
            // update the child form's table by deleting the original record and adding 
            // the updated record

            child.getDelete(idx);

            if (child != null)
            {
                child.getUpdate(this.idRichTextBox.Text + "\t" + this.nameRichTextBox.Text + "\t" +
                    this.qtyReqRichTextBox.Text + "\t" + this.qtyRichTextBox.Text + "\t"
                    + this.practiceRichTextBox.Text);
            }

            this.Close(); // CLOSE AFTER EACH UPDATE TO AVOID ERROR-CAUSING CIRCUMSTANCES
        }

        //*****************************************************************************************
    }
}
