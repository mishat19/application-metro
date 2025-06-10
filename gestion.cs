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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace application_metro
{

    public partial class Gestion : Form
    {
        ListeLignes lignes = new ListeLignes();
        string nomLigne = "";
        string nomStation = "";
        string horaire = "";

        PrivateFontCollection fontCollection = new PrivateFontCollection();
        private TrainErrorManager trainError;
        public Gestion(Point position)
        {
            // Initialisation des composants de la fenêtre
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position; // Position en pixels à l’écran

            lignes = Serveur.Lignes();

            foreach (Ligne ligne in lignes.lignes)
            {
                cmbLigne.Items.Add(ligne.nom);
            }

            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

            trainError = new TrainErrorManager(picTrain2, lblErreur, endX : 15, trainTop: 460);
        }

        /// <summary>
        /// Chargement des poles et initialisation des polices de caractères pour les contrôles du formulaire.
        /// </summary>
        private void gestion_Load(object sender, EventArgs e)
        {
            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];
            lblAjout.Font = new Font(D, 11);
            lblSelection.Font = new Font(G, 11, FontStyle.Underline);
            lblGestion.Font = new Font(G, 11, FontStyle.Underline);
            cmbLigne.Font = new Font(D, 9);
            cmbStation.Font = new Font(D, 9);
            btnModif.Font = new Font(D, 14);
            btnSupp.Font = new Font(D, 14);
            lblTitre.Font = new Font(G, 16, FontStyle.Bold);
            lblTitre.Location = new Point((this.ClientSize.Width - lblTitre.Width) / 2, 115); // Centrer le titre horizontalement
            lblErreur.Font = new Font(D, 9, FontStyle.Italic);
        }

        // Bouton pour retourner a la page précédente
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            this.Close();
        }

        /// <summary>
        /// Bouton pour modifier une ligne/une station
        /// </summary>
        string mode;
        private void btnModif_Click(object sender, EventArgs e)
        {
            if (!(cmbLigne.SelectedIndex == -1))
            {
                mode = "Modification";
                Gestion_modification modif = new Gestion_modification(mode, this.Location, nomLigne, nomStation);
                modif.Show();
                this.Close();
            }
            else
            {
                trainError.ShowError("Veuillez saisir au moins une donnée");
            }
        }

        /// <summary>
        /// Bouton pour supprimer une ligne/une station
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (cmbLigne.SelectedItem == null && cmbStation.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
                return;
            }

            // Demande de confirmation avant la suppression
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer ces données ?\nCette action est irréversible.",
                "Confirmation de suppression",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            // Si l'utilisateur annule, on quitte la méthode
            if (result != DialogResult.OK)
                return;

            // Suppression d'une station d'une ligne
            if (cmbStation.SelectedItem != null && cmbLigne.SelectedItem != null)
            {
                // R2écupération des valeurs sélectionnées
                string station = cmbStation.SelectedItem.ToString();
                string ligne = cmbLigne.SelectedItem.ToString();

                // On supprime la station de la ligne
                Serveur.SupprimerUnSegment(station);
                Serveur.SupprimerUneStation(station);

                // On supprime les horaires associés à cette station
                MessageBox.Show("La station a été supprimée avec succès.");
                return;
            }

            // Suppression d'une ligne et de toutes ses stations
            if (cmbStation.SelectedItem == null && cmbLigne.SelectedItem != null)
            {
                string ligne = cmbLigne.SelectedItem.ToString();

                int idLigne = Serveur.idLigneGraceNom(ligne);

                // On supprime la ligne, les horaires, les informations de la ligne
                Serveur.SupprimerUneLigne(idLigne);
                Serveur.SupprimerUnHoraire(idLigne);
                Serveur.SupprimerUneInfoLigne(idLigne);

                // Affichage d'un message de succès
                MessageBox.Show("Les informations de la ligne ont bien été supprimé.");

                return;
            }
        }


        private void picPlus_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Lorsqu'on sélectionne une ligne, on active le choix des stations et on charge les stations correspondantes.
        /// </summary>
        private void cmbLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomLigne = cmbLigne.SelectedItem.ToString().Trim();
            cmbStation.Enabled = true;
            cmbStation.Items.Clear();
            NomsStation(nomLigne);
        }

        /// <summary>
        /// Charge les noms des stations pour la ligne sélectionnée dans le ComboBox.
        /// </summary>
        /// <param name="nomLigne">Nom de la ligne</param>
        public void NomsStation(string nomLigne)
        {
            foreach (Ligne ligne in lignes.lignes)
            {
                if (ligne.nom == nomLigne)
                {
                    // Ajoute les stataions de la ligne sélectionnée dans le ComboBox des stations
                    foreach (string nomStation in ligne.stations)
                    {
                        cmbStation.Items.Add(nomStation);
                    }
                }
            }
        }

        /// <summary>
        /// Récupère le nom de la station sélectionnée dans le ComboBox.
        /// </summary>
        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomStation = cmbStation.SelectedItem.ToString().Trim();
        }

        /// <summary>
        /// Retourne a la page précédente.
        /// </summary>
        private void picRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            this.Close();
        }

        /// <summary>
        /// Retourne au menu principal
        /// </summary>

        private void picHome_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            this.Close();
        }

        /// <summary>
        /// Bouton pour ajouter une ligne.
        /// </summary>

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Met la page en mode ajout
            mode = "Ajout";
            Gestion_modification gestion_Modification = new Gestion_modification(mode, this.Location);
            gestion_Modification.Show();
            this.Close();
        }

        private void pnlGestion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpAjout_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }
    }
}