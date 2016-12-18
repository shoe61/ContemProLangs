using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UsingMDI
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        public ChildForm(string title, string resourceName)
        {
            //Required for Windows Form Designer Support
            InitializeComponent();

            //set title text
            Text = title;

            //set image to display in PictureBox
            displayPictureBox.Image = Image.FromFile(
                    Directory.GetCurrentDirectory() + resourceName); 

        }
    }
}
