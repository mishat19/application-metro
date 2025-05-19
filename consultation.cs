namespace application_metro
{
    public partial class Consultation : Form
    {
        string _ligne;
        public Consultation(string ligne)
        {
            InitializeComponent();
            _ligne = ligne;
            cmbLignes.Text =_ligne;
        }

        private void consultation_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Carte carte = new Carte();
            carte.Show();
            this.Close();
        }

        private void cmbLignes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
