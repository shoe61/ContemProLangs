﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Add(inputBox.Text);
            inputBox.Clear();
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
