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


namespace Shoe_Program_7
{
    public partial class MedicalSupplies : Form
    {
        FileStream input;
        StreamReader fileReader;
        
        
        // parameterless constructor
        public MedicalSupplies()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
                    fileReader = new StreamReader(input);

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

                    // Now, read the file line by line, each line becoming a record- book has it in a try block
                    
                    // First, go to the beginning of the file
                    input.Seek(0, SeekOrigin.Begin);
                    
                    // Then, while(true) get the next record in the file
                    while (true)
                    {
                        // read a line
                        string record = fileReader.ReadLine();

                        // Have an exit plan: (if record == null)
                        if (record == null)
                        {
                            return;
                        }

                        // Parse the input; comma separated fields
                        string[] inputFields = record.Split(',');

                        // Create a Record object
                        Record newRec = new Record(int.Parse(inputFields[0]), inputFields[1],
                            int.Parse(inputFields[2]), int.Parse(inputFields[3]), inputFields[4]);

                        // ... and display the records in the TextBox of the appropriate child window.
                        textBox1.AppendText("{newRec.ID}\t" + "{newRec.Name}\t" + "{newRec.QtyReq}\t" + "{newRec.Qty}\t" + "{newRec.Practice}{Environment.NewLine}");
                    }

                }
            }
        }




        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fileReader.Close(); // close streamreader and underlying file
            }
            catch
            {
                // if can't close file, notify
                MessageBox.Show("Error: cannot close file.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }


    }
}
