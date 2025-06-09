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
            pnlRecherche = new Panel();
            grpRecherche = new GroupBox();
            lblTitre = new Label();
            grpRecherche2 = new GroupBox();
            lblArrivee = new Label();
            lblDepart = new Label();
            cmbDepart = new ComboBox();
            cmbArrivee = new ComboBox();
            grpRecherche1 = new GroupBox();
            lblHoraires = new Label();
            lblHoraireArrivée = new Label();
            dtpArrivee = new DateTimePicker();
            lblHoraireDepart = new Label();
            dtpDepart = new DateTimePicker();
            flpResultat = new FlowLayoutPanel();
            grpResultat = new GroupBox();
            grpResultatItineraire = new GroupBox();
            lblTemps = new Label();
            lblNumLigneResultat = new Label();
            lblTempsArrivee = new Label();
            lblTempsDepart = new Label();
            lblArrivee2 = new Label();
            lblDépart = new Label();
            lblIntituleHeures = new Label();
            lblIntituleStations = new Label();
            lstStations = new ListBox();
            lblIntituleNumLigne = new Label();
            picVoirPlus = new PictureBox();
            picHome = new PictureBox();
            picRetour = new PictureBox();
            grpTrajet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).BeginInit();
            pnlRecherche.SuspendLayout();
            grpRecherche.SuspendLayout();
            grpRecherche2.SuspendLayout();
            grpRecherche1.SuspendLayout();
            flpResultat.SuspendLayout();
            grpResultat.SuspendLayout();
            grpResultatItineraire.SuspendLayout();
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
            grpTrajet.Location = new Point(10, 14067);
            grpTrajet.Margin = new Padding(3, 2, 3, 2);
            grpTrajet.Name = "grpTrajet";
            grpTrajet.Padding = new Padding(3, 2, 3, 2);
            grpTrajet.Size = new Size(0, 212);
            grpTrajet.TabIndex = 16;
            grpTrajet.TabStop = false;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.FromArgb(205, 33, 42);
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnDetails.ForeColor = Color.White;
            btnDetails.Location = new Point(92, 134);
            btnDetails.Margin = new Padding(3, 2, 3, 2);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(110, 21);
            btnDetails.TabIndex = 17;
            btnDetails.Text = "Détails";
            btnDetails.UseVisualStyleBackColor = false;
            // 
            // lblDuree
            // 
            lblDuree.AutoSize = true;
            lblDuree.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDuree.ForeColor = Color.FromArgb(205, 33, 42);
            lblDuree.Location = new Point(241, 95);
            lblDuree.Name = "lblDuree";
            lblDuree.Size = new Size(48, 18);
            lblDuree.TabIndex = 24;
            lblDuree.Text = "40min";
            // 
            // lblLigne
            // 
            lblLigne.AutoSize = true;
            lblLigne.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLigne.ForeColor = Color.FromArgb(205, 33, 42);
            lblLigne.Location = new Point(0, 95);
            lblLigne.Name = "lblLigne";
            lblLigne.Size = new Size(60, 18);
            lblLigne.TabIndex = 23;
            lblLigne.Text = "N°Ligne";
            // 
            // lblSeparation2
            // 
            lblSeparation2.AutoSize = true;
            lblSeparation2.Location = new Point(140, 46);
            lblSeparation2.Name = "lblSeparation2";
            lblSeparation2.Size = new Size(25, 15);
            lblSeparation2.TabIndex = 22;
            lblSeparation2.Text = "-->";
            // 
            // lblHeureArrivee
            // 
            lblHeureArrivee.AutoSize = true;
            lblHeureArrivee.Font = new Font("Microsoft Sans Serif", 7.79999971F);
            lblHeureArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            lblHeureArrivee.Location = new Point(172, 46);
            lblHeureArrivee.Name = "lblHeureArrivee";
            lblHeureArrivee.Size = new Size(71, 13);
            lblHeureArrivee.TabIndex = 21;
            lblHeureArrivee.Text = "Heure arrivée";
            // 
            // picPlus
            // 
            picPlus.Image = (Image)resources.GetObject("picPlus.Image");
            picPlus.Location = new Point(125, 167);
            picPlus.Margin = new Padding(3, 2, 3, 2);
            picPlus.Name = "picPlus";
            picPlus.Size = new Size(42, 40);
            picPlus.SizeMode = PictureBoxSizeMode.CenterImage;
            picPlus.TabIndex = 17;
            picPlus.TabStop = false;
            // 
            // lblHeureDepart
            // 
            lblHeureDepart.AutoSize = true;
            lblHeureDepart.Font = new Font("Microsoft Sans Serif", 7.79999971F);
            lblHeureDepart.ForeColor = Color.FromArgb(205, 33, 42);
            lblHeureDepart.Location = new Point(50, 46);
            lblHeureDepart.Name = "lblHeureDepart";
            lblHeureDepart.Size = new Size(69, 13);
            lblHeureDepart.TabIndex = 20;
            lblHeureDepart.Text = "Heure départ";
            // 
            // lblSeparation
            // 
            lblSeparation.AutoSize = true;
            lblSeparation.Location = new Point(140, 25);
            lblSeparation.Name = "lblSeparation";
            lblSeparation.Size = new Size(25, 15);
            lblSeparation.TabIndex = 19;
            lblSeparation.Text = "-->";
            // 
            // lblStationArrivee
            // 
            lblStationArrivee.AutoSize = true;
            lblStationArrivee.Font = new Font("Microsoft Sans Serif", 7.79999971F);
            lblStationArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            lblStationArrivee.Location = new Point(172, 25);
            lblStationArrivee.Name = "lblStationArrivee";
            lblStationArrivee.Size = new Size(76, 13);
            lblStationArrivee.TabIndex = 18;
            lblStationArrivee.Text = "Station Arrivée";
            // 
            // lblStationDepart
            // 
            lblStationDepart.AutoSize = true;
            lblStationDepart.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStationDepart.ForeColor = Color.FromArgb(205, 33, 42);
            lblStationDepart.Location = new Point(42, 25);
            lblStationDepart.Name = "lblStationDepart";
            lblStationDepart.Size = new Size(75, 13);
            lblStationDepart.TabIndex = 17;
            lblStationDepart.Text = "Station Départ";
            // 
            // lblTrajet
            // 
            lblTrajet.AutoSize = true;
            lblTrajet.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblTrajet.ForeColor = Color.FromArgb(15, 93, 70);
            lblTrajet.Location = new Point(8, 412);
            lblTrajet.Name = "lblTrajet";
            lblTrajet.Size = new Size(142, 17);
            lblTrajet.TabIndex = 15;
            lblTrajet.Text = "Trajet le plus rapide :";
            // 
            // btnRecherche
            // 
            btnRecherche.BackColor = Color.FromArgb(205, 33, 42);
            btnRecherche.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecherche.ForeColor = Color.White;
            btnRecherche.Location = new Point(8, 344);
            btnRecherche.Margin = new Padding(3, 2, 3, 2);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(298, 48);
            btnRecherche.TabIndex = 8;
            btnRecherche.Text = "Lancer la recherche";
            btnRecherche.UseVisualStyleBackColor = false;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // pnlRecherche
            // 
            pnlRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecherche.AutoScroll = true;
            pnlRecherche.AutoScrollMinSize = new Size(0, 1500);
            pnlRecherche.BackColor = Color.FromArgb(255, 230, 188);
            pnlRecherche.Controls.Add(grpRecherche);
            pnlRecherche.Controls.Add(flpResultat);
            pnlRecherche.Controls.Add(picHome);
            pnlRecherche.Controls.Add(picRetour);
            pnlRecherche.Controls.Add(grpTrajet);
            pnlRecherche.Location = new Point(0, 0);
            pnlRecherche.Margin = new Padding(3, 2, 3, 2);
            pnlRecherche.Name = "pnlRecherche";
            pnlRecherche.Size = new Size(334, 565);
            pnlRecherche.TabIndex = 20;
            // 
            // grpRecherche
            // 
            grpRecherche.Controls.Add(lblTitre);
            grpRecherche.Controls.Add(grpRecherche2);
            grpRecherche.Controls.Add(grpRecherche1);
            grpRecherche.Controls.Add(btnRecherche);
            grpRecherche.Controls.Add(lblTrajet);
            grpRecherche.Location = new Point(3, 211);
            grpRecherche.Margin = new Padding(3, 2, 3, 2);
            grpRecherche.Name = "grpRecherche";
            grpRecherche.Padding = new Padding(3, 2, 3, 2);
            grpRecherche.Size = new Size(311, 440);
            grpRecherche.TabIndex = 58;
            grpRecherche.TabStop = false;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(8, 34);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(129, 24);
            lblTitre.TabIndex = 30;
            lblTitre.Text = "RECHERCHE";
            // 
            // grpRecherche2
            // 
            grpRecherche2.Controls.Add(lblArrivee);
            grpRecherche2.Controls.Add(lblDepart);
            grpRecherche2.Controls.Add(cmbDepart);
            grpRecherche2.Controls.Add(cmbArrivee);
            grpRecherche2.Location = new Point(3, 67);
            grpRecherche2.Margin = new Padding(3, 2, 3, 2);
            grpRecherche2.Name = "grpRecherche2";
            grpRecherche2.Padding = new Padding(3, 2, 3, 2);
            grpRecherche2.Size = new Size(304, 146);
            grpRecherche2.TabIndex = 31;
            grpRecherche2.TabStop = false;
            grpRecherche2.Paint += grpRecherche2_Paint_1;
            // 
            // lblArrivee
            // 
            lblArrivee.AutoSize = true;
            lblArrivee.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblArrivee.ForeColor = Color.FromArgb(15, 93, 70);
            lblArrivee.Location = new Point(14, 80);
            lblArrivee.Name = "lblArrivee";
            lblArrivee.Size = new Size(119, 17);
            lblArrivee.TabIndex = 32;
            lblArrivee.Text = "Station d'arrivée :";
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepart.ForeColor = Color.FromArgb(15, 93, 70);
            lblDepart.Location = new Point(14, 17);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(125, 17);
            lblDepart.TabIndex = 31;
            lblDepart.Text = "Station de départ :";
            // 
            // cmbDepart
            // 
            cmbDepart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepart.ForeColor = Color.FromArgb(205, 33, 42);
            cmbDepart.FormattingEnabled = true;
            cmbDepart.Location = new Point(14, 44);
            cmbDepart.Margin = new Padding(3, 2, 3, 2);
            cmbDepart.Name = "cmbDepart";
            cmbDepart.Size = new Size(277, 23);
            cmbDepart.TabIndex = 33;
            cmbDepart.Text = "Choisir une station";
            // 
            // cmbArrivee
            // 
            cmbArrivee.Font = new Font("Microsoft Sans Serif", 9F);
            cmbArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            cmbArrivee.FormattingEnabled = true;
            cmbArrivee.Location = new Point(14, 104);
            cmbArrivee.Margin = new Padding(3, 2, 3, 2);
            cmbArrivee.Name = "cmbArrivee";
            cmbArrivee.Size = new Size(277, 23);
            cmbArrivee.TabIndex = 34;
            cmbArrivee.Text = "Choisir une station";
            // 
            // grpRecherche1
            // 
            grpRecherche1.Controls.Add(lblHoraires);
            grpRecherche1.Controls.Add(lblHoraireArrivée);
            grpRecherche1.Controls.Add(dtpArrivee);
            grpRecherche1.Controls.Add(lblHoraireDepart);
            grpRecherche1.Controls.Add(dtpDepart);
            grpRecherche1.Location = new Point(3, 211);
            grpRecherche1.Margin = new Padding(3, 2, 3, 2);
            grpRecherche1.Name = "grpRecherche1";
            grpRecherche1.Padding = new Padding(3, 2, 3, 2);
            grpRecherche1.Size = new Size(304, 118);
            grpRecherche1.TabIndex = 20;
            grpRecherche1.TabStop = false;
            grpRecherche1.Paint += grpRecherche1_Paint;
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblHoraires.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraires.Location = new Point(14, 17);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(70, 17);
            lblHoraires.TabIndex = 23;
            lblHoraires.Text = "Horaires :";
            // 
            // lblHoraireArrivée
            // 
            lblHoraireArrivée.AutoSize = true;
            lblHoraireArrivée.Font = new Font("Microsoft Sans Serif", 9F);
            lblHoraireArrivée.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraireArrivée.Location = new Point(14, 86);
            lblHoraireArrivée.Name = "lblHoraireArrivée";
            lblHoraireArrivée.Size = new Size(104, 15);
            lblHoraireArrivée.TabIndex = 25;
            lblHoraireArrivée.Text = "Horaire d'arrivée :";
            // 
            // dtpArrivee
            // 
            dtpArrivee.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpArrivee.CalendarForeColor = Color.FromArgb(205, 33, 42);
            dtpArrivee.CustomFormat = "\"HH:mm:SS\"";
            dtpArrivee.Format = DateTimePickerFormat.Time;
            dtpArrivee.Location = new Point(178, 82);
            dtpArrivee.Margin = new Padding(3, 2, 3, 2);
            dtpArrivee.Name = "dtpArrivee";
            dtpArrivee.ShowUpDown = true;
            dtpArrivee.Size = new Size(113, 23);
            dtpArrivee.TabIndex = 27;
            // 
            // lblHoraireDepart
            // 
            lblHoraireDepart.AutoSize = true;
            lblHoraireDepart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraireDepart.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraireDepart.Location = new Point(14, 50);
            lblHoraireDepart.Name = "lblHoraireDepart";
            lblHoraireDepart.Size = new Size(109, 15);
            lblHoraireDepart.TabIndex = 24;
            lblHoraireDepart.Text = "Horaire de départ :";
            // 
            // dtpDepart
            // 
            dtpDepart.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDepart.CalendarForeColor = Color.FromArgb(205, 33, 42);
            dtpDepart.CustomFormat = "\"HH:mm:SS\"";
            dtpDepart.Format = DateTimePickerFormat.Time;
            dtpDepart.Location = new Point(178, 45);
            dtpDepart.Margin = new Padding(3, 2, 3, 2);
            dtpDepart.Name = "dtpDepart";
            dtpDepart.ShowUpDown = true;
            dtpDepart.Size = new Size(113, 23);
            dtpDepart.TabIndex = 26;
            dtpDepart.Value = new DateTime(2025, 4, 29, 22, 31, 8, 0);
            // 
            // flpResultat
            // 
            flpResultat.Controls.Add(grpResultat);
            flpResultat.Controls.Add(picVoirPlus);
            flpResultat.Location = new Point(3, 652);
            flpResultat.Margin = new Padding(3, 2, 3, 2);
            flpResultat.Name = "flpResultat";
            flpResultat.Size = new Size(313, 415);
            flpResultat.TabIndex = 57;
            flpResultat.Visible = false;
            // 
            // grpResultat
            // 
            grpResultat.Controls.Add(grpResultatItineraire);
            grpResultat.Controls.Add(lblIntituleHeures);
            grpResultat.Controls.Add(lblIntituleStations);
            grpResultat.Controls.Add(lstStations);
            grpResultat.Controls.Add(lblIntituleNumLigne);
            grpResultat.ForeColor = Color.FromArgb(15, 93, 70);
            grpResultat.Location = new Point(3, 2);
            grpResultat.Margin = new Padding(3, 2, 3, 2);
            grpResultat.Name = "grpResultat";
            grpResultat.Padding = new Padding(3, 2, 3, 2);
            grpResultat.Size = new Size(311, 175);
            grpResultat.TabIndex = 0;
            grpResultat.TabStop = false;
            grpResultat.Paint += grpResultat_Paint;
            // 
            // grpResultatItineraire
            // 
            grpResultatItineraire.Controls.Add(lblTemps);
            grpResultatItineraire.Controls.Add(lblNumLigneResultat);
            grpResultatItineraire.Controls.Add(lblTempsArrivee);
            grpResultatItineraire.Controls.Add(lblTempsDepart);
            grpResultatItineraire.Controls.Add(lblArrivee2);
            grpResultatItineraire.Controls.Add(lblDépart);
            grpResultatItineraire.Location = new Point(169, 12);
            grpResultatItineraire.Margin = new Padding(3, 2, 3, 2);
            grpResultatItineraire.Name = "grpResultatItineraire";
            grpResultatItineraire.Padding = new Padding(3, 2, 3, 2);
            grpResultatItineraire.Size = new Size(135, 158);
            grpResultatItineraire.TabIndex = 10;
            grpResultatItineraire.TabStop = false;
            grpResultatItineraire.Paint += grpResultatItineraire_Paint;
            // 
            // lblTemps
            // 
            lblTemps.AutoSize = true;
            lblTemps.ForeColor = Color.FromArgb(205, 33, 42);
            lblTemps.Location = new Point(78, 106);
            lblTemps.Name = "lblTemps";
            lblTemps.Size = new Size(40, 15);
            lblTemps.TabIndex = 12;
            lblTemps.Text = "40min";
            // 
            // lblNumLigneResultat
            // 
            lblNumLigneResultat.AutoSize = true;
            lblNumLigneResultat.ForeColor = Color.FromArgb(205, 33, 42);
            lblNumLigneResultat.Location = new Point(84, 135);
            lblNumLigneResultat.Name = "lblNumLigneResultat";
            lblNumLigneResultat.Size = new Size(35, 15);
            lblNumLigneResultat.TabIndex = 11;
            lblNumLigneResultat.Text = "NUM";
            // 
            // lblTempsArrivee
            // 
            lblTempsArrivee.AutoSize = true;
            lblTempsArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            lblTempsArrivee.Location = new Point(80, 78);
            lblTempsArrivee.Name = "lblTempsArrivee";
            lblTempsArrivee.Size = new Size(39, 15);
            lblTempsArrivee.TabIndex = 10;
            lblTempsArrivee.Text = "heurA";
            // 
            // lblTempsDepart
            // 
            lblTempsDepart.AutoSize = true;
            lblTempsDepart.ForeColor = Color.FromArgb(205, 33, 42);
            lblTempsDepart.Location = new Point(32, 78);
            lblTempsDepart.Name = "lblTempsDepart";
            lblTempsDepart.Size = new Size(39, 15);
            lblTempsDepart.TabIndex = 9;
            lblTempsDepart.Text = "heurD";
            // 
            // lblArrivee2
            // 
            lblArrivee2.AutoSize = true;
            lblArrivee2.ForeColor = Color.FromArgb(205, 33, 42);
            lblArrivee2.Location = new Point(9, 49);
            lblArrivee2.Name = "lblArrivee2";
            lblArrivee2.Size = new Size(44, 15);
            lblArrivee2.TabIndex = 8;
            lblArrivee2.Text = "Arrivée";
            // 
            // lblDépart
            // 
            lblDépart.AutoSize = true;
            lblDépart.ForeColor = Color.FromArgb(205, 33, 42);
            lblDépart.Location = new Point(9, 21);
            lblDépart.Name = "lblDépart";
            lblDépart.Size = new Size(42, 15);
            lblDépart.TabIndex = 7;
            lblDépart.Text = "Départ";
            // 
            // lblIntituleHeures
            // 
            lblIntituleHeures.AutoSize = true;
            lblIntituleHeures.Location = new Point(10, 90);
            lblIntituleHeures.Name = "lblIntituleHeures";
            lblIntituleHeures.Size = new Size(57, 15);
            lblIntituleHeures.TabIndex = 9;
            lblIntituleHeures.Text = "Horaires :";
            // 
            // lblIntituleStations
            // 
            lblIntituleStations.AutoSize = true;
            lblIntituleStations.Location = new Point(10, 33);
            lblIntituleStations.Name = "lblIntituleStations";
            lblIntituleStations.Size = new Size(55, 15);
            lblIntituleStations.TabIndex = 8;
            lblIntituleStations.Text = "Stations :";
            // 
            // lstStations
            // 
            lstStations.BackColor = Color.FromArgb(255, 230, 188);
            lstStations.ForeColor = Color.FromArgb(15, 93, 70);
            lstStations.FormattingEnabled = true;
            lstStations.ItemHeight = 15;
            lstStations.Location = new Point(5, 188);
            lstStations.Margin = new Padding(3, 2, 3, 2);
            lstStations.Name = "lstStations";
            lstStations.Size = new Size(301, 124);
            lstStations.TabIndex = 7;
            lstStations.Visible = false;
            // 
            // lblIntituleNumLigne
            // 
            lblIntituleNumLigne.AutoSize = true;
            lblIntituleNumLigne.Location = new Point(10, 147);
            lblIntituleNumLigne.Name = "lblIntituleNumLigne";
            lblIntituleNumLigne.Size = new Size(109, 15);
            lblIntituleNumLigne.TabIndex = 4;
            lblIntituleNumLigne.Text = "N°Ligne de départ :";
            // 
            // picVoirPlus
            // 
            picVoirPlus.Image = (Image)resources.GetObject("picVoirPlus.Image");
            picVoirPlus.Location = new Point(3, 181);
            picVoirPlus.Margin = new Padding(3, 2, 3, 2);
            picVoirPlus.Name = "picVoirPlus";
            picVoirPlus.Size = new Size(311, 46);
            picVoirPlus.SizeMode = PictureBoxSizeMode.Zoom;
            picVoirPlus.TabIndex = 1;
            picVoirPlus.TabStop = false;
            picVoirPlus.Click += picVoirPlus_Click;
            // 
            // picHome
            // 
            picHome.Image = Properties.Resources.home;
            picHome.Location = new Point(30, 0);
            picHome.Margin = new Padding(3, 2, 3, 2);
            picHome.Name = "picHome";
            picHome.Size = new Size(24, 19);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 56;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(0, 0);
            picRetour.Margin = new Padding(3, 2, 3, 2);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(24, 19);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 23;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // Recherche
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 565);
            Controls.Add(pnlRecherche);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
            grpRecherche2.ResumeLayout(false);
            grpRecherche2.PerformLayout();
            grpRecherche1.ResumeLayout(false);
            grpRecherche1.PerformLayout();
            flpResultat.ResumeLayout(false);
            grpResultat.ResumeLayout(false);
            grpResultat.PerformLayout();
            grpResultatItineraire.ResumeLayout(false);
            grpResultatItineraire.PerformLayout();
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
        private Panel pnlRecherche;
        private PictureBox picRetour;
        private PictureBox picHome;
        private FlowLayoutPanel flpResultat;
        private GroupBox grpResultat;
        private Label lblIntituleNumLigne;
        private PictureBox picVoirPlus;
        private GroupBox grpRecherche;
        private GroupBox grpRecherche1;
        private Label lblHoraires;
        private Label lblHoraireArrivée;
        private DateTimePicker dtpArrivee;
        private Label lblHoraireDepart;
        private DateTimePicker dtpDepart;
        private GroupBox grpRecherche2;
        private Label lblTitre;
        private Label lblArrivee;
        private Label lblDepart;
        private ComboBox cmbDepart;
        private ComboBox cmbArrivee;
        private ListBox lstStations;
        private Label lblIntituleHeures;
        private Label lblIntituleStations;
        private GroupBox grpResultatItineraire;
        private Label lblTemps;
        private Label lblNumLigneResultat;
        private Label lblTempsArrivee;
        private Label lblTempsDepart;
        private Label lblArrivee2;
        private Label lblDépart;
    }
}