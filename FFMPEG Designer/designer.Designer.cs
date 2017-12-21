namespace FFMPEG_Designer
{
    partial class designer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(designer));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.filebar = new System.Windows.Forms.ToolStripMenuItem();
            this.editbar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filebar,
            this.editbar});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(494, 27);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "Menu Bar";
            // 
            // filebar
            // 
            this.filebar.Name = "filebar";
            this.filebar.Size = new System.Drawing.Size(43, 23);
            this.filebar.Text = "File";
            // 
            // editbar
            // 
            this.editbar.Name = "editbar";
            this.editbar.Size = new System.Drawing.Size(45, 23);
            this.editbar.Text = "Edit";
            // 
            // designer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 399);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "designer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFMPEG Designer";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem filebar;
        private System.Windows.Forms.ToolStripMenuItem editbar;
    }
}

