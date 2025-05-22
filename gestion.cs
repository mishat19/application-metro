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
        string nomLigne = "";
        string nomStation = "";
        string horaire = "";

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
            Gestion_modification modif = new Gestion_modification(mode, nomLigne, nomStation, horaire);
            modif.Show();
            this.Close();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer ces données ?\nCette action est irréversible.",
                "Confirmation de suppression",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (!string.IsNullOrWhiteSpace(nomLigne))
            {
                Serveur.SupprimerDonnees(nomLigne,
                    string.IsNullOrWhiteSpace(nomStation) ? null : nomStation);
            }
            else
            {
                MessageBox.Show("Une ligne doit au moins être sélectionnée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            nomLigne = cmbLigne.SelectedItem.ToString().Trim();
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

            nomStation = cmbStation.SelectedItem.ToString().Trim();

            DateTime date = DateTime.Now;

            List<string> horaires = Serveur.CalculeHorairePassageStation(nomStation, date);
            cmbHoraire.Items.AddRange(horaires.ToArray());
        }

        private void cmbHoraire_SelectedIndexChanged(object sender, EventArgs e)
        {
            horaire = cmbHoraire.SelectedItem.ToString().Trim();
        }
    }
}