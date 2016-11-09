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
    public partial class MedicalSupplies : Form
    {
        public MedicalSupplies()
        {
            InitializeComponent();
        }

        // Create a dental forms window
        private void dentalFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new child; assign this form as its parent; display the child
            DentalForm newMDIChild = new DentalForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // Create a medical forms window
        private void medicalFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new child; assign this form as its parent; display the child
            FootForm newMDIChild = new FootForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
