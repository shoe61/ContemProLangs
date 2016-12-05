namespace Shoe_Program_7C
{
    partial class MedicalSupplies
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.AboutMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(539, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuNew,
            this.fileMenuOpen,
            this.fileMenuClose,
            this.fileMenuSave,
            this.fileMenuExit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // fileMenuNew
            // 
            this.fileMenuNew.Name = "fileMenuNew";
            this.fileMenuNew.Size = new System.Drawing.Size(152, 22);
            this.fileMenuNew.Text = "New";
            this.fileMenuNew.Click += new System.EventHandler(this.fileMenuNew_Click);
            // 
            // fileMenuOpen
            // 
            this.fileMenuOpen.Name = "fileMenuOpen";
            this.fileMenuOpen.Size = new System.Drawing.Size(152, 22);
            this.fileMenuOpen.Text = "Open";
            this.fileMenuOpen.Click += new System.EventHandler(this.fileMenuOpen_Click);
            // 
            // fileMenuClose
            // 
            this.fileMenuClose.Name = "fileMenuClose";
            this.fileMenuClose.Size = new System.Drawing.Size(152, 22);
            this.fileMenuClose.Text = "Close";
            this.fileMenuClose.Click += new System.EventHandler(this.fileMenuClose_Click);
            // 
            // fileMenuSave
            // 
            this.fileMenuSave.Name = "fileMenuSave";
            this.fileMenuSave.Size = new System.Drawing.Size(152, 22);
            this.fileMenuSave.Text = "Save";
            this.fileMenuSave.Click += new System.EventHandler(this.fileMenuSave_Click);
            // 
            // fileMenuExit
            // 
            this.fileMenuExit.Name = "fileMenuExit";
            this.fileMenuExit.Size = new System.Drawing.Size(152, 22);
            this.fileMenuExit.Text = "Exit";
            this.fileMenuExit.Click += new System.EventHandler(this.fileMenuExit_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuInsert,
            this.editMenuUpdate,
            this.editMenuDelete});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // editMenuInsert
            // 
            this.editMenuInsert.Name = "editMenuInsert";
            this.editMenuInsert.Size = new System.Drawing.Size(112, 22);
            this.editMenuInsert.Text = "Insert";
            this.editMenuInsert.Click += new System.EventHandler(this.editMenuInsert_Click);
            // 
            // editMenuUpdate
            // 
            this.editMenuUpdate.Name = "editMenuUpdate";
            this.editMenuUpdate.Size = new System.Drawing.Size(112, 22);
            this.editMenuUpdate.Text = "Update";
            this.editMenuUpdate.Click += new System.EventHandler(this.editMenuUpdate_Click);
            // 
            // editMenuDelete
            // 
            this.editMenuDelete.Name = "editMenuDelete";
            this.editMenuDelete.Size = new System.Drawing.Size(112, 22);
            this.editMenuDelete.Text = "Delete";
            this.editMenuDelete.Click += new System.EventHandler(this.editMenuDelete_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(61, 20);
            this.AboutMenu.Text = "About...";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // MedicalSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 291);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.Name = "MedicalSupplies";
            this.Text = "Shoe\'s Hoof and Mouth Supplies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuNew;
        private System.Windows.Forms.ToolStripMenuItem fileMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem fileMenuClose;
        private System.Windows.Forms.ToolStripMenuItem fileMenuSave;
        private System.Windows.Forms.ToolStripMenuItem fileMenuExit;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenuInsert;
        private System.Windows.Forms.ToolStripMenuItem editMenuUpdate;
        private System.Windows.Forms.ToolStripMenuItem editMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
    }
}

