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

        PrivateFontCollection fontCollection = new PrivateFontCollection();

        public Recherche(Point position)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;

            webView = new WebView2();

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
            pnlRecherche.Controls.Add(flpResultat);
            pnlRecherche.Controls.Add(grpRecherche);


            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
            fontCollection.AddFontFile(@"..\..\..\Fonts\Gliker-Regular.ttf");

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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serveur2 != null && serveur2.IsListening)
            {
                serveur2.Stop();
                serveur2.Close();
            }
            base.OnFormClosing(e);
        }

        private void label15_Click(object sender, EventArgs e)
        {

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
            lblDépart.Font = new Font(D, 9);
            lblArrivee2.Font = new Font(D, 9);
            lblTempsArrivee.Font = new Font(D, 9);
            lblTempsDepart.Font = new Font(D, 9);
            lblNumLigne.Font = new Font(D, 9);
            lblNumLigneResultat.Font = new Font(D, 9);
            lblTemps.Font = new Font(D, 9);

            lblTrajet.Font = new Font(G, 11, FontStyle.Underline);
            lblTitre.Font = new Font(G, 14, FontStyle.Bold);
        }

        private void btnRetour_Click(object sender, EventArgs e)
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

        private void grpResultat_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }

        private void cmbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpRecherche1_Paint(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }

        private void grpRecherche1_Enter(object sender, EventArgs e)
        {

        }

        private void grpRecherche2_Paint_1(object sender, PaintEventArgs e)
        {
            GroupBoxBordure.ApplyCustomStyle((GroupBox)sender, e);
        }

        private void pnlRecherche_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
