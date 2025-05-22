using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_metro
{
    public partial class Gestion_modification : Form
    {
        public Gestion_modification(string mode, string ligne = null, string station = null, string horaire = null)
        {
            InitializeComponent();
            if (mode == "Ajout")
            {
                lblModif.Text = "Ajout d'une ligne";
                txtNomLigne.Visible = true;
                cmbLigne.Visible = false;
                txtNumero.Visible = true;
                dudNumLigne.Visible = false;
            }
            else
            {
                txtNomLigne.Visible = false;
                cmbLigne.Visible = true;
                txtNumero.Visible = false;
                dudNumLigne.Visible = true;
            }
        }

        private void gestion_modification_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Gestion gestion = new Gestion();
            gestion.Show();
            this.Close();
        }

        private void btnEnregistrement_Click(object sender, EventArgs e)
        {

        }

        private void lblCouleur_Click(object sender, EventArgs e)
        {

        }

        private void dudNumLigne_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void pnlGestionModification_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
