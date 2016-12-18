//Scott Schumacher
//File Name: radio.Designer.cs
//Description: This is the C# generated file underlying the radio GUI.

namespace tootootle
{
    partial class Radio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radio));
            this.presetsGrpBox = new System.Windows.Forms.GroupBox();
            this.preset6 = new System.Windows.Forms.Button();
            this.preset4 = new System.Windows.Forms.Button();
            this.preset5 = new System.Windows.Forms.Button();
            this.preset3 = new System.Windows.Forms.Button();
            this.preset2 = new System.Windows.Forms.Button();
            this.preset1 = new System.Windows.Forms.Button();
            this.speakersGrpBox = new System.Windows.Forms.GroupBox();
            this.FrtSpkrCkBx = new System.Windows.Forms.CheckBox();
            this.RearSpkrCkBx = new System.Windows.Forms.CheckBox();
            this.PwrButton = new System.Windows.Forms.Button();
            this.VolCtrlGrpBx = new System.Windows.Forms.GroupBox();
            this.VolTrakBar = new System.Windows.Forms.TrackBar();
            this.MuteCkBx = new System.Windows.Forms.CheckBox();
            this.TuningGrpBx = new System.Windows.Forms.GroupBox();
            this.FMRadioButton = new System.Windows.Forms.RadioButton();
            this.AMRadioButton = new System.Windows.Forms.RadioButton();
            this.FreqLabel = new System.Windows.Forms.Label();
            this.NotePicBox = new System.Windows.Forms.PictureBox();
            this.presetsGrpBox.SuspendLayout();
            this.speakersGrpBox.SuspendLayout();
            this.VolCtrlGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolTrakBar)).BeginInit();
            this.TuningGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // presetsGrpBox
            // 
            this.presetsGrpBox.Controls.Add(this.preset6);
            this.presetsGrpBox.Controls.Add(this.preset4);
            this.presetsGrpBox.Controls.Add(this.preset5);
            this.presetsGrpBox.Controls.Add(this.preset3);
            this.presetsGrpBox.Controls.Add(this.preset2);
            this.presetsGrpBox.Controls.Add(this.preset1);
            this.presetsGrpBox.Location = new System.Drawing.Point(12, 12);
            this.presetsGrpBox.Name = "presetsGrpBox";
            this.presetsGrpBox.Size = new System.Drawing.Size(180, 55);
            this.presetsGrpBox.TabIndex = 0;
            this.presetsGrpBox.TabStop = false;
            this.presetsGrpBox.Text = "Pre-set Stations";
            // 
            // preset6
            // 
            this.preset6.Location = new System.Drawing.Point(149, 22);
            this.preset6.Name = "preset6";
            this.preset6.Size = new System.Drawing.Size(23, 23);
            this.preset6.TabIndex = 3;
            this.preset6.Text = "6";
            this.preset6.UseVisualStyleBackColor = true;
            // 
            // preset4
            // 
            this.preset4.Location = new System.Drawing.Point(91, 22);
            this.preset4.Name = "preset4";
            this.preset4.Size = new System.Drawing.Size(23, 23);
            this.preset4.TabIndex = 3;
            this.preset4.Text = "4";
            this.preset4.UseVisualStyleBackColor = true;
            // 
            // preset5
            // 
            this.preset5.Location = new System.Drawing.Point(120, 22);
            this.preset5.Name = "preset5";
            this.preset5.Size = new System.Drawing.Size(23, 23);
            this.preset5.TabIndex = 2;
            this.preset5.Text = "5";
            this.preset5.UseVisualStyleBackColor = true;
            // 
            // preset3
            // 
            this.preset3.Location = new System.Drawing.Point(62, 22);
            this.preset3.Name = "preset3";
            this.preset3.Size = new System.Drawing.Size(23, 23);
            this.preset3.TabIndex = 2;
            this.preset3.Text = "3";
            this.preset3.UseVisualStyleBackColor = true;
            // 
            // preset2
            // 
            this.preset2.Location = new System.Drawing.Point(37, 22);
            this.preset2.Name = "preset2";
            this.preset2.Size = new System.Drawing.Size(23, 23);
            this.preset2.TabIndex = 2;
            this.preset2.Text = "2";
            this.preset2.UseVisualStyleBackColor = true;
            // 
            // preset1
            // 
            this.preset1.Location = new System.Drawing.Point(8, 22);
            this.preset1.Name = "preset1";
            this.preset1.Size = new System.Drawing.Size(23, 23);
            this.preset1.TabIndex = 0;
            this.preset1.Text = "1";
            this.preset1.UseVisualStyleBackColor = true;
            // 
            // speakersGrpBox
            // 
            this.speakersGrpBox.Controls.Add(this.FrtSpkrCkBx);
            this.speakersGrpBox.Controls.Add(this.RearSpkrCkBx);
            this.speakersGrpBox.Location = new System.Drawing.Point(198, 12);
            this.speakersGrpBox.Name = "speakersGrpBox";
            this.speakersGrpBox.Size = new System.Drawing.Size(120, 55);
            this.speakersGrpBox.TabIndex = 1;
            this.speakersGrpBox.TabStop = false;
            this.speakersGrpBox.Text = "Speakers";
            // 
            // FrtSpkrCkBx
            // 
            this.FrtSpkrCkBx.AutoSize = true;
            this.FrtSpkrCkBx.Location = new System.Drawing.Point(62, 22);
            this.FrtSpkrCkBx.Name = "FrtSpkrCkBx";
            this.FrtSpkrCkBx.Size = new System.Drawing.Size(54, 19);
            this.FrtSpkrCkBx.TabIndex = 1;
            this.FrtSpkrCkBx.Text = "Front";
            this.FrtSpkrCkBx.UseVisualStyleBackColor = true;
            // 
            // RearSpkrCkBx
            // 
            this.RearSpkrCkBx.AutoSize = true;
            this.RearSpkrCkBx.Location = new System.Drawing.Point(7, 23);
            this.RearSpkrCkBx.Name = "RearSpkrCkBx";
            this.RearSpkrCkBx.Size = new System.Drawing.Size(49, 19);
            this.RearSpkrCkBx.TabIndex = 0;
            this.RearSpkrCkBx.Text = "Rear";
            this.RearSpkrCkBx.UseVisualStyleBackColor = true;
            // 
            // PwrButton
            // 
            this.PwrButton.Location = new System.Drawing.Point(324, 12);
            this.PwrButton.Name = "PwrButton";
            this.PwrButton.Size = new System.Drawing.Size(75, 55);
            this.PwrButton.TabIndex = 2;
            this.PwrButton.Text = "Power On/Off";
            this.PwrButton.UseVisualStyleBackColor = true;
            // 
            // VolCtrlGrpBx
            // 
            this.VolCtrlGrpBx.Controls.Add(this.VolTrakBar);
            this.VolCtrlGrpBx.Controls.Add(this.MuteCkBx);
            this.VolCtrlGrpBx.Location = new System.Drawing.Point(12, 73);
            this.VolCtrlGrpBx.Name = "VolCtrlGrpBx";
            this.VolCtrlGrpBx.Size = new System.Drawing.Size(180, 70);
            this.VolCtrlGrpBx.TabIndex = 3;
            this.VolCtrlGrpBx.TabStop = false;
            this.VolCtrlGrpBx.Text = "Volume Control";
            // 
            // VolTrakBar
            // 
            this.VolTrakBar.Location = new System.Drawing.Point(68, 19);
            this.VolTrakBar.Name = "VolTrakBar";
            this.VolTrakBar.Size = new System.Drawing.Size(104, 45);
            this.VolTrakBar.TabIndex = 1;
            // 
            // MuteCkBx
            // 
            this.MuteCkBx.AutoSize = true;
            this.MuteCkBx.Location = new System.Drawing.Point(8, 22);
            this.MuteCkBx.Name = "MuteCkBx";
            this.MuteCkBx.Size = new System.Drawing.Size(54, 19);
            this.MuteCkBx.TabIndex = 0;
            this.MuteCkBx.Text = "Mute";
            this.MuteCkBx.UseVisualStyleBackColor = true;
            // 
            // TuningGrpBx
            // 
            this.TuningGrpBx.Controls.Add(this.FMRadioButton);
            this.TuningGrpBx.Controls.Add(this.AMRadioButton);
            this.TuningGrpBx.Controls.Add(this.FreqLabel);
            this.TuningGrpBx.Location = new System.Drawing.Point(198, 73);
            this.TuningGrpBx.Name = "TuningGrpBx";
            this.TuningGrpBx.Size = new System.Drawing.Size(120, 70);
            this.TuningGrpBx.TabIndex = 4;
            this.TuningGrpBx.TabStop = false;
            this.TuningGrpBx.Text = "Tuning";
            // 
            // FMRadioButton
            // 
            this.FMRadioButton.AutoSize = true;
            this.FMRadioButton.Location = new System.Drawing.Point(62, 45);
            this.FMRadioButton.Name = "FMRadioButton";
            this.FMRadioButton.Size = new System.Drawing.Size(42, 19);
            this.FMRadioButton.TabIndex = 2;
            this.FMRadioButton.TabStop = true;
            this.FMRadioButton.Text = "FM";
            this.FMRadioButton.UseVisualStyleBackColor = true;
            // 
            // AMRadioButton
            // 
            this.AMRadioButton.AutoSize = true;
            this.AMRadioButton.Location = new System.Drawing.Point(62, 22);
            this.AMRadioButton.Name = "AMRadioButton";
            this.AMRadioButton.Size = new System.Drawing.Size(44, 19);
            this.AMRadioButton.TabIndex = 1;
            this.AMRadioButton.TabStop = true;
            this.AMRadioButton.Text = "AM";
            this.AMRadioButton.UseVisualStyleBackColor = true;
            // 
            // FreqLabel
            // 
            this.FreqLabel.BackColor = System.Drawing.Color.Black;
            this.FreqLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreqLabel.ForeColor = System.Drawing.Color.Silver;
            this.FreqLabel.Location = new System.Drawing.Point(6, 22);
            this.FreqLabel.Name = "FreqLabel";
            this.FreqLabel.Size = new System.Drawing.Size(50, 44);
            this.FreqLabel.TabIndex = 0;
            this.FreqLabel.Text = "92.9";
            this.FreqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotePicBox
            // 
            this.NotePicBox.Image = ((System.Drawing.Image)(resources.GetObject("NotePicBox.Image")));
            this.NotePicBox.Location = new System.Drawing.Point(335, 73);
            this.NotePicBox.Name = "NotePicBox";
            this.NotePicBox.Size = new System.Drawing.Size(55, 70);
            this.NotePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NotePicBox.TabIndex = 5;
            this.NotePicBox.TabStop = false;
            // 
            // Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 155);
            this.Controls.Add(this.NotePicBox);
            this.Controls.Add(this.TuningGrpBx);
            this.Controls.Add(this.VolCtrlGrpBx);
            this.Controls.Add(this.PwrButton);
            this.Controls.Add(this.speakersGrpBox);
            this.Controls.Add(this.presetsGrpBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Radio";
            this.Text = "Radio";
            this.presetsGrpBox.ResumeLayout(false);
            this.speakersGrpBox.ResumeLayout(false);
            this.speakersGrpBox.PerformLayout();
            this.VolCtrlGrpBx.ResumeLayout(false);
            this.VolCtrlGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolTrakBar)).EndInit();
            this.TuningGrpBx.ResumeLayout(false);
            this.TuningGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox presetsGrpBox;
        private System.Windows.Forms.Button preset6;
        private System.Windows.Forms.Button preset4;
        private System.Windows.Forms.Button preset5;
        private System.Windows.Forms.Button preset3;
        private System.Windows.Forms.Button preset2;
        private System.Windows.Forms.Button preset1;
        private System.Windows.Forms.GroupBox speakersGrpBox;
        private System.Windows.Forms.CheckBox FrtSpkrCkBx;
        private System.Windows.Forms.CheckBox RearSpkrCkBx;
        private System.Windows.Forms.Button PwrButton;
        private System.Windows.Forms.GroupBox VolCtrlGrpBx;
        private System.Windows.Forms.TrackBar VolTrakBar;
        private System.Windows.Forms.CheckBox MuteCkBx;
        private System.Windows.Forms.GroupBox TuningGrpBx;
        private System.Windows.Forms.RadioButton FMRadioButton;
        private System.Windows.Forms.RadioButton AMRadioButton;
        private System.Windows.Forms.Label FreqLabel;
        private System.Windows.Forms.PictureBox NotePicBox;
    }
}

