namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.kalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paranormnaalneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munnigiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalaToolStripMenuItem,
            this.koerToolStripMenuItem,
            this.paranormnaalneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kalaToolStripMenuItem
            // 
            this.kalaToolStripMenuItem.Name = "kalaToolStripMenuItem";
            this.kalaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.kalaToolStripMenuItem.Text = "kala";
            // 
            // koerToolStripMenuItem
            // 
            this.koerToolStripMenuItem.Name = "koerToolStripMenuItem";
            this.koerToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.koerToolStripMenuItem.Text = "koer";
            // 
            // paranormnaalneToolStripMenuItem
            // 
            this.paranormnaalneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vajaToolStripMenuItem,
            this.poleToolStripMenuItem,
            this.munnigiToolStripMenuItem});
            this.paranormnaalneToolStripMenuItem.Name = "paranormnaalneToolStripMenuItem";
            this.paranormnaalneToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.paranormnaalneToolStripMenuItem.Text = "paranormnaalne";
            // 
            // vajaToolStripMenuItem
            // 
            this.vajaToolStripMenuItem.Name = "vajaToolStripMenuItem";
            this.vajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vajaToolStripMenuItem.Text = "vaja";
            this.vajaToolStripMenuItem.Click += new System.EventHandler(this.vajaToolStripMenuItem_Click);
            // 
            // poleToolStripMenuItem
            // 
            this.poleToolStripMenuItem.Name = "poleToolStripMenuItem";
            this.poleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poleToolStripMenuItem.Text = "pole";
            // 
            // munnigiToolStripMenuItem
            // 
            this.munnigiToolStripMenuItem.Name = "munnigiToolStripMenuItem";
            this.munnigiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.munnigiToolStripMenuItem.Text = "munnigi";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "DualTry";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paranormnaalneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munnigiToolStripMenuItem;
    }
}

