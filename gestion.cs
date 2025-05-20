using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionReseau;

namespace application_metro
{
    public partial class Gestion : Form
    {
        ListeLignes lignes = new ListeLignes();
        public Gestion()
        {
            InitializeComponent();
            lignes = Serveur.Lignes();

            foreach (Ligne ligne in lignes.lignes)
            {
                cmbLigne.Items.Add(ligne.nom);
            }
        }

        private void gestion_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        string mode;
        private void btnModif_Click(object sender, EventArgs e)
        {
            mode = "Modification";
            Gestion_modification modif = new Gestion_modification(mode);
            modif.Show();
            this.Close();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            SuppressionWindow suppression = new SuppressionWindow();
            suppression.Show();
            this.Close();
        }

        private void picPlus_Click(object sender, EventArgs e)
        {
            mode = "Ajout";
            Gestion_modification gestion_Modification = new Gestion_modification(mode);
            gestion_Modification.Show();
            this.Close();
        }

        private void cmbLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomLigne = cmbLigne.SelectedItem.ToString().Trim();
            cmbStation.Enabled = true;
            cmbStation.Items.Clear();
            NomsStation(nomLigne);
        }

        public void NomsStation(string nomLigne)
        {
            foreach (Ligne ligne in lignes.lignes)
            {
                Console.WriteLine(ligne.nom);
                if (ligne.nom == nomLigne)
                {
                    foreach (string nomStation in ligne.stations)
                    {
                        Console.WriteLine(nomStation);
                        cmbStation.Items.Add(nomStation);
                    }
                }
            }
        }

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHoraire.Enabled = true;
            cmbHoraire.Items.Clear();

            string nomLigne = cmbLigne.SelectedItem.ToString().Trim();
            string nomStation = cmbStation.SelectedItem.ToString().Trim();

            List<string> horaires = Serveur.HorairesParStationEtLigne(nomLigne, nomStation);

            foreach (string horaire in horaires)
            {
                cmbHoraire.Items.Add(horaire);
            }

        }
    }
}
