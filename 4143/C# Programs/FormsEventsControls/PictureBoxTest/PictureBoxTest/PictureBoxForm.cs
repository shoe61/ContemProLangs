using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PictureBoxTest
{
    public partial class PictureBoxForm : Form
    {
        private int imageNum = -1;

        public PictureBoxForm()
        {
            InitializeComponent();
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            imageNum = (imageNum + 1) % 3; // imageNum from 0 to 2

            // create Image object from file, display on PictureBox
            imagePictureBox.Image = Image.FromFile(
               Directory.GetCurrentDirectory() +
              "\\images\\image" + imageNum + ".bmp");

        }
    }
}
