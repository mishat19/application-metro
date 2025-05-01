namespace application_metro
{
    public partial class Ouverture : Form
    {
        public Ouverture()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Connexion connexionWindow = new Connexion();
            connexionWindow.Show();
        }

        private void btnNoConnexion_Click(object sender, EventArgs e)
        {
            Accueil accueilWindow = new Accueil();
            accueilWindow.Show();
            accueilWindow.UpdateBtnRetourText("Se connecter");
        }
    }
}