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
