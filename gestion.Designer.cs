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
            picTrain2 = new PictureBox();
            lblErreur = new Label();
            picRetour = new PictureBox();
            picHome = new PictureBox();
            grpAjout = new GroupBox();
            pictureBox1 = new PictureBox();
            lblAjout = new Label();
            lblCreation = new Label();
            lblTitre = new Label();
            btnModif = new Button();
            btnSupp = new Button();
            lblGestion = new Label();
            cmbLigne = new ComboBox();
            cmbStation = new ComboBox();
            lblSelection = new Label();
            picFond2 = new PictureBox();
            pictureBox2 = new PictureBox();
            pnlGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTrain2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            grpAjout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlGestion
            // 
            pnlGestion.BackColor = Color.FromArgb(255, 230, 188);
            pnlGestion.Controls.Add(picTrain2);
            pnlGestion.Controls.Add(lblErreur);
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
            pnlGestion.Controls.Add(lblSelection);
            pnlGestion.Controls.Add(picFond2);
            pnlGestion.Controls.Add(pictureBox2);
            pnlGestion.Dock = DockStyle.Fill;
            pnlGestion.Location = new Point(0, 0);
            pnlGestion.Name = "pnlGestion";
            pnlGestion.Size = new Size(382, 753);
            pnlGestion.TabIndex = 41;
            pnlGestion.Paint += pnlGestion_Paint;
            // 
            // picTrain2
            // 
            picTrain2.BackColor = Color.Transparent;
            picTrain2.Controls.Add(lblErreur);
            picTrain2.Image = Properties.Resources.imgTrainRose2;
            picTrain2.Location = new Point(12, 462);
            picTrain2.Name = "picTrain2";
            picTrain2.Size = new Size(286, 53);
            picTrain2.SizeMode = PictureBoxSizeMode.Zoom;
            picTrain2.TabIndex = 65;
            picTrain2.TabStop = false;
            picTrain2.Visible = false;
            // 
            // lblErreur
            // 
            lblErreur.AutoSize = true;
            lblErreur.BackColor = Color.Transparent;
            lblErreur.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErreur.ForeColor = Color.FromArgb(15, 93, 70);
            lblErreur.Location = new Point(44, 477);
            lblErreur.Name = "lblErreur";
            lblErreur.Size = new Size(284, 22);
            lblErreur.TabIndex = 64;
            lblErreur.Text = "Veuillez choisir au moins une ligne";
            lblErreur.Visible = false;
            // 
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(0, 0);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(28, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 62;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // picHome
            // 
            picHome.Image = Properties.Resources.home;
            picHome.Location = new Point(34, 0);
            picHome.Name = "picHome";
            picHome.Size = new Size(27, 25);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 56;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // grpAjout
            // 
            grpAjout.Controls.Add(pictureBox1);
            grpAjout.Controls.Add(lblAjout);
            grpAjout.FlatStyle = FlatStyle.Flat;
            grpAjout.Location = new Point(14, 217);
            grpAjout.Name = "grpAjout";
            grpAjout.Size = new Size(358, 85);
            grpAjout.TabIndex = 44;
            grpAjout.TabStop = false;
            grpAjout.Paint += grpAjout_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.plus2;
            pictureBox1.Location = new Point(278, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblAjout
            // 
            lblAjout.AutoSize = true;
            lblAjout.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAjout.ForeColor = Color.FromArgb(205, 33, 42);
            lblAjout.Location = new Point(16, 30);
            lblAjout.Name = "lblAjout";
            lblAjout.Size = new Size(217, 22);
            lblAjout.TabIndex = 32;
            lblAjout.Text = "Ajouter une nouvelle ligne";
            // 
            // lblCreation
            // 
            lblCreation.AutoSize = true;
            lblCreation.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCreation.ForeColor = Color.FromArgb(15, 93, 70);
            lblCreation.Location = new Point(61, 156);
            lblCreation.Name = "lblCreation";
            lblCreation.Size = new Size(267, 26);
            lblCreation.TabIndex = 43;
            lblCreation.Text = "Création et modification de lignes";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(3, 120);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(356, 36);
            lblTitre.TabIndex = 42;
            lblTitre.Text = "Panneau de configuration";
            // 
            // btnModif
            // 
            btnModif.BackColor = Color.FromArgb(205, 33, 42);
            btnModif.FlatStyle = FlatStyle.Flat;
            btnModif.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnSupp.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            lblGestion.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline);
            lblGestion.ForeColor = Color.FromArgb(15, 93, 70);
            lblGestion.Location = new Point(14, 518);
            lblGestion.Name = "lblGestion";
            lblGestion.Size = new Size(82, 22);
            lblGestion.TabIndex = 49;
            lblGestion.Text = "Gestion :";
            // 
            // cmbLigne
            // 
            cmbLigne.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLigne.ForeColor = Color.FromArgb(205, 33, 42);
            cmbLigne.FormattingEnabled = true;
            cmbLigne.Location = new Point(14, 385);
            cmbLigne.Name = "cmbLigne";
            cmbLigne.Size = new Size(358, 26);
            cmbLigne.TabIndex = 48;
            cmbLigne.Text = "Choisir une ligne";
            cmbLigne.SelectedIndexChanged += cmbLigne_SelectedIndexChanged;
            // 
            // cmbStation
            // 
            cmbStation.Enabled = false;
            cmbStation.Font = new Font("Microsoft Sans Serif", 9F);
            cmbStation.ForeColor = Color.FromArgb(205, 33, 42);
            cmbStation.FormattingEnabled = true;
            cmbStation.Location = new Point(14, 429);
            cmbStation.Name = "cmbStation";
            cmbStation.Size = new Size(358, 26);
            cmbStation.TabIndex = 47;
            cmbStation.Text = "Choisir une station";
            cmbStation.SelectedIndexChanged += cmbStation_SelectedIndexChanged;
            // 
            // lblSelection
            // 
            lblSelection.AutoSize = true;
            lblSelection.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSelection.ForeColor = Color.FromArgb(15, 93, 70);
            lblSelection.Location = new Point(14, 341);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new Size(227, 22);
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo4;
            pictureBox2.Location = new Point(71, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(242, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
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
            StartPosition = FormStartPosition.CenterParent;
            Text = "Panneau de configuration";
            Load += gestion_Load;
            pnlGestion.ResumeLayout(false);
            pnlGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTrain2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            grpAjout.ResumeLayout(false);
            grpAjout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGestion;
        private GroupBox grpAjout;
        private Label lblAjout;
        private Label lblCreation;
        private Label lblTitre;
        private Button btnModif;
        private Button btnSupp;
        private Label lblGestion;
        private ComboBox cmbLigne;
        private ComboBox cmbStation;
        private Label lblSelection;
        private PictureBox picFond2;
        private PictureBox picHome;
        private PictureBox picRetour;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblErreur;
        private PictureBox picTrain2;
    }
}