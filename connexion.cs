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

namespace application_metro
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Ouverture ouverture = Application.OpenForms[0] as Ouverture;

            if (ouverture != null)
            {
                ouverture.lblDeconnexion.Visible = false;
                ouverture.Show();
                this.Close();
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Accueil accueilWindow = new Accueil();
            accueilWindow.Show();
            accueilWindow.btnRetour.Text = "Se déconnecter";
            this.Close();
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

        string cheminOff = @"C:\Users\mathi\Documents\BUT\C#\application-metro\visibility-off.png";
        string cheminOn = @"C:\Users\mathi\Documents\BUT\C#\application-metro\visibility-on.png";

        private void picOeil_Click(object sender, EventArgs e)
        {

            if(txtMdp.PasswordChar == '*')
            {
                try
                {
                    Image image = Image.FromFile(cheminOn);
                    picOeil.Image = image;
                    txtMdp.PasswordChar = '\0';
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Image image = Image.FromFile(cheminOff);
                    picOeil.Image = image;
                    txtMdp.PasswordChar = '*';
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur :", ex.Message);
                }
            }
        }
    }
}
