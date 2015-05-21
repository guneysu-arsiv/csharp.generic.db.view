namespace UI
{
    partial class MAIN
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDataGridToolStripMenuItem,
            this.viewListViewToolStripMenuItem});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.listToolStripMenuItem.Text = "List";
            // 
            // viewDataGridToolStripMenuItem
            // 
            this.viewDataGridToolStripMenuItem.Name = "viewDataGridToolStripMenuItem";
            this.viewDataGridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewDataGridToolStripMenuItem.Text = "View DataGrid";
            this.viewDataGridToolStripMenuItem.Click += new System.EventHandler(this.viewDataGridToolStripMenuItem_Click);
            // 
            // viewListViewToolStripMenuItem
            // 
            this.viewListViewToolStripMenuItem.Name = "viewListViewToolStripMenuItem";
            this.viewListViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewListViewToolStripMenuItem.Text = "View ListView";
            this.viewListViewToolStripMenuItem.Click += new System.EventHandler(this.viewListViewToolStripMenuItem_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 293);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MAIN";
            this.Text = "MAIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDataGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListViewToolStripMenuItem;
    }
}