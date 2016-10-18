//SimpleEventExample.cs
using System;
using System.Windows.Forms;

namespace SimpleEventExample
{
    //program that shows a simple event handler
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked");
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form was loaded");
        }
    }//end class MyForm
}
