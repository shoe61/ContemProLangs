using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuTest
{
    public partial class MenuTestForm : Form
    {
        public MenuTestForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "This is an example\nof using menus.",
        "About", MessageBoxButtons.OK,
        MessageBoxIcon.Information);

        }

        // reset color
        private void ClearColor()
        {
            // clear all checkmarks
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset checkmarks for color menu items
            ClearColor();

            // set color to black
            displayLabel.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {            // reset checkmarks for color menu items
            ClearColor();

            // set color to black
            displayLabel.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;

        }
    }
}
