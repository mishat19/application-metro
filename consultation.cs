namespace application_metro
{
    public partial class Consultation : Form
    {
        public Consultation()
        {
            InitializeComponent();
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
