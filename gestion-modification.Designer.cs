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
            btnRetour = new Button();
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
            nudNumLigne = new NumericUpDown();
            txtNumero = new TextBox();
            txtNomLigne = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudNbStations).BeginInit();
            pnlGestionModification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumLigne).BeginInit();
            SuspendLayout();
            // 
            // cmbLigne
            // 
            cmbLigne.Enabled = false;
            cmbLigne.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            cmbLigne.ForeColor = Color.FromArgb(205, 33, 42);
            cmbLigne.FormattingEnabled = true;
            cmbLigne.Location = new Point(12, 197);
            cmbLigne.Name = "cmbLigne";
            cmbLigne.Size = new Size(197, 34);
            cmbLigne.TabIndex = 41;
            cmbLigne.Text = "Nom de la ligne";
            // 
            // lblModif
            // 
            lblModif.AutoSize = true;
            lblModif.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lblModif.ForeColor = Color.FromArgb(15, 93, 70);
            lblModif.Location = new Point(133, 116);
            lblModif.Name = "lblModif";
            lblModif.Size = new Size(104, 26);
            lblModif.TabIndex = 40;
            lblModif.Text = "Modification";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Impact", 18F);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(13, 65);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(335, 37);
            lblTitre.TabIndex = 39;
            lblTitre.Text = "Panneau de configuration";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 39);
            btnRetour.TabIndex = 38;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // lblIntitule
            // 
            lblIntitule.AutoSize = true;
            lblIntitule.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblIntitule.ForeColor = Color.FromArgb(15, 93, 70);
            lblIntitule.Location = new Point(12, 164);
            lblIntitule.Name = "lblIntitule";
            lblIntitule.Size = new Size(140, 22);
            lblIntitule.TabIndex = 42;
            lblIntitule.Text = "Intitulé de la ligne";
            // 
            // lblCouleur
            // 
            lblCouleur.AutoSize = true;
            lblCouleur.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblCouleur.ForeColor = Color.FromArgb(15, 93, 70);
            lblCouleur.Location = new Point(12, 271);
            lblCouleur.Name = "lblCouleur";
            lblCouleur.Size = new Size(145, 22);
            lblCouleur.TabIndex = 45;
            lblCouleur.Text = "Couleur de la ligne";
            lblCouleur.Click += lblCouleur_Click;
            // 
            // txtCouleur
            // 
            txtCouleur.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txtCouleur.ForeColor = Color.FromArgb(205, 33, 42);
            txtCouleur.Location = new Point(12, 303);
            txtCouleur.Name = "txtCouleur";
            txtCouleur.PlaceholderText = "Couleur";
            txtCouleur.Size = new Size(336, 34);
            txtCouleur.TabIndex = 46;
            // 
            // lblNbStations
            // 
            lblNbStations.AutoSize = true;
            lblNbStations.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblNbStations.ForeColor = Color.FromArgb(15, 93, 70);
            lblNbStations.Location = new Point(13, 364);
            lblNbStations.Name = "lblNbStations";
            lblNbStations.Size = new Size(155, 22);
            lblNbStations.TabIndex = 47;
            lblNbStations.Text = "Nombre de stations :";
            // 
            // nudNbStations
            // 
            nudNbStations.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            nudNbStations.ForeColor = Color.FromArgb(205, 33, 42);
            nudNbStations.Location = new Point(174, 361);
            nudNbStations.Name = "nudNbStations";
            nudNbStations.Size = new Size(63, 34);
            nudNbStations.TabIndex = 49;
            nudNbStations.ValueChanged += nudNbStations_ValueChanged;
            // 
            // lblNoms
            // 
            lblNoms.AutoSize = true;
            lblNoms.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblNoms.ForeColor = Color.FromArgb(15, 93, 70);
            lblNoms.Location = new Point(12, 418);
            lblNoms.Name = "lblNoms";
            lblNoms.Size = new Size(334, 22);
            lblNoms.TabIndex = 50;
            lblNoms.Text = "Nom des stations (cochez les deux terminus) :";
            // 
            // lblCoordonnees
            // 
            lblCoordonnees.AutoSize = true;
            lblCoordonnees.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblCoordonnees.ForeColor = Color.FromArgb(15, 93, 70);
            lblCoordonnees.Location = new Point(12, 591);
            lblCoordonnees.Name = "lblCoordonnees";
            lblCoordonnees.Size = new Size(234, 22);
            lblCoordonnees.TabIndex = 51;
            lblCoordonnees.Text = "Coordonnées GPS des stations :";
            // 
            // flpStations
            // 
            flpStations.AutoScroll = true;
            flpStations.Location = new Point(3, 458);
            flpStations.Name = "flpStations";
            flpStations.Size = new Size(355, 125);
            flpStations.TabIndex = 52;
            // 
            // flpCoordonnees
            // 
            flpCoordonnees.AutoScroll = true;
            flpCoordonnees.Location = new Point(3, 627);
            flpCoordonnees.Name = "flpCoordonnees";
            flpCoordonnees.Size = new Size(355, 125);
            flpCoordonnees.TabIndex = 53;
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblHoraires.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraires.Location = new Point(12, 832);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(169, 22);
            lblHoraires.TabIndex = 54;
            lblHoraires.Text = "Horaires des stations :";
            // 
            // rbDirectionA
            // 
            rbDirectionA.AutoSize = true;
            rbDirectionA.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            rbDirectionA.ForeColor = Color.FromArgb(205, 33, 42);
            rbDirectionA.Location = new Point(139, 857);
            rbDirectionA.Name = "rbDirectionA";
            rbDirectionA.Size = new Size(209, 30);
            rbDirectionA.TabIndex = 55;
            rbDirectionA.TabStop = true;
            rbDirectionA.Text = "Direction NomStation1";
            rbDirectionA.UseVisualStyleBackColor = true;
            // 
            // rbDirectionB
            // 
            rbDirectionB.AutoSize = true;
            rbDirectionB.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            rbDirectionB.ForeColor = Color.FromArgb(205, 33, 42);
            rbDirectionB.Location = new Point(139, 893);
            rbDirectionB.Name = "rbDirectionB";
            rbDirectionB.Size = new Size(209, 30);
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
            pnlGestionModification.Controls.Add(nudNumLigne);
            pnlGestionModification.Controls.Add(txtNumero);
            pnlGestionModification.Controls.Add(txtNomLigne);
            pnlGestionModification.Controls.Add(lblTitre);
            pnlGestionModification.Controls.Add(btnEnregistrement);
            pnlGestionModification.Controls.Add(btnRetour);
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
            // nudNumLigne
            // 
            nudNumLigne.Location = new Point(215, 197);
            nudNumLigne.Name = "nudNumLigne";
            nudNumLigne.Size = new Size(131, 27);
            nudNumLigne.TabIndex = 60;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txtNumero.ForeColor = Color.FromArgb(205, 33, 42);
            txtNumero.Location = new Point(215, 238);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numéro de ligne";
            txtNumero.Size = new Size(133, 34);
            txtNumero.TabIndex = 59;
            txtNumero.Visible = false;
            // 
            // txtNomLigne
            // 
            txtNomLigne.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txtNomLigne.ForeColor = Color.FromArgb(205, 33, 42);
            txtNomLigne.Location = new Point(13, 238);
            txtNomLigne.Name = "txtNomLigne";
            txtNomLigne.PlaceholderText = "Nom de votre ligne";
            txtNomLigne.Size = new Size(196, 34);
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
            Text = "Panneau de modification";
            Load += gestion_modification_Load;
            ((System.ComponentModel.ISupportInitialize)nudNbStations).EndInit();
            pnlGestionModification.ResumeLayout(false);
            pnlGestionModification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumLigne).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbLigne;
        private Label lblModif;
        private Label lblTitre;
        private Button btnRetour;
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
    }
}