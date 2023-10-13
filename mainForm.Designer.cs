namespace SPTLauncher_ConfigEditor
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.configItems = new System.Windows.Forms.ListBox();
            this.btnBrowse = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Label();
            this.bApplyNewFiles = new System.Windows.Forms.Label();
            this.placeholder = new System.Windows.Forms.Label();
            this.titleDragandDrop = new System.Windows.Forms.Label();
            this.separator1 = new System.Windows.Forms.Panel();
            this.bCloseLauncher = new System.Windows.Forms.Label();
            this.boolDeveloperMode = new System.Windows.Forms.Label();
            this.titleDeveloperMode = new System.Windows.Forms.Label();
            this.itemDetector = new System.Windows.Forms.Timer(this.components);
            this.bClearAll = new System.Windows.Forms.Label();
            this.bRemoveSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // configItems
            // 
            this.configItems.AllowDrop = true;
            this.configItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.configItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configItems.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.configItems.ForeColor = System.Drawing.Color.LightGray;
            this.configItems.FormattingEnabled = true;
            this.configItems.ItemHeight = 23;
            this.configItems.Location = new System.Drawing.Point(12, 61);
            this.configItems.Name = "configItems";
            this.configItems.Size = new System.Drawing.Size(311, 253);
            this.configItems.TabIndex = 0;
            this.configItems.DragDrop += new System.Windows.Forms.DragEventHandler(this.configItems_DragDrop);
            this.configItems.DragEnter += new System.Windows.Forms.DragEventHandler(this.configItems_DragEnter);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnBrowse.Location = new System.Drawing.Point(348, 15);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.btnBrowse.Size = new System.Drawing.Size(308, 40);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse for config files";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            this.btnBrowse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBrowse_MouseDown);
            this.btnBrowse.MouseEnter += new System.EventHandler(this.btnBrowse_MouseEnter);
            this.btnBrowse.MouseLeave += new System.EventHandler(this.btnBrowse_MouseLeave);
            // 
            // bExit
            // 
            this.bExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.bExit.ForeColor = System.Drawing.Color.IndianRed;
            this.bExit.Location = new System.Drawing.Point(348, 322);
            this.bExit.Name = "bExit";
            this.bExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.bExit.Size = new System.Drawing.Size(308, 40);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Exit";
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bExit_MouseDown);
            this.bExit.MouseEnter += new System.EventHandler(this.bExit_MouseEnter);
            this.bExit.MouseLeave += new System.EventHandler(this.bExit_MouseLeave);
            // 
            // bApplyNewFiles
            // 
            this.bApplyNewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bApplyNewFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bApplyNewFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bApplyNewFiles.Enabled = false;
            this.bApplyNewFiles.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.bApplyNewFiles.Location = new System.Drawing.Point(348, 64);
            this.bApplyNewFiles.Name = "bApplyNewFiles";
            this.bApplyNewFiles.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.bApplyNewFiles.Size = new System.Drawing.Size(308, 40);
            this.bApplyNewFiles.TabIndex = 3;
            this.bApplyNewFiles.Text = "Apply new files";
            this.bApplyNewFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bApplyNewFiles.Click += new System.EventHandler(this.bApplyNewFiles_Click);
            this.bApplyNewFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bApplyNewFiles_MouseDown);
            this.bApplyNewFiles.MouseEnter += new System.EventHandler(this.bApplyNewFiles_MouseEnter);
            this.bApplyNewFiles.MouseLeave += new System.EventHandler(this.bApplyNewFiles_MouseLeave);
            // 
            // placeholder
            // 
            this.placeholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.placeholder.AutoSize = true;
            this.placeholder.Font = new System.Drawing.Font("Bahnschrift Light", 6F);
            this.placeholder.Location = new System.Drawing.Point(12, 357);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(44, 10);
            this.placeholder.TabIndex = 4;
            this.placeholder.Text = "placeholder";
            this.placeholder.Visible = false;
            // 
            // titleDragandDrop
            // 
            this.titleDragandDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleDragandDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.titleDragandDrop.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.titleDragandDrop.Location = new System.Drawing.Point(14, 15);
            this.titleDragandDrop.Name = "titleDragandDrop";
            this.titleDragandDrop.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.titleDragandDrop.Size = new System.Drawing.Size(309, 40);
            this.titleDragandDrop.TabIndex = 5;
            this.titleDragandDrop.Text = "Drag and drop files below";
            this.titleDragandDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separator1
            // 
            this.separator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.separator1.Location = new System.Drawing.Point(335, 15);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(1, 347);
            this.separator1.TabIndex = 6;
            // 
            // bCloseLauncher
            // 
            this.bCloseLauncher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCloseLauncher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bCloseLauncher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCloseLauncher.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.bCloseLauncher.ForeColor = System.Drawing.Color.IndianRed;
            this.bCloseLauncher.Location = new System.Drawing.Point(348, 273);
            this.bCloseLauncher.Name = "bCloseLauncher";
            this.bCloseLauncher.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.bCloseLauncher.Size = new System.Drawing.Size(308, 40);
            this.bCloseLauncher.TabIndex = 7;
            this.bCloseLauncher.Text = "Close SPT Launcher";
            this.bCloseLauncher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCloseLauncher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bCloseLauncher_MouseDown);
            this.bCloseLauncher.MouseEnter += new System.EventHandler(this.bCloseLauncher_MouseEnter);
            this.bCloseLauncher.MouseLeave += new System.EventHandler(this.bCloseLauncher_MouseLeave);
            // 
            // boolDeveloperMode
            // 
            this.boolDeveloperMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boolDeveloperMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.boolDeveloperMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boolDeveloperMode.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.boolDeveloperMode.Location = new System.Drawing.Point(556, 113);
            this.boolDeveloperMode.Name = "boolDeveloperMode";
            this.boolDeveloperMode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.boolDeveloperMode.Size = new System.Drawing.Size(100, 40);
            this.boolDeveloperMode.TabIndex = 9;
            this.boolDeveloperMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boolDeveloperMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boolDeveloperMode_MouseDown);
            this.boolDeveloperMode.MouseEnter += new System.EventHandler(this.boolDeveloperMode_MouseEnter);
            this.boolDeveloperMode.MouseLeave += new System.EventHandler(this.boolDeveloperMode_MouseLeave);
            // 
            // titleDeveloperMode
            // 
            this.titleDeveloperMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleDeveloperMode.BackColor = System.Drawing.Color.Transparent;
            this.titleDeveloperMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleDeveloperMode.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.titleDeveloperMode.Location = new System.Drawing.Point(342, 113);
            this.titleDeveloperMode.Name = "titleDeveloperMode";
            this.titleDeveloperMode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.titleDeveloperMode.Size = new System.Drawing.Size(208, 40);
            this.titleDeveloperMode.TabIndex = 10;
            this.titleDeveloperMode.Text = "DEVELOPER MODE";
            this.titleDeveloperMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemDetector
            // 
            this.itemDetector.Interval = 300;
            this.itemDetector.Tick += new System.EventHandler(this.itemDetector_Tick);
            // 
            // bClearAll
            // 
            this.bClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bClearAll.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.bClearAll.Location = new System.Drawing.Point(14, 322);
            this.bClearAll.Name = "bClearAll";
            this.bClearAll.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.bClearAll.Size = new System.Drawing.Size(150, 40);
            this.bClearAll.TabIndex = 11;
            this.bClearAll.Text = "Clear all";
            this.bClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bClearAll.Click += new System.EventHandler(this.bClearAll_Click);
            this.bClearAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bClearAll_MouseDown);
            this.bClearAll.MouseEnter += new System.EventHandler(this.bClearAll_MouseEnter);
            this.bClearAll.MouseLeave += new System.EventHandler(this.bClearAll_MouseLeave);
            // 
            // bRemoveSelected
            // 
            this.bRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bRemoveSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRemoveSelected.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.bRemoveSelected.Location = new System.Drawing.Point(173, 322);
            this.bRemoveSelected.Name = "bRemoveSelected";
            this.bRemoveSelected.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.bRemoveSelected.Size = new System.Drawing.Size(150, 40);
            this.bRemoveSelected.TabIndex = 12;
            this.bRemoveSelected.Text = "Remove selected";
            this.bRemoveSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bRemoveSelected.Click += new System.EventHandler(this.bRemoveSelected_Click);
            this.bRemoveSelected.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bRemoveSelected_MouseDown);
            this.bRemoveSelected.MouseEnter += new System.EventHandler(this.bRemoveSelected_MouseEnter);
            this.bRemoveSelected.MouseLeave += new System.EventHandler(this.bRemoveSelected_MouseLeave);
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(668, 376);
            this.Controls.Add(this.bRemoveSelected);
            this.Controls.Add(this.bClearAll);
            this.Controls.Add(this.titleDeveloperMode);
            this.Controls.Add(this.boolDeveloperMode);
            this.Controls.Add(this.bCloseLauncher);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.titleDragandDrop);
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.bApplyNewFiles);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.configItems);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse configs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox configItems;
        private System.Windows.Forms.Label btnBrowse;
        private System.Windows.Forms.Label bExit;
        private System.Windows.Forms.Label bApplyNewFiles;
        private System.Windows.Forms.Label placeholder;
        private System.Windows.Forms.Label titleDragandDrop;
        private System.Windows.Forms.Panel separator1;
        private System.Windows.Forms.Label bCloseLauncher;
        private System.Windows.Forms.Label boolDeveloperMode;
        private System.Windows.Forms.Label titleDeveloperMode;
        private System.Windows.Forms.Timer itemDetector;
        private System.Windows.Forms.Label bClearAll;
        private System.Windows.Forms.Label bRemoveSelected;
    }
}

