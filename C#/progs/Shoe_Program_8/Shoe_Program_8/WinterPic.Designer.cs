namespace Shoe_Program_8
{
    partial class WinterPic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinterPic));
            this.imagePanel = new System.Windows.Forms.Panel();
            this.celsTimer = new System.Windows.Forms.Timer(this.components);
            this.celsList = new System.Windows.Forms.ImageList(this.components);
            this.startStopBtn = new System.Windows.Forms.Button();
            this.imagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Controls.Add(this.startStopBtn);
            this.imagePanel.Location = new System.Drawing.Point(12, 12);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(1194, 552);
            this.imagePanel.TabIndex = 0;
            this.imagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.imagePanel_Paint_1);
            // 
            // celsTimer
            // 
            this.celsTimer.Interval = 500;
            this.celsTimer.Tick += new System.EventHandler(this.celsTimer_Tick);
            // 
            // celsList
            // 
            this.celsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("celsList.ImageStream")));
            this.celsList.TransparentColor = System.Drawing.Color.Transparent;
            this.celsList.Images.SetKeyName(0, "0.png");
            this.celsList.Images.SetKeyName(1, "1.png");
            this.celsList.Images.SetKeyName(2, "2.png");
            this.celsList.Images.SetKeyName(3, "3.png");
            this.celsList.Images.SetKeyName(4, "4.png");
            this.celsList.Images.SetKeyName(5, "5.png");
            this.celsList.Images.SetKeyName(6, "6.png");
            this.celsList.Images.SetKeyName(7, "7.png");
            this.celsList.Images.SetKeyName(8, "8.png");
            this.celsList.Images.SetKeyName(9, "9.png");
            this.celsList.Images.SetKeyName(10, "10.png");
            this.celsList.Images.SetKeyName(11, "11.png");
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(452, 491);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(106, 27);
            this.startStopBtn.TabIndex = 1;
            this.startStopBtn.Text = "START";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // WinterPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1268, 559);
            this.Controls.Add(this.imagePanel);
            this.DoubleBuffered = true;
            this.Name = "WinterPic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "A Winter Scene";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.imagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Timer celsTimer;
        private System.Windows.Forms.ImageList celsList;
        private System.Windows.Forms.Button startStopBtn;
    }
}

