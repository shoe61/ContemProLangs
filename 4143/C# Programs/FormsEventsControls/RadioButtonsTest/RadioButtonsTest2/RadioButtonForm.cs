using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadioButtonsTest2
{
    public partial class RadioButtonForm : Form
    {
        private MessageBoxIcon iconType = MessageBoxIcon.Error;
        private MessageBoxButtons buttonType = MessageBoxButtons.OK;

        public RadioButtonForm()
        {
            InitializeComponent();
        }

        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == okButton)  // display OK button
                buttonType = MessageBoxButtons.OK;
            // display OK and Cancel buttons
            else if (sender == okCancelButton)
                buttonType = MessageBoxButtons.OKCancel;
            // display Abort, Retry and Ignore buttons
            else if (sender == abortRetryIgnoreButton)
                buttonType = MessageBoxButtons.AbortRetryIgnore;
            // display Yes, No and Cancel buttons
            else if (sender == yesNoCancelButton)
                buttonType = MessageBoxButtons.YesNoCancel;
            // display Yes and No buttons
            else if (sender == yesNoButton)
                buttonType = MessageBoxButtons.YesNo;
            // only one option left--display Retry and Cancel buttons
            else
                buttonType = MessageBoxButtons.RetryCancel;

        }

        private void iconType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == errorButton) // display error icon
                iconType = MessageBoxIcon.Error;
            else if (sender == exclamationButton)
                iconType = MessageBoxIcon.Exclamation;
            // display information icon
            else if (sender == informationButton)
                iconType = MessageBoxIcon.Information;
            else // only one option left--display question mark
                iconType = MessageBoxIcon.Question;

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DialogResult result =
        MessageBox.Show("This is Your Custom MessageBox.",
           "Custom MessageBox", buttonType, iconType, 0, 0);
            // check for dialog result and display it in label
            switch (result)
            {
                case DialogResult.OK:
                    displayLabel.Text = "OK was pressed.";
                    break;

                case DialogResult.Cancel:
                    displayLabel.Text = "Cancel was pressed.";
                    break;

                case DialogResult.Abort:
                    displayLabel.Text = "Abort was pressed.";
                    break;

                case DialogResult.Retry:
                    displayLabel.Text = "Retry was pressed.";
                    break;

                case DialogResult.Ignore:
                    displayLabel.Text = "Ignore was pressed.";
                    break;

                case DialogResult.Yes:
                    displayLabel.Text = "Yes was pressed.";
                    break;

                case DialogResult.No:
                    displayLabel.Text = "No was pressed.";
                    break;
            } // end switch

        }
    }
}
