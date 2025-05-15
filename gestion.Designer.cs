namespace application_metro
{
    partial class Gestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion));
            btnRetour = new Button();
            lblTitre = new Label();
            lblCreation = new Label();
            lblAjout = new Label();
            grpAjout = new GroupBox();
            picPlus = new PictureBox();
            lblSelection = new Label();
            cmbHoraire = new ComboBox();
            cmbStation = new ComboBox();
            cmbLigne = new ComboBox();
            lblGestion = new Label();
            btnSupp = new Button();
            btnModif = new Button();
            grpAjout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).BeginInit();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 39);
            btnRetour.TabIndex = 26;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(183, 65);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(444, 50);
            lblTitre.TabIndex = 27;
            lblTitre.Text = "Panneau de configuration";
            // 
            // lblCreation
            // 
            lblCreation.AutoSize = true;
            lblCreation.Location = new Point(90, 150);
            lblCreation.Name = "lblCreation";
            lblCreation.Size = new Size(129, 20);
            lblCreation.TabIndex = 31;
            lblCreation.Text = "Création de lignes";
            // 
            // lblAjout
            // 
            lblAjout.AutoSize = true;
            lblAjout.Location = new Point(190, 40);
            lblAjout.Name = "lblAjout";
            lblAjout.Size = new Size(183, 20);
            lblAjout.TabIndex = 32;
            lblAjout.Text = "Ajouter une nouvelle ligne";
            // 
            // grpAjout
            // 
            grpAjout.Controls.Add(picPlus);
            grpAjout.Controls.Add(lblAjout);
            grpAjout.Location = new Point(123, 192);
            grpAjout.Name = "grpAjout";
            grpAjout.Size = new Size(556, 85);
            grpAjout.TabIndex = 33;
            grpAjout.TabStop = false;
            // 
            // picPlus
            // 
            picPlus.Image = (Image)resources.GetObject("picPlus.Image");
            picPlus.Location = new Point(471, 17);
            picPlus.Name = "picPlus";
            picPlus.Size = new Size(59, 62);
            picPlus.SizeMode = PictureBoxSizeMode.CenterImage;
            picPlus.TabIndex = 33;
            picPlus.TabStop = false;
            // 
            // lblSelection
            // 
            lblSelection.AutoSize = true;
            lblSelection.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelection.Location = new Point(90, 327);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new Size(239, 25);
            lblSelection.TabIndex = 34;
            lblSelection.Text = "Sélectionner vos données :";
            // 
            // cmbHoraire
            // 
            cmbHoraire.Enabled = false;
            cmbHoraire.FormattingEnabled = true;
            cmbHoraire.Location = new Point(136, 452);
            cmbHoraire.Name = "cmbHoraire";
            cmbHoraire.Size = new Size(408, 28);
            cmbHoraire.TabIndex = 35;
            cmbHoraire.Text = "Choisir un horaire";
            // 
            // cmbStation
            // 
            cmbStation.Enabled = false;
            cmbStation.FormattingEnabled = true;
            cmbStation.Location = new Point(136, 408);
            cmbStation.Name = "cmbStation";
            cmbStation.Size = new Size(408, 28);
            cmbStation.TabIndex = 36;
            cmbStation.Text = "Choisir une station";
            // 
            // cmbLigne
            // 
            cmbLigne.FormattingEnabled = true;
            cmbLigne.Location = new Point(136, 360);
            cmbLigne.Name = "cmbLigne";
            cmbLigne.Size = new Size(408, 28);
            cmbLigne.TabIndex = 37;
            cmbLigne.Text = "Choisir une ligne";
            // 
            // lblGestion
            // 
            lblGestion.AutoSize = true;
            lblGestion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestion.Location = new Point(90, 504);
            lblGestion.Name = "lblGestion";
            lblGestion.Size = new Size(87, 25);
            lblGestion.TabIndex = 38;
            lblGestion.Text = "Gestion :";
            // 
            // btnSupp
            // 
            btnSupp.Location = new Point(401, 550);
            btnSupp.Name = "btnSupp";
            btnSupp.Size = new Size(126, 121);
            btnSupp.TabIndex = 39;
            btnSupp.Text = "Supprimer";
            btnSupp.UseVisualStyleBackColor = true;
            btnSupp.Click += btnSupp_Click;
            // 
            // btnModif
            // 
            btnModif.Location = new Point(205, 550);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(126, 121);
            btnModif.TabIndex = 40;
            btnModif.Text = "Modifier";
            btnModif.UseVisualStyleBackColor = true;
            btnModif.Click += btnModif_Click;
            // 
            // Gestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 700);
            Controls.Add(btnModif);
            Controls.Add(btnSupp);
            Controls.Add(lblGestion);
            Controls.Add(cmbLigne);
            Controls.Add(cmbStation);
            Controls.Add(cmbHoraire);
            Controls.Add(lblSelection);
            Controls.Add(grpAjout);
            Controls.Add(lblCreation);
            Controls.Add(lblTitre);
            Controls.Add(btnRetour);
            Name = "Gestion";
            Text = "Panneau de configuration";
            Load += gestion_Load;
            grpAjout.ResumeLayout(false);
            grpAjout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private Label lblTitre;
        private Label lblCreation;
        private Label lblAjout;
        private GroupBox grpAjout;
        private PictureBox picPlus;
        private Label lblSelection;
        private ComboBox cmbHoraire;
        private ComboBox cmbStation;
        private ComboBox cmbLigne;
        private Label lblGestion;
        private Button btnSupp;
        private Button btnModif;
    }
}