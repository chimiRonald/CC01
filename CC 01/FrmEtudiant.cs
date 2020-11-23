using CC01.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_01
{
    public partial class FrmEtudiant : Form
    {
        private EtudiantBLO etudiantBLO;
        public FrmEtudiant()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        private void loadData()
        {
            string value = txtRecherche.Text.ToLower();
            var etudiants = etudiantBLO.GetBy
            (
                x =>
                x.Matricule.ToLower().Contains(value) ||
                x.Nom.ToLower().Contains(value)
            ).OrderBy(x => x.Matricule).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = etudiants;
           // lblRowCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();
        }

        private void FrmEtudiant_Load(object sender, EventArgs e)
        {

        }

        private void btnCree_Click(object sender, EventArgs e)
        {
            Form f = new FrmEtudiant(loadData);
            f.Show();
        }
    }
}
