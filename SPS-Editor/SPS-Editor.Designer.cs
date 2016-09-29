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
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.fileToolStripMenuItem});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(529, 24);
            this.menubar.TabIndex = 2;
            this.menubar.Text = "menubar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveMenuItem.Text = "Save All";
            this.saveMenuItem.ToolTipText = "Save all modified data.";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuClick);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitItemClick);
            // 
            // pageTextBox
            // 
            this.pageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageTextBox.BulletIndent = 1;
            this.pageTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTextBox.Location = new System.Drawing.Point(157, 27);
            this.pageTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pageTextBox.Name = "pageTextBox";
            this.pageTextBox.Size = new System.Drawing.Size(330, 308);
            this.pageTextBox.TabIndex = 4;
            this.pageTextBox.Text = "";
            this.pageTextBox.TextChanged += new System.EventHandler(this.pageTextBox_TextChanged);
            this.pageTextBox.Enter += new System.EventHandler(this.pageTextBoxEnter);
            // 
            // contentGroupBox
            // 
            this.contentGroupBox.Controls.Add(this.pagesListBox);
            this.contentGroupBox.Controls.Add(this.pageTextBox);
            this.contentGroupBox.Location = new System.Drawing.Point(12, 27);
            this.contentGroupBox.Name = "contentGroupBox";
            this.contentGroupBox.Size = new System.Drawing.Size(501, 353);
            this.contentGroupBox.TabIndex = 6;
            this.contentGroupBox.TabStop = false;
            this.contentGroupBox.Text = "Content: ";
            // 
            // SPSEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 391);
            this.Controls.Add(this.contentGroupBox);
            this.Controls.Add(this.menubar);
            this.MainMenuStrip = this.menubar;
            this.MaximizeBox = false;
            this.Name = "SPSEditor";
            this.Text = "SPS-Editor";
            this.Load += new System.EventHandler(this.LoadFormContent);
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
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.RichTextBox pageTextBox;
        private System.Windows.Forms.GroupBox contentGroupBox;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    }
}

