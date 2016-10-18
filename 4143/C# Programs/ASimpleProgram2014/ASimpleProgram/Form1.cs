using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASimpleProgram
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void myForm_Load(object sender, EventArgs e)
        {
                    
            welcomeLabel.Text = "Yipee!";
            this.BackColor = Color.Red;
        }

    }
}
