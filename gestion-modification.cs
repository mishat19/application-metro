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
        int numeroLigne = 0;
        string mode = "";
        public Gestion_modification(string mode, Point position, string ligne = null, string station = null, string horaire = null)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position; // Position en pixels à l’écran

            if (mode == "Ajout")
            {
                mode = "Ajout"; //Pour enregistrer données dans btnEnregistrement
                lblModif.Text = "Ajout d'une ligne";
                txtNomLigne.Visible = true;
                cmbLigne.Visible = false;
                txtNumero.Visible = false;
                nudNumLigne.Visible = true;
            }
            else
            {
                mode = "Modif"; //Pour modifier données dans btnEnregistrement
                txtNomLigne.Visible = false;
                cmbLigne.Visible = true;
                txtNumero.Visible = false;
                nudNumLigne.Visible = true;
                nudNbStations.Enabled = true;

                string nom = nomLigneDeconcatenation(ligne);
                cmbLigne.Items.Add(nom);
                cmbLigne.SelectedItem = nom;

                ListeLignes lignes = Serveur.Lignes();
                foreach (Ligne ligne1 in lignes.lignes)
                {
                    if (ligne1.nom == ligne)
                    {
                        nudNumLigne.Value = numLigneDeconcatenation(ligne1.nom);
                        numeroLigne = Convert.ToInt32(ligne1.num);
                        txtCouleur.Text = ligne1.couleur;

                        int nb = 0;
                        string sta;
                        foreach (string nStation in ligne1.stations)
                        {
                            nb++;
                        }
                        List<List<decimal>> coordonnees = Serveur.CoordonneesStationsLigne(ligne1.stations);
                        CreationTextBox(nb, ligne1.stations, coordonnees);
                        nudNbStations.Value = nb;
                    }
                }
            }
        }

        public string nomLigneDeconcatenation(string nom)
        {
            for (int i = 0; i < nom.Length; i++)
            {
                if (char.IsDigit(nom[i]))
                {
                    return nom.Substring(0, i);
                }
            }
            return nom;
        }


        public int numLigneDeconcatenation(string nom)
        {
            for (int i = 0; i < nom.Length; i++)
            {
                if (char.IsDigit(nom[i]))
                    return (int)char.GetNumericValue(nom[i]);
            }
            return -1;
        }

        //Expression lambda
        public string ligneConcatenation(string nom, int numero) => nom + numero;


        public int nbStations(List<string> stations)
        {
            int nbStations = 0;
            foreach (string station in stations)
            {
                nbStations++;
            }
            return nbStations;
        }

        public void CreationTextBox(int nbStations, List<string> noms = null, List<List<decimal>> coordonnees = null)
        {
            while (flpStations.Controls.Count > nbStations)
            {
                flpStations.Controls.RemoveAt(flpStations.Controls.Count - 1);
                flpCoordonnees.Controls.RemoveAt(flpCoordonnees.Controls.Count - 1);
            }

            for (int i = flpStations.Controls.Count + 1; i <= nbStations; i++)
            {
                string nom = (noms != null && noms.Count >= i) ? noms[i - 1] : null;
                List<decimal> coordonnee = (coordonnees != null && coordonnees.Count >= i) ? coordonnees[i - 1] : null;

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
                    Width = 260,
                    Location = new Point(30, 5)
                };

                if (!string.IsNullOrEmpty(nom))
                {
                    txt.Name = nom;
                    txt.Text = nom;
                }
                else
                {
                    txt.Name = $"txtStation{i}";
                    txt.PlaceholderText = $"Nom de la station {i}";
                }

                txt.TextChanged += Txt_TextChanged;

                //NumericUpDown stations
                NumericUpDown nud = new NumericUpDown
                {
                    Location = new Point(310, 8),
                    Width = 40
                };

                if (!string.IsNullOrEmpty(nom))
                {
                    nud.Name = nom;
                }
                else
                {
                    nud.Name = $"nudStation{i}";
                }

                //TextBox coordonnees
                TextBox txt2 = new TextBox
                {
                    Width = 120,
                    Location = new Point(30, 5)
                };

                if (coordonnee != null)
                {
                    txt2.Name = nom;
                    txt2.Text = coordonnee[0].ToString();
                }
                else
                {
                    txt2.Name = $"txtCoordonneeLa{i}";
                    txt2.PlaceholderText = $"Latitude{i}";
                }

                txt2.TextChanged += Txt2_TextChanged;

                TextBox txt3 = new TextBox
                {
                    Width = 120,
                    Location = new Point(160, 5)
                };

                if (coordonnee != null)
                {
                    txt3.Name = nom;
                    txt3.Text = coordonnee[1].ToString();
                }
                else
                {
                    txt3.Name = $"txtCoordonneeLa{i}";
                    txt3.PlaceholderText = $"Longitude{i}";
                }

                txt3.TextChanged += Txt3_TextChanged;

                stationPanel.Controls.Add(lblNum);
                stationPanel.Controls.Add(txt);
                stationPanel.Controls.Add(nud);

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

        }

        private void btnEnregistrement_Click(object sender, EventArgs e)
        {
            if (mode == "Ajout")
            {
                //Fonctions de Serveur à mettre ici
            }
            else
            {
                if (nudChange || couleurChange)
                {
                    string nom = ligneConcatenation(cmbLigne.Text, (int)nudNumLigne.Value);
                    Serveur.ModifInfosLigne(numeroLigne, nom, txtCouleur.Text);
                }
                ;

                if (nudStations)
                {
                    //A faire
                }
                ;

                if (stationsChange != null)
                {
                    Serveur.ModifNomStations(stationsChange);
                }

                if (coordonneesChange != null)
                {
                    Serveur.ModifCoordonneesStations(coordonneesChange);
                }
                ;
            }
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
            nudStations = true;
        }

        private void lblHoraires_Click(object sender, EventArgs e)
        {

        }

        bool nudChange = false;
        bool couleurChange = false;
        bool nudStations = false;
        Dictionary<string, string> stationsChange = new Dictionary<string, string>();
        Dictionary<string, (decimal lat, decimal lon)> coordonneesChange = new();

        private void nudNumLigne_ValueChanged(object sender, EventArgs e)
        {
            nudChange = true;
        }

        private void txtCouleur_TextChanged(object sender, EventArgs e)
        {
            couleurChange = true;
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string nom = txt.Name;
                string contenu = txt.Text;
                stationsChange[nom] = contenu;
            }
        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string nom = txt.Name;
                string contenu = txt.Text;

                if (decimal.TryParse(contenu, out decimal latitude))
                {
                    if (coordonneesChange.ContainsKey(nom))
                    {
                        coordonneesChange[nom] = (latitude, coordonneesChange[nom].lon);
                    }
                    else
                    {
                        coordonneesChange[nom] = (latitude, 0);
                    }
                }
            }
        }

        private void Txt3_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string nom = txt.Name;
                string contenu = txt.Text;

                if (decimal.TryParse(contenu, out decimal longitude))
                {
                    if (coordonneesChange.ContainsKey(nom))
                    {
                        coordonneesChange[nom] = (coordonneesChange[nom].lat, longitude);
                    }
                    else
                    {
                        coordonneesChange[nom] = (0, longitude);
                    }
                }
            }
        }

        private void picRetour_Click(object sender, EventArgs e)
        {
            Gestion gestion = new Gestion(this.Location);
            gestion.Show();
            this.Close();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            this.Close();
        }

        private void flpCoordonnees_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanelBordure.ApplyCustomStyle(flpCoordonnees, e);
        }

        private void flpStations_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanelBordure.ApplyCustomStyle(flpStations, e);
        }

        private void flpHoraires_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanelBordure.ApplyCustomStyle(flpHoraires, e);
        }
    }
}
