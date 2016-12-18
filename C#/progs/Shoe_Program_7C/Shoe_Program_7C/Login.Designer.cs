namespace Shoe_Program_7C
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPassword1 = new Shoe_Program_7C.LoginPassword();
            this.SuspendLayout();
            // 
            // loginPassword1
            // 
            this.loginPassword1.Location = new System.Drawing.Point(51, 30);
            this.loginPassword1.Name = "loginPassword1";
            this.loginPassword1.Size = new System.Drawing.Size(170, 149);
            this.loginPassword1.TabIndex = 0;
            this.loginPassword1.Click += new System.EventHandler(this.loginPassword1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loginPassword1);
            this.Name = "Login";
            this.Text = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginPassword loginPassword1;
    }
}