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
    public partial class DentalForm : Form
    {
        public DentalForm()
        {
            InitializeComponent();
        }

        
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (DentalOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader dsr = new
                    System.IO.StreamReader(DentalOpenFileDialog.FileName);
                MessageBox.Show(dsr.ReadToEnd());
                dsr.Close();
            }
        }





    }
}
