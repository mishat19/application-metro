using GestionReseau;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace application_metro
{

    public partial class Gestion : Form
    {
        ListeLignes lignes = new ListeLignes();
        string nomLigne = "";
        string nomStation = "";
        string horaire = "";

        PrivateFontCollection fontCollection = new PrivateFontCollection();

        public Gestion(Point position)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position; // Position en pixels à l’écran

            lignes = Serveur.Lignes();

            foreach (Ligne ligne in lignes.lignes)
            {
                cmbLigne.Items.Add(ligne.nom);
            }

            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");
        }

        private void gestion_Load(object sender, EventArgs e)
        {
            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];
            lblAjout.Font = new Font(D, 11);
            lblSelection.Font = new Font(G, 11, FontStyle.Underline);
            lblGestion.Font = new Font(G, 11, FontStyle.Underline);
            cmbLigne.Font = new Font(D, 9);
            cmbStation.Font = new Font(D, 9);
            btnModif.Font = new Font(D, 14);
            btnSupp.Font = new Font(D, 14);
            lblTitre.Font = new Font(G, 16, FontStyle.Bold);
            lblTitre.Location = new Point((this.ClientSize.Width - lblTitre.Width) / 2, 115); // Centrer le titre horizontalement
            lblErreur.Font = new Font(D, 9, FontStyle.Italic);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            this.Close();
        }

        string mode;
        private void btnModif_Click(object sender, EventArgs e)
        {
            if (!(cmbLigne.SelectedIndex == -1))
            {
                mode = "Modification";
                Gestion_modification modif = new Gestion_modification(mode, this.Location, nomLigne, nomStation);
                modif.Show();
                this.Close();
            }
            else
            {
                lblErreur.Visible = true;
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (cmbLigne.SelectedItem == null && cmbStation.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer ces données ?\nCette action est irréversible.",
                "Confirmation de suppression",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.OK)
                return;

            if (cmbStation.SelectedItem != null && cmbLigne.SelectedItem != null)
            {
                string station = cmbStation.SelectedItem.ToString();
                string ligne = cmbLigne.SelectedItem.ToString();

                Serveur.SupprimerUneStation(ligne, station);

                MessageBox.Show("La station a été supprimée avec succès.");
                return;
            }

            if (cmbStation.SelectedItem == null && cmbLigne.SelectedItem != null)
            {
                string ligne = cmbLigne.SelectedItem.ToString();

                int idLigne = Serveur.idLigneGraceNom(ligne);

                Serveur.SupprimerUneLigne(idLigne);
                Serveur.SupprimerUnHoraire(idLigne);
                Serveur.SupprimerUneInfoLigne(idLigne);

                List<string> listeStation = Serveur.StationsParLigne(ligne);

                foreach (string station in listeStation)
                {
                    Serveur.SupprimerUneStation(ligne, station);
                }

                MessageBox.Show("La ligne et ses stations ont été supprimées avec succès.");
                return;
            }
        }


        private void picPlus_Click(object sender, EventArgs e)
        {

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
            //cmbHoraire.Enabled = true;
            //cmbHoraire.Items.Clear();

            nomStation = cmbStation.SelectedItem.ToString().Trim();

            //DateTime date = DateTime.Now;

            //List<string> horaires = Serveur.CalculeHorairePassageStation(nomStation, date);
            //cmbHoraire.Items.AddRange(horaires.ToArray());
        }

        //private void cmbHoraire_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    horaire = cmbHoraire.SelectedItem.ToString().Trim();
        //}

        private void picRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            this.Close();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mode = "Ajout";
            Gestion_modification gestion_Modification = new Gestion_modification(mode, this.Location);
            gestion_Modification.Show();
            this.Close();
        }

        private void pnlGestion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpAjout_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }
    }
}