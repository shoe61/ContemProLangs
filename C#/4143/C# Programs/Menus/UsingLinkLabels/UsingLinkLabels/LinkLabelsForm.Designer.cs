namespace UsingLinkLabels
{
    partial class LinkLabelsForm
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
            this.driveLinkLabel = new System.Windows.Forms.LinkLabel();
            this.deitelLinkLabel = new System.Windows.Forms.LinkLabel();
            this.notePadLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // driveLinkLabel
            // 
            this.driveLinkLabel.AutoSize = true;
            this.driveLinkLabel.Location = new System.Drawing.Point(67, 42);
            this.driveLinkLabel.Name = "driveLinkLabel";
            this.driveLinkLabel.Size = new System.Drawing.Size(97, 13);
            this.driveLinkLabel.TabIndex = 0;
            this.driveLinkLabel.TabStop = true;
            this.driveLinkLabel.Text = "Click to browse C:\\";
            this.driveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.driveLinkLabel_LinkClicked);
            // 
            // deitelLinkLabel
            // 
            this.deitelLinkLabel.AutoSize = true;
            this.deitelLinkLabel.Location = new System.Drawing.Point(70, 122);
            this.deitelLinkLabel.Name = "deitelLinkLabel";
            this.deitelLinkLabel.Size = new System.Drawing.Size(141, 13);
            this.deitelLinkLabel.TabIndex = 1;
            this.deitelLinkLabel.TabStop = true;
            this.deitelLinkLabel.Text = "Click to visit www.deitel.com";
            this.deitelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deitelLinkLabel_LinkClicked);
            // 
            // notePadLinkLabel
            // 
            this.notePadLinkLabel.AutoSize = true;
            this.notePadLinkLabel.Location = new System.Drawing.Point(73, 182);
            this.notePadLinkLabel.Name = "notePadLinkLabel";
            this.notePadLinkLabel.Size = new System.Drawing.Size(104, 13);
            this.notePadLinkLabel.TabIndex = 2;
            this.notePadLinkLabel.TabStop = true;
            this.notePadLinkLabel.Text = "Click to run Notepad";
            this.notePadLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notePadLinkLabel_LinkClicked);
            // 
            // LinkLabelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.notePadLinkLabel);
            this.Controls.Add(this.deitelLinkLabel);
            this.Controls.Add(this.driveLinkLabel);
            this.Name = "LinkLabelsForm";
            this.Text = "Link Label Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel driveLinkLabel;
        private System.Windows.Forms.LinkLabel deitelLinkLabel;
        private System.Windows.Forms.LinkLabel notePadLinkLabel;
    }
}

