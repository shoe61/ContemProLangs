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
            string workFile;
            
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
                    

                    if (workFile.Contains("ental") || workFile.Contains("Lake"))
                    {
                        // Create a new child Dental Form; assign this form as its parent; display the child
                        DentalForm LakeDental = new DentalForm();
                        LakeDental.MdiParent = this;
                        LakeDental.Show();
                    }
                    if (workFile.Contains("foot") || workFile.Contains("odiatry") || workFile.Contains("Foot"))
                    {
                        // Create a new child Foot Form; assign this form as its parent; display the child
                        FootForm PickensFoot = new FootForm();
                        PickensFoot.MdiParent = this;
                        PickensFoot.Show();
                    }

                    // deserialize and display in text box
                    try
                    {
                        // get next Record from file
                        Record newRec = (Record)fileReader.Deserialize(input);

                        // store Record values in temporary string array
                        var values = new string[] { newRec.ID.ToString(), newRec.Name.ToString(), 
                            newRec.QtyReq.ToString(), newRec.Qty.ToString(), newRec.Practice.ToString() };

                        // display in the text box
                        textBox1.AppendText(values[0] + "\t" + values[1] + "\t" + values[2] + "\t" + values[3] + "\t" + values[4]);
                        

                    }

                    catch(IOException)
                    {
                        MessageBox.Show("oops.");
                    }
                }
            }
        }


//*************************************************************************************************************

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //fileReader.Close(); // close streamreader and underlying file
            }
            catch
            {
                // if can't close file, notify
                MessageBox.Show("Error: cannot close file.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }


        //**************************************************************************************


        private void MedicalSupplies_Load(object sender, EventArgs e)
        { 
            FileStream output = new FileStream("LakeDentalClinic.inv", 
                FileMode.OpenOrCreate, FileAccess.Write);

            Record rex = new Record();
            rex.ID = 3570;
            rex.Name = "toothbrush";
            rex.QtyReq = 100;
            rex.Qty = 61;
            rex.Practice = "Lake Dental Clinic";

            reader.Serialize(output, rex);
        }


    }
}
