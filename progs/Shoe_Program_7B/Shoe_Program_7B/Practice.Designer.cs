namespace Shoe_Program_7B
{
    partial class PracticeForm
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
            this.inventoryListBx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // inventoryListBx
            // 
            this.inventoryListBx.FormattingEnabled = true;
            this.inventoryListBx.Location = new System.Drawing.Point(10, 60);
            this.inventoryListBx.Name = "inventoryListBx";
            this.inventoryListBx.Size = new System.Drawing.Size(541, 173);
            this.inventoryListBx.TabIndex = 0;
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 261);
            this.Controls.Add(this.inventoryListBx);
            this.Name = "PracticeForm";
            this.Text = "Items on hand";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PracticeForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox inventoryListBx;
    }
}