namespace SPS_Editor
{
    partial class SPSEditor
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
            this.pagesListBox = new System.Windows.Forms.ListBox();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageTextBox = new System.Windows.Forms.RichTextBox();
            this.contentGroupBox = new System.Windows.Forms.GroupBox();
            this.menubar.SuspendLayout();
            this.contentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagesListBox
            // 
            this.pagesListBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagesListBox.FormattingEnabled = true;
            this.pagesListBox.ItemHeight = 16;
            this.pagesListBox.Items.AddRange(new object[] {
            "Questions",
            "Responses",
            "Contacts"});
            this.pagesListBox.Location = new System.Drawing.Point(15, 27);
            this.pagesListBox.Name = "pagesListBox";
            this.pagesListBox.Size = new System.Drawing.Size(127, 308);
            this.pagesListBox.TabIndex = 1;
            this.pagesListBox.SelectedIndexChanged += new System.EventHandler(this.pageSelectionChanged);
            // 
            // menubar
            // 
            this.menubar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpMenuItem});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(668, 24);
            this.menubar.TabIndex = 2;
            this.menubar.Text = "menubar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.undoMenuItem.Size = new System.Drawing.Size(145, 22);
            this.undoMenuItem.Text = "Undo";
            this.undoMenuItem.Click += new System.EventHandler(this.undoClick);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoMenuItem,
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "Help";
            // 
            // infoMenuItem
            // 
            this.infoMenuItem.Name = "infoMenuItem";
            this.infoMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoMenuItem.Text = "Info";
            this.infoMenuItem.Click += new System.EventHandler(this.infoMenuClick);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItemClick);
            // 
            // pageTextBox
            // 
            this.pageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageTextBox.BulletIndent = 1;
            this.pageTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTextBox.Location = new System.Drawing.Point(163, 27);
            this.pageTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pageTextBox.Name = "pageTextBox";
            this.pageTextBox.Size = new System.Drawing.Size(462, 308);
            this.pageTextBox.TabIndex = 4;
            this.pageTextBox.Text = "";
            this.pageTextBox.WordWrap = false;
            this.pageTextBox.TextChanged += new System.EventHandler(this.pageTextBox_TextChanged);
            // 
            // contentGroupBox
            // 
            this.contentGroupBox.Controls.Add(this.pagesListBox);
            this.contentGroupBox.Controls.Add(this.pageTextBox);
            this.contentGroupBox.Location = new System.Drawing.Point(12, 27);
            this.contentGroupBox.Name = "contentGroupBox";
            this.contentGroupBox.Size = new System.Drawing.Size(642, 353);
            this.contentGroupBox.TabIndex = 6;
            this.contentGroupBox.TabStop = false;
            this.contentGroupBox.Text = "Content: ";
            // 
            // SPSEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 391);
            this.Controls.Add(this.contentGroupBox);
            this.Controls.Add(this.menubar);
            this.MainMenuStrip = this.menubar;
            this.MaximizeBox = false;
            this.Name = "SPSEditor";
            this.Text = "SPS-Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseProgram);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.contentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox pagesListBox;
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.RichTextBox pageTextBox;
        private System.Windows.Forms.GroupBox contentGroupBox;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
    }
}

