namespace LineIntersect
{
    partial class Form1
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
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojTocaka0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojLinija0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojKrizanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vrijemeIzracunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.menuStrip1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(586, 446);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.brojTocaka0ToolStripMenuItem,
            this.brojLinija0ToolStripMenuItem,
            this.brojKrizanjaToolStripMenuItem,
            this.vrijemeIzracunaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // brojTocaka0ToolStripMenuItem
            // 
            this.brojTocaka0ToolStripMenuItem.Name = "brojTocaka0ToolStripMenuItem";
            this.brojTocaka0ToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.brojTocaka0ToolStripMenuItem.Text = "Broj Tocaka: 0";
            // 
            // brojLinija0ToolStripMenuItem
            // 
            this.brojLinija0ToolStripMenuItem.Name = "brojLinija0ToolStripMenuItem";
            this.brojLinija0ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.brojLinija0ToolStripMenuItem.Text = "Broj Linija: 0";
            // 
            // brojKrizanjaToolStripMenuItem
            // 
            this.brojKrizanjaToolStripMenuItem.Name = "brojKrizanjaToolStripMenuItem";
            this.brojKrizanjaToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.brojKrizanjaToolStripMenuItem.Text = "Broj krizanja:  0";
            // 
            // vrijemeIzracunaToolStripMenuItem
            // 
            this.vrijemeIzracunaToolStripMenuItem.Name = "vrijemeIzracunaToolStripMenuItem";
            this.vrijemeIzracunaToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.vrijemeIzracunaToolStripMenuItem.Text = "Vrijeme izracuna:  0 ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 446);
            this.Controls.Add(this.panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Line Intersect Calculator";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojTocaka0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojLinija0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vrijemeIzracunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojKrizanjaToolStripMenuItem;

    }
}

