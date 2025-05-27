using application_metro;
using GestionReseau;
using System.Drawing.Text;
using System.Runtime.InteropServices;

using System.IO;

namespace application_metro
{
    public partial class Ouverture : Form
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        PrivateFontCollection fontCollection = new PrivateFontCollection();


        private int trainStartX = -300; // Position de départ hors écran
        private int trainEndX = 30;     // Position finale d'arrivée du train

        public Ouverture(Point position)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = position; // Position en pixels à l’écran

            fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");

            // Affiche la console pour debug
            AllocConsole();
            Serveur.OuvertureConnexion();

            // Le label d'erreur est maintenant contenu dans le train
            picTrain1.Controls.Add(labelTrainError);
            labelTrainError.Text = "Lukas fait le Trello";
            labelTrainError.ForeColor = Color.FromArgb(15, 93, 70);
            labelTrainError.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelTrainError.AutoSize = true;
            labelTrainError.Location = new Point(20, 15); // Position dans le train
            labelTrainError.Visible = true; // visible dès l'apparition du train

        }




        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                picTrain1.Left = trainStartX;
                picTrain1.Top = 210;
                picTrain1.Visible = true;

                timerTrain.Start();
            }
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

        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion(this.Location);
            connexion.Show(this);
            this.Hide();
        }

        private void btnNoConnexion_Click_1(object sender, EventArgs e)
        {
            Accueil accueilWindow = new Accueil(this.Location);
            accueilWindow.Show(this);
            //accueilWindow.UpdateBtnRetourText("Se connecter");
            this.Hide();
        }

        private void lnkInscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inscription inscription = new Inscription(this.Location);
            inscription.Show();
            this.Close();
        }

        private void Ouverture_Load(object sender, EventArgs e)
        {
            FontFamily F = fontCollection.Families[0];
            btnConnexion.Font = new Font(F, 18);
            btnNoConnexion.Font = new Font(F, 18);

        }
    }
}