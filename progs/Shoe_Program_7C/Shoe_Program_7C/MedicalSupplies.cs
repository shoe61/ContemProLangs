/* Scott Schumacher
 * Medical Supplies.cs
 * 6 December 2016
 * This program demonstrates MDI operations, including list boxes, menus, user controls, and 
 * serialization. This is a simple inventory program that enables the user to display the inventories 
 * of two different medical practices; to add new items to either inventory; to delete items; and to 
 * edit entries. 
 * 
 *      The inventories are displayed on child MDI forms, which are stripped of their control 
 * boxes. This is to preclude the user closing the form from the "x" in the upper right hand corner;
 * the forms must only be closed by the menu click item because that initiates the file write.
 * 
 *      The data entry forms are launched with a specific child as their object; as a reminder to
 * the user, the practice field is already filled in. This, I hope, would help to prevent a tired 
 * operator from mistakenly entering or changing data for one practice when the other was intended.
 * 
 */

//*************************************************************************************************
 
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

        // Default Constructor********************************************************************

        public MedicalSupplies()
        {
            InitializeComponent();
        }

        // New: Not Implemented********************************************************************

        private void fileMenuNew_Click(object sender, EventArgs e)
        {
            // will be used to create new account
        }

        // Opens the file and the appropriate window to display the inventory**********************

        private void fileMenuOpen_Click(object sender, EventArgs e)
        {
            // Create Dialog Box result variable 
            DialogResult result;

            // Create the dialog box to get the file name
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
                    //open a child window to read the file
                    open_window(workFile);
                }
            }
        }

        //*****************************************************************************************

        private void fileMenuSave_Click(object sender, EventArgs e)
        {

        }

        //*****************************************************************************************

        private void fileMenuExit_Click(object sender, EventArgs e)
        {
            // First, check to see if child forms are open. If so, ask if want to save.
            PracticeForm child = this.ActiveMdiChild as PracticeForm;

            if(child != null)
            {
                DialogResult notSoFast = MessageBox.Show("Do you want to save changes?", "SAVE CHANGES?",
                MessageBoxButtons.YesNo);

                if (notSoFast == DialogResult.Yes)
                {
                    child.writeFile();
                    Application.Exit();
                }
                else // don't want to save...
                {
                    Application.Exit();
                }
            }

            // if no child is open, okay to close
            Application.Exit();
        }

        //*****************************************************************************************

        private void editMenuInsert_Click(object sender, EventArgs e)
        {
            PracticeForm child = this.ActiveMdiChild as PracticeForm;
            //create a new EntryForm, passing child and bool update = false
            Form EntryForm = new EntryForm(child, false);
            EntryForm.Controls.RemoveAt(0); // the update button won't be visible; insert only
            EntryForm.Text = "Insert new inventory item";
            EntryForm.ShowDialog();
        }

        //*****************************************************************************************

        private void editMenuUpdate_Click(object sender, EventArgs e)
        {

            // Identify the active child; it will be passed to the EntryForm
            PracticeForm child = this.ActiveMdiChild as PracticeForm;

            //create a new EntryForm, passing child and bool update = true
            EntryForm Entry = new EntryForm(child, true);
            
            // This try / catch is necessary in case the user clicks "update" with no record selected.
            try
            {
                Entry.Controls.RemoveAt(2); // the insert button won't be visible; update only
                Entry.Text = "Update inventory item";
                Entry.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                // The exception is handled by the EntryForm.
            }
        }

        //*****************************************************************************************

        private void editMenuDelete_Click(object sender, EventArgs e)
        {
            // identify the active child form
            PracticeForm child = this.ActiveMdiChild as PracticeForm;

            // get the index of the selected record from the form
            int idx = child.inventoryListBx.SelectedIndex;

            // delete the selected line from the child's list box
            child.getDelete(idx);
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

        private void fileMenuClose_Click(object sender, EventArgs e)
        {
            // identify the active child form
            PracticeForm child = this.ActiveMdiChild as PracticeForm;

            try
            {
                // call the active child form to serialize the newly edited file
                child.writeFile();

                // reset the window open boolean variable
                if (child.Text == "Lake Dental Clinic") { dentalOpen = false; }
                if (child.Text == "Pickens Foot Clinic") { footOpen = false; }

                // close the child form 
                child.Close();
            }

            catch(NullReferenceException)
            {
                MessageBox.Show("There's no file open.");
            }
        }

        //*****************************************************************************************

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a program by Scott Schumacher.");
        }

        //*****************************************************************************************

        //*****************************************************************************************

        /*
        private void MedicalSupplies_Load(object sender, EventArgs e)
        {
            BinaryFormatter writer = new BinaryFormatter();
            FileStream output = new FileStream("Pickens Foot Clinic.Inv", FileMode.OpenOrCreate, FileAccess.Write);
            Record nuRec = new Record();
            nuRec.ID = 4117;
            nuRec.Name = "socks";
            nuRec.QtyReq = 54;
            nuRec.Qty = 41;
            nuRec.Practice = "Pickens Foot Clinic";
            writer.Serialize(output, nuRec);
        }
      */
    }
}
