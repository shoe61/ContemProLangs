using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualInheritance
{
    public partial class VisualInheritanceBaseForm : Form
    {
        public VisualInheritanceBaseForm()
        {
            InitializeComponent();
        }

        private void learnMoreButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bugs, Bugs, Bugs is a product of Stringfellow, Inc.",
                "Learn More", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
