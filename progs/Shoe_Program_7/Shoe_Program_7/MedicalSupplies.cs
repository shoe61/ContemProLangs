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
        FileStream input; // stream for reading from file

        // object for deserializing records
        BinaryFormatter fileReader = new BinaryFormatter();

        BinaryFormatter reader = new BinaryFormatter();

        private bool dentalOpen = false;
        private bool footOpen = false;
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create Dialog Box to open file
            DialogResult result;
            string workFile, goober;
            
            using(OpenFileDialog topOpenFileDialog = new OpenFileDialog())
            {
                result = topOpenFileDialog.ShowDialog();
                workFile = topOpenFileDialog.FileName;
            }

            if(result == DialogResult.OK)
            {
                // display error if invalid filename
                if(string.IsNullOrEmpty(workFile))
                {
                    MessageBox.Show("Invalid file name.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // create filestream object to get read access
                    input = new FileStream(workFile, FileMode.Open, FileAccess.Read);

                    // deserialize and display in text box
                    try
                    {
                        // get next Record from file
                        Record newRec = (Record)fileReader.Deserialize(input);

                        // store Record values in temporary string array
                        var values = new string[] { newRec.ID.ToString(), newRec.Name.ToString(), 
                            newRec.QtyReq.ToString(), newRec.Qty.ToString(), newRec.Practice.ToString() };

                        // display in the text box
                        //textBox1.AppendText(values[0] + "\t" + values[1] + "\t" + values[2] + "\t" + values[3] + "\t" + values[4]);
                        goober = (values[0] + "\t" + values[1] + "\t" + values[2] + "\t" + values[3] + "\t" + values[4]);
                        //textBox1.AppendText(goober);

                        open_window(workFile, goober); 
                    }

                    catch(IOException)
                    {
                        MessageBox.Show("oops.");
                    }
                }
            }
        }


//*************************************************************************************************************

        private void open_window(string workFile, string goober)
        {
            if ((workFile.Contains("ental") || workFile.Contains("Lake")) && dentalOpen == false)
            {
                // Create a new child Dental Form; assign this form as its parent; display the child
                // it is automatically, and remains, the active mdi child until another supersedes it.
                DentalForm LakeDental = new DentalForm();
                dentalOpen = true;
                LakeDental.MdiParent = this;
                LakeDental.Show();
                LakeDental.recordTextBox.AppendText(goober);
            }

            if ((workFile.Contains("foot") || workFile.Contains("odiatry") || workFile.Contains("Foot")) && footOpen == false)
            {
                // Create a new child Foot Form; assign this form as its parent; display the child
                // it is automatically, and remains, the active mdi child until another supersedes it.
                FootForm PickensFoot = new FootForm();
                footOpen = true;
                PickensFoot.MdiParent = this;
                PickensFoot.Show();
                PickensFoot.recordRichTextBox.AppendText(goober);
            }
        }

//*************************************************************************************************************

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.ActiveMdiChild.Close();
        }

//*************************************************************************************************************

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(insertFormOpen == false)
            {
                insertNewItemForm insertForm = new insertNewItemForm();
                insertFormOpen = true;
                insertForm.Show();
            }  
        }

//*************************************************************************************************************


       /* private void MedicalSupplies_Load(object sender, EventArgs e)
        { 
            FileStream output = new FileStream("PickensFootClinic.inv", 
                FileMode.OpenOrCreate, FileAccess.Write);

            Record rex = new Record();
            rex.ID = 0440;
            rex.Name = "arch support";
            rex.QtyReq = 60;
            rex.Qty = 43;
            rex.Practice = "Pickens Foot Clinic";

            reader.Serialize(output, rex);
        }*/


    }
}
