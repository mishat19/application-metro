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
    public partial class Accueil : Form
    {
        private Ouverture _ouverture;
        public Accueil()
        {
            InitializeComponent();
        }

        public Accueil(Ouverture ouverture) : this()
        {
            _ouverture = ouverture;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (_ouverture != null)
            {
                if (btnRetour.Text.Contains("Se connecter"))
                {
                    Connexion connexion = new Connexion(_ouverture);
                    connexion.Show();
                }
                else
                {
                    _ouverture.Show();
                    _ouverture.lblDeconnexion.Visible = true;
                };
            }
            this.Close();
        }

        public void UpdateBtnRetourText(string newText)
        {
            if (btnRetour != null)
            {
                btnRetour.Text = newText;
            }
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            Carte carte = new Carte();
            carte.Show();
            this.Close();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            Recherche consultation = new Recherche();
            consultation.Show();
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Gestion gestion = new Gestion();
            gestion.Show();
            this.Close();
        }
    }
}