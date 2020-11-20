namespace frmParent
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creerUneCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatDuneCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerUneCarteToolStripMenuItem,
            this.etatDuneCarteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creerUneCarteToolStripMenuItem
            // 
            this.creerUneCarteToolStripMenuItem.Name = "creerUneCarteToolStripMenuItem";
            this.creerUneCarteToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.creerUneCarteToolStripMenuItem.Text = "creer une carte";
            this.creerUneCarteToolStripMenuItem.Click += new System.EventHandler(this.creerUneCarteToolStripMenuItem_Click);
            // 
            // etatDuneCarteToolStripMenuItem
            // 
            this.etatDuneCarteToolStripMenuItem.Name = "etatDuneCarteToolStripMenuItem";
            this.etatDuneCarteToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.etatDuneCarteToolStripMenuItem.Text = "etat d\'une carte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creerUneCarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etatDuneCarteToolStripMenuItem;
    }
}

