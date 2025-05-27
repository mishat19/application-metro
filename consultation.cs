using GestionReseau;
using System.Drawing.Text;

namespace application_metro
{
    public partial class Consultation : Form
    {
        string _ligne;

        PrivateFontCollection fontCollection = new PrivateFontCollection();

        public Consultation(string ligne, Point position)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;

            _ligne = ligne;
            cmbLignes.Text = _ligne;

            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

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

            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];
            cmbLignes.Font = new Font(D, 9);
            cmbStation.Font = new Font(D, 9);
            btnRecherche.Font = new Font(D, 14);
            lstStations.Font = new Font(D, 9);
            lblTitre.Font = new Font(G, 24, FontStyle.Bold);
            lblTitre.Location = new Point((this.ClientSize.Width - lblTitre.Width) / 2, 150);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {

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
            DateTime date = calDate.SelectionStart;

            List<string> horaires = Serveur.CalculeHorairePassageStation(nomStation, date);
            lstStations.Items.AddRange(horaires.ToArray());
        }

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRecherche.Enabled = cmbStation.SelectedIndex != -1;
        }

        private void lstStations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calDate_DateSelected(object sender, DateRangeEventArgs e)
        {
        }

        private void picRetour_Click(object sender, EventArgs e)
        {
            Carte carte = new Carte(this.Location);
            carte.Show();
            this.Close();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            this.Close();
        }
    }
}
