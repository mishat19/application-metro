using System.Runtime.InteropServices;
using GestionReseau;

namespace application_metro
{
    public partial class Ouverture : Form
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public Ouverture()
        {
            InitializeComponent();
            AllocConsole(); //Ouverture de la console pour les Console.WriteLine()
            Serveur.OuvertureConnexion();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Connexion connexionWindow = new Connexion();
            connexionWindow.Show(this);
            this.Hide();
        }

        private void btnNoConnexion_Click(object sender, EventArgs e)
        {
            Accueil accueilWindow = new Accueil();
            accueilWindow.Show(this);
            accueilWindow.UpdateBtnRetourText("Se connecter");
            this.Hide();
        }

        public void lblDeconnexion_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblDeconnexion_Click_1(object sender, EventArgs e)
        {

        }
    }
}