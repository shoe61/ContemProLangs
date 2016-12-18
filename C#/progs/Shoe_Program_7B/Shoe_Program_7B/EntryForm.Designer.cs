namespace Shoe_Program_7B
{
    partial class EntryForm
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
            this.itemInfoGrpBx = new System.Windows.Forms.GroupBox();
            this.practiceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.qtyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.qtyReqRichTextBox = new System.Windows.Forms.RichTextBox();
            this.nameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.idRichTextBox = new System.Windows.Forms.RichTextBox();
            this.practiceLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.qtyReqLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.itemInfoGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemInfoGrpBx
            // 
            this.itemInfoGrpBx.Controls.Add(this.practiceRichTextBox);
            this.itemInfoGrpBx.Controls.Add(this.qtyRichTextBox);
            this.itemInfoGrpBx.Controls.Add(this.qtyReqRichTextBox);
            this.itemInfoGrpBx.Controls.Add(this.nameRichTextBox);
            this.itemInfoGrpBx.Controls.Add(this.idRichTextBox);
            this.itemInfoGrpBx.Controls.Add(this.practiceLabel);
            this.itemInfoGrpBx.Controls.Add(this.qtyLabel);
            this.itemInfoGrpBx.Controls.Add(this.qtyReqLabel);
            this.itemInfoGrpBx.Controls.Add(this.nameLabel);
            this.itemInfoGrpBx.Controls.Add(this.idLabel);
            this.itemInfoGrpBx.Location = new System.Drawing.Point(49, 23);
            this.itemInfoGrpBx.Name = "itemInfoGrpBx";
            this.itemInfoGrpBx.Size = new System.Drawing.Size(486, 260);
            this.itemInfoGrpBx.TabIndex = 1;
            this.itemInfoGrpBx.TabStop = false;
            this.itemInfoGrpBx.Text = "Item Information Fields";
            // 
            // practiceRichTextBox
            // 
            this.practiceRichTextBox.Location = new System.Drawing.Point(188, 192);
            this.practiceRichTextBox.Name = "practiceRichTextBox";
            this.practiceRichTextBox.Size = new System.Drawing.Size(233, 28);
            this.practiceRichTextBox.TabIndex = 9;
            this.practiceRichTextBox.Text = "";
            // 
            // qtyRichTextBox
            // 
            this.qtyRichTextBox.Location = new System.Drawing.Point(188, 151);
            this.qtyRichTextBox.Name = "qtyRichTextBox";
            this.qtyRichTextBox.Size = new System.Drawing.Size(233, 28);
            this.qtyRichTextBox.TabIndex = 8;
            this.qtyRichTextBox.Text = "";
            // 
            // qtyReqRichTextBox
            // 
            this.qtyReqRichTextBox.Location = new System.Drawing.Point(188, 110);
            this.qtyReqRichTextBox.Name = "qtyReqRichTextBox";
            this.qtyReqRichTextBox.Size = new System.Drawing.Size(233, 28);
            this.qtyReqRichTextBox.TabIndex = 7;
            this.qtyReqRichTextBox.Text = "";
            // 
            // nameRichTextBox
            // 
            this.nameRichTextBox.Location = new System.Drawing.Point(188, 69);
            this.nameRichTextBox.Name = "nameRichTextBox";
            this.nameRichTextBox.Size = new System.Drawing.Size(233, 28);
            this.nameRichTextBox.TabIndex = 6;
            this.nameRichTextBox.Text = "";
            // 
            // idRichTextBox
            // 
            this.idRichTextBox.Location = new System.Drawing.Point(188, 28);
            this.idRichTextBox.Multiline = false;
            this.idRichTextBox.Name = "idRichTextBox";
            this.idRichTextBox.Size = new System.Drawing.Size(233, 28);
            this.idRichTextBox.TabIndex = 5;
            this.idRichTextBox.Text = "";
            // 
            // practiceLabel
            // 
            this.practiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.practiceLabel.Location = new System.Drawing.Point(22, 192);
            this.practiceLabel.Name = "practiceLabel";
            this.practiceLabel.Size = new System.Drawing.Size(160, 40);
            this.practiceLabel.TabIndex = 4;
            this.practiceLabel.Text = "practice:";
            this.practiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qtyLabel
            // 
            this.qtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.Location = new System.Drawing.Point(22, 151);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(160, 40);
            this.qtyLabel.TabIndex = 3;
            this.qtyLabel.Text = "quantity on hand:";
            this.qtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qtyReqLabel
            // 
            this.qtyReqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyReqLabel.Location = new System.Drawing.Point(22, 110);
            this.qtyReqLabel.Name = "qtyReqLabel";
            this.qtyReqLabel.Size = new System.Drawing.Size(160, 40);
            this.qtyReqLabel.TabIndex = 2;
            this.qtyReqLabel.Text = "quantitiy required:";
            this.qtyReqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(22, 69);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(160, 40);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(22, 28);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(160, 40);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "id number:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(393, 313);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(142, 51);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(49, 313);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(142, 51);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insert new item";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(226, 313);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(142, 51);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update item";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 389);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.itemInfoGrpBx);
            this.Name = "EntryForm";
            this.Text = "Inventory Entry Form";
            this.itemInfoGrpBx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox itemInfoGrpBx;
        private System.Windows.Forms.RichTextBox practiceRichTextBox;
        private System.Windows.Forms.RichTextBox qtyRichTextBox;
        private System.Windows.Forms.RichTextBox qtyReqRichTextBox;
        private System.Windows.Forms.RichTextBox nameRichTextBox;
        private System.Windows.Forms.RichTextBox idRichTextBox;
        private System.Windows.Forms.Label practiceLabel;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.Label qtyReqLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button updateButton;
    }
}