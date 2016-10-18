﻿namespace DisplayTable
{
   partial class DisplayAuthorsTable
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAuthorsTable));
         this.authorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.authorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.authorDataGridView = new System.Windows.Forms.DataGridView();
         this.browseAllButton = new System.Windows.Forms.Button();
         this.findGroupBox = new System.Windows.Forms.GroupBox();
         this.findButton = new System.Windows.Forms.Button();
         this.findLabel = new System.Windows.Forms.Label();
         this.findTextBox = new System.Windows.Forms.TextBox();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).BeginInit();
         this.authorBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).BeginInit();
         this.findGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // authorBindingNavigator
         // 
         this.authorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.authorBindingNavigator.BindingSource = this.authorBindingSource;
         this.authorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.authorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.authorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.authorBindingNavigatorSaveItem});
         this.authorBindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.authorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.authorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.authorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.authorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.authorBindingNavigator.Name = "authorBindingNavigator";
         this.authorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.authorBindingNavigator.Size = new System.Drawing.Size(452, 25);
         this.authorBindingNavigator.TabIndex = 0;
         this.authorBindingNavigator.Text = "bindingNavigator1";
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorAddNewItem.Text = "Add new";
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveFirstItem.Text = "Move first";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMovePreviousItem.Text = "Move previous";
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorPositionItem
         // 
         this.bindingNavigatorPositionItem.AccessibleName = "Position";
         this.bindingNavigatorPositionItem.AutoSize = false;
         this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
         this.bindingNavigatorPositionItem.Text = "0";
         this.bindingNavigatorPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveLastItem.Text = "Move last";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // authorBindingNavigatorSaveItem
         // 
         this.authorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.authorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("authorBindingNavigatorSaveItem.Image")));
         this.authorBindingNavigatorSaveItem.Name = "authorBindingNavigatorSaveItem";
         this.authorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
         this.authorBindingNavigatorSaveItem.Text = "Save Data";
         this.authorBindingNavigatorSaveItem.Click += new System.EventHandler(this.authorBindingNavigatorSaveItem_Click);
         // 
         // authorDataGridView
         // 
         this.authorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.authorDataGridView.AutoGenerateColumns = false;
         this.authorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.authorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
         this.authorDataGridView.DataSource = this.authorBindingSource;
         this.authorDataGridView.Location = new System.Drawing.Point(0, 25);
         this.authorDataGridView.Name = "authorDataGridView";
         this.authorDataGridView.Size = new System.Drawing.Size(452, 210);
         this.authorDataGridView.TabIndex = 1;
         // 
         // browseAllButton
         // 
         this.browseAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.browseAllButton.Location = new System.Drawing.Point(168, 307);
         this.browseAllButton.Name = "browseAllButton";
         this.browseAllButton.Size = new System.Drawing.Size(114, 23);
         this.browseAllButton.TabIndex = 13;
         this.browseAllButton.Text = "Browse All Entries";
         this.browseAllButton.UseVisualStyleBackColor = true;
         this.browseAllButton.Click += new System.EventHandler(this.browseAllButton_Click);
         // 
         // findGroupBox
         // 
         this.findGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.findGroupBox.Controls.Add(this.findButton);
         this.findGroupBox.Controls.Add(this.findLabel);
         this.findGroupBox.Controls.Add(this.findTextBox);
         this.findGroupBox.Location = new System.Drawing.Point(90, 250);
         this.findGroupBox.Name = "findGroupBox";
         this.findGroupBox.Size = new System.Drawing.Size(272, 51);
         this.findGroupBox.TabIndex = 12;
         this.findGroupBox.TabStop = false;
         this.findGroupBox.Text = "Find an entry by last name";
         // 
         // findButton
         // 
         this.findButton.Location = new System.Drawing.Point(188, 19);
         this.findButton.Name = "findButton";
         this.findButton.Size = new System.Drawing.Size(75, 23);
         this.findButton.TabIndex = 2;
         this.findButton.Text = "Find";
         this.findButton.UseVisualStyleBackColor = true;
         this.findButton.Click += new System.EventHandler(this.findButton_Click);
         // 
         // findLabel
         // 
         this.findLabel.AutoSize = true;
         this.findLabel.Location = new System.Drawing.Point(6, 22);
         this.findLabel.Name = "findLabel";
         this.findLabel.Size = new System.Drawing.Size(61, 13);
         this.findLabel.TabIndex = 0;
         this.findLabel.Text = "Last Name:";
         // 
         // findTextBox
         // 
         this.findTextBox.Location = new System.Drawing.Point(78, 19);
         this.findTextBox.Name = "findTextBox";
         this.findTextBox.Size = new System.Drawing.Size(104, 20);
         this.findTextBox.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "AuthorID";
         this.dataGridViewTextBoxColumn1.HeaderText = "AuthorID";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         this.dataGridViewTextBoxColumn1.ReadOnly = true;
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
         this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
         this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // authorBindingSource
         // 
         this.authorBindingSource.DataSource = typeof(BooksExamples.Author);
         // 
         // DisplayAuthorsTable
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(452, 342);
         this.Controls.Add(this.browseAllButton);
         this.Controls.Add(this.findGroupBox);
         this.Controls.Add(this.authorDataGridView);
         this.Controls.Add(this.authorBindingNavigator);
         this.MaximumSize = new System.Drawing.Size(468, 380);
         this.MinimumSize = new System.Drawing.Size(468, 380);
         this.Name = "DisplayAuthorsTable";
         this.Text = "Display Authors Table";
         this.Load += new System.EventHandler(this.DisplayAuthorsTable_Load);
         ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).EndInit();
         this.authorBindingNavigator.ResumeLayout(false);
         this.authorBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).EndInit();
         this.findGroupBox.ResumeLayout(false);
         this.findGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.BindingSource authorBindingSource;
      private System.Windows.Forms.BindingNavigator authorBindingNavigator;
      private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
      private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      private System.Windows.Forms.ToolStripButton authorBindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridView authorDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      internal System.Windows.Forms.Button browseAllButton;
      internal System.Windows.Forms.GroupBox findGroupBox;
      internal System.Windows.Forms.Button findButton;
      internal System.Windows.Forms.Label findLabel;
      internal System.Windows.Forms.TextBox findTextBox;
   }
}

