using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionReseau;

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
                nudNumLigne.Visible = false;
            }
            else
            {
                txtNomLigne.Visible = false;
                cmbLigne.Visible = true;
                txtNumero.Visible = false;
                nudNumLigne.Visible = true;

                cmbLigne.Items.Add(ligne);
                cmbLigne.SelectedItem = ligne;

                ListeLignes lignes = Serveur.Lignes();
                foreach (Ligne ligne1 in lignes.lignes) { 
                    if(ligne1.nom == ligne)
                    {
                        nudNumLigne.Value = Convert.ToDecimal(ligne1.num);
                        txtCouleur.Text = ligne1.couleur;
                    }
                }
            }
        }

        private int nbStations(List<string> stations)
        {
            int nbStations = 0;
            foreach (string station in stations)
            {
                nbStations++;
            }
            return nbStations;
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
