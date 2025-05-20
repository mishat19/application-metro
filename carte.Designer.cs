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
            picMap.Location = new Point(12, 209);
            picMap.Name = "picMap";
            picMap.Size = new Size(358, 532);
            picMap.TabIndex = 20;
            picMap.TabStop = false;
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
            btnRecherche.Location = new Point(204, 98);
            btnRecherche.Enabled = false;
            btnRecherche.Location = new Point(507, 93);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(166, 28);
            btnRecherche.TabIndex = 22;
            btnRecherche.Text = "Rechercher";
            btnRecherche.UseVisualStyleBackColor = true;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // btnHoraires
            // 
            btnHoraires.Enabled = false;
            btnHoraires.Location = new Point(12, 162);
            btnHoraires.Name = "btnHoraires";
            btnHoraires.Size = new Size(358, 41);
            btnHoraires.TabIndex = 23;
            btnHoraires.Text = "Voir les horaires";
            btnHoraires.UseVisualStyleBackColor = true;
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
            // 
            // Carte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 753);
            Controls.Add(picSupprimer);
            Controls.Add(btnHoraires);
            Controls.Add(btnRecherche);
            Controls.Add(cmbLignes);
            Controls.Add(btnRetour);
            Name = "Carte";
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