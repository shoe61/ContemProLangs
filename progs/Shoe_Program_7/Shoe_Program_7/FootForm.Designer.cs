namespace Shoe_Program_7
{
    partial class FootForm
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
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.ColumnWidth = 600;
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(2, 12);
            this.inventoryListBox.MultiColumn = true;
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(552, 199);
            this.inventoryListBox.TabIndex = 0;
            // 
            // FootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 261);
            this.Controls.Add(this.inventoryListBox);
            this.Name = "FootForm";
            this.Text = "Podiatric Supplies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox inventoryListBox;





    }
}