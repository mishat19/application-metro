using application_metro;
using GestionReseau;
using System.Drawing.Text;
using System.Runtime.InteropServices;

using System.IO;

namespace application_metro
{
    public partial class Ouverture : Form
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        PrivateFontCollection fontCollection = new PrivateFontCollection();

        public TrainErrorManager trainError;

        public Ouverture(Point position)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position; // Position en pixels à l’écran

            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

            // Affiche la console pour debug
            AllocConsole();
            Serveur.OuvertureConnexion();

            trainError = new TrainErrorManager(picTrain1, lblDeconnexion, trainTop: 504);
        }





        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion(this.Location);
            connexion.Show(this);
            this.Hide();
        }

        private void btnNoConnexion_Click_1(object sender, EventArgs e)
        {
            Accueil accueilWindow = new Accueil(this.Location);
            accueilWindow.Show(this);
            //accueilWindow.UpdateBtnRetourText("Se connecter");
            this.Hide();
        }

        private void lnkInscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inscription inscription = new Inscription(this.Location);
            inscription.Show();
            this.Close();
        }

        private void Ouverture_Load(object sender, EventArgs e)
        {
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