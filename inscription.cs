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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100); // Position en pixels à l’écran

        }

        private void lnkConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
            this.Close();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string email = txtEmail.Text.Trim();
            string mdp = txtMdp.Text.Trim();
            DateTime dateInscription = DateTime.Now;
            DateTime dateNaissance = dtpNaissance.Value;

            Serveur.UtilisateurInscription(nom, prenom, email, mdp, dateInscription, dateNaissance, 0);
            Accueil accueilWindow = new Accueil();
            accueilWindow.btnRetour.Text = "Se déconnecter";
            accueilWindow.Show();
            this.Close();
        }


        private void txtMdp_TextChanged(object sender, EventArgs e)
        {
            string pswd = txtMdp.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ouverture ouverture = Application.OpenForms[0] as Ouverture;
            if (ouverture != null)
            {
                ouverture.Show();
                this.Close();
            }
        }

        string cheminOff = @"..\..\..\oeiloff.png";
        string cheminOn = @"..\..\..\oeilon.png";

        private void picOeilOff_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMdp.PasswordChar == '*')
                {
                    // Affiche le mot de passe
                    picOeilOff.Image = Image.FromFile(cheminOn);
                    txtMdp.PasswordChar = '\0';
                }
                else
                {
                    // Masque le mot de passe
                    picOeilOff.Image = Image.FromFile(cheminOff);
                    txtMdp.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

    }
}
