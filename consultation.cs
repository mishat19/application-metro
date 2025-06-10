using GestionReseau;
using System.Drawing.Text;

namespace application_metro
{
    public partial class Consultation : Form
    {
        // Stockage du nom de la ligne sélectionnée dans la fenêtre précédente
        string _ligne;

        // Collection pour charger des polices personnalisées
        PrivateFontCollection fontCollection = new PrivateFontCollection();

        /// <summary>
        /// Constructeur du formulaire.
        /// Initialise la fenêtre avec une ligne sélectionnée et une position spécifique sur l’écran utilisateur.
        /// </summary>
        /// <param name="ligne">Nom de la ligne sélectionnée</param>
        /// <param name="position">Position pour la fenêtre</param>
        public Consultation(string ligne, Point position)
        {
            InitializeComponent();

            // Place la fenêtre à une position manuelle donnée
            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;

            // Stocke la ligne sélectionnée dans la fenêtre précédente et la met dans le ComboBox
            _ligne = ligne;
            cmbLignes.Text = _ligne;

            // Ajoute des fichiers de police personnalisée à la collection
            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

            // Définit le format du sélecteur de date et l'initialise à l'heure actuelle
            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.CustomFormat = "dd/MM/yyyy HH:mm"; // Format d'affichage (date et heure)
            DateTime dateHeureSouhaitee = DateTime.Now; // Récupère l’heure actuelle
            dtpDateTime.Value = dateHeureSouhaitee; // Affiche l'heure souhaitée
        }

        /// <summary>
        /// Événement déclenché au chargement du formulaire.
        /// Initialise les polices, les lignes.
        /// </summary>
        private void consultation_Load(object sender, EventArgs e)
        {
            cmbStation.Enabled = false;       // Désactive le choix de la station tant qu’aucune ligne n’est choisie
            btnRecherche.Enabled = false;     // Désactive le bouton de recherche initialement

            List<string> lignes = Serveur.ListeDesLignes(); // Récupère la liste des lignes depuis la bdd
            cmbLignes.Items.Clear(); // Vide la liste des lignes affichées
            cmbLignes.Items.AddRange(lignes.ToArray()); // Remplit la ComboBox avec les lignes

            // Sélectionne la ligne récupérée de la fenêtre précédente
            if (!string.IsNullOrEmpty(_ligne))
            {
                cmbLignes.SelectedItem = _ligne;
            }

            // Récupère les polices depuis la collection
            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];

            // Applique les polices aux différents éléments
            cmbLignes.Font = new Font(D, 9);
            cmbStation.Font = new Font(D, 9);
            btnRecherche.Font = new Font(D, 14);
            lstStations.Font = new Font(D, 9);
            lblTitre.Font = new Font(G, 24, FontStyle.Bold);

            // Centre le titre horizontalement dans la fenêtre
            lblTitre.Location = new Point((this.ClientSize.Width - lblTitre.Width) / 2, 70);
        }

        /// <summary>
        /// Événement déclenché lorsqu'une ligne est sélectionnée.
        /// Active le choix des stations et charge les stations correspondantes.
        /// </summary>
        private void cmbLignes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLignes.SelectedIndex != -1)
            {
                cmbStation.Enabled = true; // Active le ComboBox pour sélectionner une station

                string nomLigne = cmbLignes.SelectedItem.ToString(); // Récupère le nom de la ligne sélectionnée

                List<string> stations = Serveur.StationsParLigne(nomLigne); // Récupère les stations de la ligne
                foreach (string station in stations)
                {
                    cmbStation.Items.Add(station); // Ajoute chaque station dans la ComboBox
                }

                cmbStation.SelectedIndex = -1; // Désélectionne toute station, affichage du texte par défaut
                btnRecherche.Enabled = false; // Désactive le bouton tant qu’aucune station n’est choisie
            }
        }

        /// <summary>
        /// Événement déclenché lorsqu’on clique sur le bouton de recherche.
        /// Récupère les horaires de passage à la station et les affiche.
        /// </summary>
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                lstStations.Items.Clear(); // Vide la liste avant d’afficher les résultats (simple précaution)

                string nomStation = cmbStation.SelectedItem?.ToString(); // Station sélectionnée
                DateTime dateHoraire = dtpDateTime.Value; // Date et heure choisies

                // Récupère les horaires depuis le serveur
                List<string> horaires = Serveur.CalculeHorairePassageStation(nomStation, dateHoraire);

                // Ajoute les horaires à la liste pour les afficher à l'écran
                lstStations.Items.AddRange(horaires.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}");
            }
        }

        /// <summary>
        /// Événement déclenché lorsqu’une station est sélectionnée.
        /// Active le bouton de recherche.
        /// </summary>
        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Active ou désactive le bouton selon si une station est sélectionnée ou non
            btnRecherche.Enabled = cmbStation.SelectedIndex != -1;
        }

        /// <summary>
        /// Événement déclenché lorsqu’on clique sur l’icône de retour.
        /// Crée et ouvre la fenêtre Carte et ferme le formulaire actuel.
        /// </summary>
        private void picRetour_Click(object sender, EventArgs e)
        {
            Carte carte = new Carte(this.Location); // Crée une fenêtre Carte à la même position que cette fenêtre
            carte.Show();
            this.Close();
        }

        /// <summary>
        /// Événement déclenché lorsqu’on clique sur l’icône Accueil.
        /// Crée et ouvre la fenêtre Accueil.
        /// </summary>
        private void picHome_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location); // Crée une fenêtre Accueil à la même position que cette fenêtre
            accueil.Show();
            this.Close();
        }
    }
}
