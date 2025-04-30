namespace application_metro
{
    partial class gestion_modification
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
            dudNumLigne = new DomainUpDown();
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
            ((System.ComponentModel.ISupportInitialize)nudNbStations).BeginInit();
            SuspendLayout();
            // 
            // cmbLigne
            // 
            cmbLigne.Enabled = false;
            cmbLigne.FormattingEnabled = true;
            cmbLigne.Location = new Point(77, 206);
            cmbLigne.Name = "cmbLigne";
            cmbLigne.Size = new Size(321, 28);
            cmbLigne.TabIndex = 41;
            cmbLigne.Text = "Nom de la ligne";
            // 
            // lblModif
            // 
            lblModif.AutoSize = true;
            lblModif.Location = new Point(344, 124);
            lblModif.Name = "lblModif";
            lblModif.Size = new Size(94, 20);
            lblModif.TabIndex = 40;
            lblModif.Text = "Modification";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(181, 74);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(444, 50);
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
            // 
            // lblIntitule
            // 
            lblIntitule.AutoSize = true;
            lblIntitule.Location = new Point(77, 173);
            lblIntitule.Name = "lblIntitule";
            lblIntitule.Size = new Size(129, 20);
            lblIntitule.TabIndex = 42;
            lblIntitule.Text = "Intitulé de la ligne";
            // 
            // lblCouleur
            // 
            lblCouleur.AutoSize = true;
            lblCouleur.Location = new Point(77, 249);
            lblCouleur.Name = "lblCouleur";
            lblCouleur.Size = new Size(134, 20);
            lblCouleur.TabIndex = 45;
            lblCouleur.Text = "Couleur de la ligne";
            // 
            // txtCouleur
            // 
            txtCouleur.Location = new Point(77, 282);
            txtCouleur.Name = "txtCouleur";
            txtCouleur.Size = new Size(321, 27);
            txtCouleur.TabIndex = 46;
            txtCouleur.Text = "Couleur";
            // 
            // lblNbStations
            // 
            lblNbStations.AutoSize = true;
            lblNbStations.Location = new Point(77, 337);
            lblNbStations.Name = "lblNbStations";
            lblNbStations.Size = new Size(140, 20);
            lblNbStations.TabIndex = 47;
            lblNbStations.Text = "Nombre de stations";
            // 
            // dudNumLigne
            // 
            dudNumLigne.Enabled = false;
            dudNumLigne.Location = new Point(492, 206);
            dudNumLigne.Name = "dudNumLigne";
            dudNumLigne.Size = new Size(150, 27);
            dudNumLigne.TabIndex = 48;
            dudNumLigne.Text = "Ligne N°";
            // 
            // nudNbStations
            // 
            nudNbStations.Location = new Point(232, 335);
            nudNbStations.Name = "nudNbStations";
            nudNbStations.Size = new Size(43, 27);
            nudNbStations.TabIndex = 49;
            // 
            // lblNoms
            // 
            lblNoms.AutoSize = true;
            lblNoms.Location = new Point(77, 396);
            lblNoms.Name = "lblNoms";
            lblNoms.Size = new Size(310, 20);
            lblNoms.TabIndex = 50;
            lblNoms.Text = "Nom des stations (cochez les deux terminus) :";
            // 
            // lblCoordonnees
            // 
            lblCoordonnees.AutoSize = true;
            lblCoordonnees.Location = new Point(77, 585);
            lblCoordonnees.Name = "lblCoordonnees";
            lblCoordonnees.Size = new Size(216, 20);
            lblCoordonnees.TabIndex = 51;
            lblCoordonnees.Text = "Coordonnées GPS des stations :";
            // 
            // flpStations
            // 
            flpStations.Location = new Point(131, 436);
            flpStations.Name = "flpStations";
            flpStations.Size = new Size(511, 125);
            flpStations.TabIndex = 52;
            // 
            // flpCoordonnees
            // 
            flpCoordonnees.Location = new Point(131, 623);
            flpCoordonnees.Name = "flpCoordonnees";
            flpCoordonnees.Size = new Size(511, 125);
            flpCoordonnees.TabIndex = 53;
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Location = new Point(77, 774);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(154, 20);
            lblHoraires.TabIndex = 54;
            lblHoraires.Text = "Horaires des stations :";
            // 
            // rbDirectionA
            // 
            rbDirectionA.AutoSize = true;
            rbDirectionA.Location = new Point(525, 774);
            rbDirectionA.Name = "rbDirectionA";
            rbDirectionA.Size = new Size(183, 24);
            rbDirectionA.TabIndex = 55;
            rbDirectionA.TabStop = true;
            rbDirectionA.Text = "Direction NomStation1";
            rbDirectionA.UseVisualStyleBackColor = true;
            // 
            // rbDirectionB
            // 
            rbDirectionB.AutoSize = true;
            rbDirectionB.Location = new Point(525, 804);
            rbDirectionB.Name = "rbDirectionB";
            rbDirectionB.Size = new Size(183, 24);
            rbDirectionB.TabIndex = 56;
            rbDirectionB.TabStop = true;
            rbDirectionB.Text = "Direction NomStation2";
            rbDirectionB.UseVisualStyleBackColor = true;
            // 
            // flpHoraires
            // 
            flpHoraires.Location = new Point(131, 844);
            flpHoraires.Name = "flpHoraires";
            flpHoraires.Size = new Size(511, 125);
            flpHoraires.TabIndex = 54;
            // 
            // btnEnregistrement
            // 
            btnEnregistrement.Location = new Point(516, 1004);
            btnEnregistrement.Name = "btnEnregistrement";
            btnEnregistrement.Size = new Size(126, 39);
            btnEnregistrement.TabIndex = 57;
            btnEnregistrement.Text = "Enregistrer";
            btnEnregistrement.UseVisualStyleBackColor = true;
            // 
            // gestion_modification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1055);
            Controls.Add(btnEnregistrement);
            Controls.Add(flpHoraires);
            Controls.Add(rbDirectionB);
            Controls.Add(rbDirectionA);
            Controls.Add(lblHoraires);
            Controls.Add(flpCoordonnees);
            Controls.Add(flpStations);
            Controls.Add(lblCoordonnees);
            Controls.Add(lblNoms);
            Controls.Add(nudNbStations);
            Controls.Add(dudNumLigne);
            Controls.Add(lblNbStations);
            Controls.Add(txtCouleur);
            Controls.Add(lblCouleur);
            Controls.Add(lblIntitule);
            Controls.Add(cmbLigne);
            Controls.Add(lblModif);
            Controls.Add(lblTitre);
            Controls.Add(btnRetour);
            Name = "gestion_modification";
            Text = "gestion_modification";
            ((System.ComponentModel.ISupportInitialize)nudNbStations).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DomainUpDown dudNumLigne;
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
    }
}