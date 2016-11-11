using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingListBoxes
{
    public partial class ListBoxTest : Form
    {
        public ListBoxTest()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Add(inputTextBox.Text);
            inputTextBox.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (displayListBox.SelectedIndex != -1)
                displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
