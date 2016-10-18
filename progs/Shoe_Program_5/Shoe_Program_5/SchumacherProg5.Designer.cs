namespace Shoe_Program_5
{
    partial class ScottSchumacher_Prog_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScottSchumacher_Prog_5));
            this.ShapeListBx = new System.Windows.Forms.ListBox();
            this.WelcomeInstructLabel = new System.Windows.Forms.Label();
            this.UserInputGrpBx = new System.Windows.Forms.GroupBox();
            this.UserInputGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShapeListBx
            // 
            this.ShapeListBx.FormattingEnabled = true;
            this.ShapeListBx.Location = new System.Drawing.Point(6, 19);
            this.ShapeListBx.Name = "ShapeListBx";
            this.ShapeListBx.Size = new System.Drawing.Size(179, 95);
            this.ShapeListBx.TabIndex = 0;
            // 
            // WelcomeInstructLabel
            // 
            this.WelcomeInstructLabel.BackColor = System.Drawing.Color.Khaki;
            this.WelcomeInstructLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeInstructLabel.Location = new System.Drawing.Point(31, 9);
            this.WelcomeInstructLabel.Name = "WelcomeInstructLabel";
            this.WelcomeInstructLabel.Size = new System.Drawing.Size(1313, 83);
            this.WelcomeInstructLabel.TabIndex = 1;
            this.WelcomeInstructLabel.Text = resources.GetString("WelcomeInstructLabel.Text");
            // 
            // UserInputGrpBx
            // 
            this.UserInputGrpBx.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.UserInputGrpBx.BackColor = System.Drawing.Color.Khaki;
            this.UserInputGrpBx.Controls.Add(this.ShapeListBx);
            this.UserInputGrpBx.Location = new System.Drawing.Point(35, 111);
            this.UserInputGrpBx.Name = "UserInputGrpBx";
            this.UserInputGrpBx.Size = new System.Drawing.Size(200, 502);
            this.UserInputGrpBx.TabIndex = 2;
            this.UserInputGrpBx.TabStop = false;
            this.UserInputGrpBx.Text = "Your Choices:";
            // 
            // ScottSchumacher_Prog_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 625);
            this.Controls.Add(this.UserInputGrpBx);
            this.Controls.Add(this.WelcomeInstructLabel);
            this.Name = "ScottSchumacher_Prog_5";
            this.Text = "Scott Schumacher Program 5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.UserInputGrpBx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ShapeListBx;
        private System.Windows.Forms.Label WelcomeInstructLabel;
        private System.Windows.Forms.GroupBox UserInputGrpBx;
    }
}

