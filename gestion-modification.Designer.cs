namespace application_metro
{
    partial class Gestion_modification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_modification));
            lblModif = new Label();
            lblTitre = new Label();
            lblNoms = new Label();
            lblCoordonnees = new Label();
            lblHoraires = new Label();
            btnEnregistrement = new Button();
            pnlGestionModification = new Panel();
            flpHoraires = new FlowLayoutPanel();
            lblPremier = new Label();
            dtp_HoraireDebut = new DateTimePicker();
            lblDernier = new Label();
            dtp_HoraireFin = new DateTimePicker();
            grpHorairesStations = new GroupBox();
            lblDuree = new Label();
            grpCoordonnees = new GroupBox();
            flpCoordonnees = new FlowLayoutPanel();
            grpNomStations = new GroupBox();
            flpStations = new FlowLayoutPanel();
            grpModif = new GroupBox();
            nudNumLigne = new NumericUpDown();
            txtNumero = new TextBox();
            txtNomLigne = new TextBox();
            cmbLigne = new ComboBox();
            lblIntitule = new Label();
            lblCouleur = new Label();
            txtCouleur = new TextBox();
            lblNbStations = new Label();
            nudNbStations = new NumericUpDown();
            picHome = new PictureBox();
            picRetour = new PictureBox();
            picFond2 = new PictureBox();
            pnlGestionModification.SuspendLayout();
            flpHoraires.SuspendLayout();
            grpCoordonnees.SuspendLayout();
            grpNomStations.SuspendLayout();
            grpModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumLigne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNbStations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).BeginInit();
            SuspendLayout();
            // 
            // lblModif
            // 
            lblModif.AutoSize = true;
            lblModif.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lblModif.ForeColor = Color.FromArgb(15, 93, 70);
            lblModif.Location = new Point(112, 93);
            lblModif.Name = "lblModif";
            lblModif.Size = new Size(83, 21);
            lblModif.TabIndex = 40;
            lblModif.Text = "Modification";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(21, 71);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(250, 24);
            lblTitre.TabIndex = 39;
            lblTitre.Text = "Panneau de configuration";
            // 
            // lblNoms
            // 
            lblNoms.AutoSize = true;
            lblNoms.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblNoms.ForeColor = Color.FromArgb(15, 93, 70);
            lblNoms.Location = new Point(21, 330);
            lblNoms.Name = "lblNoms";
            lblNoms.Size = new Size(133, 18);
            lblNoms.TabIndex = 50;
            lblNoms.Text = "Nom des stations :";
            // 
            // lblCoordonnees
            // 
            lblCoordonnees.AutoSize = true;
            lblCoordonnees.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblCoordonnees.ForeColor = Color.FromArgb(15, 93, 70);
            lblCoordonnees.Location = new Point(21, 542);
            lblCoordonnees.Name = "lblCoordonnees";
            lblCoordonnees.Size = new Size(227, 18);
            lblCoordonnees.TabIndex = 51;
            lblCoordonnees.Text = "Coordonnées GPS des stations :";
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblHoraires.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraires.Location = new Point(21, 753);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(157, 18);
            lblHoraires.TabIndex = 54;
            lblHoraires.Text = "Horaires des stations :";
            // 
            // btnEnregistrement
            // 
            btnEnregistrement.BackColor = Color.FromArgb(205, 33, 42);
            btnEnregistrement.Enabled = false;
            btnEnregistrement.FlatStyle = FlatStyle.Flat;
            btnEnregistrement.Font = new Font("Microsoft Sans Serif", 9F);
            btnEnregistrement.ForeColor = Color.White;
            btnEnregistrement.Location = new Point(192, 882);
            btnEnregistrement.Margin = new Padding(3, 2, 3, 2);
            btnEnregistrement.Name = "btnEnregistrement";
            btnEnregistrement.Size = new Size(112, 29);
            btnEnregistrement.TabIndex = 57;
            btnEnregistrement.Text = "Enregistrer";
            btnEnregistrement.UseVisualStyleBackColor = false;
            btnEnregistrement.Click += btnEnregistrement_Click;
            // 
            // pnlGestionModification
            // 
            pnlGestionModification.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlGestionModification.AutoScroll = true;
            pnlGestionModification.AutoScrollMinSize = new Size(0, 1500);
            pnlGestionModification.BackColor = Color.FromArgb(255, 230, 188);
            pnlGestionModification.Controls.Add(flpHoraires);
            pnlGestionModification.Controls.Add(grpHorairesStations);
            pnlGestionModification.Controls.Add(lblDuree);
            pnlGestionModification.Controls.Add(grpCoordonnees);
            pnlGestionModification.Controls.Add(grpNomStations);
            pnlGestionModification.Controls.Add(grpModif);
            pnlGestionModification.Controls.Add(picHome);
            pnlGestionModification.Controls.Add(picRetour);
            pnlGestionModification.Controls.Add(lblHoraires);
            pnlGestionModification.Controls.Add(lblTitre);
            pnlGestionModification.Controls.Add(btnEnregistrement);
            pnlGestionModification.Controls.Add(lblModif);
            pnlGestionModification.Controls.Add(lblCoordonnees);
            pnlGestionModification.Controls.Add(lblNoms);
            pnlGestionModification.Controls.Add(picFond2);
            pnlGestionModification.Location = new Point(0, 0);
            pnlGestionModification.Margin = new Padding(3, 2, 3, 2);
            pnlGestionModification.Name = "pnlGestionModification";
            pnlGestionModification.Size = new Size(334, 566);
            pnlGestionModification.TabIndex = 58;
            // 
            // flpHoraires
            // 
            flpHoraires.AutoScroll = true;
            flpHoraires.Controls.Add(lblPremier);
            flpHoraires.Controls.Add(dtp_HoraireDebut);
            flpHoraires.Controls.Add(lblDernier);
            flpHoraires.Controls.Add(dtp_HoraireFin);
            flpHoraires.Location = new Point(16, 806);
            flpHoraires.Margin = new Padding(3, 2, 3, 2);
            flpHoraires.Name = "flpHoraires";
            flpHoraires.Size = new Size(283, 56);
            flpHoraires.TabIndex = 55;
            // 
            // lblPremier
            // 
            lblPremier.AutoSize = true;
            lblPremier.ForeColor = Color.FromArgb(15, 93, 70);
            lblPremier.Location = new Point(3, 0);
            lblPremier.Name = "lblPremier";
            lblPremier.Size = new Size(156, 15);
            lblPremier.TabIndex = 0;
            lblPremier.Text = "Premier passage de la ligne :";
            // 
            // dtp_HoraireDebut
            // 
            dtp_HoraireDebut.CalendarForeColor = Color.FromArgb(205, 33, 42);
            dtp_HoraireDebut.CalendarMonthBackground = Color.FromArgb(205, 33, 42);
            dtp_HoraireDebut.CalendarTitleBackColor = Color.FromArgb(205, 33, 42);
            dtp_HoraireDebut.CalendarTitleForeColor = Color.FromArgb(205, 33, 42);
            dtp_HoraireDebut.CalendarTrailingForeColor = Color.FromArgb(205, 33, 42);
            dtp_HoraireDebut.Format = DateTimePickerFormat.Time;
            dtp_HoraireDebut.Location = new Point(165, 2);
            dtp_HoraireDebut.Margin = new Padding(3, 2, 3, 2);
            dtp_HoraireDebut.Name = "dtp_HoraireDebut";
            dtp_HoraireDebut.ShowUpDown = true;
            dtp_HoraireDebut.Size = new Size(89, 23);
            dtp_HoraireDebut.TabIndex = 1;
            // 
            // lblDernier
            // 
            lblDernier.AutoSize = true;
            lblDernier.ForeColor = Color.FromArgb(15, 93, 70);
            lblDernier.Location = new Point(3, 27);
            lblDernier.Name = "lblDernier";
            lblDernier.Size = new Size(153, 15);
            lblDernier.TabIndex = 2;
            lblDernier.Text = "Dernier passage de la ligne :";
            // 
            // dtp_HoraireFin
            // 
            dtp_HoraireFin.Format = DateTimePickerFormat.Time;
            dtp_HoraireFin.Location = new Point(162, 29);
            dtp_HoraireFin.Margin = new Padding(3, 2, 3, 2);
            dtp_HoraireFin.Name = "dtp_HoraireFin";
            dtp_HoraireFin.ShowUpDown = true;
            dtp_HoraireFin.Size = new Size(91, 23);
            dtp_HoraireFin.TabIndex = 3;
            // 
            // grpHorairesStations
            // 
            grpHorairesStations.Location = new Point(10, 784);
            grpHorairesStations.Margin = new Padding(3, 2, 3, 2);
            grpHorairesStations.Name = "grpHorairesStations";
            grpHorairesStations.Padding = new Padding(3, 2, 3, 2);
            grpHorairesStations.Size = new Size(293, 94);
            grpHorairesStations.TabIndex = 70;
            grpHorairesStations.TabStop = false;
            grpHorairesStations.Paint += grpHorairesStations_Paint;
            // 
            // lblDuree
            // 
            lblDuree.AutoSize = true;
            lblDuree.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblDuree.ForeColor = Color.FromArgb(15, 93, 70);
            lblDuree.Location = new Point(232, 330);
            lblDuree.Name = "lblDuree";
            lblDuree.Size = new Size(56, 18);
            lblDuree.TabIndex = 69;
            lblDuree.Text = "Durée :";
            // 
            // grpCoordonnees
            // 
            grpCoordonnees.Controls.Add(flpCoordonnees);
            grpCoordonnees.Location = new Point(10, 571);
            grpCoordonnees.Margin = new Padding(3, 2, 3, 2);
            grpCoordonnees.Name = "grpCoordonnees";
            grpCoordonnees.Padding = new Padding(3, 2, 3, 2);
            grpCoordonnees.Size = new Size(293, 173);
            grpCoordonnees.TabIndex = 68;
            grpCoordonnees.TabStop = false;
            grpCoordonnees.Paint += grpCoordonnees_Paint;
            // 
            // flpCoordonnees
            // 
            flpCoordonnees.AutoScroll = true;
            flpCoordonnees.Location = new Point(5, 4);
            flpCoordonnees.Name = "flpCoordonnees";
            flpCoordonnees.Size = new Size(283, 164);
            flpCoordonnees.TabIndex = 54;
            // 
            // grpNomStations
            // 
            grpNomStations.Controls.Add(flpStations);
            grpNomStations.Location = new Point(10, 356);
            grpNomStations.Margin = new Padding(3, 2, 3, 2);
            grpNomStations.Name = "grpNomStations";
            grpNomStations.Padding = new Padding(3, 2, 3, 2);
            grpNomStations.Size = new Size(293, 173);
            grpNomStations.TabIndex = 67;
            grpNomStations.TabStop = false;
            grpNomStations.Paint += grpNomStations_Paint;
            // 
            // flpStations
            // 
            flpStations.AutoScroll = true;
            flpStations.Location = new Point(5, 4);
            flpStations.Name = "flpStations";
            flpStations.Size = new Size(283, 164);
            flpStations.TabIndex = 53;
            // 
            // grpModif
            // 
            grpModif.Controls.Add(nudNumLigne);
            grpModif.Controls.Add(txtNumero);
            grpModif.Controls.Add(txtNomLigne);
            grpModif.Controls.Add(cmbLigne);
            grpModif.Controls.Add(lblIntitule);
            grpModif.Controls.Add(lblCouleur);
            grpModif.Controls.Add(txtCouleur);
            grpModif.Controls.Add(lblNbStations);
            grpModif.Controls.Add(nudNbStations);
            grpModif.Location = new Point(12, 131);
            grpModif.Margin = new Padding(3, 2, 3, 2);
            grpModif.Name = "grpModif";
            grpModif.Padding = new Padding(3, 2, 3, 2);
            grpModif.Size = new Size(291, 188);
            grpModif.TabIndex = 66;
            grpModif.TabStop = false;
            grpModif.Paint += grpModif_Paint;
            // 
            // nudNumLigne
            // 
            nudNumLigne.Font = new Font("Microsoft Sans Serif", 9F);
            nudNumLigne.ForeColor = Color.FromArgb(205, 33, 42);
            nudNumLigne.Location = new Point(163, 47);
            nudNumLigne.Name = "nudNumLigne";
            nudNumLigne.Size = new Size(117, 21);
            nudNumLigne.TabIndex = 69;
            nudNumLigne.ValueChanged += txtNomLigne_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Microsoft Sans Serif", 9F);
            txtNumero.ForeColor = Color.FromArgb(205, 33, 42);
            txtNumero.Location = new Point(160, 46);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numéro de ligne";
            txtNumero.Size = new Size(120, 21);
            txtNumero.TabIndex = 68;
            txtNumero.Text = "Entrer du texte...";
            txtNumero.Visible = false;
            // 
            // txtNomLigne
            // 
            txtNomLigne.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomLigne.ForeColor = Color.FromArgb(205, 33, 42);
            txtNomLigne.Location = new Point(9, 48);
            txtNomLigne.Margin = new Padding(3, 2, 3, 2);
            txtNomLigne.Name = "txtNomLigne";
            txtNomLigne.PlaceholderText = "Nom de votre ligne";
            txtNomLigne.Size = new Size(144, 21);
            txtNomLigne.TabIndex = 67;
            txtNomLigne.Visible = false;
            // 
            // cmbLigne
            // 
            cmbLigne.Enabled = false;
            cmbLigne.Font = new Font("Microsoft Sans Serif", 9F);
            cmbLigne.ForeColor = Color.FromArgb(205, 33, 42);
            cmbLigne.FormattingEnabled = true;
            cmbLigne.Location = new Point(9, 46);
            cmbLigne.Margin = new Padding(3, 2, 3, 2);
            cmbLigne.Name = "cmbLigne";
            cmbLigne.Size = new Size(146, 23);
            cmbLigne.TabIndex = 61;
            cmbLigne.Text = "Nom de la ligne";
            // 
            // lblIntitule
            // 
            lblIntitule.AutoSize = true;
            lblIntitule.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblIntitule.ForeColor = Color.FromArgb(15, 93, 70);
            lblIntitule.Location = new Point(8, 17);
            lblIntitule.Name = "lblIntitule";
            lblIntitule.Size = new Size(126, 18);
            lblIntitule.TabIndex = 62;
            lblIntitule.Text = "Intitulé de la ligne :";
            // 
            // lblCouleur
            // 
            lblCouleur.AutoSize = true;
            lblCouleur.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblCouleur.ForeColor = Color.FromArgb(15, 93, 70);
            lblCouleur.Location = new Point(8, 81);
            lblCouleur.Name = "lblCouleur";
            lblCouleur.Size = new Size(137, 18);
            lblCouleur.TabIndex = 63;
            lblCouleur.Text = "Couleur de la ligne :";
            // 
            // txtCouleur
            // 
            txtCouleur.Font = new Font("Microsoft Sans Serif", 9F);
            txtCouleur.ForeColor = Color.FromArgb(205, 33, 42);
            txtCouleur.Location = new Point(9, 113);
            txtCouleur.Name = "txtCouleur";
            txtCouleur.PlaceholderText = "Couleur";
            txtCouleur.Size = new Size(272, 21);
            txtCouleur.TabIndex = 64;
            txtCouleur.TabStop = false;
            txtCouleur.TextChanged += txtCouleur_TextChanged;
            // 
            // lblNbStations
            // 
            lblNbStations.AutoSize = true;
            lblNbStations.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblNbStations.ForeColor = Color.FromArgb(15, 93, 70);
            lblNbStations.Location = new Point(9, 155);
            lblNbStations.Name = "lblNbStations";
            lblNbStations.Size = new Size(146, 18);
            lblNbStations.TabIndex = 65;
            lblNbStations.Text = "Nombre de stations :";
            // 
            // nudNbStations
            // 
            nudNbStations.Font = new Font("Microsoft Sans Serif", 9F);
            nudNbStations.ForeColor = Color.FromArgb(205, 33, 42);
            nudNbStations.Location = new Point(211, 154);
            nudNbStations.Name = "nudNbStations";
            nudNbStations.Size = new Size(69, 21);
            nudNbStations.TabIndex = 66;
            nudNbStations.ValueChanged += nudNbStations_ValueChanged;
            // 
            // picHome
            // 
            picHome.Image = Properties.Resources.home;
            picHome.Location = new Point(31, 0);
            picHome.Margin = new Padding(3, 2, 3, 2);
            picHome.Name = "picHome";
            picHome.Size = new Size(24, 19);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 65;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(0, 0);
            picRetour.Margin = new Padding(3, 2, 3, 2);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(25, 19);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 64;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // picFond2
            // 
            picFond2.Image = Properties.Resources.logo4;
            picFond2.Location = new Point(104, 9);
            picFond2.Margin = new Padding(3, 2, 3, 2);
            picFond2.Name = "picFond2";
            picFond2.Size = new Size(99, 72);
            picFond2.SizeMode = PictureBoxSizeMode.Zoom;
            picFond2.TabIndex = 63;
            picFond2.TabStop = false;
            // 
            // Gestion_modification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 565);
            Controls.Add(pnlGestionModification);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Gestion_modification";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Panneau de configuration";
            Load += gestion_modification_Load;
            pnlGestionModification.ResumeLayout(false);
            pnlGestionModification.PerformLayout();
            flpHoraires.ResumeLayout(false);
            flpHoraires.PerformLayout();
            grpCoordonnees.ResumeLayout(false);
            grpNomStations.ResumeLayout(false);
            grpModif.ResumeLayout(false);
            grpModif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumLigne).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNbStations).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblModif;
        private Label lblTitre;
        private Label lblNoms;
        private Label lblCoordonnees;
        private Label lblHoraires;
        private Button btnEnregistrement;
        private Panel pnlGestionModification;
        private PictureBox picFond2;
        private PictureBox picRetour;
        private PictureBox picHome;
        private GroupBox grpModif;
        private NumericUpDown nudNumLigne;
        private TextBox txtNumero;
        private TextBox txtNomLigne;
        private ComboBox cmbLigne;
        private Label lblIntitule;
        private Label lblCouleur;
        private TextBox txtCouleur;
        private Label lblNbStations;
        private NumericUpDown nudNbStations;
        private GroupBox grpNomStations;
        private FlowLayoutPanel flpStations;
        private GroupBox grpCoordonnees;
        private FlowLayoutPanel flpCoordonnees;
        private Label lblDuree;
        private GroupBox grpHorairesStations;
        private FlowLayoutPanel flpHoraires;
        private Label lblPremier;
        private DateTimePicker dtp_HoraireDebut;
        private Label lblDernier;
        private DateTimePicker dtp_HoraireFin;
    }
}