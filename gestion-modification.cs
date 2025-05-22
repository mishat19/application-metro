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
    public partial class Gestion_modification : Form
    {
        public Gestion_modification(string mode, string ligne = null, string station = null, string horaire = null)
        {
            InitializeComponent();
            if (mode == "Ajout")
            {
                lblModif.Text = "Ajout d'une ligne";
                txtNomLigne.Visible = true;
                cmbLigne.Visible = false;
                txtNumero.Visible = false;
                nudNumLigne.Visible = true;
            }
            else
            {
                txtNomLigne.Visible = false;
                cmbLigne.Visible = true;
                txtNumero.Visible = false;
                nudNumLigne.Visible = true;
                nudNbStations.Enabled = false;

                cmbLigne.Items.Add(ligne);
                cmbLigne.SelectedItem = ligne;

                ListeLignes lignes = Serveur.Lignes();
                foreach (Ligne ligne1 in lignes.lignes)
                {
                    if (ligne1.nom == ligne)
                    {
                        nudNumLigne.Value = Convert.ToDecimal(ligne1.num);
                        txtCouleur.Text = ligne1.couleur;

                        int nb = 0;
                        foreach (string nStation in ligne1.stations)
                        {
                            nb++;
                        }
                        CreationTextBox(nb);
                        nudNbStations.Value = nb;
                    }
                }
            }
        }

        public int nbStations(List<string> stations)
        {
            int nbStations = 0;
            foreach (string station in stations)
            {
                nbStations++;
            }
            return nbStations;
        }

        public void CreationTextBox(int nbStations)
        {
            while (flpStations.Controls.Count > nbStations)
            {
                flpStations.Controls.RemoveAt(flpStations.Controls.Count - 1);
                flpCoordonnees.Controls.RemoveAt(flpCoordonnees.Controls.Count - 1);
            }

            for (int i = flpStations.Controls.Count + 1; i <= nbStations; i++)
            {
                //Panel stations
                Panel stationPanel = new Panel
                {
                    Width = 340,
                    Height = 35,
                    Margin = new Padding(5),
                    AutoSize = false
                };

                //Panel coordonneees
                Panel coordonneePanel = new Panel
                {
                    Width = 340,
                    Height = 35,
                    Margin = new Padding(5),
                    AutoSize = false
                };

                // Label du numéro
                Label lblNum = new Label
                {
                    Text = i.ToString(),
                    Width = 25,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(0, 8)
                };

                Label lblNum2 = new Label
                {
                    Text = i.ToString(),
                    Width = 25,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(0, 8)
                };

                //TextBox stations
                TextBox txt = new TextBox
                {
                    Name = $"txtStation{i}",
                    PlaceholderText = $"Nom de la station {i}",
                    Width = 260,
                    Location = new Point(30, 5)
                };

                //TextBox coordonnees
                TextBox txt2 = new TextBox
                {
                    Name = $"txtCoordonneeLa{i}",
                    PlaceholderText = $"Latitude{i}",
                    Width = 120,
                    Location = new Point(30, 5)
                };

                TextBox txt3 = new TextBox
                {
                    Name = $"txtCoordonneeLo{i}",
                    PlaceholderText = $"Longitude{i}",
                    Width = 120,
                    Location = new Point(160, 5)
                };

                //CheckBox
                CheckBox chk = new CheckBox
                {
                    Name = $"chkStation{i}",
                    Location = new Point(300, 8),
                    Width = 20
                };

                stationPanel.Controls.Add(lblNum);
                stationPanel.Controls.Add(txt);
                stationPanel.Controls.Add(chk);

                coordonneePanel.Controls.Add(lblNum2);
                coordonneePanel.Controls.Add(txt2);
                coordonneePanel.Controls.Add(txt3);

                flpStations.Controls.Add(stationPanel);
                flpCoordonnees.Controls.Add(coordonneePanel);
            }
        }
        private void gestion_modification_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Gestion gestion = new Gestion();
            gestion.Show();
            this.Close();
        }

        private void btnEnregistrement_Click(object sender, EventArgs e)
        {

        }

        private void lblCouleur_Click(object sender, EventArgs e)
        {

        }

        private void dudNumLigne_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void pnlGestionModification_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nudNbStations_ValueChanged(object sender, EventArgs e)
        {
            int nbStations = (int)nudNbStations.Value;
            CreationTextBox(nbStations);
        }
    }
}
