﻿namespace BaseballPlayers
{
   partial class BaseballPlayers
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseballPlayers));
         this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.playerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.playerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.playerDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.browseAllButton = new System.Windows.Forms.Button();
         this.findGroupBox = new System.Windows.Forms.GroupBox();
         this.findButton = new System.Windows.Forms.Button();
         this.findLabel = new System.Windows.Forms.Label();
         this.findTextBox = new System.Windows.Forms.TextBox();
         this.averageGroupBox = new System.Windows.Forms.GroupBox();
         this.maximumTextBox = new System.Windows.Forms.TextBox();
         this.maximumLabel = new System.Windows.Forms.Label();
         this.minimumTextBox = new System.Windows.Forms.TextBox();
         this.minimumLabel = new System.Windows.Forms.Label();
         this.averageButton = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.playerBindingNavigator)).BeginInit();
         this.playerBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).BeginInit();
         this.findGroupBox.SuspendLayout();
         this.averageGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // playerBindingSource
         // 
         this.playerBindingSource.DataSource = typeof(BaseballExercises.Player);
         // 
         // playerBindingNavigator
         // 
         this.playerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.playerBindingNavigator.BindingSource = this.playerBindingSource;
         this.playerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.playerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.playerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.playerBindingNavigatorSaveItem});
         this.playerBindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.playerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.playerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.playerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.playerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.playerBindingNavigator.Name = "playerBindingNavigator";
         this.playerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.playerBindingNavigator.Size = new System.Drawing.Size(460, 25);
         this.playerBindingNavigator.TabIndex = 0;
         this.playerBindingNavigator.Text = "bindingNavigator1";
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
         // playerBindingNavigatorSaveItem
         // 
         this.playerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.playerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("playerBindingNavigatorSaveItem.Image")));
         this.playerBindingNavigatorSaveItem.Name = "playerBindingNavigatorSaveItem";
         this.playerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
         this.playerBindingNavigatorSaveItem.Text = "Save Data";
         this.playerBindingNavigatorSaveItem.Click += new System.EventHandler(this.playerBindingNavigatorSaveItem_Click);
         // 
         // playerDataGridView
         // 
         this.playerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.playerDataGridView.AutoGenerateColumns = false;
         this.playerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.playerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
         this.playerDataGridView.DataSource = this.playerBindingSource;
         this.playerDataGridView.Location = new System.Drawing.Point(0, 28);
         this.playerDataGridView.Name = "playerDataGridView";
         this.playerDataGridView.Size = new System.Drawing.Size(460, 271);
         this.playerDataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "PlayerID";
         this.dataGridViewTextBoxColumn1.HeaderText = "PlayerID";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "BattingAverage";
         this.dataGridViewTextBoxColumn4.HeaderText = "BattingAverage";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         // 
         // browseAllButton
         // 
         this.browseAllButton.Location = new System.Drawing.Point(172, 383);
         this.browseAllButton.Name = "browseAllButton";
         this.browseAllButton.Size = new System.Drawing.Size(114, 23);
         this.browseAllButton.TabIndex = 15;
         this.browseAllButton.Text = "Browse All Entries";
         this.browseAllButton.UseVisualStyleBackColor = true;
         this.browseAllButton.Click += new System.EventHandler(this.browseAllButton_Click);
         // 
         // findGroupBox
         // 
         this.findGroupBox.Controls.Add(this.findButton);
         this.findGroupBox.Controls.Add(this.findLabel);
         this.findGroupBox.Controls.Add(this.findTextBox);
         this.findGroupBox.Location = new System.Drawing.Point(94, 326);
         this.findGroupBox.Name = "findGroupBox";
         this.findGroupBox.Size = new System.Drawing.Size(272, 51);
         this.findGroupBox.TabIndex = 14;
         this.findGroupBox.TabStop = false;
         this.findGroupBox.Text = "Find a player by last name";
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
         // averageGroupBox
         // 
         this.averageGroupBox.Controls.Add(this.maximumTextBox);
         this.averageGroupBox.Controls.Add(this.maximumLabel);
         this.averageGroupBox.Controls.Add(this.minimumTextBox);
         this.averageGroupBox.Controls.Add(this.minimumLabel);
         this.averageGroupBox.Controls.Add(this.averageButton);
         this.averageGroupBox.Location = new System.Drawing.Point(43, 412);
         this.averageGroupBox.Name = "averageGroupBox";
         this.averageGroupBox.Size = new System.Drawing.Size(375, 57);
         this.averageGroupBox.TabIndex = 16;
         this.averageGroupBox.TabStop = false;
         this.averageGroupBox.Text = "Find players by batting average";
         // 
         // maximumTextBox
         // 
         this.maximumTextBox.Location = new System.Drawing.Point(208, 22);
         this.maximumTextBox.Name = "maximumTextBox";
         this.maximumTextBox.Size = new System.Drawing.Size(78, 20);
         this.maximumTextBox.TabIndex = 3;
         this.maximumTextBox.Text = "1.000";
         // 
         // maximumLabel
         // 
         this.maximumLabel.AutoSize = true;
         this.maximumLabel.Location = new System.Drawing.Point(148, 25);
         this.maximumLabel.Name = "maximumLabel";
         this.maximumLabel.Size = new System.Drawing.Size(54, 13);
         this.maximumLabel.TabIndex = 2;
         this.maximumLabel.Text = "Maximum:";
         // 
         // minimumTextBox
         // 
         this.minimumTextBox.Location = new System.Drawing.Point(63, 22);
         this.minimumTextBox.Name = "minimumTextBox";
         this.minimumTextBox.Size = new System.Drawing.Size(79, 20);
         this.minimumTextBox.TabIndex = 1;
         this.minimumTextBox.Text = "0.000";
         // 
         // minimumLabel
         // 
         this.minimumLabel.AutoSize = true;
         this.minimumLabel.Location = new System.Drawing.Point(6, 25);
         this.minimumLabel.Name = "minimumLabel";
         this.minimumLabel.Size = new System.Drawing.Size(51, 13);
         this.minimumLabel.TabIndex = 0;
         this.minimumLabel.Text = "Minimum:";
         // 
         // averageButton
         // 
         this.averageButton.Location = new System.Drawing.Point(292, 20);
         this.averageButton.Name = "averageButton";
         this.averageButton.Size = new System.Drawing.Size(75, 23);
         this.averageButton.TabIndex = 4;
         this.averageButton.Text = "Find";
         this.averageButton.UseVisualStyleBackColor = true;
         this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
         // 
         // BaseballPlayers
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(460, 483);
         this.Controls.Add(this.averageGroupBox);
         this.Controls.Add(this.browseAllButton);
         this.Controls.Add(this.findGroupBox);
         this.Controls.Add(this.playerDataGridView);
         this.Controls.Add(this.playerBindingNavigator);
         this.Name = "BaseballPlayers";
         this.Text = "Baseball Players";
         this.Load += new System.EventHandler(this.BaseballPlayers_Load);
         ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.playerBindingNavigator)).EndInit();
         this.playerBindingNavigator.ResumeLayout(false);
         this.playerBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).EndInit();
         this.findGroupBox.ResumeLayout(false);
         this.findGroupBox.PerformLayout();
         this.averageGroupBox.ResumeLayout(false);
         this.averageGroupBox.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.BindingSource playerBindingSource;
      private System.Windows.Forms.BindingNavigator playerBindingNavigator;
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
      private System.Windows.Forms.ToolStripButton playerBindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridView playerDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      internal System.Windows.Forms.Button browseAllButton;
      internal System.Windows.Forms.GroupBox findGroupBox;
      internal System.Windows.Forms.Button findButton;
      internal System.Windows.Forms.Label findLabel;
      internal System.Windows.Forms.TextBox findTextBox;
      internal System.Windows.Forms.GroupBox averageGroupBox;
      internal System.Windows.Forms.TextBox maximumTextBox;
      internal System.Windows.Forms.Label maximumLabel;
      internal System.Windows.Forms.TextBox minimumTextBox;
      internal System.Windows.Forms.Label minimumLabel;
      internal System.Windows.Forms.Button averageButton;
   }
}

