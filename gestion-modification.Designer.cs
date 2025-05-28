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
            cmbLigne = new ComboBox();
            lblModif = new Label();
            lblTitre = new Label();
            lblIntitule = new Label();
            lblCouleur = new Label();
            txtCouleur = new PlaceholderTextBox();
            lblNbStations = new Label();
            nudNbStations = new NumericUpDown();
            lblNoms = new Label();
            lblCoordonnees = new Label();
            flpStations = new FlowLayoutPanel();
            flpCoordonnees = new FlowLayoutPanel();
            lblHoraires = new Label();
            flpHoraires = new FlowLayoutPanel();
            label1 = new Label();
            dtp_HoraireDebut = new DateTimePicker();
            label2 = new Label();
            dtp_HoraireFin = new DateTimePicker();
            btnEnregistrement = new Button();
            pnlGestionModification = new Panel();
            picHome = new PictureBox();
            picRetour = new PictureBox();
            nudNumLigne = new NumericUpDown();
            txtNumero = new PlaceholderTextBox();
            txtNomLigne = new PlaceholderTextBox();
            picFond2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudNbStations).BeginInit();
            flpHoraires.SuspendLayout();
            pnlGestionModification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumLigne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).BeginInit();
            SuspendLayout();
            // 
            // cmbLigne
            // 
            cmbLigne.Enabled = false;
            cmbLigne.Font = new Font("Microsoft Sans Serif", 9F);
            cmbLigne.ForeColor = Color.FromArgb(205, 33, 42);
            cmbLigne.FormattingEnabled = true;
            cmbLigne.Location = new Point(11, 197);
            cmbLigne.Name = "cmbLigne";
            cmbLigne.Size = new Size(178, 26);
            cmbLigne.TabIndex = 41;
            cmbLigne.Text = "Nom de la ligne";
            // 
            // lblModif
            // 
            lblModif.AutoSize = true;
            lblModif.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lblModif.ForeColor = Color.FromArgb(15, 93, 70);
            lblModif.Location = new Point(129, 124);
            lblModif.Name = "lblModif";
            lblModif.Size = new Size(104, 26);
            lblModif.TabIndex = 40;
            lblModif.Text = "Modification";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(24, 95);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(310, 29);
            lblTitre.TabIndex = 39;
            lblTitre.Text = "Panneau de configuration";
            // 
            // lblIntitule
            // 
            lblIntitule.AutoSize = true;
            lblIntitule.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblIntitule.ForeColor = Color.FromArgb(15, 93, 70);
            lblIntitule.Location = new Point(11, 164);
            lblIntitule.Name = "lblIntitule";
            lblIntitule.Size = new Size(149, 22);
            lblIntitule.TabIndex = 42;
            lblIntitule.Text = "Intitulé de la ligne";
            // 
            // lblCouleur
            // 
            lblCouleur.AutoSize = true;
            lblCouleur.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblCouleur.ForeColor = Color.FromArgb(15, 93, 70);
            lblCouleur.Location = new Point(11, 245);
            lblCouleur.Name = "lblCouleur";
            lblCouleur.Size = new Size(160, 22);
            lblCouleur.TabIndex = 45;
            lblCouleur.Text = "Couleur de la ligne";
            lblCouleur.Click += lblCouleur_Click;
            // 
            // txtCouleur
            // 
            txtCouleur.Font = new Font("Microsoft Sans Serif", 9F);
            txtCouleur.ForeColor = Color.FromArgb(205, 33, 42);
            txtCouleur.Location = new Point(11, 299);
            txtCouleur.Margin = new Padding(3, 4, 3, 4);
            txtCouleur.Name = "txtCouleur";
            txtCouleur.PlaceholderColor = Color.FromArgb(205, 33, 42);
            txtCouleur.PlaceholderText = "Couleur";
            txtCouleur.Size = new Size(336, 24);
            txtCouleur.TabIndex = 46;
            txtCouleur.TabStop = false;
            txtCouleur.Text = "Couleur";
            txtCouleur.TextChanged += txtCouleur_TextChanged;
            // 
            // lblNbStations
            // 
            lblNbStations.AutoSize = true;
            lblNbStations.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblNbStations.ForeColor = Color.FromArgb(15, 93, 70);
            lblNbStations.Location = new Point(12, 355);
            lblNbStations.Name = "lblNbStations";
            lblNbStations.Size = new Size(175, 22);
            lblNbStations.TabIndex = 47;
            lblNbStations.Text = "Nombre de stations :";
            // 
            // nudNbStations
            // 
            nudNbStations.Font = new Font("Microsoft Sans Serif", 9F);
            nudNbStations.ForeColor = Color.FromArgb(205, 33, 42);
            nudNbStations.Location = new Point(196, 353);
            nudNbStations.Margin = new Padding(3, 4, 3, 4);
            nudNbStations.Name = "nudNbStations";
            nudNbStations.Size = new Size(79, 24);
            nudNbStations.TabIndex = 49;
            nudNbStations.ValueChanged += nudNbStations_ValueChanged;
            // 
            // lblNoms
            // 
            lblNoms.AutoSize = true;
            lblNoms.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblNoms.ForeColor = Color.FromArgb(15, 93, 70);
            lblNoms.Location = new Point(12, 412);
            lblNoms.Name = "lblNoms";
            lblNoms.Size = new Size(158, 22);
            lblNoms.TabIndex = 50;
            lblNoms.Text = "Nom des stations :";
            // 
            // lblCoordonnees
            // 
            lblCoordonnees.AutoSize = true;
            lblCoordonnees.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblCoordonnees.ForeColor = Color.FromArgb(15, 93, 70);
            lblCoordonnees.Location = new Point(11, 712);
            lblCoordonnees.Name = "lblCoordonnees";
            lblCoordonnees.Size = new Size(272, 22);
            lblCoordonnees.TabIndex = 51;
            lblCoordonnees.Text = "Coordonnées GPS des stations :";
            // 
            // flpStations
            // 
            flpStations.AutoScroll = true;
            flpStations.Location = new Point(11, 481);
            flpStations.Margin = new Padding(3, 4, 3, 4);
            flpStations.Name = "flpStations";
            flpStations.Size = new Size(336, 215);
            flpStations.TabIndex = 52;
            flpStations.Paint += flpStations_Paint;
            // 
            // flpCoordonnees
            // 
            flpCoordonnees.AutoScroll = true;
            flpCoordonnees.Location = new Point(11, 765);
            flpCoordonnees.Margin = new Padding(3, 4, 3, 4);
            flpCoordonnees.Name = "flpCoordonnees";
            flpCoordonnees.Size = new Size(334, 215);
            flpCoordonnees.TabIndex = 53;
            flpCoordonnees.Paint += flpCoordonnees_Paint;
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblHoraires.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraires.Location = new Point(11, 1003);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(189, 22);
            lblHoraires.TabIndex = 54;
            lblHoraires.Text = "Horaires des stations :";
            lblHoraires.Click += lblHoraires_Click;
            // 
            // flpHoraires
            // 
            flpHoraires.AutoScroll = true;
            flpHoraires.Controls.Add(label1);
            flpHoraires.Controls.Add(dtp_HoraireDebut);
            flpHoraires.Controls.Add(label2);
            flpHoraires.Controls.Add(dtp_HoraireFin);
            flpHoraires.Location = new Point(11, 1049);
            flpHoraires.Name = "flpHoraires";
            flpHoraires.Size = new Size(335, 125);
            flpHoraires.TabIndex = 54;
            flpHoraires.Paint += flpHoraires_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Premier passage de la ligne";
            // 
            // dtp_HoraireDebut
            // 
            dtp_HoraireDebut.Format = DateTimePickerFormat.Time;
            dtp_HoraireDebut.Location = new Point(201, 3);
            dtp_HoraireDebut.Name = "dtp_HoraireDebut";
            dtp_HoraireDebut.ShowUpDown = true;
            dtp_HoraireDebut.Size = new Size(101, 27);
            dtp_HoraireDebut.TabIndex = 1;
            dtp_HoraireDebut.ValueChanged += dtp_HoraireDebut_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 2;
            label2.Text = "Dernier passage de la ligne";
            // 
            // dtp_HoraireFin
            // 
            dtp_HoraireFin.Format = DateTimePickerFormat.Time;
            dtp_HoraireFin.Location = new Point(199, 36);
            dtp_HoraireFin.Name = "dtp_HoraireFin";
            dtp_HoraireFin.ShowUpDown = true;
            dtp_HoraireFin.Size = new Size(103, 27);
            dtp_HoraireFin.TabIndex = 3;
            dtp_HoraireFin.ValueChanged += dtp_HoraireFin_ValueChanged;
            // 
            // btnEnregistrement
            // 
            btnEnregistrement.BackColor = Color.FromArgb(205, 33, 42);
            btnEnregistrement.FlatStyle = FlatStyle.Flat;
            btnEnregistrement.Font = new Font("Microsoft Sans Serif", 9F);
            btnEnregistrement.ForeColor = Color.White;
            btnEnregistrement.Location = new Point(218, 1189);
            btnEnregistrement.Name = "btnEnregistrement";
            btnEnregistrement.Size = new Size(126, 39);
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
            pnlGestionModification.Controls.Add(picHome);
            pnlGestionModification.Controls.Add(picRetour);
            pnlGestionModification.Controls.Add(lblHoraires);
            pnlGestionModification.Controls.Add(nudNumLigne);
            pnlGestionModification.Controls.Add(txtNumero);
            pnlGestionModification.Controls.Add(txtNomLigne);
            pnlGestionModification.Controls.Add(lblTitre);
            pnlGestionModification.Controls.Add(btnEnregistrement);
            pnlGestionModification.Controls.Add(flpHoraires);
            pnlGestionModification.Controls.Add(lblModif);
            pnlGestionModification.Controls.Add(cmbLigne);
            pnlGestionModification.Controls.Add(lblIntitule);
            pnlGestionModification.Controls.Add(lblCouleur);
            pnlGestionModification.Controls.Add(flpCoordonnees);
            pnlGestionModification.Controls.Add(txtCouleur);
            pnlGestionModification.Controls.Add(flpStations);
            pnlGestionModification.Controls.Add(lblNbStations);
            pnlGestionModification.Controls.Add(lblCoordonnees);
            pnlGestionModification.Controls.Add(lblNoms);
            pnlGestionModification.Controls.Add(nudNbStations);
            pnlGestionModification.Controls.Add(picFond2);
            pnlGestionModification.Location = new Point(0, 0);
            pnlGestionModification.Name = "pnlGestionModification";
            pnlGestionModification.Size = new Size(382, 754);
            pnlGestionModification.TabIndex = 58;
            pnlGestionModification.Paint += pnlGestionModification_Paint;
            // 
            // picHome
            // 
            picHome.Image = Properties.Resources.home;
            picHome.Location = new Point(57, 0);
            picHome.Name = "picHome";
            picHome.Size = new Size(27, 25);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 65;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(0, 0);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(51, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 64;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // nudNumLigne
            // 
            nudNumLigne.Font = new Font("Microsoft Sans Serif", 9F);
            nudNumLigne.ForeColor = Color.FromArgb(205, 33, 42);
            nudNumLigne.Location = new Point(196, 198);
            nudNumLigne.Margin = new Padding(3, 4, 3, 4);
            nudNumLigne.Name = "nudNumLigne";
            nudNumLigne.Size = new Size(150, 24);
            nudNumLigne.TabIndex = 60;
            nudNumLigne.ValueChanged += nudNumLigne_ValueChanged;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Microsoft Sans Serif", 9F);
            txtNumero.ForeColor = Color.FromArgb(205, 33, 42);
            txtNumero.Location = new Point(196, 199);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderColor = Color.FromArgb(205, 33, 42);
            txtNumero.PlaceholderText = "Numéro de ligne";
            txtNumero.Size = new Size(151, 24);
            txtNumero.TabIndex = 59;
            txtNumero.Text = "Entrer du texte...";
            txtNumero.Visible = false;
            // 
            // txtNomLigne
            // 
            txtNomLigne.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomLigne.ForeColor = Color.FromArgb(205, 33, 42);
            txtNomLigne.Location = new Point(12, 199);
            txtNomLigne.Name = "txtNomLigne";
            txtNomLigne.PlaceholderColor = Color.FromArgb(205, 33, 42);
            txtNomLigne.PlaceholderText = "Nom de votre ligne";
            txtNomLigne.Size = new Size(176, 24);
            txtNomLigne.TabIndex = 58;
            txtNomLigne.Text = "Nom de votre ligne";
            txtNomLigne.Visible = false;
            // 
            // picFond2
            // 
            picFond2.Image = Properties.Resources.logo4;
            picFond2.Location = new Point(129, 3);
            picFond2.Name = "picFond2";
            picFond2.Size = new Size(113, 96);
            picFond2.SizeMode = PictureBoxSizeMode.Zoom;
            picFond2.TabIndex = 63;
            picFond2.TabStop = false;
            // 
            // Gestion_modification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 753);
            Controls.Add(pnlGestionModification);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Gestion_modification";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Panneau de configuration";
            Load += gestion_modification_Load;
            ((System.ComponentModel.ISupportInitialize)nudNbStations).EndInit();
            flpHoraires.ResumeLayout(false);
            flpHoraires.PerformLayout();
            pnlGestionModification.ResumeLayout(false);
            pnlGestionModification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumLigne).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbLigne;
        private Label lblModif;
        private Label lblTitre;
        private Label lblIntitule;
        private Label lblCouleur;
        private PlaceholderTextBox txtCouleur;
        private Label lblNbStations;
        private NumericUpDown nudNbStations;
        private Label lblNoms;
        private Label lblCoordonnees;
        private FlowLayoutPanel flpStations;
        private FlowLayoutPanel flpCoordonnees;
        private Label lblHoraires;
        private FlowLayoutPanel flpHoraires;
        private Button btnEnregistrement;
        private Panel pnlGestionModification;
        private PlaceholderTextBox txtNumero;
        private PlaceholderTextBox txtNomLigne;
        private NumericUpDown nudNumLigne;
        private PictureBox picFond2;
        private PictureBox picRetour;
        private PictureBox picHome;
        private Label label1;
        private DateTimePicker dtp_HoraireDebut;
        private Label label2;
        private DateTimePicker dtp_HoraireFin;
    }
}