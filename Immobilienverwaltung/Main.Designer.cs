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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVerwalter = new System.Windows.Forms.TabPage();
            this.tabLiegenschaft = new System.Windows.Forms.TabPage();
            this.tabHaus = new System.Windows.Forms.TabPage();
            this.tabWohnung = new System.Windows.Forms.TabPage();
            this.tabMieter = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwalterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liegenschaftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wohungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mieterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVerwalter);
            this.tabControl1.Controls.Add(this.tabLiegenschaft);
            this.tabControl1.Controls.Add(this.tabHaus);
            this.tabControl1.Controls.Add(this.tabWohnung);
            this.tabControl1.Controls.Add(this.tabMieter);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVerwalter
            // 
            this.tabVerwalter.Location = new System.Drawing.Point(4, 22);
            this.tabVerwalter.Name = "tabVerwalter";
            this.tabVerwalter.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerwalter.Size = new System.Drawing.Size(792, 400);
            this.tabVerwalter.TabIndex = 0;
            this.tabVerwalter.Text = "Verwalter";
            this.tabVerwalter.UseVisualStyleBackColor = true;
            this.tabVerwalter.Enter += new System.EventHandler(this.tabVerwalter_Enter);
            // 
            // tabLiegenschaft
            // 
            this.tabLiegenschaft.Location = new System.Drawing.Point(4, 22);
            this.tabLiegenschaft.Name = "tabLiegenschaft";
            this.tabLiegenschaft.Padding = new System.Windows.Forms.Padding(3);
            this.tabLiegenschaft.Size = new System.Drawing.Size(792, 400);
            this.tabLiegenschaft.TabIndex = 1;
            this.tabLiegenschaft.Text = "Liegenschaft";
            this.tabLiegenschaft.UseVisualStyleBackColor = true;
            this.tabLiegenschaft.Enter += new System.EventHandler(this.tabLiegenschaft_Enter);
            // 
            // tabHaus
            // 
            this.tabHaus.Location = new System.Drawing.Point(4, 22);
            this.tabHaus.Name = "tabHaus";
            this.tabHaus.Padding = new System.Windows.Forms.Padding(3);
            this.tabHaus.Size = new System.Drawing.Size(792, 400);
            this.tabHaus.TabIndex = 2;
            this.tabHaus.Text = "Haus";
            this.tabHaus.UseVisualStyleBackColor = true;
            this.tabHaus.Enter += new System.EventHandler(this.tabHaus_Enter);
            // 
            // tabWohnung
            // 
            this.tabWohnung.Location = new System.Drawing.Point(4, 22);
            this.tabWohnung.Name = "tabWohnung";
            this.tabWohnung.Padding = new System.Windows.Forms.Padding(3);
            this.tabWohnung.Size = new System.Drawing.Size(792, 400);
            this.tabWohnung.TabIndex = 3;
            this.tabWohnung.Text = "Wohnung";
            this.tabWohnung.UseVisualStyleBackColor = true;
            this.tabWohnung.Enter += new System.EventHandler(this.tabWohnung_Enter);
            // 
            // tabMieter
            // 
            this.tabMieter.Location = new System.Drawing.Point(4, 22);
            this.tabMieter.Name = "tabMieter";
            this.tabMieter.Padding = new System.Windows.Forms.Padding(3);
            this.tabMieter.Size = new System.Drawing.Size(792, 400);
            this.tabMieter.TabIndex = 4;
            this.tabMieter.Text = "Mieter";
            this.tabMieter.UseVisualStyleBackColor = true;
            this.tabMieter.Enter += new System.EventHandler(this.tabMieter_Enter);
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
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Immobilienverwaltung";
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVerwalter;
        private System.Windows.Forms.TabPage tabLiegenschaft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verwalterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liegenschaftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hausToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wohungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mieterToolStripMenuItem;
        private System.Windows.Forms.TabPage tabHaus;
        private System.Windows.Forms.TabPage tabWohnung;
        private System.Windows.Forms.TabPage tabMieter;
    }
}

