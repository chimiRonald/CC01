using System;
using CC01.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CC01.BO;
using System.Configuration;

namespace CC_01
{
    public partial class FrmEcole : Form
    {
        private EcoleBLO ecoleBLO;
        private Ecole oldEcole;
        public FrmEcole()
        {
            InitializeComponent();
            ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
            oldEcole = ecoleBLO.GetEcole();
            if (oldEcole != null)
            {
                txtNomEtablissement.Text = oldEcole.Nom;
                txtAddresse.Text = oldEcole.Addresse;
                cbSection.Text = oldEcole.Section;
                pictureBox1.ImageLocation = oldEcole.Picture;
            }
        }

        private void FrmEcole_Load(object sender, EventArgs e)
        {

        }
        private void checkForm()
        {
            string text = string.Empty;
            txtAddresse.BackColor = Color.White;
            txtNomEtablissement.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtAddresse.Text))
            {
                text += "- Please enter a good Address ! \n";
                txtNomEtablissement.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtNomEtablissement.Text))
            {
                text += "- Please enter the name ! \n";
                txtAddresse.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                checkForm();

                Ecole newEcole = new Ecole
                (
                    txtNomEtablissement.Text.ToUpper(),
                    txtAddresse.Text,
                    cbSection.Text,
                    pictureBox1.ImageLocation
                );

                ecoleBLO.CreateEcole(oldEcole, newEcole);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Close();

            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }
    }
}
