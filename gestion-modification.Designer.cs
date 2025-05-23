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
            cmbLigne.Location = new Point(10, 148);
            cmbLigne.Margin = new Padding(3, 2, 3, 2);
            cmbLigne.Name = "cmbLigne";
            cmbLigne.Size = new Size(173, 29);
            cmbLigne.TabIndex = 41;
            cmbLigne.Text = "Nom de la ligne";
            // 
            // lblModif
            // 
            lblModif.AutoSize = true;
            lblModif.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lblModif.ForeColor = Color.FromArgb(15, 93, 70);
            lblModif.Location = new Point(116, 87);
            lblModif.Name = "lblModif";
            lblModif.Size = new Size(83, 21);
            lblModif.TabIndex = 40;
            lblModif.Text = "Modification";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Impact", 18F);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(11, 49);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(266, 29);
            lblTitre.TabIndex = 39;
            lblTitre.Text = "Panneau de configuration";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(10, 9);
            btnRetour.Margin = new Padding(3, 2, 3, 2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(110, 29);
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
            lblIntitule.Location = new Point(10, 123);
            lblIntitule.Name = "lblIntitule";
            lblIntitule.Size = new Size(124, 19);
            lblIntitule.TabIndex = 42;
            lblIntitule.Text = "Intitulé de la ligne";
            // 
            // lblCouleur
            // 
            lblCouleur.AutoSize = true;
            lblCouleur.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblCouleur.ForeColor = Color.FromArgb(15, 93, 70);
            lblCouleur.Location = new Point(10, 203);
            lblCouleur.Name = "lblCouleur";
            lblCouleur.Size = new Size(127, 19);
            lblCouleur.TabIndex = 45;
            lblCouleur.Text = "Couleur de la ligne";
            lblCouleur.Click += lblCouleur_Click;
            // 
            // txtCouleur
            // 
            txtCouleur.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txtCouleur.ForeColor = Color.FromArgb(205, 33, 42);
            txtCouleur.Location = new Point(10, 227);
            txtCouleur.Margin = new Padding(3, 2, 3, 2);
            txtCouleur.Name = "txtCouleur";
            txtCouleur.PlaceholderText = "Couleur";
            txtCouleur.Size = new Size(294, 29);
            txtCouleur.TabIndex = 46;
            // 
            // lblNbStations
            // 
            lblNbStations.AutoSize = true;
            lblNbStations.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblNbStations.ForeColor = Color.FromArgb(15, 93, 70);
            lblNbStations.Location = new Point(11, 273);
            lblNbStations.Name = "lblNbStations";
            lblNbStations.Size = new Size(138, 19);
            lblNbStations.TabIndex = 47;
            lblNbStations.Text = "Nombre de stations :";
            // 
            // nudNbStations
            // 
            nudNbStations.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            nudNbStations.ForeColor = Color.FromArgb(205, 33, 42);
            nudNbStations.Location = new Point(152, 271);
            nudNbStations.Margin = new Padding(3, 2, 3, 2);
            nudNbStations.Name = "nudNbStations";
            nudNbStations.Size = new Size(55, 29);
            nudNbStations.TabIndex = 49;
            nudNbStations.ValueChanged += nudNbStations_ValueChanged;
            // 
            // lblNoms
            // 
            lblNoms.AutoSize = true;
            lblNoms.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblNoms.ForeColor = Color.FromArgb(15, 93, 70);
            lblNoms.Location = new Point(10, 314);
            lblNoms.Name = "lblNoms";
            lblNoms.Size = new Size(296, 19);
            lblNoms.TabIndex = 50;
            lblNoms.Text = "Nom des stations (cochez les deux terminus) :";
            // 
            // lblCoordonnees
            // 
            lblCoordonnees.AutoSize = true;
            lblCoordonnees.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblCoordonnees.ForeColor = Color.FromArgb(15, 93, 70);
            lblCoordonnees.Location = new Point(10, 443);
            lblCoordonnees.Name = "lblCoordonnees";
            lblCoordonnees.Size = new Size(207, 19);
            lblCoordonnees.TabIndex = 51;
            lblCoordonnees.Text = "Coordonnées GPS des stations :";
            // 
            // flpStations
            // 
            flpStations.AutoScroll = true;
            flpStations.Location = new Point(3, 344);
            flpStations.Margin = new Padding(3, 2, 3, 2);
            flpStations.Name = "flpStations";
            flpStations.Size = new Size(311, 94);
            flpStations.TabIndex = 52;
            // 
            // flpCoordonnees
            // 
            flpCoordonnees.AutoScroll = true;
            flpCoordonnees.Location = new Point(3, 470);
            flpCoordonnees.Margin = new Padding(3, 2, 3, 2);
            flpCoordonnees.Name = "flpCoordonnees";
            flpCoordonnees.Size = new Size(311, 94);
            flpCoordonnees.TabIndex = 53;
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblHoraires.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraires.Location = new Point(10, 624);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(149, 19);
            lblHoraires.TabIndex = 54;
            lblHoraires.Text = "Horaires des stations :";
            // 
            // rbDirectionA
            // 
            rbDirectionA.AutoSize = true;
            rbDirectionA.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            rbDirectionA.ForeColor = Color.FromArgb(205, 33, 42);
            rbDirectionA.Location = new Point(122, 643);
            rbDirectionA.Margin = new Padding(3, 2, 3, 2);
            rbDirectionA.Name = "rbDirectionA";
            rbDirectionA.Size = new Size(171, 25);
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
            rbDirectionB.Location = new Point(122, 670);
            rbDirectionB.Margin = new Padding(3, 2, 3, 2);
            rbDirectionB.Name = "rbDirectionB";
            rbDirectionB.Size = new Size(171, 25);
            rbDirectionB.TabIndex = 56;
            rbDirectionB.TabStop = true;
            rbDirectionB.Text = "Direction NomStation2";
            rbDirectionB.UseVisualStyleBackColor = true;
            // 
            // flpHoraires
            // 
            flpHoraires.AutoScroll = true;
            flpHoraires.Location = new Point(3, 699);
            flpHoraires.Margin = new Padding(3, 2, 3, 2);
            flpHoraires.Name = "flpHoraires";
            flpHoraires.Size = new Size(311, 94);
            flpHoraires.TabIndex = 54;
            // 
            // btnEnregistrement
            // 
            btnEnregistrement.BackColor = Color.FromArgb(205, 33, 42);
            btnEnregistrement.Enabled = false;
            btnEnregistrement.FlatStyle = FlatStyle.Flat;
            btnEnregistrement.ForeColor = Color.White;
            btnEnregistrement.Location = new Point(194, 875);
            btnEnregistrement.Margin = new Padding(3, 2, 3, 2);
            btnEnregistrement.Name = "btnEnregistrement";
            btnEnregistrement.Size = new Size(110, 29);
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
            pnlGestionModification.Margin = new Padding(3, 2, 3, 2);
            pnlGestionModification.Name = "pnlGestionModification";
            pnlGestionModification.Size = new Size(334, 565);
            pnlGestionModification.TabIndex = 58;
            pnlGestionModification.Paint += pnlGestionModification_Paint;
            // 
            // nudNumLigne
            // 
            nudNumLigne.Location = new Point(188, 148);
            nudNumLigne.Margin = new Padding(3, 2, 3, 2);
            nudNumLigne.Name = "nudNumLigne";
            nudNumLigne.Size = new Size(115, 23);
            nudNumLigne.TabIndex = 60;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txtNumero.ForeColor = Color.FromArgb(205, 33, 42);
            txtNumero.Location = new Point(188, 178);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numéro de ligne";
            txtNumero.Size = new Size(117, 29);
            txtNumero.TabIndex = 59;
            txtNumero.Visible = false;
            // 
            // txtNomLigne
            // 
            txtNomLigne.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txtNomLigne.ForeColor = Color.FromArgb(205, 33, 42);
            txtNomLigne.Location = new Point(11, 178);
            txtNomLigne.Margin = new Padding(3, 2, 3, 2);
            txtNomLigne.Name = "txtNomLigne";
            txtNomLigne.PlaceholderText = "Nom de votre ligne";
            txtNomLigne.Size = new Size(172, 29);
            txtNomLigne.TabIndex = 58;
            txtNomLigne.Visible = false;
            // 
            // Gestion_modification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 565);
            Controls.Add(pnlGestionModification);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
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