//  TreeViewDirectoryStructureTest.cs
// Using TreeView to display directory structure
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UsingTreeView
{
    /// <summary>
    /// displays the structure of directories in a TreeView
    /// </summary>
    public partial class TreeViewDirectoryStructureForm : Form
    {
        string substringDirectory;  //store last part of full path name

        // default constructor
        public TreeViewDirectoryStructureForm()
        {
            InitializeComponent();
        }

        public void PopulateTreeView(string directoryValue, TreeNode parentNode)
        {
            // populate current node with subdirectories
            string[] directoryArray =
               Directory.GetDirectories(directoryValue);

            // populate current node with subdirectories
            try
            {
                if (directoryArray.Length != 0)
                {
                    // for every subdirectory, create new TreeNode,
                    // add as child of current node and recursively
                    // populate child nodes with subdirectories
                    foreach (string directory in directoryArray)
                    {
                        //obtain last part of path name from the full path
                        //name by calling the GetFileNameWithoutExtension
                        //method of class Path
                        substringDirectory = Path.GetFileNameWithoutExtension(directory);

                        // create TreeNode for current directory
                        TreeNode myNode = new TreeNode(substringDirectory);

                        // add current directory node to parent node
                        parentNode.Nodes.Add(myNode);

                        // recursively populate every subdirectory
                        PopulateTreeView(directory, myNode);
                    }//end foreach
                } // end if
            } //end try

               // catch exception
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied");
            }

        } // end PopulateTreeView 

        private void enterButton_Click(object sender, EventArgs e)
        {
            //clear all nodes
            directoryTreeView.Nodes.Clear();

            //check if the directory enterd by user exists
            //if it does, then fill in the TreeView
            //if not, display error MessageBox
            if (Directory.Exists(inputTextBox.Text))
            {
                //add full path name to directoryTreeView
                directoryTreeView.Nodes.Add(inputTextBox.Text);

                //insert subfolders
                PopulateTreeView(inputTextBox.Text,
                    directoryTreeView.Nodes[0]);
            }
            //display error MessageBox if directory not found
            else
                MessageBox.Show(inputTextBox.Text + " couldnot be found.",
                    "Directory not Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }//end method enterButton_Click
    }
}
