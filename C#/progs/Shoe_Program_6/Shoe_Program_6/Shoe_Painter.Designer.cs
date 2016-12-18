namespace Painter
{
   partial class PainterForm
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
            this.sizeGrpBx = new System.Windows.Forms.GroupBox();
            this.rollerRdoBtn = new System.Windows.Forms.RadioButton();
            this.boldRdoBtn = new System.Windows.Forms.RadioButton();
            this.medRdoBtn = new System.Windows.Forms.RadioButton();
            this.fineRdoBtn = new System.Windows.Forms.RadioButton();
            this.colorGrpBx = new System.Windows.Forms.GroupBox();
            this.eraseRdoBtn = new System.Windows.Forms.RadioButton();
            this.blackRdoBtn = new System.Windows.Forms.RadioButton();
            this.yellowRdoBtn = new System.Windows.Forms.RadioButton();
            this.blueRdoBtn = new System.Windows.Forms.RadioButton();
            this.greenRdoBtn = new System.Windows.Forms.RadioButton();
            this.redRdoBtn = new System.Windows.Forms.RadioButton();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.sizeGrpBx.SuspendLayout();
            this.colorGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeGrpBx
            // 
            this.sizeGrpBx.Controls.Add(this.rollerRdoBtn);
            this.sizeGrpBx.Controls.Add(this.boldRdoBtn);
            this.sizeGrpBx.Controls.Add(this.medRdoBtn);
            this.sizeGrpBx.Controls.Add(this.fineRdoBtn);
            this.sizeGrpBx.Location = new System.Drawing.Point(30, 13);
            this.sizeGrpBx.Name = "sizeGrpBx";
            this.sizeGrpBx.Size = new System.Drawing.Size(99, 135);
            this.sizeGrpBx.TabIndex = 0;
            this.sizeGrpBx.TabStop = false;
            this.sizeGrpBx.Text = "Line Size";
            // 
            // rollerRdoBtn
            // 
            this.rollerRdoBtn.AutoSize = true;
            this.rollerRdoBtn.Location = new System.Drawing.Point(20, 98);
            this.rollerRdoBtn.Name = "rollerRdoBtn";
            this.rollerRdoBtn.Size = new System.Drawing.Size(55, 19);
            this.rollerRdoBtn.TabIndex = 3;
            this.rollerRdoBtn.TabStop = true;
            this.rollerRdoBtn.Text = "Roller";
            this.rollerRdoBtn.UseVisualStyleBackColor = true;
            this.rollerRdoBtn.CheckedChanged += new System.EventHandler(this.sizeRdoBtns_CheckedChanged);
            // 
            // boldRdoBtn
            // 
            this.boldRdoBtn.AutoSize = true;
            this.boldRdoBtn.Location = new System.Drawing.Point(20, 72);
            this.boldRdoBtn.Name = "boldRdoBtn";
            this.boldRdoBtn.Size = new System.Drawing.Size(49, 19);
            this.boldRdoBtn.TabIndex = 2;
            this.boldRdoBtn.TabStop = true;
            this.boldRdoBtn.Text = "Bold";
            this.boldRdoBtn.UseVisualStyleBackColor = true;
            this.boldRdoBtn.CheckedChanged += new System.EventHandler(this.sizeRdoBtns_CheckedChanged);
            // 
            // medRdoBtn
            // 
            this.medRdoBtn.AutoSize = true;
            this.medRdoBtn.Location = new System.Drawing.Point(20, 47);
            this.medRdoBtn.Name = "medRdoBtn";
            this.medRdoBtn.Size = new System.Drawing.Size(70, 19);
            this.medRdoBtn.TabIndex = 1;
            this.medRdoBtn.TabStop = true;
            this.medRdoBtn.Text = "Medium";
            this.medRdoBtn.UseVisualStyleBackColor = true;
            this.medRdoBtn.CheckedChanged += new System.EventHandler(this.sizeRdoBtns_CheckedChanged);
            // 
            // fineRdoBtn
            // 
            this.fineRdoBtn.AutoSize = true;
            this.fineRdoBtn.Location = new System.Drawing.Point(20, 22);
            this.fineRdoBtn.Name = "fineRdoBtn";
            this.fineRdoBtn.Size = new System.Drawing.Size(47, 19);
            this.fineRdoBtn.TabIndex = 0;
            this.fineRdoBtn.TabStop = true;
            this.fineRdoBtn.Text = "Fine";
            this.fineRdoBtn.UseVisualStyleBackColor = true;
            this.fineRdoBtn.CheckedChanged += new System.EventHandler(this.sizeRdoBtns_CheckedChanged);
            // 
            // colorGrpBx
            // 
            this.colorGrpBx.Controls.Add(this.eraseRdoBtn);
            this.colorGrpBx.Controls.Add(this.blackRdoBtn);
            this.colorGrpBx.Controls.Add(this.yellowRdoBtn);
            this.colorGrpBx.Controls.Add(this.blueRdoBtn);
            this.colorGrpBx.Controls.Add(this.greenRdoBtn);
            this.colorGrpBx.Controls.Add(this.redRdoBtn);
            this.colorGrpBx.Location = new System.Drawing.Point(30, 162);
            this.colorGrpBx.Name = "colorGrpBx";
            this.colorGrpBx.Size = new System.Drawing.Size(99, 184);
            this.colorGrpBx.TabIndex = 1;
            this.colorGrpBx.TabStop = false;
            this.colorGrpBx.Text = "Colors";
            // 
            // eraseRdoBtn
            // 
            this.eraseRdoBtn.AutoSize = true;
            this.eraseRdoBtn.Location = new System.Drawing.Point(20, 150);
            this.eraseRdoBtn.Name = "eraseRdoBtn";
            this.eraseRdoBtn.Size = new System.Drawing.Size(58, 19);
            this.eraseRdoBtn.TabIndex = 5;
            this.eraseRdoBtn.Text = "ERASE";
            this.eraseRdoBtn.UseVisualStyleBackColor = true;
            this.eraseRdoBtn.CheckedChanged += new System.EventHandler(this.colorRdoBtns_CheckedChanged);
            // 
            // blackRdoBtn
            // 
            this.blackRdoBtn.AutoSize = true;
            this.blackRdoBtn.Checked = true;
            this.blackRdoBtn.Location = new System.Drawing.Point(20, 125);
            this.blackRdoBtn.Name = "blackRdoBtn";
            this.blackRdoBtn.Size = new System.Drawing.Size(53, 19);
            this.blackRdoBtn.TabIndex = 4;
            this.blackRdoBtn.TabStop = true;
            this.blackRdoBtn.Text = "Black";
            this.blackRdoBtn.UseVisualStyleBackColor = true;
            this.blackRdoBtn.CheckedChanged += new System.EventHandler(this.colorRdoBtns_CheckedChanged);
            // 
            // yellowRdoBtn
            // 
            this.yellowRdoBtn.AutoSize = true;
            this.yellowRdoBtn.Location = new System.Drawing.Point(20, 99);
            this.yellowRdoBtn.Name = "yellowRdoBtn";
            this.yellowRdoBtn.Size = new System.Drawing.Size(59, 19);
            this.yellowRdoBtn.TabIndex = 3;
            this.yellowRdoBtn.Text = "Yellow";
            this.yellowRdoBtn.UseVisualStyleBackColor = true;
            this.yellowRdoBtn.CheckedChanged += new System.EventHandler(this.colorRdoBtns_CheckedChanged);
            // 
            // blueRdoBtn
            // 
            this.blueRdoBtn.AutoSize = true;
            this.blueRdoBtn.Location = new System.Drawing.Point(20, 73);
            this.blueRdoBtn.Name = "blueRdoBtn";
            this.blueRdoBtn.Size = new System.Drawing.Size(48, 19);
            this.blueRdoBtn.TabIndex = 2;
            this.blueRdoBtn.Text = "Blue";
            this.blueRdoBtn.UseVisualStyleBackColor = true;
            this.blueRdoBtn.CheckedChanged += new System.EventHandler(this.colorRdoBtns_CheckedChanged);
            // 
            // greenRdoBtn
            // 
            this.greenRdoBtn.AutoSize = true;
            this.greenRdoBtn.Location = new System.Drawing.Point(20, 48);
            this.greenRdoBtn.Name = "greenRdoBtn";
            this.greenRdoBtn.Size = new System.Drawing.Size(56, 19);
            this.greenRdoBtn.TabIndex = 1;
            this.greenRdoBtn.Text = "Green";
            this.greenRdoBtn.UseVisualStyleBackColor = true;
            this.greenRdoBtn.CheckedChanged += new System.EventHandler(this.colorRdoBtns_CheckedChanged);
            // 
            // redRdoBtn
            // 
            this.redRdoBtn.AutoSize = true;
            this.redRdoBtn.Location = new System.Drawing.Point(20, 23);
            this.redRdoBtn.Name = "redRdoBtn";
            this.redRdoBtn.Size = new System.Drawing.Size(45, 19);
            this.redRdoBtn.TabIndex = 0;
            this.redRdoBtn.Text = "Red";
            this.redRdoBtn.UseVisualStyleBackColor = true;
            this.redRdoBtn.CheckedChanged += new System.EventHandler(this.colorRdoBtns_CheckedChanged);
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackColor = System.Drawing.Color.White;
            this.ImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImagePanel.Location = new System.Drawing.Point(145, 16);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ImagePanel.Size = new System.Drawing.Size(726, 438);
            this.ImagePanel.TabIndex = 2;
            this.ImagePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseDown);
            this.ImagePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseMove);
            this.ImagePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseUp);
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(883, 466);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.colorGrpBx);
            this.Controls.Add(this.sizeGrpBx);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PainterForm";
            this.Text = "Shoe Painter (Not for use on shoes)";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseUp);
            this.sizeGrpBx.ResumeLayout(false);
            this.sizeGrpBx.PerformLayout();
            this.colorGrpBx.ResumeLayout(false);
            this.colorGrpBx.PerformLayout();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox sizeGrpBx;
      private System.Windows.Forms.RadioButton boldRdoBtn;
      private System.Windows.Forms.RadioButton medRdoBtn;
      private System.Windows.Forms.RadioButton fineRdoBtn;
      private System.Windows.Forms.GroupBox colorGrpBx;
      private System.Windows.Forms.RadioButton yellowRdoBtn;
      private System.Windows.Forms.RadioButton blueRdoBtn;
      private System.Windows.Forms.RadioButton greenRdoBtn;
      private System.Windows.Forms.RadioButton redRdoBtn;
      private System.Windows.Forms.RadioButton rollerRdoBtn;
      private System.Windows.Forms.RadioButton eraseRdoBtn;
      private System.Windows.Forms.RadioButton blackRdoBtn;
      private System.Windows.Forms.Panel ImagePanel;


   }
}

