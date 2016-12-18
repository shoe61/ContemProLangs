/* Scott Schumacher
 * Medical Supplies.cs
 * 6 December 2016
 * This class defines a login form, launched modally; before any work can be done on the main form,
 * a satisfactory login must be completed.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shoe_Program_7C
{
    public partial class LoginForm : Form
    {

        //Default Constructor**********************************************************************
        public LoginForm()
        {
            InitializeComponent();
        }

        // login_Click: ensures some input entered for usernmame and password**********************       

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userNameTextBx.Text == "")
            {
                MessageBox.Show("Enter a user name...any user name.");
            }

            if (PasswordTextBx.Text == "")
            {
                MessageBox.Show("Any password will do... except none.");
            }
            else
            {
                this.Close();
            }
        }
    }
}
