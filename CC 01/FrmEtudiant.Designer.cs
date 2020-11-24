namespace CC_01
{
    partial class FrmEtudiant
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnCree = new System.Windows.Forms.Button();
            this.dtpDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRaffraichir = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM  :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(393, 116);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(167, 20);
            this.txtNom.TabIndex = 1;
            // 
            // btnCree
            // 
            this.btnCree.Location = new System.Drawing.Point(619, 80);
            this.btnCree.Name = "btnCree";
            this.btnCree.Size = new System.Drawing.Size(88, 56);
            this.btnCree.TabIndex = 2;
            this.btnCree.Text = "CREE";
            this.btnCree.UseVisualStyleBackColor = true;
            this.btnCree.Click += new System.EventHandler(this.btnCree_Click);
            // 
            // dtpDateNaiss
            // 
            this.dtpDateNaiss.Location = new System.Drawing.Point(389, 244);
            this.dtpDateNaiss.Name = "dtpDateNaiss";
            this.dtpDateNaiss.Size = new System.Drawing.Size(169, 20);
            this.dtpDateNaiss.TabIndex = 3;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(391, 159);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(167, 20);
            this.txtPrenom.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PRENOM  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DATE DE NAISSANCE :";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(94, 354);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(464, 20);
            this.txtRecherche.TabIndex = 9;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "RECHERCHE :";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(391, 286);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(167, 20);
            this.txtNumber.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TELEPHONE  :";
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(391, 201);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(167, 20);
            this.txtClasse.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CLASSE  :";
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(619, 165);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(88, 56);
            this.btnSupp.TabIndex = 14;
            this.btnSupp.Text = "SUPPRIMER";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(619, 250);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(88, 56);
            this.btnFermer.TabIndex = 15;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 160);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "PHOTO ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(166, 113);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(14, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(470, 41);
            this.label8.TabIndex = 20;
            this.label8.Text = "FORMULAIRE D\'INSCRPTION";
            // 
            // btnRaffraichir
            // 
            this.btnRaffraichir.Location = new System.Drawing.Point(619, 318);
            this.btnRaffraichir.Name = "btnRaffraichir";
            this.btnRaffraichir.Size = new System.Drawing.Size(88, 56);
            this.btnRaffraichir.TabIndex = 21;
            this.btnRaffraichir.Text = "Raffraichir";
            this.btnRaffraichir.UseVisualStyleBackColor = true;
            this.btnRaffraichir.Click += new System.EventHandler(this.btnRaffraichir_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(631, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Editer";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(710, 489);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(75, 23);
            this.btnImprimer.TabIndex = 23;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // FrmEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 542);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRaffraichir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateNaiss);
            this.Controls.Add(this.btnCree);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Name = "FrmEtudiant";
            this.Text = "FrmEtudiant";
            this.Load += new System.EventHandler(this.FrmEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnCree;
        private System.Windows.Forms.DateTimePicker dtpDateNaiss;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRaffraichir;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnImprimer;
    }
}