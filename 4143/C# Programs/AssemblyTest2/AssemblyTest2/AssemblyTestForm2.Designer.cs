namespace AssemblyTest2
{
    partial class AssemblyTestForm2
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
            this.hourLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.hourButton = new System.Windows.Forms.Button();
            this.minuteButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.minuteTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.displayLabel1 = new System.Windows.Forms.Label();
            this.displayLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(65, 49);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(33, 13);
            this.hourLabel.TabIndex = 0;
            this.hourLabel.Text = "Hour:";
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(65, 79);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(42, 13);
            this.minuteLabel.TabIndex = 1;
            this.minuteLabel.Text = "Minute:";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(65, 118);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(47, 13);
            this.secondLabel.TabIndex = 2;
            this.secondLabel.Text = "Second:";
            // 
            // hourButton
            // 
            this.hourButton.Location = new System.Drawing.Point(179, 44);
            this.hourButton.Name = "hourButton";
            this.hourButton.Size = new System.Drawing.Size(75, 23);
            this.hourButton.TabIndex = 3;
            this.hourButton.Text = "Set Hour";
            this.hourButton.UseVisualStyleBackColor = true;
            this.hourButton.Click += new System.EventHandler(this.hourButton_Click);
            // 
            // minuteButton
            // 
            this.minuteButton.Location = new System.Drawing.Point(179, 73);
            this.minuteButton.Name = "minuteButton";
            this.minuteButton.Size = new System.Drawing.Size(75, 23);
            this.minuteButton.TabIndex = 4;
            this.minuteButton.Text = "Set Minute";
            this.minuteButton.UseVisualStyleBackColor = true;
            this.minuteButton.Click += new System.EventHandler(this.minuteButton_Click);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(179, 108);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(75, 23);
            this.secondButton.TabIndex = 5;
            this.secondButton.Text = "Set Second";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.secondButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(179, 152);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(116, 24);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add 1 to Second";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // hourTextBox
            // 
            this.hourTextBox.Location = new System.Drawing.Point(115, 46);
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(43, 20);
            this.hourTextBox.TabIndex = 7;
            // 
            // minuteTextBox
            // 
            this.minuteTextBox.Location = new System.Drawing.Point(115, 79);
            this.minuteTextBox.Name = "minuteTextBox";
            this.minuteTextBox.Size = new System.Drawing.Size(43, 20);
            this.minuteTextBox.TabIndex = 8;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(115, 118);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(43, 20);
            this.secondTextBox.TabIndex = 9;
            // 
            // displayLabel1
            // 
            this.displayLabel1.AutoSize = true;
            this.displayLabel1.Location = new System.Drawing.Point(373, 73);
            this.displayLabel1.Name = "displayLabel1";
            this.displayLabel1.Size = new System.Drawing.Size(0, 13);
            this.displayLabel1.TabIndex = 10;
            // 
            // displayLabel2
            // 
            this.displayLabel2.AutoSize = true;
            this.displayLabel2.Location = new System.Drawing.Point(373, 121);
            this.displayLabel2.Name = "displayLabel2";
            this.displayLabel2.Size = new System.Drawing.Size(0, 13);
            this.displayLabel2.TabIndex = 11;
            // 
            // AssemblyTestForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 259);
            this.Controls.Add(this.displayLabel2);
            this.Controls.Add(this.displayLabel1);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.minuteTextBox);
            this.Controls.Add(this.hourTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.minuteButton);
            this.Controls.Add(this.hourButton);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.hourLabel);
            this.Name = "AssemblyTestForm2";
            this.Text = "Testing Time Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Button hourButton;
        private System.Windows.Forms.Button minuteButton;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.TextBox minuteTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Label displayLabel1;
        private System.Windows.Forms.Label displayLabel2;
    }
}

