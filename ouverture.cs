using application_metro;
using GestionReseau;
using System.Drawing.Text;
using System.Runtime.InteropServices;

using System.IO;

namespace application_metro
{
    public partial class Ouverture : Form
    {
        // Importation d'une fonction native de Windows pour afficher une console (CMD)
        //[DllImport("kernel32.dll")]
        //private static extern bool AllocConsole();

        // Gestionnaire de polices personnalisées
        PrivateFontCollection fontCollection = new PrivateFontCollection();


        // Gestionnaire des erreurs d'animation du train
        public TrainErrorManager trainError;

        public Ouverture(Point position)
        {
            InitializeComponent();

            // Positionne la fenêtre selon la position passée en paramètre
            this.StartPosition = FormStartPosition.Manual;
            this.Location = position; // Position en pixels à l’écran

            // Chargement des polices personnalisées
            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

            //Affiche la console pour debug
            //AllocConsole();
            // Établit la connexion avec la base de données
            Serveur.OuvertureConnexion();

            // Initialisation de l’objet TrainErrorManager (gère une animation ou un effet sur le train)
            trainError = new TrainErrorManager(picTrain1, lblDeconnexion, endX : 40, trainTop: 504);
        }

        // Bouton "Se connecter"
        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion(this.Location);
            connexion.Show(this);
            this.Hide();
        }

        // Bouton "Continuer sans se connecter"
        private void btnNoConnexion_Click_1(object sender, EventArgs e)
        {
            // Ouvre la fenêtre de connexion, cache celle-ci
            Accueil accueilWindow = new Accueil(this.Location);
            accueilWindow.Show(this);
            this.Hide();
        }

        // Événement déclenché au chargement de la fenêtre
        private void Ouverture_Load(object sender, EventArgs e)
        {
            // Application des polices personnalisées aux composants
            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];
            btnConnexion.Font = new Font(D, 14);
            btnNoConnexion.Font = new Font(D, 14);
            lblDeconnexion.Font = new Font(D, 9);
            lblTitre.Font = new Font(G, 24, FontStyle.Bold);
            lblTitre.Location = new Point((this.ClientSize.Width - lblTitre.Width) / 2, 150); // Centrer le titre horizontalement

        }
    }
}