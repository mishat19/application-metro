using GestionReseau;
using K4os.Compression.LZ4.Encoders;
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
using static System.Windows.Forms.DataFormats;

namespace application_metro
{
    public partial class Connexion : Form
    {

        PrivateFontCollection fontCollection = new PrivateFontCollection();

        private TrainErrorManager trainError;
        public Connexion(Point position)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;

            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

            trainError = new TrainErrorManager(picTrain1, lblErreur, trainTop : 273);

        }

        /// <summary>
        /// Bouton de connexion
        /// </summary>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            // Récupère l'email et mdp et ce connecte
            string email = txtEmail.Text.Trim();
            string mdp = txtMdp.Text.Trim();
            if (Serveur.UtilisateurConnexion(email, mdp))
            {
                Accueil accueilWindow = new Accueil(this.Location);
                accueilWindow.Show();
                this.Close(); // Ferme la page de connexion
            }
            else
            {
                // Affiche une erreur si la connexion échoue
                trainError.ShowError("Identifiants incorrects");
            }
        }

        private void lnkInscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inscription inscription = new Inscription(this.Location);
            inscription.Show();
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string nom = txtEmail.Text;
        }

        // Bouton pour rétourner a la page précédente
        private void picRetour_Click(object sender, EventArgs e)
        {
            Ouverture ouverture = Application.OpenForms[0] as Ouverture;

            if (ouverture != null)
            {
                ouverture.lblDeconnexion.Visible = false;
                ouverture.Location = this.Location;
                ouverture.Show();
                this.Close();
            }
        }

        // Logo pour masquer ou afficher le mot de passe
        string cheminOff = @"..\..\..\oeiloff.png";
        string cheminOn = @"..\..\..\oeilon.png";

        // Bouton pour masquer ou afficher le mot de passe
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

        // Chargement de la page de connexion
        private void Connexion_Load(object sender, EventArgs e)
        {
            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];
            txtEmail.Font = new Font(D, 9);
            txtMdp.Font = new Font(D, 9);
            lblInscription.Font = new Font(D, 9);
            lnkInscription.Font = new Font(D, 9);
            btnConnexion.Font = new Font(D, 9);
            btnConnexion.ForeColor = Color.White;
            lblTitre.Font = new Font(G, 24, FontStyle.Bold);
            lblTitre.Location = new Point((this.ClientSize.Width - lblTitre.Width) / 2, 90);

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);

        }

        private void grpInscriptionConnexion_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }
    }
}
