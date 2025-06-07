using GestionReseau;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_metro
{
    public partial class Accueil : Form
    {
        PrivateFontCollection fontCollection = new PrivateFontCollection();

        public Accueil(Point position)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;
            btnRetour.Text = Serveur.UtilisateurConnecte();

            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

            //Fermeture de la fenetre
            this.FormClosing += Ouverture_FormClosing;
        }

        private void Ouverture_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serveur.DeconnexionUtilisateurs();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Ouverture ouverture = Application.OpenForms[0] as Ouverture;

            if (ouverture != null)
            {
                if (btnRetour.Text.Contains("Se connecter"))
                {
                    Connexion connexion = new Connexion(this.Location);
                    connexion.Show();
                }
                else
                {
                    ouverture.lblDeconnexion.Visible = true;
                    ouverture.StartPosition = FormStartPosition.Manual;
                    ouverture.Location = this.Location;
                    Serveur.DeconnexionUtilisateurs();
                    ouverture.Show();
                }
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
            Carte carte = new Carte(this.Location);
            carte.Show();
            this.Close();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            Recherche consultation = new Recherche(this.Location);
            consultation.Show();
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Gestion gestion = new Gestion(this.Location);
            gestion.Show();
            this.Close();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];
            btnConsultation.Font = new Font(D, 14);
            btnRecherche.Font = new Font(D, 14);
            btnAdmin.Font = new Font(D, 14);
            lblTitre.Font = new Font(G, 24, FontStyle.Bold);
            lblTitre.Location = new Point((this.ClientSize.Width - lblTitre.Width) / 2, 150); // Centrer le titre horizontalement
            btnRetour.Font = new Font(D, 9);
        }
    }
}