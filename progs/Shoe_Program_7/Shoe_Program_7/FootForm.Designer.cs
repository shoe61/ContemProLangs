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
            this.recordRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // recordRichTextBox
            // 
            this.recordRichTextBox.Location = new System.Drawing.Point(1, 1);
            this.recordRichTextBox.Name = "recordRichTextBox";
            this.recordRichTextBox.Size = new System.Drawing.Size(553, 124);
            this.recordRichTextBox.TabIndex = 0;
            this.recordRichTextBox.Text = "";
            // 
            // FootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 261);
            this.Controls.Add(this.recordRichTextBox);
            this.Name = "FootForm";
            this.Text = "Podiatric Supplies";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox recordRichTextBox;




    }
}