namespace Shoe_Program_7
{
    partial class DentalForm
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
            this.recordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // recordTextBox
            // 
            this.recordTextBox.Location = new System.Drawing.Point(1, 2);
            this.recordTextBox.MaximumSize = new System.Drawing.Size(575, 250);
            this.recordTextBox.MinimumSize = new System.Drawing.Size(575, 250);
            this.recordTextBox.Name = "recordTextBox";
            this.recordTextBox.Size = new System.Drawing.Size(575, 20);
            this.recordTextBox.TabIndex = 0;
            // 
            // DentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 261);
            this.Controls.Add(this.recordTextBox);
            this.Name = "DentalForm";
            this.Text = "Dental Supplies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox recordTextBox;


    }
}