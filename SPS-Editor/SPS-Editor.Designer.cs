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
            this.pagesGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.underlineButton = new System.Windows.Forms.Button();
            this.italicsButton = new System.Windows.Forms.Button();
            this.boldButton = new System.Windows.Forms.Button();
            this.pageTextBox = new System.Windows.Forms.RichTextBox();
            this.contentGroupBox = new System.Windows.Forms.GroupBox();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menubar.SuspendLayout();
            this.pagesGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagesListBox
            // 
            this.pagesListBox.FormattingEnabled = true;
            this.pagesListBox.Location = new System.Drawing.Point(15, 27);
            this.pagesListBox.Name = "pagesListBox";
            this.pagesListBox.Size = new System.Drawing.Size(127, 394);
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
            this.menubar.Size = new System.Drawing.Size(656, 24);
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
            this.saveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.ToolTipText = "Save all modified data.";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuClick);
            // 
            // pagesGroupBox
            // 
            this.pagesGroupBox.Controls.Add(this.pagesListBox);
            this.pagesGroupBox.Location = new System.Drawing.Point(12, 30);
            this.pagesGroupBox.Name = "pagesGroupBox";
            this.pagesGroupBox.Size = new System.Drawing.Size(158, 439);
            this.pagesGroupBox.TabIndex = 3;
            this.pagesGroupBox.TabStop = false;
            this.pagesGroupBox.Text = "Pages:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.underlineButton);
            this.groupBox1.Controls.Add(this.italicsButton);
            this.groupBox1.Controls.Add(this.boldButton);
            this.groupBox1.Location = new System.Drawing.Point(85, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // underlineButton
            // 
            this.underlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineButton.Location = new System.Drawing.Point(191, 19);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(75, 35);
            this.underlineButton.TabIndex = 2;
            this.underlineButton.Text = "Underline";
            this.underlineButton.UseVisualStyleBackColor = true;
            this.underlineButton.Click += new System.EventHandler(this.underlineButtonClick);
            // 
            // italicsButton
            // 
            this.italicsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicsButton.Location = new System.Drawing.Point(108, 19);
            this.italicsButton.Name = "italicsButton";
            this.italicsButton.Size = new System.Drawing.Size(65, 35);
            this.italicsButton.TabIndex = 1;
            this.italicsButton.Text = "Italics";
            this.italicsButton.UseVisualStyleBackColor = true;
            this.italicsButton.Click += new System.EventHandler(this.italicsButtonClick);
            // 
            // boldButton
            // 
            this.boldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldButton.Location = new System.Drawing.Point(23, 19);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(63, 35);
            this.boldButton.TabIndex = 0;
            this.boldButton.Text = "Bold";
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButtonClick);
            // 
            // pageTextBox
            // 
            this.pageTextBox.Location = new System.Drawing.Point(16, 113);
            this.pageTextBox.Name = "pageTextBox";
            this.pageTextBox.Size = new System.Drawing.Size(415, 308);
            this.pageTextBox.TabIndex = 4;
            this.pageTextBox.Text = "";
            this.pageTextBox.Enter += new System.EventHandler(this.pageTextBoxEnter);
            // 
            // contentGroupBox
            // 
            this.contentGroupBox.Controls.Add(this.groupBox1);
            this.contentGroupBox.Controls.Add(this.pageTextBox);
            this.contentGroupBox.Location = new System.Drawing.Point(191, 30);
            this.contentGroupBox.Name = "contentGroupBox";
            this.contentGroupBox.Size = new System.Drawing.Size(448, 439);
            this.contentGroupBox.TabIndex = 6;
            this.contentGroupBox.TabStop = false;
            this.contentGroupBox.Text = "Content: ";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitItemClick);
            // 
            // SPSEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 483);
            this.Controls.Add(this.contentGroupBox);
            this.Controls.Add(this.pagesGroupBox);
            this.Controls.Add(this.menubar);
            this.MainMenuStrip = this.menubar;
            this.Name = "SPSEditor";
            this.Text = "SPS-Editor";
            this.Load += new System.EventHandler(this.LoadFormContent);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.pagesGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox pagesListBox;
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.GroupBox pagesGroupBox;
        private System.Windows.Forms.RichTextBox pageTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button italicsButton;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button underlineButton;
        private System.Windows.Forms.GroupBox contentGroupBox;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    }
}

