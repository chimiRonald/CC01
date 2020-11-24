using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_01
{
    public partial class FrmEtudiant : Form
    {
        
        private EcoleBLO ecoleBLO;
        private EtudiantBLO etudiantBLO;
        private Action callBack;
        private Etudiant oldEtudiant;
        public FrmEtudiant()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        public FrmEtudiant(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        private void loadData()
        {
            string value = txtRecherche.Text.ToLower();
            var etudiants = etudiantBLO.GetBy
            (
                x =>
                x.Matricule.ToLower().Contains(value) ||
                x.NomEtudiant.ToLower().Contains(value)
            ).OrderBy(x => x.Matricule).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = etudiants;
           // lblRowCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();
        }
         

        private void FrmEtudiant_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnCree_Click(object sender, EventArgs e)
        {
            Form f = new FrmEtudiant(loadData);
            f.Show();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnRaffraichir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecherche.Text))
                loadData();
            else
                txtRecherche.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FrmEtudiant
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Etudiant,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this product(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        etudiantBLO.DeleteEtudiant(dataGridView1.SelectedRows[i].DataBoundItem as Etudiant);
                    }
                    loadData();
                }
            }
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {

            List<EtudiantList> items = new List<EtudiantList>();
           Ecole ecole = ecoleBLO.GetEcole();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Etudiant e = dataGridView1.Rows[i].DataBoundItem as Etudiant;
                items.Add
                (
                   new EtudiantList
                   (
                       e.Matricule,
                       e.NomEtudiant,
                       e.Prenom,
                       e.PhotoEtudiant,
                       ecole?.Nom,
                       ecole?.Addresse,
                       ecole?.Section,
                       !string.IsNullOrEmpty(ecole?.Picture) ? File.ReadAllBytes(ecole?.Picture) : null
                    )
                ) ;
            }
            Form f = new FrmPreview("ProductListRpt.rdlc", items);
            f.Show();
        }
    }
}
