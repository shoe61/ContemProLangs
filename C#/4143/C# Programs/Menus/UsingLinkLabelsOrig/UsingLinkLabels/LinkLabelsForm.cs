using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingLinkLabels
{
    public partial class LinkLabelsForm : Form
    {
        public LinkLabelsForm()
        {
            InitializeComponent();
        }

        private void driveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            driveLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\");
        }

        private void deitelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deitelLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(
               "IExplore", "http://www.deitel.com");

        }

        private void notepadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            notepadLinkLabel.LinkVisited = true;

            // program called as if in run
            // menu and full path not needed
            System.Diagnostics.Process.Start("notepad");

        }

  
    }
}
