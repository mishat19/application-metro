using GestionReseau;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace application_metro
{
    public partial class Carte : Form
    {
        private WebView2 webView;
        private HttpListener serveur;
        private Task serveurTask;

        PrivateFontCollection fontCollection = new PrivateFontCollection();

        public Carte(Point position)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;

            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            // Démarre serveur local + initialise WebView
            InitializeAsync();

            ListeLignes lignes = Serveur.Lignes();
            foreach (Ligne ligne in lignes.lignes)
            {
                cmbLignes.Items.Add(ligne.nom);
            }
        }

        private async void InitializeAsync()
        {
            //Dossier de map-milan.html
            string dossier = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\.."));

            //Serveur HTTP local
            serveur = new HttpListener();
            serveur.Prefixes.Add("http://localhost:8080/");
            serveur.Start();
            serveurTask = Task.Run(() => EcouterRequetes(dossier));

            //Initialisation WebView2
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.Navigate("http://localhost:8080/map-milan.html");
        }

        private void EcouterRequetes(string dossier)
        {
            try
            {
                while (serveur.IsListening)
                {
                    var context = serveur.GetContext();

                    string url = context.Request.Url.LocalPath.TrimStart('/');
                    if (string.IsNullOrEmpty(url))
                        url = "map-milan.html";

                    string fichier = Path.Combine(dossier, url);

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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serveur != null && serveur.IsListening)
            {
                serveur.Stop();
                serveur.Close();
            }
            base.OnFormClosing(e);
        }

        private void carte_Load(object sender, EventArgs e)
        {
            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];
            btnRecherche.Font = new Font(D, 9);
            btnHoraires.Font = new Font(D, 14);
            cmbLignes.Font = new Font(D, 9);

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {

        }
        string ligne;
        private void cmbLignes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRecherche.Enabled = true;
            ligne = cmbLignes.Text;
        }

        private void btnHoraires_Click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation(ligne, this.Location);
            consultation.Show();
            this.Close();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            btnHoraires.Enabled = true;
        }

        private void picSupprimer_Click(object sender, EventArgs e)
        {

        }

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

        private void picCroix_Click(object sender, EventArgs e)
        {
            cmbLignes.SelectedIndex = -1; //Permet de sélectionner aucune ligne
        }
    }
}
