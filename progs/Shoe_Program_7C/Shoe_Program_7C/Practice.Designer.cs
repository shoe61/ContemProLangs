namespace Shoe_Program_7C
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
            this.heading = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.qtyReqLabel = new System.Windows.Forms.Label();
            this.onHandLabel = new System.Windows.Forms.Label();
            this.ClinicLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inventoryListBx
            // 
            this.inventoryListBx.FormattingEnabled = true;
            this.inventoryListBx.Location = new System.Drawing.Point(23, 78);
            this.inventoryListBx.Name = "inventoryListBx";
            this.inventoryListBx.Size = new System.Drawing.Size(541, 173);
            this.inventoryListBx.TabIndex = 1;
            // 
            // heading
            // 
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(23, 9);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(541, 30);
            this.heading.TabIndex = 2;
            this.heading.Text = "Inventory Status";
            this.heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemLabel
            // 
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(23, 59);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(93, 16);
            this.itemLabel.TabIndex = 3;
            this.itemLabel.Text = "item ID";
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(113, 59);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Description";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // qtyReqLabel
            // 
            this.qtyReqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyReqLabel.Location = new System.Drawing.Point(256, 59);
            this.qtyReqLabel.Name = "qtyReqLabel";
            this.qtyReqLabel.Size = new System.Drawing.Size(93, 16);
            this.qtyReqLabel.TabIndex = 5;
            this.qtyReqLabel.Text = "Qty. Req.";
            this.qtyReqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // onHandLabel
            // 
            this.onHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onHandLabel.Location = new System.Drawing.Point(355, 59);
            this.onHandLabel.Name = "onHandLabel";
            this.onHandLabel.Size = new System.Drawing.Size(93, 16);
            this.onHandLabel.TabIndex = 6;
            this.onHandLabel.Text = "Qty. O/H";
            this.onHandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClinicLabel
            // 
            this.ClinicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClinicLabel.Location = new System.Drawing.Point(454, 59);
            this.ClinicLabel.Name = "ClinicLabel";
            this.ClinicLabel.Size = new System.Drawing.Size(93, 16);
            this.ClinicLabel.TabIndex = 7;
            this.ClinicLabel.Text = "Clinic";
            this.ClinicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 263);
            this.ControlBox = false;
            this.Controls.Add(this.ClinicLabel);
            this.Controls.Add(this.onHandLabel);
            this.Controls.Add(this.qtyReqLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.inventoryListBx);
            this.Name = "PracticeForm";
            this.Text = "Practice";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox inventoryListBx;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label qtyReqLabel;
        private System.Windows.Forms.Label onHandLabel;
        private System.Windows.Forms.Label ClinicLabel;
    }
}