namespace CC_01
{
    partial class FrmParent
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
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eTUDIANTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eCOLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eTUDIANTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eCOLEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerToolStripMenuItem,
            this.rechercherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eTUDIANTToolStripMenuItem,
            this.eCOLEToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.créerToolStripMenuItem.Text = "Créer ";
            // 
            // eTUDIANTToolStripMenuItem
            // 
            this.eTUDIANTToolStripMenuItem.Name = "eTUDIANTToolStripMenuItem";
            this.eTUDIANTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eTUDIANTToolStripMenuItem.Text = "ETUDIANT";
            this.eTUDIANTToolStripMenuItem.Click += new System.EventHandler(this.eTUDIANTToolStripMenuItem_Click);
            // 
            // eCOLEToolStripMenuItem
            // 
            this.eCOLEToolStripMenuItem.Name = "eCOLEToolStripMenuItem";
            this.eCOLEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eCOLEToolStripMenuItem.Text = "ECOLE";
            this.eCOLEToolStripMenuItem.Click += new System.EventHandler(this.eCOLEToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fermerToolStripMenuItem.Text = "fermer";
       //     this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eTUDIANTToolStripMenuItem1,
            this.eCOLEToolStripMenuItem1});
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.rechercherToolStripMenuItem.Text = "Editer";
            // 
            // eTUDIANTToolStripMenuItem1
            // 
            this.eTUDIANTToolStripMenuItem1.Name = "eTUDIANTToolStripMenuItem1";
            this.eTUDIANTToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eTUDIANTToolStripMenuItem1.Text = "ETUDIANT";
         //   this.eTUDIANTToolStripMenuItem1.Click += new System.EventHandler(this.eTUDIANTToolStripMenuItem1_Click);
            // 
            // eCOLEToolStripMenuItem1
            // 
            this.eCOLEToolStripMenuItem1.Name = "eCOLEToolStripMenuItem1";
            this.eCOLEToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eCOLEToolStripMenuItem1.Text = "ECOLE";
           // this.eCOLEToolStripMenuItem1.Click += new System.EventHandler(this.eCOLEToolStripMenuItem1_Click);
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 552);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmParent";
            this.Text = "FrmParent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eTUDIANTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eCOLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eTUDIANTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eCOLEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
    }
}