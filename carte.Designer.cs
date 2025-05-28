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
            picHome = new PictureBox();
            picLogo5 = new PictureBox();
            picRetour = new PictureBox();
            picCroix = new PictureBox();
            btnHoraires = new Button();
            cmbLignes = new ComboBox();
            btnRecherche = new Button();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCroix).BeginInit();
            SuspendLayout();
            // 
            // picHome
            // 
            picHome.Image = Properties.Resources.home;
            picHome.Location = new Point(61, 45);
            picHome.Name = "picHome";
            picHome.Size = new Size(27, 25);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 70;
            picHome.TabStop = false;
            // 
            // picLogo5
            // 
            picLogo5.Image = Properties.Resources.logo5;
            picLogo5.Location = new Point(248, 39);
            picLogo5.Name = "picLogo5";
            picLogo5.Size = new Size(92, 81);
            picLogo5.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo5.TabIndex = 72;
            picLogo5.TabStop = false;
            // 
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(22, 45);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(42, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 69;
            picRetour.TabStop = false;
            // 
            // picCroix
            // 
            picCroix.Image = Properties.Resources.croix;
            picCroix.Location = new Point(174, 119);
            picCroix.Name = "picCroix";
            picCroix.Size = new Size(16, 27);
            picCroix.SizeMode = PictureBoxSizeMode.Zoom;
            picCroix.TabIndex = 71;
            picCroix.TabStop = false;
            // 
            // btnHoraires
            // 
            btnHoraires.BackColor = Color.FromArgb(205, 33, 42);
            btnHoraires.Enabled = false;
            btnHoraires.FlatStyle = FlatStyle.Flat;
            btnHoraires.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHoraires.ForeColor = Color.White;
            btnHoraires.Location = new Point(12, 170);
            btnHoraires.Name = "btnHoraires";
            btnHoraires.Size = new Size(358, 52);
            btnHoraires.TabIndex = 68;
            btnHoraires.Text = "Voir les horaires";
            btnHoraires.UseVisualStyleBackColor = false;
            // 
            // cmbLignes
            // 
            cmbLignes.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLignes.ForeColor = Color.FromArgb(205, 33, 42);
            cmbLignes.FormattingEnabled = true;
            cmbLignes.Location = new Point(30, 119);
            cmbLignes.Name = "cmbLignes";
            cmbLignes.Size = new Size(186, 26);
            cmbLignes.TabIndex = 66;
            cmbLignes.Text = "Ligne n°";
            // 
            // btnRecherche
            // 
            btnRecherche.BackColor = Color.FromArgb(205, 33, 42);
            btnRecherche.Enabled = false;
            btnRecherche.FlatStyle = FlatStyle.Flat;
            btnRecherche.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecherche.ForeColor = Color.White;
            btnRecherche.Location = new Point(248, 119);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(92, 27);
            btnRecherche.TabIndex = 67;
            btnRecherche.Text = "Afficher";
            btnRecherche.UseVisualStyleBackColor = false;
            // 
            // Carte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 753);
            Controls.Add(picHome);
            Controls.Add(picLogo5);
            Controls.Add(picRetour);
            Controls.Add(picCroix);
            Controls.Add(btnHoraires);
            Controls.Add(cmbLignes);
            Controls.Add(btnRecherche);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Carte";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Carte du réseau";
            Load += carte_Load;
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCroix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picHome;
        private PictureBox picLogo5;
        private PictureBox picRetour;
        private PictureBox picCroix;
        private Button btnHoraires;
        private ComboBox cmbLignes;
        private Button btnRecherche;
    }
}