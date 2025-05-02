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
            Connexion connexionWindow = new Connexion(this);
            connexionWindow.Show();
            this.Hide();
        }

        private void btnNoConnexion_Click(object sender, EventArgs e)
        {
            Accueil accueilWindow = new Accueil();
            accueilWindow.Show();
            this.Hide();
            accueilWindow.UpdateBtnRetourText("Se connecter");
        }
    }
}