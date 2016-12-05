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

        //*****************************************************************************************

        public EntryForm()
        {
            InitializeComponent();
            
        }

        //*****************************************************************************************

        public EntryForm(PracticeForm child, bool update)
        {
            InitializeComponent();

            string workfile = MedicalSupplies.workFile;

            this.child = child;

            // the practice name will be displayed as a reminder to the operator
            this.practiceRichTextBox.Text = child.Text;

            // if boolean update is true, display the selected record in this form's 
            // rich text boxesfor editing
            if(update == true)
            {
                // get the index of the selected line
                idx = child.inventoryListBx.SelectedIndex;
                
                try
                {
                    // read the line as a string
                    line = child.inventoryListBx.Items[idx].ToString();

                    // parse the (tab separated) string to display elements in the appropriate rich text box
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

        //*****************************************************************************************

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //*****************************************************************************************

        private void InsertButton_Click(object sender, EventArgs e)
        {
            //update the child form's table
            if (child != null)
            {
                child.getUpdate(this.idRichTextBox.Text + "\t" + this.nameRichTextBox.Text + "\t" +
                    this.qtyReqRichTextBox.Text + "\t" + this.qtyRichTextBox.Text + "\t" 
                    + this.practiceRichTextBox.Text);
            }

            // clear the rich text boxes in case of another entry
            this.idRichTextBox.Text = "";
            this.nameRichTextBox.Text = "";
            this.qtyReqRichTextBox.Text = "";
            this.qtyRichTextBox.Text = "";
        }

        //*****************************************************************************************

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

            this.Close();
        }

        //*****************************************************************************************
    }
}
