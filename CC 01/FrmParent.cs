using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_01
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        private void eTUDIANTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEtudiant form1 = new FrmEtudiant();
            form1.MdiParent = this;
            form1.Show();


        }

        private void eCOLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEcole f = new FrmEcole();
            f.MdiParent = this;
            f.Show();
        }
    }
}
