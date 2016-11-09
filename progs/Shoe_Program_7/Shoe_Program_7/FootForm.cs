using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Program_7
{
    public partial class FootForm : Form
    {
        public FootForm()
        {
            InitializeComponent();
        }

        // This method opens a file when the file:open menu is clicked
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FootOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader fsr = new
                    System.IO.StreamReader(FootOpenFileDialog.FileName);
                MessageBox.Show(fsr.ReadToEnd());
                fsr.Close();
            }
        }



    }
}
