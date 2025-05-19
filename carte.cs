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
    public partial class Carte : Form
    {
        public Carte()
        {
            InitializeComponent();
            ListeLignes lignes = Serveur.Lignes();
            foreach (Ligne ligne in lignes.lignes)
            {
                cmbLignes.Items.Add(ligne.nom);
            }
        }

        private void carte_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void cmbLignes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
