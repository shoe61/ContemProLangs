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


namespace Shoe_Program_7B
{
    public partial class EntryForm : Form
    {

        BinaryFormatter writer = new BinaryFormatter();
        PracticeForm child;
        private int idx;


        //*****************************************************************************************

        public EntryForm()
        {
            InitializeComponent();

            string workFile = MedicalSupplies.workFile;
        }

        //*****************************************************************************************
        public EntryForm(PracticeForm child)
        {
            InitializeComponent();

            string workfile = MedicalSupplies.workFile;

            this.child = child;

            // the practice name will be displayed as a reminder to the operator
            this.practiceRichTextBox.Text = child.Text;
        }

        //*****************************************************************************************

        public EntryForm(PracticeForm child, bool update)
        {
            InitializeComponent();

            // identifying information about the subject file and active child window
            string workfile = MedicalSupplies.workFile;
            this.child = child;

            // get the index of the selected record from the form
            idx = child.inventoryListBx.SelectedIndex;

            // display the info in this form's richTextBoxes
            this.idRichTextBox.Text = MedicalSupplies.theList[idx][0];
            this.nameRichTextBox.Text = MedicalSupplies.theList[idx][1];
            this.qtyReqRichTextBox.Text = MedicalSupplies.theList[idx][2];
            this.qtyRichTextBox.Text = MedicalSupplies.theList[idx][3];
            this.practiceRichTextBox.Text = MedicalSupplies.theList[idx][4];
        }

        //*****************************************************************************************

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //*****************************************************************************************

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Record temp = new Record();
            try
            {
                temp.ID = int.Parse(this.idRichTextBox.Text);
                temp.Name = this.nameRichTextBox.Text;
                temp.QtyReq = int.Parse(this.qtyReqRichTextBox.Text);
                temp.Qty = int.Parse(this.qtyRichTextBox.Text);
                temp.Practice = this.practiceRichTextBox.Text;
            }

            catch (SystemException)
            {
                MessageBox.Show("If you don't want to add a record, click the CANCEL button.");
            }

            // create filestream object to get write access
            FileStream output = new FileStream(MedicalSupplies.workFile, FileMode.Append, FileAccess.Write);

            // serialize the output to file
            writer.Serialize(output, temp);

            //update the child form's table

            if (child != null)
            {
                child.getUpdate(temp.ID.ToString() + "\t" + temp.Name.ToString() + "\t" +
                    temp.QtyReq.ToString() + "\t" + temp.Qty.ToString() + "\t" + temp.Practice.ToString());
            }

            //Close filestream object
            output.Close();
            this.Close();
        }

       //*****************************************************************************************




        // When the user has finished making changes to the information displayed in this form's 
        // text boxes and clicks the Update button, the changes will be reflected in the practice window
        // and the fields will be assembled for serialization.

        private void updateButton_Click(object sender, EventArgs e)
        {
            // create record
            Record temp = new Record();
            temp.ID = int.Parse(this.idRichTextBox.Text);
            temp.Name = this.nameRichTextBox.Text;
            temp.QtyReq = int.Parse(this.qtyReqRichTextBox.Text);
            temp.Qty = int.Parse(this.qtyReqRichTextBox.Text);
            temp.Practice = this.practiceRichTextBox.Text;

           
           





            // update practice window's inventory display
            child.getDelete(idx);
            child.getUpdate(temp.ID.ToString() + "\t" + temp.Name.ToString() + "\t" +
                    temp.QtyReq.ToString() + "\t" + temp.Qty.ToString() + "\t" + temp.Practice.ToString());
        }

        //*****************************************************************************************

        // updating theList and the target file are equivalent to deleting the record and 
        // appending a new record

        public Record informer()
        {
            // create record
            Record temp = new Record();
            temp.ID = int.Parse(this.idRichTextBox.Text);
            temp.Name = this.nameRichTextBox.Text;
            temp.QtyReq = int.Parse(this.qtyReqRichTextBox.Text);
            temp.Qty = int.Parse(this.qtyReqRichTextBox.Text);
            temp.Practice = this.practiceRichTextBox.Text;
            return temp;
        }

        //*****************************************************************************************

    }
}
