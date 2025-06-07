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

namespace application_metro
{
    public partial class Inscription : Form
    {

        PrivateFontCollection fontCollection = new PrivateFontCollection();
        public Inscription(Point position)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;

            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

        }

        private void lnkConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Connexion connexion = new Connexion(this.Location);
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
            Accueil accueilWindow = new Accueil(this.Location);
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

        private void Inscription_Load(object sender, EventArgs e)
        {
            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];
            txtNom.Font = new Font(D, 9);
            txtPrenom.Font = new Font(D, 9);
            txtEmail.Font = new Font(D, 9);
            txtMdp.Font = new Font(D, 9);
            dtpNaissance.Font = new Font(D, 9);
            lblNaissance.Font = new Font(G, 9, FontStyle.Underline);
            lblConnexion.Font = new Font(G, 9, FontStyle.Underline);
            lnkConnexion.Font = new Font(D, 9, FontStyle.Underline);
            btnInscription.Font = new Font(D, 14);
            lblTitre.Font = new Font(G, 24, FontStyle.Bold);
            lblTitre.Location = new Point((this.ClientSize.Width - lblTitre.Width) / 2, 100); // Centrer le titre horizontalement
        }

        private void grpNomPrenom_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }

        private void grpAdrMdp_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }
    }
}
