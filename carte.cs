using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace application_metro
{
    public partial class Carte : Form
    {
        private WebView2 webView;
        private HttpListener serveur;
        private Task serveurTask;

        public Carte()
        {
            InitializeComponent();

            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            // Démarre serveur local + initialise WebView
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            // Dossier où se trouve map-milan.html (ajuste selon ta structure)
            string dossier = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\.."));

            // Démarre un serveur HTTP local minimaliste pour servir les fichiers de ce dossier
            serveur = new HttpListener();
            serveur.Prefixes.Add("http://localhost:8080/");
            serveur.Start();

            // Lance la boucle d'écoute en tâche séparée (sans bloquer l'UI)
            serveurTask = Task.Run(() => EcouterRequetes(dossier));

            // Initialise WebView2
            await webView.EnsureCoreWebView2Async(null);

            // Charge la page via le serveur local
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
            // Arrête le serveur proprement
            if (serveur != null && serveur.IsListening)
            {
                serveur.Stop();
                serveur.Close();
            }
            base.OnFormClosing(e);
        }

        private void carte_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void cmbLignes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ton code ici
        }
    }
}
