namespace application_metro
{
    partial class Recherche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recherche));
            grpTrajet = new GroupBox();
            btnDetails = new Button();
            lblDuree = new Label();
            lblLigne = new Label();
            lblSeparation2 = new Label();
            lblHeureArrivee = new Label();
            picPlus = new PictureBox();
            lblHeureDepart = new Label();
            lblSeparation = new Label();
            lblStationArrivee = new Label();
            lblStationDepart = new Label();
            lblTrajet = new Label();
            btnRecherche = new Button();
            dtpArrivee = new DateTimePicker();
            dtpDepart = new DateTimePicker();
            lblHoraireArrivée = new Label();
            lblHoraireDepart = new Label();
            lblHoraires = new Label();
            cmbArrivee = new ComboBox();
            lblArrivee = new Label();
            cmbDepart = new ComboBox();
            lblDepart = new Label();
            lblTitre = new Label();
            pnlRecherche = new Panel();
            grpRecherche = new GroupBox();
            flpResultat = new FlowLayoutPanel();
            grpResultat = new GroupBox();
            btnDetails1 = new Button();
            lblTemps = new Label();
            lblNumLigneResultat = new Label();
            lblNumLigne = new Label();
            lblTempsArrivee = new Label();
            lblTempsDepart = new Label();
            lblArrivee2 = new Label();
            lblDépart = new Label();
            picVoirPlus = new PictureBox();
            picHome = new PictureBox();
            picRetour = new PictureBox();
            grpTrajet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).BeginInit();
            pnlRecherche.SuspendLayout();
            grpRecherche.SuspendLayout();
            flpResultat.SuspendLayout();
            grpResultat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVoirPlus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            SuspendLayout();
            // 
            // grpTrajet
            // 
            grpTrajet.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            grpTrajet.Controls.Add(btnDetails);
            grpTrajet.Controls.Add(lblDuree);
            grpTrajet.Controls.Add(lblLigne);
            grpTrajet.Controls.Add(lblSeparation2);
            grpTrajet.Controls.Add(lblHeureArrivee);
            grpTrajet.Controls.Add(picPlus);
            grpTrajet.Controls.Add(lblHeureDepart);
            grpTrajet.Controls.Add(lblSeparation);
            grpTrajet.Controls.Add(lblStationArrivee);
            grpTrajet.Controls.Add(lblStationDepart);
            grpTrajet.Location = new Point(12, 9341);
            grpTrajet.Name = "grpTrajet";
            grpTrajet.Size = new Size(171, 282);
            grpTrajet.TabIndex = 16;
            grpTrajet.TabStop = false;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.FromArgb(205, 33, 42);
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnDetails.ForeColor = Color.White;
            btnDetails.Location = new Point(105, 179);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(126, 28);
            btnDetails.TabIndex = 17;
            btnDetails.Text = "Détails";
            btnDetails.UseVisualStyleBackColor = false;
            // 
            // lblDuree
            // 
            lblDuree.AutoSize = true;
            lblDuree.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDuree.ForeColor = Color.FromArgb(205, 33, 42);
            lblDuree.Location = new Point(275, 127);
            lblDuree.Name = "lblDuree";
            lblDuree.Size = new Size(58, 22);
            lblDuree.TabIndex = 24;
            lblDuree.Text = "40min";
            // 
            // lblLigne
            // 
            lblLigne.AutoSize = true;
            lblLigne.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLigne.ForeColor = Color.FromArgb(205, 33, 42);
            lblLigne.Location = new Point(0, 127);
            lblLigne.Name = "lblLigne";
            lblLigne.Size = new Size(74, 22);
            lblLigne.TabIndex = 23;
            lblLigne.Text = "N°Ligne";
            lblLigne.Click += label15_Click;
            // 
            // lblSeparation2
            // 
            lblSeparation2.AutoSize = true;
            lblSeparation2.Location = new Point(160, 62);
            lblSeparation2.Name = "lblSeparation2";
            lblSeparation2.Size = new Size(31, 20);
            lblSeparation2.TabIndex = 22;
            lblSeparation2.Text = "-->";
            // 
            // lblHeureArrivee
            // 
            lblHeureArrivee.AutoSize = true;
            lblHeureArrivee.Font = new Font("Microsoft Sans Serif", 7.79999971F);
            lblHeureArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            lblHeureArrivee.Location = new Point(197, 62);
            lblHeureArrivee.Name = "lblHeureArrivee";
            lblHeureArrivee.Size = new Size(89, 16);
            lblHeureArrivee.TabIndex = 21;
            lblHeureArrivee.Text = "Heure arrivée";
            // 
            // picPlus
            // 
            picPlus.Image = (Image)resources.GetObject("picPlus.Image");
            picPlus.Location = new Point(143, 223);
            picPlus.Name = "picPlus";
            picPlus.Size = new Size(48, 53);
            picPlus.SizeMode = PictureBoxSizeMode.CenterImage;
            picPlus.TabIndex = 17;
            picPlus.TabStop = false;
            // 
            // lblHeureDepart
            // 
            lblHeureDepart.AutoSize = true;
            lblHeureDepart.Font = new Font("Microsoft Sans Serif", 7.79999971F);
            lblHeureDepart.ForeColor = Color.FromArgb(205, 33, 42);
            lblHeureDepart.Location = new Point(57, 62);
            lblHeureDepart.Name = "lblHeureDepart";
            lblHeureDepart.Size = new Size(86, 16);
            lblHeureDepart.TabIndex = 20;
            lblHeureDepart.Text = "Heure départ";
            // 
            // lblSeparation
            // 
            lblSeparation.AutoSize = true;
            lblSeparation.Location = new Point(160, 33);
            lblSeparation.Name = "lblSeparation";
            lblSeparation.Size = new Size(31, 20);
            lblSeparation.TabIndex = 19;
            lblSeparation.Text = "-->";
            // 
            // lblStationArrivee
            // 
            lblStationArrivee.AutoSize = true;
            lblStationArrivee.Font = new Font("Microsoft Sans Serif", 7.79999971F);
            lblStationArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            lblStationArrivee.Location = new Point(197, 33);
            lblStationArrivee.Name = "lblStationArrivee";
            lblStationArrivee.Size = new Size(94, 16);
            lblStationArrivee.TabIndex = 18;
            lblStationArrivee.Text = "Station Arrivée";
            // 
            // lblStationDepart
            // 
            lblStationDepart.AutoSize = true;
            lblStationDepart.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStationDepart.ForeColor = Color.FromArgb(205, 33, 42);
            lblStationDepart.Location = new Point(48, 33);
            lblStationDepart.Name = "lblStationDepart";
            lblStationDepart.Size = new Size(92, 16);
            lblStationDepart.TabIndex = 17;
            lblStationDepart.Text = "Station Départ";
            // 
            // lblTrajet
            // 
            lblTrajet.AutoSize = true;
            lblTrajet.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblTrajet.ForeColor = Color.FromArgb(15, 93, 70);
            lblTrajet.Location = new Point(6, 387);
            lblTrajet.Name = "lblTrajet";
            lblTrajet.Size = new Size(167, 20);
            lblTrajet.TabIndex = 15;
            lblTrajet.Text = "Trajet le plus rapide :";
            // 
            // btnRecherche
            // 
            btnRecherche.BackColor = Color.FromArgb(205, 33, 42);
            btnRecherche.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecherche.ForeColor = Color.White;
            btnRecherche.Location = new Point(6, 320);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(339, 64);
            btnRecherche.TabIndex = 8;
            btnRecherche.Text = "Lancer la recherche";
            btnRecherche.UseVisualStyleBackColor = false;
            // 
            // dtpArrivee
            // 
            dtpArrivee.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpArrivee.CalendarForeColor = Color.FromArgb(205, 33, 42);
            dtpArrivee.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            dtpArrivee.Location = new Point(149, 271);
            dtpArrivee.Name = "dtpArrivee";
            dtpArrivee.Size = new Size(196, 27);
            dtpArrivee.TabIndex = 14;
            // 
            // dtpDepart
            // 
            dtpDepart.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDepart.CalendarForeColor = Color.FromArgb(205, 33, 42);
            dtpDepart.CustomFormat = "\"dd/MM HH:mm\"";
            dtpDepart.Location = new Point(149, 237);
            dtpDepart.Name = "dtpDepart";
            dtpDepart.Size = new Size(196, 27);
            dtpDepart.TabIndex = 13;
            dtpDepart.Value = new DateTime(2025, 4, 29, 22, 31, 8, 0);
            // 
            // lblHoraireArrivée
            // 
            lblHoraireArrivée.AutoSize = true;
            lblHoraireArrivée.Font = new Font("Microsoft Sans Serif", 9F);
            lblHoraireArrivée.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraireArrivée.Location = new Point(6, 276);
            lblHoraireArrivée.Name = "lblHoraireArrivée";
            lblHoraireArrivée.Size = new Size(116, 18);
            lblHoraireArrivée.TabIndex = 12;
            lblHoraireArrivée.Text = "Horaire d'arrivée";
            // 
            // lblHoraireDepart
            // 
            lblHoraireDepart.AutoSize = true;
            lblHoraireDepart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraireDepart.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraireDepart.Location = new Point(6, 244);
            lblHoraireDepart.Name = "lblHoraireDepart";
            lblHoraireDepart.Size = new Size(122, 18);
            lblHoraireDepart.TabIndex = 11;
            lblHoraireDepart.Text = "Horaire de départ";
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblHoraires.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraires.Location = new Point(6, 210);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(74, 20);
            lblHoraires.TabIndex = 10;
            lblHoraires.Text = "Horaires";
            // 
            // cmbArrivee
            // 
            cmbArrivee.Font = new Font("Microsoft Sans Serif", 9F);
            cmbArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            cmbArrivee.FormattingEnabled = true;
            cmbArrivee.Location = new Point(6, 162);
            cmbArrivee.Name = "cmbArrivee";
            cmbArrivee.Size = new Size(339, 26);
            cmbArrivee.TabIndex = 19;
            cmbArrivee.Text = "Choisir une station";
            // 
            // lblArrivee
            // 
            lblArrivee.AutoSize = true;
            lblArrivee.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblArrivee.ForeColor = Color.FromArgb(15, 93, 70);
            lblArrivee.Location = new Point(6, 136);
            lblArrivee.Name = "lblArrivee";
            lblArrivee.Size = new Size(130, 20);
            lblArrivee.TabIndex = 5;
            lblArrivee.Text = "Station d'arrivée";
            // 
            // cmbDepart
            // 
            cmbDepart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepart.ForeColor = Color.FromArgb(205, 33, 42);
            cmbDepart.FormattingEnabled = true;
            cmbDepart.Location = new Point(6, 96);
            cmbDepart.Name = "cmbDepart";
            cmbDepart.Size = new Size(339, 26);
            cmbDepart.TabIndex = 18;
            cmbDepart.Text = "Choisir une station";
            cmbDepart.SelectedIndexChanged += cmbDepart_SelectedIndexChanged;
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepart.ForeColor = Color.FromArgb(15, 93, 70);
            lblDepart.Location = new Point(6, 70);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(136, 20);
            lblDepart.TabIndex = 4;
            lblDepart.Text = "Station de départ";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(6, 23);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(163, 29);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "RECHERCHE";
            // 
            // pnlRecherche
            // 
            pnlRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecherche.AutoScroll = true;
            pnlRecherche.AutoScrollMinSize = new Size(0, 1200);
            pnlRecherche.BackColor = Color.FromArgb(255, 230, 188);
            pnlRecherche.Controls.Add(grpRecherche);
            pnlRecherche.Controls.Add(flpResultat);
            pnlRecherche.Controls.Add(picHome);
            pnlRecherche.Controls.Add(picRetour);
            pnlRecherche.Controls.Add(grpTrajet);
            pnlRecherche.Location = new Point(0, 0);
            pnlRecherche.Name = "pnlRecherche";
            pnlRecherche.Size = new Size(382, 753);
            pnlRecherche.TabIndex = 20;
            // 
            // grpRecherche
            // 
            grpRecherche.Controls.Add(lblTitre);
            grpRecherche.Controls.Add(lblArrivee);
            grpRecherche.Controls.Add(lblDepart);
            grpRecherche.Controls.Add(cmbDepart);
            grpRecherche.Controls.Add(cmbArrivee);
            grpRecherche.Controls.Add(lblTrajet);
            grpRecherche.Controls.Add(lblHoraires);
            grpRecherche.Controls.Add(btnRecherche);
            grpRecherche.Controls.Add(lblHoraireArrivée);
            grpRecherche.Controls.Add(dtpArrivee);
            grpRecherche.Controls.Add(lblHoraireDepart);
            grpRecherche.Controls.Add(dtpDepart);
            grpRecherche.Location = new Point(3, 281);
            grpRecherche.Name = "grpRecherche";
            grpRecherche.Size = new Size(355, 423);
            grpRecherche.TabIndex = 58;
            grpRecherche.TabStop = false;
            // 
            // flpResultat
            // 
            flpResultat.Controls.Add(grpResultat);
            flpResultat.Controls.Add(picVoirPlus);
            flpResultat.Location = new Point(0, 734);
            flpResultat.Name = "flpResultat";
            flpResultat.Size = new Size(358, 312);
            flpResultat.TabIndex = 57;
            // 
            // grpResultat
            // 
            grpResultat.Controls.Add(btnDetails1);
            grpResultat.Controls.Add(lblTemps);
            grpResultat.Controls.Add(lblNumLigneResultat);
            grpResultat.Controls.Add(lblNumLigne);
            grpResultat.Controls.Add(lblTempsArrivee);
            grpResultat.Controls.Add(lblTempsDepart);
            grpResultat.Controls.Add(lblArrivee2);
            grpResultat.Controls.Add(lblDépart);
            grpResultat.ForeColor = Color.FromArgb(15, 93, 70);
            grpResultat.Location = new Point(3, 3);
            grpResultat.Name = "grpResultat";
            grpResultat.Size = new Size(355, 233);
            grpResultat.TabIndex = 0;
            grpResultat.TabStop = false;
            grpResultat.Paint += grpResultat_Paint;
            // 
            // btnDetails1
            // 
            btnDetails1.BackColor = Color.FromArgb(205, 33, 42);
            btnDetails1.FlatStyle = FlatStyle.Flat;
            btnDetails1.ForeColor = Color.White;
            btnDetails1.Location = new Point(254, 198);
            btnDetails1.Name = "btnDetails1";
            btnDetails1.Size = new Size(94, 29);
            btnDetails1.TabIndex = 7;
            btnDetails1.Text = "Détails";
            btnDetails1.UseVisualStyleBackColor = false;
            // 
            // lblTemps
            // 
            lblTemps.AutoSize = true;
            lblTemps.Location = new Point(282, 148);
            lblTemps.Name = "lblTemps";
            lblTemps.Size = new Size(50, 20);
            lblTemps.TabIndex = 6;
            lblTemps.Text = "40min";
            // 
            // lblNumLigneResultat
            // 
            lblNumLigneResultat.AutoSize = true;
            lblNumLigneResultat.Location = new Point(169, 148);
            lblNumLigneResultat.Name = "lblNumLigneResultat";
            lblNumLigneResultat.Size = new Size(43, 20);
            lblNumLigneResultat.TabIndex = 5;
            lblNumLigneResultat.Text = "NUM";
            // 
            // lblNumLigne
            // 
            lblNumLigne.AutoSize = true;
            lblNumLigne.Location = new Point(57, 148);
            lblNumLigne.Name = "lblNumLigne";
            lblNumLigne.Size = new Size(69, 20);
            lblNumLigne.TabIndex = 4;
            lblNumLigne.Text = "N°Ligne :";
            // 
            // lblTempsArrivee
            // 
            lblTempsArrivee.AutoSize = true;
            lblTempsArrivee.Location = new Point(229, 93);
            lblTempsArrivee.Name = "lblTempsArrivee";
            lblTempsArrivee.Size = new Size(103, 20);
            lblTempsArrivee.TabIndex = 3;
            lblTempsArrivee.Text = "Temps Arrivée";
            // 
            // lblTempsDepart
            // 
            lblTempsDepart.AutoSize = true;
            lblTempsDepart.Location = new Point(31, 93);
            lblTempsDepart.Name = "lblTempsDepart";
            lblTempsDepart.Size = new Size(121, 20);
            lblTempsDepart.TabIndex = 2;
            lblTempsDepart.Text = "Temps de départ";
            // 
            // lblArrivee2
            // 
            lblArrivee2.AutoSize = true;
            lblArrivee2.Location = new Point(245, 44);
            lblArrivee2.Name = "lblArrivee2";
            lblArrivee2.Size = new Size(56, 20);
            lblArrivee2.TabIndex = 1;
            lblArrivee2.Text = "Arrivée";
            // 
            // lblDépart
            // 
            lblDépart.AutoSize = true;
            lblDépart.Location = new Point(66, 44);
            lblDépart.Name = "lblDépart";
            lblDépart.Size = new Size(55, 20);
            lblDépart.TabIndex = 0;
            lblDépart.Text = "Départ";
            // 
            // picVoirPlus
            // 
            picVoirPlus.Image = Properties.Resources.plus2;
            picVoirPlus.Location = new Point(3, 242);
            picVoirPlus.Name = "picVoirPlus";
            picVoirPlus.Size = new Size(355, 62);
            picVoirPlus.SizeMode = PictureBoxSizeMode.Zoom;
            picVoirPlus.TabIndex = 1;
            picVoirPlus.TabStop = false;
            // 
            // picHome
            // 
            picHome.Image = Properties.Resources.home;
            picHome.Location = new Point(47, 0);
            picHome.Name = "picHome";
            picHome.Size = new Size(27, 25);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 56;
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
            picRetour.TabIndex = 23;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // Recherche
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 753);
            Controls.Add(pnlRecherche);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Recherche";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rechercher un itinéraire";
            Load += consultation_Load;
            grpTrajet.ResumeLayout(false);
            grpTrajet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).EndInit();
            pnlRecherche.ResumeLayout(false);
            grpRecherche.ResumeLayout(false);
            grpRecherche.PerformLayout();
            flpResultat.ResumeLayout(false);
            grpResultat.ResumeLayout(false);
            grpResultat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVoirPlus).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox grpTrajet;
        private Label lblLigne;
        private Label lblSeparation2;
        private Label lblHeureArrivee;
        private Label lblHeureDepart;
        private Label lblSeparation;
        private Label lblStationArrivee;
        private Label lblStationDepart;
        private Button btnDetails;
        private Label lblDuree;
        private PictureBox picPlus;
        private Label lblTrajet;
        private Button btnRecherche;
        private DateTimePicker dtpArrivee;
        private DateTimePicker dtpDepart;
        private Label lblHoraireArrivée;
        private Label lblHoraireDepart;
        private Label lblHoraires;
        private ComboBox cmbArrivee;
        private Label lblArrivee;
        private ComboBox cmbDepart;
        private Label lblDepart;
        private Label lblTitre;
        private Panel pnlRecherche;
        private PictureBox picRetour;
        private PictureBox picHome;
        private FlowLayoutPanel flpResultat;
        private GroupBox grpResultat;
        private Label lblArrivee2;
        private Label lblDépart;
        private Button btnDetails1;
        private Label lblTemps;
        private Label lblNumLigneResultat;
        private Label lblNumLigne;
        private Label lblTempsArrivee;
        private Label lblTempsDepart;
        private PictureBox picVoirPlus;
        private GroupBox grpRecherche;
    }
}