using GestionReseau;

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
            cmbStation.Enabled = false;
            btnRecherche.Enabled = false;

            List<string> lignes = Serveur.ListeDesLignes();
            cmbLignes.Items.Clear();
            cmbLignes.Items.AddRange(lignes.ToArray());

            if (!string.IsNullOrEmpty(_ligne))
            {
                cmbLignes.SelectedItem = _ligne;
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
                cmbStation.Enabled = true;
                string nomLigne = cmbLignes.SelectedItem.ToString();
                List<string> stations = Serveur.StationsParLigne(nomLigne);
                foreach (string station in stations)
                {
                    cmbStation.Items.Add(station);
                }
                cmbStation.SelectedIndex = -1;
                btnRecherche.Enabled = false;
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            lstStations.Items.Clear();

            string nomStation = cmbStation.SelectedItem?.ToString();

            List<string> horaires = Serveur.CalculeHorairePassageStation(nomStation);
            lstStations.Items.AddRange(horaires.ToArray());
        }

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRecherche.Enabled = cmbStation.SelectedIndex != -1;
        }

        private void lstStations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
