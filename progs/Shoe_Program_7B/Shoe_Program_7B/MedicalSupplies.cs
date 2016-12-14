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
    public partial class MedicalSupplies : Form
    {
        // Filestream object, BinaryFormatter reader, and string variable for file name
        private FileStream input;
        private BinaryFormatter fileReader = new BinaryFormatter();
        public static string workFile;

        // string array of values from records and a list of the values arrays
        public static string[] values;
        static public List<string[]> theList = new List<string[]>();

        // boolean values used as flags to ensure only one of each clinic form is open at a time
        public static bool dentalOpen = false;
        public static bool footOpen = false;

        //*****************************************************************************************

        public MedicalSupplies()
        {
            InitializeComponent();
        }

        //*****************************************************************************************

        private void fileMenuOpen_Click(object sender, EventArgs e)
        {
            // open the child form

            // Create Dialog Box to open file
            DialogResult result;

            using (OpenFileDialog topOpenFileDialog = new OpenFileDialog())
            {
                result = topOpenFileDialog.ShowDialog();
                workFile = topOpenFileDialog.FileName;
            }

            if (result == DialogResult.OK)
            {
                // display error if invalid filename
                if (string.IsNullOrEmpty(workFile))
                {
                    MessageBox.Show("Invalid file name.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    // create filestream object to get read access
                    using (input = new FileStream(workFile, FileMode.Open, FileAccess.ReadWrite))
                    {

                        // go to beginning of file
                        input.Seek(0, SeekOrigin.Begin);

                        // clear the list before each file opening
                        theList.Clear();

                        // deserialize and display in text box
                        try
                        {
                            // iterate over filestream object input, opening a record and appending it to the list
                            while (input.Position < input.Length)
                            {
                                // get next Record from file
                                Record newRec = (Record)fileReader.Deserialize(input);
                                if (newRec == null) continue;

                                // store Record values in temporary string array
                                values = new string[] { newRec.ID.ToString(), newRec.Name.ToString(), 
                            newRec.QtyReq.ToString(), newRec.Qty.ToString(), newRec.Practice.ToString() };

                                // add current iteration of values to theList
                                theList.Add(values);
                            }
                            input.Close();
                            input.Dispose();
                            open_window(workFile);
                        }

                        catch (IOException)
                        {
                            MessageBox.Show("oops.");
                        }
                    }
                }
            }

        }

        //*****************************************************************************************

        private void open_window(string workFile)
        {
            if ((workFile.Contains("ental") || workFile.Contains("Lake")) && dentalOpen == false)
            {
                // Create a new child PracticeForm; assign this form as its parent; display the child;
                // set its text property to the appropriate practice name
                PracticeForm LakeDental = new PracticeForm(workFile);
                dentalOpen = true;
                LakeDental.MdiParent = this;
                this.ActivateMdiChild(LakeDental);
                LakeDental.Text = "Lake Dental Clinic";
                LakeDental.displayInv();
                LakeDental.Show();
            }

            if ((workFile.Contains("foot") || workFile.Contains("odiatry") || workFile.Contains("Foot"))
                && footOpen == false)
            {
                // Create a new child PracticeForm; assign this form as its parent; display the child
                // 
                PracticeForm PickensFoot = new PracticeForm(workFile);
                footOpen = true;
                PickensFoot.MdiParent = this;
                PickensFoot.Text = "Pickens Foot Clinic";
                PickensFoot.displayInv();
                PickensFoot.Show();
            }
        }

        //*****************************************************************************************

        private void editMenuInsert_Click(object sender, EventArgs e)
        {
            PracticeForm child = this.ActiveMdiChild as PracticeForm;
            Form EntryForm = new EntryForm(child);
            EntryForm.Controls.RemoveAt(0); // the update button won't be visible; insert only
            EntryForm.Text = "Insert new inventory item";
            EntryForm.ShowDialog();
        }

        //*****************************************************************************************

        private void editMenuUpdate_Click(object sender, EventArgs e)
        {
            PracticeForm child = this.ActiveMdiChild as PracticeForm;
            EntryForm Entry = new EntryForm(child, true);
            Entry.Controls.RemoveAt(2); // the insert button won't be visible; update only
            Entry.Text = "Update inventory item";
            Entry.ShowDialog();
            //Record tozemp = Entry.informer();
            //Deleter();
        }

        //*****************************************************************************************

        public void editMenuDelete_Click(object sender, EventArgs e)
        {
            Deleter();

        }



        //*****************************************************************************************
        public void Deleter()
        {
            // identify the active child form
            PracticeForm child = this.ActiveMdiChild as PracticeForm;

            // get the index of the selected record from the form
            int idx = child.inventoryListBx.SelectedIndex;

            // open the correct file and make a table of the records
            workFile = child.workFile;

            // create filestream object to get read access
            input = new FileStream(workFile, FileMode.Open, FileAccess.ReadWrite);

            // go to beginning of file
            input.Seek(0, SeekOrigin.Begin);

            // clear the list before each file opening
            theList.Clear();

            // deserialize and display in text box
            try
            {
                // iterate over filestream object input, opening a record and appending it to the list
                while (input.Position < input.Length)
                {
                    // get next Record from file
                    Record newRec = (Record)fileReader.Deserialize(input);
                    if (newRec == null) continue;

                    // store Record values in temporary string array
                    values = new string[] { newRec.ID.ToString(), newRec.Name.ToString(), 
                            newRec.QtyReq.ToString(), newRec.Qty.ToString(), newRec.Practice.ToString() };

                    // add current iteration of values to theList
                    theList.Add(values);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("oops.");
            }

            // Close the read/write stream and open an append stream
            input.Close();
            FileStream output = new FileStream(workFile, FileMode.Create, FileAccess.Write);

            // delete the item from theList and the child form's list box
            theList.RemoveAt(idx);
            child.getDelete(idx);

            // using fileMode Create, write the first record of the modified table to the file;
            // all other records will be serialized using Append

            Record temp = new Record();
            temp.ID = int.Parse(theList[0][0]);
            temp.Name = theList[0][1];
            temp.QtyReq = int.Parse(theList[0][2]);
            temp.Qty = int.Parse(theList[0][3]);
            temp.Practice = theList[0][4];

            BinaryFormatter writer = new BinaryFormatter();
            writer.Serialize(output, temp);

            // close output and open another filestream to Append the rest
            output.Close();
            output.Dispose();
            FileStream outputRest = new FileStream(workFile, FileMode.Append, FileAccess.Write);

            // write the rest of the file using Append, which doesn't overrwrite, buts adds to the end

            for (int i = 1; i < theList.Count(); i++) // i starts at 1 because zero is done above
            {
                Record tempo = new Record();
                tempo.ID = int.Parse(theList[i][0]);
                tempo.Name = theList[i][1];
                tempo.QtyReq = int.Parse(theList[i][2]);
                tempo.Qty = int.Parse(theList[i][3]);
                tempo.Practice = theList[i][4];
                writer.Serialize(outputRest, tempo);
            }
        }

        //*****************************************************************************************

        private void fileMenuClose_Click(object sender, EventArgs e)
        {
            // identify the active child form, reset the appropriate flag, and close the form

            PracticeForm child = this.ActiveMdiChild as PracticeForm;

            if (child.Text == "Lake Dental Clinic") { dentalOpen = false; }

            if (child.Text == "Pickens Foot Clinic") { footOpen = false; }

            // close the child form
            child.Close();
        }

        //*****************************************************************************************

        /*
        private void MedicalSupplies_Load_1(object sender, EventArgs e)
        {
            BinaryFormatter writer = new BinaryFormatter();
            FileStream output = new FileStream("Lake Dental Clinic.Inv", FileMode.OpenOrCreate, FileAccess.Write);
            Record nuRec = new Record();
            nuRec.ID = 7636;
            nuRec.Name = "floss";
            nuRec.QtyReq = 144;
            nuRec.Qty = 91;
            nuRec.Practice = "Lake Dental Clinic";
            writer.Serialize(output, nuRec);
        }
      */

    }
}
