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
            cmbLigne = new ComboBox();
            lblModif = new Label();
            lblTitre = new Label();
            lblIntitule = new Label();
            lblCouleur = new Label();
            txtCouleur = new TextBox();
            lblNbStations = new Label();
            nudNbStations = new NumericUpDown();
            lblNoms = new Label();
            lblCoordonnees = new Label();
            flpStations = new FlowLayoutPanel();
            flpCoordonnees = new FlowLayoutPanel();
            lblHoraires = new Label();
            rbDirectionA = new RadioButton();
            rbDirectionB = new RadioButton();
            flpHoraires = new FlowLayoutPanel();
            btnEnregistrement = new Button();
            pnlGestionModification = new Panel();
            picHome = new PictureBox();
            picRetour = new PictureBox();
            nudNumLigne = new NumericUpDown();
            txtNumero = new TextBox();
            txtNomLigne = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudNbStations).BeginInit();
            pnlGestionModification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumLigne).BeginInit();
            SuspendLayout();
            // 
            // cmbLigne
            // 
            cmbLigne.Enabled = false;
            cmbLigne.Font = new Font("DynaPuff", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLigne.ForeColor = Color.FromArgb(205, 33, 42);
            cmbLigne.FormattingEnabled = true;
            cmbLigne.Location = new Point(11, 197);
            cmbLigne.Name = "cmbLigne";
            cmbLigne.Size = new Size(225, 27);
            cmbLigne.TabIndex = 41;
            cmbLigne.Text = "Nom de la ligne";
            // 
            // lblModif
            // 
            lblModif.AutoSize = true;
            lblModif.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lblModif.ForeColor = Color.FromArgb(15, 93, 70);
            lblModif.Location = new Point(132, 122);
            lblModif.Name = "lblModif";
            lblModif.Size = new Size(104, 26);
            lblModif.TabIndex = 40;
            lblModif.Text = "Modification";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Gliker", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(24, 95);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(318, 27);
            lblTitre.TabIndex = 39;
            lblTitre.Text = "Panneau de configuration";
            // 
            // lblIntitule
            // 
            lblIntitule.AutoSize = true;
            lblIntitule.Font = new Font("Gliker", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblIntitule.ForeColor = Color.FromArgb(15, 93, 70);
            lblIntitule.Location = new Point(11, 164);
            lblIntitule.Name = "lblIntitule";
            lblIntitule.Size = new Size(161, 21);
            lblIntitule.TabIndex = 42;
            lblIntitule.Text = "Intitulé de la ligne";
            // 
            // lblCouleur
            // 
            lblCouleur.AutoSize = true;
            lblCouleur.Font = new Font("Gliker", 10.8F, FontStyle.Underline);
            lblCouleur.ForeColor = Color.FromArgb(15, 93, 70);
            lblCouleur.Location = new Point(3, 379);
            lblCouleur.Name = "lblCouleur";
            lblCouleur.Size = new Size(168, 21);
            lblCouleur.TabIndex = 45;
            lblCouleur.Text = "Couleur de la ligne";
            lblCouleur.Click += lblCouleur_Click;
            // 
            // txtCouleur
            // 
            txtCouleur.Font = new Font("DynaPuff", 9F);
            txtCouleur.ForeColor = Color.FromArgb(205, 33, 42);
            txtCouleur.Location = new Point(15, 427);
            txtCouleur.Margin = new Padding(3, 4, 3, 4);
            txtCouleur.Name = "txtCouleur";
            txtCouleur.PlaceholderText = "Couleur";
            txtCouleur.Size = new Size(340, 25);
            txtCouleur.TabIndex = 46;
            // 
            // lblNbStations
            // 
            lblNbStations.AutoSize = true;
            lblNbStations.Font = new Font("Gliker", 10.8F, FontStyle.Underline);
            lblNbStations.ForeColor = Color.FromArgb(15, 93, 70);
            lblNbStations.Location = new Point(14, 497);
            lblNbStations.Name = "lblNbStations";
            lblNbStations.Size = new Size(192, 21);
            lblNbStations.TabIndex = 47;
            lblNbStations.Text = "Nombre de stations :";
            // 
            // nudNbStations
            // 
            nudNbStations.Font = new Font("DynaPuff", 9F);
            nudNbStations.ForeColor = Color.FromArgb(205, 33, 42);
            nudNbStations.Location = new Point(246, 492);
            nudNbStations.Margin = new Padding(3, 4, 3, 4);
            nudNbStations.Name = "nudNbStations";
            nudNbStations.Size = new Size(72, 25);
            nudNbStations.TabIndex = 49;
            nudNbStations.ValueChanged += nudNbStations_ValueChanged;
            // 
            // lblNoms
            // 
            lblNoms.AutoSize = true;
            lblNoms.Font = new Font("Gliker", 10.8F, FontStyle.Underline);
            lblNoms.ForeColor = Color.FromArgb(15, 93, 70);
            lblNoms.Location = new Point(10, 560);
            lblNoms.Name = "lblNoms";
            lblNoms.Size = new Size(244, 42);
            lblNoms.TabIndex = 50;
            lblNoms.Text = "Nom des stations :\r\n(cochez les deux terminus)\r\n";
            // 
            // lblCoordonnees
            // 
            lblCoordonnees.AutoSize = true;
            lblCoordonnees.Font = new Font("Gliker", 10.8F, FontStyle.Underline);
            lblCoordonnees.ForeColor = Color.FromArgb(15, 93, 70);
            lblCoordonnees.Location = new Point(10, 833);
            lblCoordonnees.Name = "lblCoordonnees";
            lblCoordonnees.Size = new Size(291, 21);
            lblCoordonnees.TabIndex = 51;
            lblCoordonnees.Text = "Coordonnées GPS des stations :";
            // 
            // flpStations
            // 
            flpStations.AutoScroll = true;
            flpStations.Location = new Point(0, 644);
            flpStations.Margin = new Padding(3, 4, 3, 4);
            flpStations.Name = "flpStations";
            flpStations.Size = new Size(355, 125);
            flpStations.TabIndex = 52;
            // 
            // flpCoordonnees
            // 
            flpCoordonnees.AutoScroll = true;
            flpCoordonnees.Location = new Point(3, 896);
            flpCoordonnees.Margin = new Padding(3, 4, 3, 4);
            flpCoordonnees.Name = "flpCoordonnees";
            flpCoordonnees.Size = new Size(355, 125);
            flpCoordonnees.TabIndex = 53;
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Gliker", 10.8F, FontStyle.Underline);
            lblHoraires.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraires.Location = new Point(12, 803);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(207, 21);
            lblHoraires.TabIndex = 54;
            lblHoraires.Text = "Horaires des stations :";
            // 
            // rbDirectionA
            // 
            rbDirectionA.AutoSize = true;
            rbDirectionA.Font = new Font("DynaPuff", 9F);
            rbDirectionA.ForeColor = Color.FromArgb(205, 33, 42);
            rbDirectionA.Location = new Point(139, 857);
            rbDirectionA.Name = "rbDirectionA";
            rbDirectionA.Size = new Size(198, 23);
            rbDirectionA.TabIndex = 55;
            rbDirectionA.TabStop = true;
            rbDirectionA.Text = "Direction NomStation1";
            rbDirectionA.UseVisualStyleBackColor = true;
            // 
            // rbDirectionB
            // 
            rbDirectionB.AutoSize = true;
            rbDirectionB.Font = new Font("DynaPuff", 9F);
            rbDirectionB.ForeColor = Color.FromArgb(205, 33, 42);
            rbDirectionB.Location = new Point(139, 893);
            rbDirectionB.Name = "rbDirectionB";
            rbDirectionB.Size = new Size(200, 23);
            rbDirectionB.TabIndex = 56;
            rbDirectionB.TabStop = true;
            rbDirectionB.Text = "Direction NomStation2";
            rbDirectionB.UseVisualStyleBackColor = true;
            // 
            // flpHoraires
            // 
            flpHoraires.AutoScroll = true;
            flpHoraires.Location = new Point(3, 932);
            flpHoraires.Name = "flpHoraires";
            flpHoraires.Size = new Size(355, 125);
            flpHoraires.TabIndex = 54;
            // 
            // btnEnregistrement
            // 
            btnEnregistrement.BackColor = Color.FromArgb(205, 33, 42);
            btnEnregistrement.Enabled = false;
            btnEnregistrement.FlatStyle = FlatStyle.Flat;
            btnEnregistrement.Font = new Font("DynaPuff", 9F);
            btnEnregistrement.ForeColor = Color.White;
            btnEnregistrement.Location = new Point(222, 1167);
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
            pnlGestionModification.AutoScrollMinSize = new Size(0, 1300);
            pnlGestionModification.BackColor = Color.FromArgb(255, 230, 188);
            pnlGestionModification.Controls.Add(picHome);
            pnlGestionModification.Controls.Add(picRetour);
            pnlGestionModification.Controls.Add(nudNumLigne);
            pnlGestionModification.Controls.Add(txtNumero);
            pnlGestionModification.Controls.Add(txtNomLigne);
            pnlGestionModification.Controls.Add(lblTitre);
            pnlGestionModification.Controls.Add(btnEnregistrement);
            pnlGestionModification.Controls.Add(flpHoraires);
            pnlGestionModification.Controls.Add(lblModif);
            pnlGestionModification.Controls.Add(rbDirectionB);
            pnlGestionModification.Controls.Add(cmbLigne);
            pnlGestionModification.Controls.Add(rbDirectionA);
            pnlGestionModification.Controls.Add(lblIntitule);
            pnlGestionModification.Controls.Add(lblHoraires);
            pnlGestionModification.Controls.Add(lblCouleur);
            pnlGestionModification.Controls.Add(flpCoordonnees);
            pnlGestionModification.Controls.Add(txtCouleur);
            pnlGestionModification.Controls.Add(flpStations);
            pnlGestionModification.Controls.Add(lblNbStations);
            pnlGestionModification.Controls.Add(lblCoordonnees);
            pnlGestionModification.Controls.Add(lblNoms);
            pnlGestionModification.Controls.Add(nudNbStations);
            pnlGestionModification.Location = new Point(0, 0);
            pnlGestionModification.Name = "pnlGestionModification";
            pnlGestionModification.Size = new Size(382, 753);
            pnlGestionModification.TabIndex = 58;
            pnlGestionModification.Paint += pnlGestionModification_Paint;
            // 
            // picHome
            // 
            picHome.Image = Properties.Resources.home;
            picHome.Location = new Point(67, 12);
            picHome.Name = "picHome";
            picHome.Size = new Size(27, 25);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 62;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(10, 12);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(51, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 61;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // nudNumLigne
            // 
            nudNumLigne.Font = new Font("DynaPuff", 9F);
            nudNumLigne.ForeColor = Color.FromArgb(205, 33, 42);
            nudNumLigne.Location = new Point(215, 269);
            nudNumLigne.Margin = new Padding(3, 4, 3, 4);
            nudNumLigne.Name = "nudNumLigne";
            nudNumLigne.Size = new Size(140, 25);
            nudNumLigne.TabIndex = 60;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("DynaPuff", 9F);
            txtNumero.ForeColor = Color.FromArgb(205, 33, 42);
            txtNumero.Location = new Point(215, 237);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numéro de ligne";
            txtNumero.Size = new Size(140, 25);
            txtNumero.TabIndex = 59;
            txtNumero.Visible = false;
            // 
            // txtNomLigne
            // 
            txtNomLigne.Font = new Font("DynaPuff", 9F);
            txtNomLigne.ForeColor = Color.FromArgb(205, 33, 42);
            txtNomLigne.Location = new Point(13, 237);
            txtNomLigne.Name = "txtNomLigne";
            txtNomLigne.PlaceholderText = "Nom de votre ligne";
            txtNomLigne.Size = new Size(196, 25);
            txtNomLigne.TabIndex = 58;
            txtNomLigne.Visible = false;
            // 
            // Gestion_modification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 753);
            Controls.Add(pnlGestionModification);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Gestion_modification";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Panneau de modification";
            Load += gestion_modification_Load;
            ((System.ComponentModel.ISupportInitialize)nudNbStations).EndInit();
            pnlGestionModification.ResumeLayout(false);
            pnlGestionModification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumLigne).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbLigne;
        private Label lblModif;
        private Label lblTitre;
        private Label lblIntitule;
        private Label lblCouleur;
        private TextBox txtCouleur;
        private Label lblNbStations;
        private NumericUpDown nudNbStations;
        private Label lblNoms;
        private Label lblCoordonnees;
        private FlowLayoutPanel flpStations;
        private FlowLayoutPanel flpCoordonnees;
        private Label lblHoraires;
        private RadioButton rbDirectionA;
        private RadioButton rbDirectionB;
        private FlowLayoutPanel flpHoraires;
        private Button btnEnregistrement;
        private Panel pnlGestionModification;
        private TextBox txtNumero;
        private TextBox txtNomLigne;
        private NumericUpDown nudNumLigne;
        private PictureBox picRetour;
        private PictureBox picHome;
    }
}