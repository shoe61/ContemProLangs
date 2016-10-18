using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingMDI
{
    public partial class UsingMDIForm : Form
    {
        public UsingMDIForm()
        {
            InitializeComponent();
        }


        private void csToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create new child
            ChildForm child = new ChildForm("Visual C# 2008 How to Program",
                                            "\\images\\csharphtp1.jpg" );
            // set parent
            child.MdiParent = this;
            // display child
            child.Show();                 

        }

        private void cppToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // create new child
            ChildForm child = new ChildForm("Visual C++ 2008 How to Program",
                                            "\\images\\vcpphtp1.jpg");
            // set parent
            child.MdiParent = this;
            // display child
            child.Show(); 
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create new child
            ChildForm child = new ChildForm("Python How to Program",
                                            "\\images\\pythonhtp1.jpg");
            // set parent
            child.MdiParent = this;
            // display child
            child.Show(); 
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
