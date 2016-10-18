using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeTest3
{
    public partial class TimeTestForm : Form
    {
        private Time3 time;
        public TimeTestForm()
        {
            InitializeComponent();

            time = new Time3();
            UpdateDisplay();

        }

        // update display labels
        public void UpdateDisplay()
        {
            displayLabel1.Text = "Hour: " + time.Hour + "; Minute: " + time.Minute +
               "; Second: " + time.Second;
            displayLabel2.Text = "Standard time: " + time.ToStandardString() +
               "\nUniversal time: " + time.ToUniversalString();
        }

        private void hourButton_Click(object sender, EventArgs e)
        {
            time.Hour = Int32.Parse(hourTextBox.Text);
            hourTextBox.Text = "";
            UpdateDisplay();

        }

        private void minuteButton_Click(object sender, EventArgs e)
        {
            time.Minute = Int32.Parse(minuteTextBox.Text);
            minuteTextBox.Text = "";
            UpdateDisplay();
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            time.Second = Int32.Parse(secondTextBox.Text);
            secondTextBox.Text = "";
            UpdateDisplay();
        }       
        
        private void addButton_Click(object sender, EventArgs e)
        {
            time.Second = (time.Second + 1) % 60;

            if (time.Second == 0)
            {
                time.Minute = (time.Minute + 1) % 60;

                if (time.Minute == 0)
                    time.Hour = (time.Hour + 1) % 24;
            }

            UpdateDisplay();
        }
    }
}
