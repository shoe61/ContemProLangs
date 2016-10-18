using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingTabs
{
    public partial class UsingTabsForm : Form
    {
        public UsingTabsForm()
        {
            InitializeComponent();
        }

        // event handler for black color radio button
        private void blackRadioButton_CheckedChanged(
           object sender, System.EventArgs e)
        {
            displayLabel.ForeColor = Color.Black;
        }

        // event handler for red color radio button
        private void redRadioButton_CheckedChanged(
           object sender, System.EventArgs e)
        {
            displayLabel.ForeColor = Color.Red;
        }

        // event handler for green color radio button
        private void greenRadioButton_CheckedChanged(
           object sender, System.EventArgs e)
        {
            displayLabel.ForeColor = Color.Green;
        }

        // event handler for size 12 radio button
        private void size12RadioButton_CheckedChanged(
           object sender, System.EventArgs e)
        {
            displayLabel.Font =
               new Font(displayLabel.Font.Name, 12);
        }

        // event handler for size 16 radio button
        private void size16RadioButton_CheckedChanged(
           object sender, System.EventArgs e)
        {
            displayLabel.Font =
               new Font(displayLabel.Font.Name, 16);
        }

        // event handler for size 20 radio button
        private void size20RadioButton_CheckedChanged(
           object sender, System.EventArgs e)
        {
            displayLabel.Font =
               new Font(displayLabel.Font.Name, 20);
        }

        // event handler for message "Hello!" radio button
        private void helloRadioButton_CheckedChanged(
           object sender, System.EventArgs e)
        {
            displayLabel.Text = "Hello!";
        }

        // event handler for message "Goodbye!" radio button
        private void goodbyeRadioButton_CheckedChanged(
           object sender, System.EventArgs e)
        {
            displayLabel.Text = "Goodbye!";
        }


    }
}
