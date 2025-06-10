using GestionReseau;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace application_metro
{
    public partial class Recherche : Form
    {
        private WebView2 webView;
        private HttpListener serveur2;
        private Task serveurTask;
        private int hauteurInitialeGrpResultat;


        PrivateFontCollection fontCollection = new PrivateFontCollection();

        public Recherche(Point position)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;

            webView = new WebView2();

            cmbDepart.Items.AddRange(Serveur.ListeDesStations().ToArray());
            cmbArrivee.Items.AddRange(Serveur.ListeDesStations().ToArray());
            cmbDepart.SelectedIndex = -1;
            cmbArrivee.SelectedIndex = -1;

            int width = pnlRecherche.ClientSize.Width - 60;
            int height = 220;
            webView.Size = new Size(width, height);

            // Centrage horizontal dans le panel
            int x = (pnlRecherche.ClientSize.Width - width) / 2;

            // Marge
            int marginTop = 50;
            int y = marginTop;

            webView.Location = new Point(x, y);


            pnlRecherche.Controls.Add(webView);
            pnlRecherche.Controls.Add(grpRecherche);


            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");
            hauteurInitialeGrpResultat = grpResultat.Height;


            // Démarre serveur local + initialise WebView
            InitializeAsync();
        }


        private async void InitializeAsync()
        {
            //Dossier de map-milan.html
            string dossier = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\.."));

            //Serveur HTTP local
            serveur2 = new HttpListener();
            serveur2.Prefixes.Add("http://localhost:8082/");
            serveur2.Start();
            //MessageBox.Show("Serveur démarré");
            serveurTask = Task.Run(() => EcouterRequetes(dossier));

            //Initialisation WebView2
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.Navigate("http://localhost:8082/map-milan.html");
        }

        private void EcouterRequetes(string dossier)
        {
            try
            {
                while (serveur2.IsListening)
                {
                    var context = serveur2.GetContext();

                    string url = context.Request.Url.LocalPath.TrimStart('/');
                    if (string.IsNullOrEmpty(url))
                        url = "map-milan.html";

                    string fichier = Path.Combine(dossier, url);
                    //MessageBox.Show(fichier);

                    if (File.Exists(fichier))
                    {
                        byte[] bytes = File.ReadAllBytes(fichier);

                        // Content-Type minimal, pour HTML
                        context.Response.ContentType = "text/html";

                        context.Response.OutputStream.Write(bytes, 0, bytes.Length);
                    }
                    else
                    {
                        context.Response.StatusCode = 404;
                        using (var writer = new StreamWriter(context.Response.OutputStream))
                        {
                            writer.Write("Fichier non trouvé");
                        }
                    }
                    context.Response.OutputStream.Close();
                }
            }
            catch (HttpListenerException) { /* Arrêt normal */ }
            catch (ObjectDisposedException) { /* Arrêt normal */ }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur serveur local : {ex.Message}");
            }
        }

        private void consultation_Load(object sender, EventArgs e)
        {
            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];
            lblDepart.Font = new Font(G, 11);
            lblArrivee.Font = new Font(G, 11);
            lblHoraireDepart.Font = new Font(G, 9);
            lblHoraireArrivée.Font = new Font(G, 9);
            lblHoraires.Font = new Font(G, 11, FontStyle.Underline);
            dtpArrivee.Font = new Font(D, 9);
            dtpDepart.Font = new Font(D, 9);
            btnRecherche.Font = new Font(D, 14);
            lblDepart2.Font = new Font(D, 9);
            lblArrivee2.Font = new Font(D, 9);
            lblTempsArrivee.Font = new Font(D, 9);
            lblTempsDepart.Font = new Font(D, 9);
            lblIntituleNumLigne.Font = new Font(G, 11);
            lblNumLigneResultat.Font = new Font(G, 11);
            lblTemps.Font = new Font(G, 11);
            cmbArrivee.Font = new Font(D, 9);
            cmbDepart.Font = new Font(D, 9);
            lblTrajet.Font = new Font(G, 11, FontStyle.Underline);
            lblTitre.Font = new Font(G, 14, FontStyle.Bold);
            lstStations.Font = new Font(D, 9);
        }

        private void picRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            serveur2.Stop();
            this.Close();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            serveur2.Stop();
            this.Close();
        }

        private void GrpResultat_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }

        private void grpRecherche1_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }

        private void grpRecherche2_Paint_1(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            var donnees = Serveur.ObtenirDonneesGraphe();
            Graphe graphe = ChargeurGrapheDepuisMySQL.Charger(donnees.stations, donnees.segments);

            // Récupérer stations sélectionnées
            Station stationDepart = graphe.Stations.FirstOrDefault(s => s.Nom == cmbDepart.SelectedItem?.ToString());
            Station stationArrivee = graphe.Stations.FirstOrDefault(s => s.Nom == cmbArrivee.SelectedItem?.ToString());

            // Vérification
            if (stationDepart == null || stationArrivee == null)
            {
                MessageBox.Show("Veuillez sélectionner une station de départ et une station d'arrivée.");
                return;
            }

            // Calcul du chemin
            Dictionary<Station, Station> predecesseurs;
            var distances = AlgorithmeDijkstra.CalculerChemins(graphe, stationDepart, out predecesseurs);
            var chemin = AlgorithmeDijkstra.TrouverChemin(stationArrivee, predecesseurs);

            if (chemin == null || chemin.Count < 2)
            {
                MessageBox.Show("Aucun trajet trouvé.");
                return;
            }

            // Mise à jour des labels de départ et arrivée
            lblDepart2.Text = chemin.First().Nom;
            lblArrivee2.Text = chemin.Last().Nom;

            // Heure actuelle comme heure de départ simulée
            DateTime heureDepart = DateTime.Now;
            int dureeTotale = distances[stationArrivee];
            DateTime heureArrivee = heureDepart.AddSeconds(dureeTotale);

            // Affichage de l'heure de départ et d'arrivée
            lblTempsDepart.Text = heureDepart.ToString("HH:mm");
            lblTempsArrivee.Text = heureArrivee.ToString("HH:mm");

            // Affichage de la durée en minutes
            lblTemps.Text = $"{(int)(dureeTotale / 60)} min";

            // Trouver la ligne utilisée entre les deux premières stations du chemin
            Station s1 = chemin[0];
            Station s2 = chemin[1];

            var trajet = graphe.Trajets.FirstOrDefault(t =>
                (t.Depart == s1 && t.Arrivee == s2) ||
                (t.Depart == s2 && t.Arrivee == s1));

            if (trajet != null && trajet.Lignes.Count > 0)
            {
                lblNumLigneResultat.Text = $"Ligne {string.Join(", ", trajet.Lignes)}";
            }
            else
            {
                lblNumLigneResultat.Text = "Ligne inconnue";
            }

            // Affichage de la liste des stations parcourues
            lstStations.Items.Clear();

            for (int i = 0; i < chemin.Count; i++)
            {
                var nomStation = chemin[i].Nom;
                string lignesInfo = "";

                if (i < chemin.Count - 1)
                {
                    var trajetEntreStations = graphe.Trajets.FirstOrDefault(t =>
                        (t.Depart == chemin[i] && t.Arrivee == chemin[i + 1]) ||
                        (t.Depart == chemin[i + 1] && t.Arrivee == chemin[i]));

                    if (trajetEntreStations != null && trajetEntreStations.Lignes.Count > 0)
                    {
                        lignesInfo = $" (Ligne {string.Join(", ", trajetEntreStations.Lignes)})";
                    }
                }

                lstStations.Items.Add($"{i + 1}. {nomStation}{lignesInfo}");
            }

            // On rend visible le panneau des résultats

            flpResultat.Visible = true;
            lblTrajet.Visible = true;

            flpResultat.Location = new Point(
                ((this.ClientSize.Width - flpResultat.Width) / 2) - 10,
                lblTrajet.Bottom + 10
            );
        }


        private bool detailsVisible = false;

        private void picVoirPlus_Click(object sender, EventArgs e)
        {
            detailsVisible = !detailsVisible;
            lstStations.Visible = detailsVisible;

            if (detailsVisible)
            {
                // Afficher "moins" pour signifier qu'on peut réduire
                picVoirPlus.Image = Image.FromFile(@"..\..\..\moins.png");

                // Agrandir le groupbox pour englober la listbox
                int nouvelleHauteur = lstStations.Bottom + 10; // 10 = petite marge
                grpResultat.Height = nouvelleHauteur;
            }
            else
            {
                // Afficher "points" pour signifier qu'on peut agrandir
                picVoirPlus.Image = Image.FromFile(@"..\..\..\points.png");

                // Rétablir la hauteur initiale
                grpResultat.Height = hauteurInitialeGrpResultat;
            }

        }

        private void grpResultat_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }

        private void grpResultat1_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e, borderColor: Color.FromArgb(15, 93, 70));
        }

        private void grpResultat2_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e, borderColor: Color.FromArgb(15, 93, 70));
        }

        private void grpResultat3_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e, borderColor: Color.FromArgb(15, 93, 70));
        }
    }
}
