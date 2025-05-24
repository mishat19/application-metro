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

namespace application_metro
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100); // Position en pixels à l’écran
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
                Accueil accueilWindow = new Accueil();
                accueilWindow.Show();
                accueilWindow.btnRetour.Text = "Se déconnecter";
                this.Close();
            }
            else
            {
                lblErreur.Visible = true;
            }
        }

        private void lnkInscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string nom = txtEmail.Text;
        }

        private void txtMdp_TextChanged(object sender, EventArgs e)
        {
            string pswd = txtMdp.Text;
        }


        private void picRetour_Click(object sender, EventArgs e)
        {
            Ouverture ouverture = Application.OpenForms[0] as Ouverture;

            if (ouverture != null)
            {
                ouverture.lblDeconnexion.Visible = false;
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
            GroupBox box = (GroupBox)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Paramètres personnalisés
            int borderRadius = 12;
            int borderWidth = 5;
            Color borderColor = Color.FromArgb(205, 33, 42);

            // Zone intérieure du GroupBox
            Rectangle rect = box.ClientRectangle;
            rect.Width -= 2;
            rect.Height -= 2;

            // Définir le stylo
            using (Pen pen = new Pen(borderColor, borderWidth))
            using (System.Drawing.Drawing2D.GraphicsPath path = RoundedRect(rect, borderRadius))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        // Fonction utilitaire pour arrondir les coins
        private System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PlaceholderConfig.ApplyPlaceholderColor(this, Color.FromArgb(205, 33, 42));
        }

    }
}
