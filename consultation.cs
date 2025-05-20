namespace application_metro
{
    public partial class Consultation : Form
    {
        string _ligne;

        public Consultation(string ligne)
        {
            InitializeComponent();
            _ligne = ligne;
            cmbLignes.Text = _ligne;
        }

        private void consultation_Load(object sender, EventArgs e)
        {
            // Désactive le comboBox des stations et le bouton de recherche
            cmbStation.Enabled = false;
            btnRecherche.Enabled = false;

            // Vérifie que _ligne n'est pas vide pour activer le comboBox des stations
            if (!string.IsNullOrEmpty(_ligne))
            {
                cmbLignes.SelectedItem = _ligne;
                cmbStation.Enabled = true;
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Carte carte = new Carte();
            carte.Show();
            this.Close();
        }

        private void cmbLignes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLignes.SelectedIndex != -1)
            {
                // On active le bouton quand une station est sélectionnée
                cmbStation.Enabled = true;
            }
        }

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On active le bouton quand une station est sélectionnée
            btnRecherche.Enabled = cmbStation.SelectedIndex != -1;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {

        }
    }
}
