using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Program_7
{
    public partial class DentalForm : Form
    {

        public DentalForm()
        {
            InitializeComponent();

            for (int i = 0; i < MedicalSupplies.theList.Count; i++)
            {
                inventoryListBox.Items.Add(MedicalSupplies.theList[i][0] + "\r\t" 
                    + MedicalSupplies.theList[i][1] + "\r\t" 
                    + MedicalSupplies.theList[i][2] + "\r\t"
                    + MedicalSupplies.theList[i][3] + "\r\t"  
                    + MedicalSupplies.theList[i][4]);
            }
        }


        public void deleter()
        {
           inventoryListBox.ClearSelected();
        }
    }
}
