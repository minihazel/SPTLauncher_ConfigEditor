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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.configItems = new System.Windows.Forms.ListBox();
            this.btnBrowse = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Label();
            this.bApplyNewFiles = new System.Windows.Forms.Label();
            this.placeholder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCloseLauncher = new System.Windows.Forms.Label();
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
            this.configItems.Location = new System.Drawing.Point(12, 15);
            this.configItems.Name = "configItems";
            this.configItems.Size = new System.Drawing.Size(317, 345);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label1.Location = new System.Drawing.Point(348, 273);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "< < <   Drag and drop files";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(335, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 347);
            this.panel1.TabIndex = 6;
            // 
            // bCloseLauncher
            // 
            this.bCloseLauncher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCloseLauncher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bCloseLauncher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCloseLauncher.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.bCloseLauncher.ForeColor = System.Drawing.Color.IndianRed;
            this.bCloseLauncher.Location = new System.Drawing.Point(348, 113);
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
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(668, 376);
            this.Controls.Add(this.bCloseLauncher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.bApplyNewFiles);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.configItems);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse configs";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bCloseLauncher;
    }
}

