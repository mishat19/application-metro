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
            pnlGestion = new Panel();
            picRetour = new PictureBox();
            picHome = new PictureBox();
            grpAjout = new GroupBox();
            picPlus = new PictureBox();
            lblAjout = new Label();
            lblCreation = new Label();
            lblTitre = new Label();
            btnModif = new Button();
            btnSupp = new Button();
            lblGestion = new Label();
            cmbLigne = new ComboBox();
            cmbStation = new ComboBox();
            cmbHoraire = new ComboBox();
            lblSelection = new Label();
            picFond2 = new PictureBox();
            pnlGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            grpAjout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).BeginInit();
            SuspendLayout();
            // 
            // pnlGestion
            // 
            pnlGestion.BackColor = Color.FromArgb(255, 230, 188);
            pnlGestion.Controls.Add(picRetour);
            pnlGestion.Controls.Add(picHome);
            pnlGestion.Controls.Add(grpAjout);
            pnlGestion.Controls.Add(lblCreation);
            pnlGestion.Controls.Add(lblTitre);
            pnlGestion.Controls.Add(btnModif);
            pnlGestion.Controls.Add(btnSupp);
            pnlGestion.Controls.Add(lblGestion);
            pnlGestion.Controls.Add(cmbLigne);
            pnlGestion.Controls.Add(cmbStation);
            pnlGestion.Controls.Add(cmbHoraire);
            pnlGestion.Controls.Add(lblSelection);
            pnlGestion.Controls.Add(picFond2);
            pnlGestion.Dock = DockStyle.Fill;
            pnlGestion.Location = new Point(0, 0);
            pnlGestion.Name = "pnlGestion";
            pnlGestion.Size = new Size(382, 753);
            pnlGestion.TabIndex = 41;
            // 
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(0, 3);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(51, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 62;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // picHome
            // 
            picHome.Image = Properties.Resources.home;
            picHome.Location = new Point(47, 3);
            picHome.Name = "picHome";
            picHome.Size = new Size(27, 25);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 56;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // grpAjout
            // 
            grpAjout.Controls.Add(picPlus);
            grpAjout.Controls.Add(lblAjout);
            grpAjout.Location = new Point(14, 205);
            grpAjout.Name = "grpAjout";
            grpAjout.Size = new Size(358, 85);
            grpAjout.TabIndex = 44;
            grpAjout.TabStop = false;
            // 
            // picPlus
            // 
            picPlus.Cursor = Cursors.Hand;
            picPlus.Image = (Image)resources.GetObject("picPlus.Image");
            picPlus.Location = new Point(299, 17);
            picPlus.Name = "picPlus";
            picPlus.Size = new Size(59, 62);
            picPlus.SizeMode = PictureBoxSizeMode.CenterImage;
            picPlus.TabIndex = 33;
            picPlus.TabStop = false;
            picPlus.Click += picPlus_Click;
            // 
            // lblAjout
            // 
            lblAjout.AutoSize = true;
            lblAjout.Font = new Font("DynaPuff", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAjout.ForeColor = Color.FromArgb(205, 33, 42);
            lblAjout.Location = new Point(6, 35);
            lblAjout.Name = "lblAjout";
            lblAjout.Size = new Size(247, 23);
            lblAjout.TabIndex = 32;
            lblAjout.Text = "Ajouter une nouvelle ligne";
            // 
            // lblCreation
            // 
            lblCreation.AutoSize = true;
            lblCreation.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCreation.ForeColor = Color.FromArgb(15, 93, 70);
            lblCreation.Location = new Point(61, 130);
            lblCreation.Name = "lblCreation";
            lblCreation.Size = new Size(267, 26);
            lblCreation.TabIndex = 43;
            lblCreation.Text = "Création et modification de lignes";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Gliker", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(1, 94);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(380, 36);
            lblTitre.TabIndex = 42;
            lblTitre.Text = "Panneau de configuration";
            // 
            // btnModif
            // 
            btnModif.BackColor = Color.FromArgb(205, 33, 42);
            btnModif.FlatStyle = FlatStyle.Flat;
            btnModif.Font = new Font("Gliker", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModif.ForeColor = Color.White;
            btnModif.Location = new Point(26, 567);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(162, 161);
            btnModif.TabIndex = 51;
            btnModif.Text = "MODIFIER";
            btnModif.UseVisualStyleBackColor = false;
            btnModif.Click += btnModif_Click;
            // 
            // btnSupp
            // 
            btnSupp.BackColor = Color.FromArgb(205, 33, 42);
            btnSupp.FlatStyle = FlatStyle.Flat;
            btnSupp.Font = new Font("Gliker", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupp.ForeColor = Color.White;
            btnSupp.Location = new Point(199, 567);
            btnSupp.Name = "btnSupp";
            btnSupp.Size = new Size(162, 161);
            btnSupp.TabIndex = 50;
            btnSupp.Text = "SUPPRIMER";
            btnSupp.UseVisualStyleBackColor = false;
            btnSupp.Click += btnSupp_Click;
            // 
            // lblGestion
            // 
            lblGestion.AutoSize = true;
            lblGestion.Font = new Font("Impact", 10.8F, FontStyle.Underline);
            lblGestion.ForeColor = Color.FromArgb(15, 93, 70);
            lblGestion.Location = new Point(14, 526);
            lblGestion.Name = "lblGestion";
            lblGestion.Size = new Size(72, 22);
            lblGestion.TabIndex = 49;
            lblGestion.Text = "Gestion :";
            // 
            // cmbLigne
            // 
            cmbLigne.Font = new Font("DynaPuff", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLigne.ForeColor = Color.FromArgb(205, 33, 42);
            cmbLigne.FormattingEnabled = true;
            cmbLigne.Location = new Point(14, 385);
            cmbLigne.Name = "cmbLigne";
            cmbLigne.Size = new Size(358, 27);
            cmbLigne.TabIndex = 48;
            cmbLigne.Text = "Choisir une ligne";
            cmbLigne.SelectedIndexChanged += cmbLigne_SelectedIndexChanged;
            // 
            // cmbStation
            // 
            cmbStation.Enabled = false;
            cmbStation.Font = new Font("DynaPuff", 9F);
            cmbStation.ForeColor = Color.FromArgb(205, 33, 42);
            cmbStation.FormattingEnabled = true;
            cmbStation.Location = new Point(14, 429);
            cmbStation.Name = "cmbStation";
            cmbStation.Size = new Size(358, 27);
            cmbStation.TabIndex = 47;
            cmbStation.Text = "Choisir une station";
            cmbStation.SelectedIndexChanged += cmbStation_SelectedIndexChanged;
            // 
            // cmbHoraire
            // 
            cmbHoraire.Enabled = false;
            cmbHoraire.Font = new Font("DynaPuff", 9F);
            cmbHoraire.ForeColor = Color.FromArgb(205, 33, 42);
            cmbHoraire.FormattingEnabled = true;
            cmbHoraire.Location = new Point(14, 472);
            cmbHoraire.Name = "cmbHoraire";
            cmbHoraire.Size = new Size(358, 27);
            cmbHoraire.TabIndex = 46;
            cmbHoraire.Text = "Choisir un horaire";
            cmbHoraire.SelectedIndexChanged += cmbHoraire_SelectedIndexChanged;
            // 
            // lblSelection
            // 
            lblSelection.AutoSize = true;
            lblSelection.Font = new Font("Impact", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSelection.ForeColor = Color.FromArgb(15, 93, 70);
            lblSelection.Location = new Point(10, 337);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new Size(202, 22);
            lblSelection.TabIndex = 45;
            lblSelection.Text = "Sélectionner vos données :";
            // 
            // picFond2
            // 
            picFond2.Image = Properties.Resources.imgFondMilan1;
            picFond2.Location = new Point(-477, 266);
            picFond2.Name = "picFond2";
            picFond2.Size = new Size(872, 552);
            picFond2.SizeMode = PictureBoxSizeMode.Zoom;
            picFond2.TabIndex = 52;
            picFond2.TabStop = false;
            // 
            // Gestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 753);
            Controls.Add(pnlGestion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Gestion";
            Text = "Panneau de configuration";
            Load += gestion_Load;
            pnlGestion.ResumeLayout(false);
            pnlGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            grpAjout.ResumeLayout(false);
            grpAjout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGestion;
        private GroupBox grpAjout;
        private PictureBox picPlus;
        private Label lblAjout;
        private Label lblCreation;
        private Label lblTitre;
        private Button btnModif;
        private Button btnSupp;
        private Label lblGestion;
        private ComboBox cmbLigne;
        private ComboBox cmbStation;
        private ComboBox cmbHoraire;
        private Label lblSelection;
        private PictureBox picFond2;
        private PictureBox picHome;
        private PictureBox picRetour;
    }
}