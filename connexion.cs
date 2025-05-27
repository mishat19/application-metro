using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

using GestionReseau;
using K4os.Compression.LZ4.Encoders;

namespace application_metro
{
    public partial class Connexion : Form
    {


        private int trainStartX = -300; // Position de départ hors écran
        private int trainEndX = 30;     // Position finale d'arrivée du train
        public Connexion(Point position)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;

            picTrain1.Left = trainStartX; // Position de départ hors écran
            picTrain1.Top = 210;
            picTrain1.Controls.Add(lblErreur);
            lblErreur.Text = "Identifiants incorrects";
            lblErreur.ForeColor = Color.FromArgb(15, 93, 70);
            lblErreur.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblErreur.AutoSize = true;
            lblErreur.Location = new Point(20, 15); // Position dans le train
            lblErreur.Visible = true;

        }


        private void btnRetour_Click(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string mdp = txtMdp.Text.Trim();
            if (Serveur.UtilisateurConnexion(email, mdp))
            {
                Accueil accueilWindow = new Accueil(this.Location);
                accueilWindow.Show();
                //accueilWindow.btnRetour.Text = "Se déconnecter";
                this.Close();
            }
            else
            {
                picTrain1.Left = trainStartX;
                picTrain1.Top = 210;
                picTrain1.Visible = true;
                timerTrain.Start();
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

        private void txtMdp_TextChanged(object sender, EventArgs e)
        {
            // Remet le caractère de mot de passe si le placeholder n'est plus actif
            if (!txtMdp.IsPlaceholderActive)
            {
                txtMdp.PasswordChar = '*';
            }
        }


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

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void Connexion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);

        }

        private void lblInscription_Click(object sender, EventArgs e)
        {

        }

        private void grpInscriptionConnexion_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }

        private void timerTrain_Tick(object sender, EventArgs e)
        {
            if (picTrain1.Left < trainEndX)
            {
                picTrain1.Left += 5;
            }
            else
            {
                timerTrain.Stop();
            }
        }
    }
}
