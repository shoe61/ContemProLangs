using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Program_7B
{
    public partial class PracticeForm : Form
    {
        public string workFile;

        public PracticeForm()
        {
            InitializeComponent();
        }

        public PracticeForm(string workfile)
        {
            InitializeComponent();
            this.workFile = workfile;
        }

        public void displayInv()
        {
            for (int i = 0; i < MedicalSupplies.theList.Count; i++)
            {
                inventoryListBx.Items.Add(MedicalSupplies.theList[i][0] + "\r\t"
                    + MedicalSupplies.theList[i][1] + "\r\t"
                    + MedicalSupplies.theList[i][2] + "\r\t"
                    + MedicalSupplies.theList[i][3] + "\r\t"
                    + MedicalSupplies.theList[i][4]);
            }
        }

        public void getUpdate(string update)
        {
            inventoryListBx.Items.Add(update);
        }

        public void getDelete(int idx)
        {
            inventoryListBx.Items.RemoveAt(idx);
        }

        private void PracticeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Text == "Lake Dental Clinic")
            {
                MedicalSupplies.dentalOpen = false;
            }
            if (this.Text == "Pickens Foot Clinic")
            {
                MedicalSupplies.footOpen = false;
            }
        }
    }
}
