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
        // Contrôle WebView2 utilisé pour afficher du contenu web dans le formulaire.
        private WebView2 webView;

        // Serveur HTTP local permettant d'héberger temporairement du contenu web.
        private HttpListener serveur;

        // Tâche asynchrone (en parallèle) qui exécute le serveur HTTP sans bloquer l'interface utilisateur.
        private Task serveurTask;


        PrivateFontCollection fontCollection = new PrivateFontCollection();

        public Carte(Point position)
        {
            // Initialisation des composants de la fenêtre
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;

            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

            //Instancie et rempli un webView
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;

            int width = this.ClientSize.Width - 60;
            int height = 500;

            webView.Size = new Size(width, height);

            //Centrage horizontal
            int x = (this.ClientSize.Width - width) / 2;

            int marginBottom = 20;
            int y = this.ClientSize.Height - height - marginBottom;

            webView.Location = new Point(x, y);
            webView.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.Controls.Add(webView);
            //Pour qu'il soit visible
            webView.BringToFront();

            //Démarre serveur local + initialisation WebView
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

        // Cherche la carte dans le dossier et la renvoie
        private void EcouterRequetes(string dossier)
        {
            try
            {
                // Boucle principale du serveur : tant que le serveur est actif
                while (serveur.IsListening)
                {
                    // Attend une requête HTTP entrante (appel bloquant)
                    var context = serveur.GetContext();

                    // Récupère le chemin demandé dans l'UR
                    string url = context.Request.Url.LocalPath.TrimStart('/');

                    // Si aucune URL n’est spécifiée, on sert la page par défaut
                    if (string.IsNullOrEmpty(url))
                        url = "map-milan.html";

                    // Construit le chemin complet vers le fichier demandé dans le dossier du serveur
                    string fichier = Path.Combine(dossier, url);

                    // Si le fichier existe...
                    if (File.Exists(fichier))
                    {
                        // Lit tout le fichier en mémoire sous forme de tableau de bytes
                        byte[] bytes = File.ReadAllBytes(fichier);

                        // Définit le type de contenu de la réponse HTTP
                        context.Response.ContentType = "text/html";

                        // Envoie le contenu du fichier dans la réponse
                        context.Response.OutputStream.Write(bytes, 0, bytes.Length);
                    }
                    else
                    {
                        // Si le fichier n’existe pas, retourne une erreur s'il n'est pas trouvé
                        context.Response.StatusCode = 404;

                        // Écrit un message d'erreur dans la réponse
                        using (var writer = new StreamWriter(context.Response.OutputStream))
                        {
                            writer.Write("Fichier non trouvé");
                        }
                    }

                    // Ferme le flux de sortie
                    context.Response.OutputStream.Close();
                }

            }
            catch (HttpListenerException) {  }
            catch (ObjectDisposedException) {  }
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

        // Chargement de la carte
        private void carte_Load(object sender, EventArgs e)
        {
            FontFamily D = fontCollection.Families[0];
            FontFamily G = fontCollection.Families[1];
            btnHoraires.ForeColor = Color.White;
            btnHoraires.Font = new Font(D, 14);
            cmbLignes.Font = new Font(D, 9);

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {

        }

        // Active le bouton en cas de selection d'une ligne
        string ligne;
        private void cmbLignes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnHoraires.Enabled = true;
            ligne = cmbLignes.Text;
        }

        // Ouvre la consultation des horaires pour la ligne sélectionnée quand on clique sur le bouton
        private void btnHoraires_Click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation(ligne, this.Location);
            consultation.Show();
            this.Close();
        }

        // Bouton retour à la page précédente
        private void picRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            this.Close();
        }

        // Bouton retour à la page d'accueil
        private void picHome_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(this.Location);
            accueil.Show();
            this.Close();
        }
    }
}
