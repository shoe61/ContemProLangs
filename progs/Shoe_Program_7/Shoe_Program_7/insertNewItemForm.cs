using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Shoe_Program_7
{
    public partial class insertNewItemForm : MedicalSupplies
    {

        string[] appendo;

        BinaryFormatter writer = new BinaryFormatter();



        public insertNewItemForm()
        {
            InitializeComponent();
            var values = MedicalSupplies.values;
           
            string workfile = MedicalSupplies.workFile;

            // the practice name will be displayed as a reminder to the operator
            this.practiceRichTextBox.Text = values[4];
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            
            Record temp = new Record();
            try
            {
                temp.ID = int.Parse(this.idRichTextBox.Text);
                temp.Name = this.nameRichTextBox.Text;
                temp.QtyReq = int.Parse(this.qtyReqRichTextBox.Text);
                temp.Qty = int.Parse(this.qtyReqRichTextBox.Text);
                temp.Practice = this.practiceRichTextBox.Text;
            }

            catch(SystemException)
            {
                MessageBox.Show("If you don't want to add a record, click the CANCEL button.");
            }
           

            // create filestream object to get write access
            FileStream output = new FileStream(workFile, FileMode.Append, FileAccess.Write);
            writer.Serialize(output, temp);
            output.Close();

            this.Close();
        }



        private void insertNewItemForm_Load(object sender, EventArgs e)
        {
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

    }
}
