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
        // Collection de polices personnalisées
        PrivateFontCollection fontCollection = new PrivateFontCollection();

        /// <summary>
        /// Constructeur du formulaire.
        /// Initialise la fenêtre à une position et charge les polices d'écriture.
        /// </summary>
        /// <param name="position">Position de la fenêtre à l'écran</param>
        public Accueil(Point position)
        {
            InitializeComponent();

            // Position manuelle de la fenêtre
            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;

            // Ajoute les fichiers de polices personnalisées dans la collection
            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

            // Récupère le status de l'utilisateur (Se connecter ou Déconnexion) et s'il est admin
            (string texteBouton, int estConnecte) = Serveur.UtilisateurConnecte();

            // Affiche "Se connecter" ou "Déconnexion" selon le status de connexion
            btnRetour.Text = texteBouton;

            //Si l'utilisateur est un admin, affiche le bouton Gestion des données
            btnAdmin.Visible = estConnecte==1;

            // A la fermeture de la fenêtre, exécute la méthode FormClosing de Ouverture
            //this.FormClosing += Ouverture_FormClosing;
        }

        /// <summary>
        /// Méthode appelée quand la fenêtre se ferme.
        /// Déconnecte tous les utilisateurs du serveur - version allégée d'une déconnexion
        /// comme un compte est inutile dans cette version.
        /// </summary>
        //private void Ouverture_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Serveur.DeconnexionUtilisateurs();
        //}

        /// <summary>
        /// Événement déclenché au clic sur le bouton btnRetour.
        /// Selon l'état du bouton, affiche la fenêtre Connexion ou la fenêtre Ouverture.
        /// </summary>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            // Récupère la première fenêtre ouverte (Ouverture.cs)
            Ouverture ouverture = Application.OpenForms[0] as Ouverture;

            if (ouverture != null)
            {
                // Si le bouton contient "Se connecter", ouvre la fenêtre Connexion
                if (btnRetour.Text.Contains("Se connecter"))
                {
                    Connexion connexion = new Connexion(this.Location);
                    connexion.Show();
                }
                else
                {
                    //Affichage de la fenêtre Ouverture et du message de déconnexion
                    ouverture.trainError.ShowError("Vous avez été déconnecté");
                    ouverture.StartPosition = FormStartPosition.Manual;
                    ouverture.Location = this.Location;
                    Serveur.DeconnexionUtilisateurs(); //Déconnexion des utilisateurs
                    ouverture.Show();
                }
            }
            this.Close();
        }

        /// <summary>
        /// Ouvre la fenêtre Carte à la position actuelle et ferme Accueil.
        /// </summary>
        private void btnConsultation_Click(object sender, EventArgs e)
        {
            Carte carte = new Carte(this.Location);
            carte.Show();
            this.Close();
        }

        /// <summary>
        /// Ouvre la fenêtre Recherche à la position actuelle et ferme Accueil.
        /// </summary>
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            Recherche consultation = new Recherche(this.Location);
            consultation.Show();
            this.Close();
        }

        /// <summary>
        /// Ouvre la fenêtre Gestion (que pour les admins) à la position actuelle et ferme Accueil.
        /// </summary>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Gestion gestion = new Gestion(this.Location);
            gestion.Show();
            this.Close();
        }

        /// <summary>
        /// Événement déclenché au chargement du formulaire.
        /// Applique les polices personnalisées aux différents contrôles,
        /// et centre le titre horizontalement dans la fenêtre.
        /// </summary>
        private void Accueil_Load(object sender, EventArgs e)
        {
            // Récupération des polices ajoutées dans la collection de polices
            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];

            // Application des polices avec tailles différentes aux éléments concernés
            btnConsultation.Font = new Font(D, 14);
            btnRecherche.Font = new Font(D, 14);
            btnAdmin.Font = new Font(D, 14);
            lblTitre.Font = new Font(G, 24, FontStyle.Bold);
            btnRetour.Font = new Font(D, 9);

            // Centre horizontalement le label du titre dans la fenêtre
            lblTitre.Location = new Point((this.ClientSize.Width - lblTitre.Width) / 2, 150);
        }
    }
}
