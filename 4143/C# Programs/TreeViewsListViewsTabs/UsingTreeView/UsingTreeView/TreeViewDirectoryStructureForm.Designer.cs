namespace UsingTreeView
{
    partial class TreeViewDirectoryStructureForm
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
            this.directoryTreeView = new System.Windows.Forms.TreeView();
            this.displayLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directoryTreeView
            // 
            this.directoryTreeView.Location = new System.Drawing.Point(41, 99);
            this.directoryTreeView.Name = "directoryTreeView";
            this.directoryTreeView.Size = new System.Drawing.Size(271, 262);
            this.directoryTreeView.TabIndex = 0;
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(38, 22);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(270, 13);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.Text = "Enter the full path to the direcoty you would like to view:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(41, 55);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(164, 20);
            this.inputTextBox.TabIndex = 2;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(254, 55);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // TreeViewDirectoryStructureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 397);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.directoryTreeView);
            this.Name = "TreeViewDirectoryStructureForm";
            this.Text = "Tree View Directory Structure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView directoryTreeView;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button enterButton;
    }
}

