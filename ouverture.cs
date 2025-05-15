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
    }
}