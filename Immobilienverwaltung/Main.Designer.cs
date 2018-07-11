namespace Immobilienverwaltung
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwalterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liegenschaftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wohungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mieterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verwalterToolStripMenuItem,
            this.liegenschaftToolStripMenuItem,
            this.hausToolStripMenuItem,
            this.wohungToolStripMenuItem,
            this.mieterToolStripMenuItem});
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // verwalterToolStripMenuItem
            // 
            this.verwalterToolStripMenuItem.Name = "verwalterToolStripMenuItem";
            this.verwalterToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.verwalterToolStripMenuItem.Text = "Verwalter";
            // 
            // liegenschaftToolStripMenuItem
            // 
            this.liegenschaftToolStripMenuItem.Name = "liegenschaftToolStripMenuItem";
            this.liegenschaftToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.liegenschaftToolStripMenuItem.Text = "Liegenschaft";
            // 
            // hausToolStripMenuItem
            // 
            this.hausToolStripMenuItem.Name = "hausToolStripMenuItem";
            this.hausToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.hausToolStripMenuItem.Text = "Haus";
            // 
            // wohungToolStripMenuItem
            // 
            this.wohungToolStripMenuItem.Name = "wohungToolStripMenuItem";
            this.wohungToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.wohungToolStripMenuItem.Text = "Wohung";
            // 
            // mieterToolStripMenuItem
            // 
            this.mieterToolStripMenuItem.Name = "mieterToolStripMenuItem";
            this.mieterToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.mieterToolStripMenuItem.Text = "Mieter";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Immobilienverwaltung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verwalterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liegenschaftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hausToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wohungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mieterToolStripMenuItem;
    }
}

