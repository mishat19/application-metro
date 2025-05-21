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
            pnlGestionModification = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudNbStations).BeginInit();
            pnlGestionModification.SuspendLayout();
            SuspendLayout();
            // 
            // cmbLigne
            // 
            cmbLigne.FormattingEnabled = true;
            cmbLigne.Location = new Point(12, 197);
            cmbLigne.Name = "cmbLigne";
            cmbLigne.Size = new Size(197, 28);
            cmbLigne.TabIndex = 41;
            cmbLigne.Text = "Nom de la ligne";
            // 
            // lblModif
            // 
            lblModif.AutoSize = true;
            lblModif.Location = new Point(133, 116);
            lblModif.Name = "lblModif";
            lblModif.Size = new Size(94, 20);
            lblModif.TabIndex = 40;
            lblModif.Text = "Modification";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(13, 65);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(335, 38);
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
            lblIntitule.Location = new Point(12, 164);
            lblIntitule.Name = "lblIntitule";
            lblIntitule.Size = new Size(129, 20);
            lblIntitule.TabIndex = 42;
            lblIntitule.Text = "Intitulé de la ligne";
            // 
            // lblCouleur
            // 
            lblCouleur.AutoSize = true;
            lblCouleur.Location = new Point(12, 240);
            lblCouleur.Name = "lblCouleur";
            lblCouleur.Size = new Size(134, 20);
            lblCouleur.TabIndex = 45;
            lblCouleur.Text = "Couleur de la ligne";
            lblCouleur.Click += lblCouleur_Click;
            // 
            // txtCouleur
            // 
            txtCouleur.Location = new Point(12, 272);
            txtCouleur.Name = "txtCouleur";
            txtCouleur.Size = new Size(336, 27);
            txtCouleur.TabIndex = 46;
            // 
            // lblNbStations
            // 
            lblNbStations.AutoSize = true;
            lblNbStations.Location = new Point(13, 333);
            lblNbStations.Name = "lblNbStations";
            lblNbStations.Size = new Size(147, 20);
            lblNbStations.TabIndex = 47;
            lblNbStations.Text = "Nombre de stations :";
            // 
            // dudNumLigne
            // 
            dudNumLigne.Enabled = false;
            dudNumLigne.Location = new Point(215, 198);
            dudNumLigne.Name = "dudNumLigne";
            dudNumLigne.Size = new Size(133, 27);
            dudNumLigne.TabIndex = 48;
            dudNumLigne.Text = "Ligne N°";
            // 
            // nudNbStations
            // 
            nudNbStations.Location = new Point(166, 331);
            nudNbStations.Name = "nudNbStations";
            nudNbStations.Size = new Size(43, 27);
            nudNbStations.TabIndex = 49;
            // 
            // lblNoms
            // 
            lblNoms.AutoSize = true;
            lblNoms.Location = new Point(12, 387);
            lblNoms.Name = "lblNoms";
            lblNoms.Size = new Size(310, 20);
            lblNoms.TabIndex = 50;
            lblNoms.Text = "Nom des stations (cochez les deux terminus) :";
            // 
            // lblCoordonnees
            // 
            lblCoordonnees.AutoSize = true;
            lblCoordonnees.Location = new Point(12, 591);
            lblCoordonnees.Name = "lblCoordonnees";
            lblCoordonnees.Size = new Size(216, 20);
            lblCoordonnees.TabIndex = 51;
            lblCoordonnees.Text = "Coordonnées GPS des stations :";
            // 
            // flpStations
            // 
            flpStations.Location = new Point(12, 427);
            flpStations.Name = "flpStations";
            flpStations.Size = new Size(336, 125);
            flpStations.TabIndex = 52;
            // 
            // flpCoordonnees
            // 
            flpCoordonnees.Location = new Point(13, 627);
            flpCoordonnees.Name = "flpCoordonnees";
            flpCoordonnees.Size = new Size(335, 125);
            flpCoordonnees.TabIndex = 53;
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Location = new Point(12, 832);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(154, 20);
            lblHoraires.TabIndex = 54;
            lblHoraires.Text = "Horaires des stations :";
            // 
            // rbDirectionA
            // 
            rbDirectionA.AutoSize = true;
            rbDirectionA.Location = new Point(165, 862);
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
            rbDirectionB.Location = new Point(165, 892);
            rbDirectionB.Name = "rbDirectionB";
            rbDirectionB.Size = new Size(183, 24);
            rbDirectionB.TabIndex = 56;
            rbDirectionB.TabStop = true;
            rbDirectionB.Text = "Direction NomStation2";
            rbDirectionB.UseVisualStyleBackColor = true;
            // 
            // flpHoraires
            // 
            flpHoraires.Location = new Point(12, 932);
            flpHoraires.Name = "flpHoraires";
            flpHoraires.Size = new Size(336, 125);
            flpHoraires.TabIndex = 54;
            // 
            // btnEnregistrement
            // 
            btnEnregistrement.Enabled = false;
            btnEnregistrement.Location = new Point(222, 1167);
            btnEnregistrement.Name = "btnEnregistrement";
            btnEnregistrement.Size = new Size(126, 39);
            btnEnregistrement.TabIndex = 57;
            btnEnregistrement.Text = "Enregistrer";
            btnEnregistrement.UseVisualStyleBackColor = true;
            btnEnregistrement.Click += btnEnregistrement_Click;
            // 
            // pnlGestionModification
            // 
            pnlGestionModification.AutoScroll = true;
            pnlGestionModification.AutoScrollMinSize = new Size(0, 1300);
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
            pnlGestionModification.Controls.Add(dudNumLigne);
            pnlGestionModification.Controls.Add(lblNoms);
            pnlGestionModification.Controls.Add(nudNbStations);
            pnlGestionModification.Dock = DockStyle.Fill;
            pnlGestionModification.Location = new Point(0, 0);
            pnlGestionModification.Name = "pnlGestionModification";
            pnlGestionModification.Size = new Size(382, 753);
            pnlGestionModification.TabIndex = 58;
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
        private Panel pnlGestionModification;
    }
}