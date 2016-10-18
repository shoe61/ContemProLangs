using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisualInheritance;

namespace VisualInheritanceTest
{
    public partial class VisualInheritanceTestForm : VisualInheritanceBaseForm
    {
        public VisualInheritanceTestForm()
        {
            InitializeComponent();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by C. Stringfellow.",
                "About This Program", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }
    }
}
