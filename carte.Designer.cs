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
            btnRecherche = new Button();
            btnHoraires = new Button();
            picRetour = new PictureBox();
            picHome = new PictureBox();
            picCroix = new PictureBox();
            picLogo5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCroix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo5).BeginInit();
            SuspendLayout();
            // 
            // cmbLignes
            // 
            cmbLignes.Font = new Font("DynaPuff", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLignes.ForeColor = Color.FromArgb(205, 33, 42);
            cmbLignes.FormattingEnabled = true;
            cmbLignes.Location = new Point(12, 99);
            cmbLignes.Name = "cmbLignes";
            cmbLignes.Size = new Size(186, 27);
            cmbLignes.TabIndex = 21;
            cmbLignes.Text = "Ligne n°";
            cmbLignes.SelectedIndexChanged += cmbLignes_SelectedIndexChanged;
            // 
            // btnRecherche
            // 
            btnRecherche.BackColor = Color.FromArgb(205, 33, 42);
            btnRecherche.Enabled = false;
            btnRecherche.FlatStyle = FlatStyle.Flat;
            btnRecherche.Font = new Font("DynaPuff", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecherche.ForeColor = Color.White;
            btnRecherche.Location = new Point(242, 99);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(92, 28);
            btnRecherche.TabIndex = 22;
            btnRecherche.Text = "Afficher";
            btnRecherche.UseVisualStyleBackColor = false;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // btnHoraires
            // 
            btnHoraires.BackColor = Color.FromArgb(205, 33, 42);
            btnHoraires.Enabled = false;
            btnHoraires.FlatStyle = FlatStyle.Flat;
            btnHoraires.Font = new Font("DynaPuff", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHoraires.ForeColor = Color.White;
            btnHoraires.Location = new Point(12, 151);
            btnHoraires.Name = "btnHoraires";
            btnHoraires.Size = new Size(358, 52);
            btnHoraires.TabIndex = 23;
            btnHoraires.Text = "Voir les horaires";
            btnHoraires.UseVisualStyleBackColor = false;
            btnHoraires.Click += btnHoraires_Click;
            // 
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(12, 12);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(51, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 25;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // picHome
            // 
            picHome.Image = Properties.Resources.home;
            picHome.Location = new Point(60, 12);
            picHome.Name = "picHome";
            picHome.Size = new Size(27, 25);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 56;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // picCroix
            // 
            picCroix.Image = Properties.Resources.croix;
            picCroix.Location = new Point(159, 99);
            picCroix.Name = "picCroix";
            picCroix.Size = new Size(16, 27);
            picCroix.SizeMode = PictureBoxSizeMode.Zoom;
            picCroix.TabIndex = 57;
            picCroix.TabStop = false;
            picCroix.Click += picCroix_Click;
            // 
            // picLogo5
            // 
            picLogo5.Image = Properties.Resources.logo5;
            picLogo5.Location = new Point(241, 21);
            picLogo5.Name = "picLogo5";
            picLogo5.Size = new Size(93, 81);
            picLogo5.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo5.TabIndex = 58;
            picLogo5.TabStop = false;
            // 
            // Carte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(382, 753);
            Controls.Add(picLogo5);
            Controls.Add(picCroix);
            Controls.Add(picHome);
            Controls.Add(picRetour);
            Controls.Add(btnHoraires);
            Controls.Add(btnRecherche);
            Controls.Add(cmbLignes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Carte";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Carte du réseau";
            Load += carte_Load;
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCroix).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbLignes;
        private Button btnRecherche;
        private Button btnHoraires;
        private PictureBox picRetour;
        private PictureBox picHome;
        private PictureBox picCroix;
        private PictureBox picLogo5;
    }
}