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


namespace Shoe_Program_7
{
    public partial class MedicalSupplies : Form
    {
        private FileStream input; // stream for reading from file

        //make a list of the string arrays
        static public List<string[]> theList = new List<string[]>();


        // object for deserializing records
        private BinaryFormatter fileReader = new BinaryFormatter();

        BinaryFormatter reader = new BinaryFormatter();

        public static string workFile;


        public static string[] values;



        public static bool dentalOpen = false;
        public static bool footOpen = false;
        private bool insertFormOpen = false;


        //*****************************************************************************

        // parameterless constructor
        public MedicalSupplies()
        {
            InitializeComponent();
        }

        //*****************************************************************************

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //*****************************************************************************

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    input = new FileStream(workFile, FileMode.Open, FileAccess.ReadWrite);

                    // go to beginning of file
                    input.Seek(0, SeekOrigin.Begin);
                    
                    // clear the list before each file opening
                    theList.Clear();
                    
                    // deserialize and display in text box
                    try
                    {
                        // iterate over filestream object input, opening a record and appending it to the list
                        while(input.Position < input.Length)
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
                        open_window(workFile);
                    }

                    catch (IOException)
                    {
                        MessageBox.Show("oops.");
                    }
                }
            }
        }


        //*************************************************************************************************************

        private void open_window(string workFile)
        {
            if ((workFile.Contains("ental") || workFile.Contains("Lake")) && dentalOpen == false)
            {
                // Create a new child Dental Form; assign this form as its parent; display the child
                // it is automatically, and remains, the active mdi child until another supersedes it.
                DentalForm LakeDental = new DentalForm();
                dentalOpen = true;
                LakeDental.MdiParent = this;
                LakeDental.Show();
            }

            if ((workFile.Contains("foot") || workFile.Contains("odiatry") || workFile.Contains("Foot")) && footOpen == false)
            {
                // Create a new child Foot Form; assign this form as its parent; display the child
                // it is automatically, and remains, the active mdi child until another supersedes it.
                FootForm PickensFoot = new FootForm();
                footOpen = true;
                PickensFoot.MdiParent = this;
                PickensFoot.Show();
            }
        }

        //*************************************************************************************************************

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           if(this.ActiveMdiChild.Name == "DentalForm")
           {
               dentalOpen = false;
           }
           else
           {
               footOpen = false;
           }
           this.ActiveMdiChild.Close();

        }

        //*************************************************************************************************************

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (insertFormOpen == false)
            {
                insertNewItemForm insertForm = new insertNewItemForm();
                insertFormOpen = true;
                insertForm.ShowDialog();

            }
        }

        

        //*************************************************************************************************************

        public void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

           //if (ActiveMdiChild.Name == "DentalForm") { DentalForm.deleter(); }
            /*
            DialogResult dialogResult = MessageBox.Show("Do you intend to delete the selected Record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(ActiveMdiChild.Name == "DentalForm")
                {
                 //do something
                  
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
             * 
             */
        }

        //*************************************************************************************************************

       


        //*************************************************************************************************************


      
       
       

    }
}
