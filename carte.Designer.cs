namespace application_metro
{
    partial class Carte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carte));
            cmbLignes = new ComboBox();
            btnRetour = new Button();
            btnRecherche = new Button();
            btnHoraires = new Button();
            picSupprimer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picSupprimer).BeginInit();
            SuspendLayout();
            // 
            // cmbLignes
            // 
            cmbLignes.FormattingEnabled = true;
            cmbLignes.Location = new Point(12, 99);
            cmbLignes.Name = "cmbLignes";
            cmbLignes.Size = new Size(186, 28);
            cmbLignes.TabIndex = 21;
            cmbLignes.Text = "Ligne n°";
            cmbLignes.SelectedIndexChanged += cmbLignes_SelectedIndexChanged;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 39);
            btnRetour.TabIndex = 19;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnRecherche
            // 
            btnRecherche.BackColor = Color.FromArgb(205, 33, 42);
            btnRecherche.Enabled = false;
            btnRecherche.FlatStyle = FlatStyle.Flat;
            btnRecherche.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnRecherche.ForeColor = Color.White;
            btnRecherche.Location = new Point(214, 88);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(156, 44);
            btnRecherche.TabIndex = 22;
            btnRecherche.Text = "Rechercher";
            btnRecherche.UseVisualStyleBackColor = false;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // btnHoraires
            // 
            btnHoraires.BackColor = Color.FromArgb(205, 33, 42);
            btnHoraires.Enabled = false;
            btnHoraires.FlatStyle = FlatStyle.Flat;
            btnHoraires.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHoraires.ForeColor = Color.White;
            btnHoraires.Location = new Point(12, 151);
            btnHoraires.Name = "btnHoraires";
            btnHoraires.Size = new Size(358, 52);
            btnHoraires.TabIndex = 23;
            btnHoraires.Text = "Voir les horaires";
            btnHoraires.UseVisualStyleBackColor = false;
            btnHoraires.Click += btnHoraires_Click;
            // 
            // picSupprimer
            // 
            picSupprimer.Image = (Image)resources.GetObject("picSupprimer.Image");
            picSupprimer.Location = new Point(151, 99);
            picSupprimer.Name = "picSupprimer";
            picSupprimer.Size = new Size(24, 28);
            picSupprimer.SizeMode = PictureBoxSizeMode.CenterImage;
            picSupprimer.TabIndex = 24;
            picSupprimer.TabStop = false;
            picSupprimer.Click += picSupprimer_Click;
            // 
            // Carte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(382, 753);
            Controls.Add(picSupprimer);
            Controls.Add(btnHoraires);
            Controls.Add(btnRecherche);
            Controls.Add(cmbLignes);
            Controls.Add(btnRetour);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Carte";
            Text = "Carte du réseau";
            Load += carte_Load;
            ((System.ComponentModel.ISupportInitialize)picSupprimer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbLignes;
        private Button btnRetour;
        private Button btnRecherche;
        private Button btnHoraires;
        private PictureBox picSupprimer;
    }
}