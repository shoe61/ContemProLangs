using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Program_7C
{
    public partial class LoginPassword : UserControl
    {
        public LoginPassword()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonClick;

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
           
        }
    }
}
