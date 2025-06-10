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
            flpResultat = new FlowLayoutPanel();
            grpResultat = new GroupBox();
            grpResultat1 = new GroupBox();
            picDeuxPoints = new PictureBox();
            picFlecheItineraire = new PictureBox();
            lblTempsArrivee = new Label();
            lblTempsDepart = new Label();
            lblArrivee2 = new Label();
            lblDepart2 = new Label();
            lblNumLigneResultat = new Label();
            lstStations = new ListBox();
            grpResultat2 = new GroupBox();
            lblTemps = new Label();
            lblIntituleNumLigne = new Label();
            picVoirPlus = new PictureBox();
            grpRecherche = new GroupBox();
            lblTitre = new Label();
            grpRecherche2 = new GroupBox();
            lblArrivee = new Label();
            lblDepart = new Label();
            cmbDepart = new ComboBox();
            cmbArrivee = new ComboBox();
            grpRecherche1 = new GroupBox();
            lblHoraires = new Label();
            lblHoraireDepart = new Label();
            dtpDepart = new DateTimePicker();
            picHome = new PictureBox();
            picRetour = new PictureBox();
            lblHoraireArrivee = new Label();
            dtpArrivee = new DateTimePicker();
            grpTrajet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).BeginInit();
            pnlRecherche.SuspendLayout();
            flpResultat.SuspendLayout();
            grpResultat.SuspendLayout();
            grpResultat1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDeuxPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFlecheItineraire).BeginInit();
            grpResultat2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVoirPlus).BeginInit();
            grpRecherche.SuspendLayout();
            grpRecherche2.SuspendLayout();
            grpRecherche1.SuspendLayout();
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
            grpTrajet.Location = new Point(11, 31823);
            grpTrajet.Name = "grpTrajet";
            grpTrajet.Size = new Size(0, 283);
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
            // 
            // lblSeparation2
            // 
            lblSeparation2.AutoSize = true;
            lblSeparation2.Location = new Point(160, 61);
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
            lblHeureArrivee.Location = new Point(197, 61);
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
            lblHeureDepart.Location = new Point(57, 61);
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
            lblTrajet.Location = new Point(22, 810);
            lblTrajet.Name = "lblTrajet";
            lblTrajet.Size = new Size(167, 20);
            lblTrajet.TabIndex = 15;
            lblTrajet.Text = "Trajet le plus rapide :";
            lblTrajet.Visible = false;
            // 
            // btnRecherche
            // 
            btnRecherche.BackColor = Color.FromArgb(205, 33, 42);
            btnRecherche.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecherche.ForeColor = Color.White;
            btnRecherche.Location = new Point(6, 732);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(341, 64);
            btnRecherche.TabIndex = 8;
            btnRecherche.Text = "Lancer la recherche";
            btnRecherche.UseVisualStyleBackColor = false;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // pnlRecherche
            // 
            pnlRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecherche.AutoScroll = true;
            pnlRecherche.AutoScrollMinSize = new Size(0, 1000);
            pnlRecherche.BackColor = Color.FromArgb(255, 230, 188);
            pnlRecherche.Controls.Add(flpResultat);
            pnlRecherche.Controls.Add(grpRecherche);
            pnlRecherche.Controls.Add(picHome);
            pnlRecherche.Controls.Add(lblTrajet);
            pnlRecherche.Controls.Add(btnRecherche);
            pnlRecherche.Controls.Add(picRetour);
            pnlRecherche.Controls.Add(grpTrajet);
            pnlRecherche.Location = new Point(0, 0);
            pnlRecherche.Name = "pnlRecherche";
            pnlRecherche.Size = new Size(382, 753);
            pnlRecherche.TabIndex = 20;
            // 
            // flpResultat
            // 
            flpResultat.Controls.Add(grpResultat);
            flpResultat.Controls.Add(picVoirPlus);
            flpResultat.Location = new Point(0, 853);
            flpResultat.Name = "flpResultat";
            flpResultat.Size = new Size(358, 463);
            flpResultat.TabIndex = 59;
            flpResultat.Visible = false;
            // 
            // grpResultat
            // 
            grpResultat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpResultat.Controls.Add(grpResultat1);
            grpResultat.Controls.Add(lblNumLigneResultat);
            grpResultat.Controls.Add(lstStations);
            grpResultat.Controls.Add(grpResultat2);
            grpResultat.Controls.Add(lblIntituleNumLigne);
            grpResultat.ForeColor = Color.FromArgb(15, 93, 70);
            grpResultat.Location = new Point(3, 3);
            grpResultat.Name = "grpResultat";
            grpResultat.Size = new Size(355, 272);
            grpResultat.TabIndex = 2;
            grpResultat.TabStop = false;
            grpResultat.Paint += grpResultat_Paint;
            // 
            // grpResultat1
            // 
            grpResultat1.Controls.Add(picDeuxPoints);
            grpResultat1.Controls.Add(picFlecheItineraire);
            grpResultat1.Controls.Add(lblTempsArrivee);
            grpResultat1.Controls.Add(lblTempsDepart);
            grpResultat1.Controls.Add(lblArrivee2);
            grpResultat1.Controls.Add(lblDepart2);
            grpResultat1.Location = new Point(9, 26);
            grpResultat1.Name = "grpResultat1";
            grpResultat1.Size = new Size(335, 149);
            grpResultat1.TabIndex = 18;
            grpResultat1.TabStop = false;
            grpResultat1.Paint += grpResultat1_Paint;
            // 
            // picDeuxPoints
            // 
            picDeuxPoints.Location = new Point(157, 109);
            picDeuxPoints.Name = "picDeuxPoints";
            picDeuxPoints.Size = new Size(24, 29);
            picDeuxPoints.SizeMode = PictureBoxSizeMode.Zoom;
            picDeuxPoints.TabIndex = 20;
            picDeuxPoints.TabStop = false;
            // 
            // picFlecheItineraire
            // 
            picFlecheItineraire.Image = (Image)resources.GetObject("picFlecheItineraire.Image");
            picFlecheItineraire.Location = new Point(161, 57);
            picFlecheItineraire.Name = "picFlecheItineraire";
            picFlecheItineraire.Size = new Size(28, 23);
            picFlecheItineraire.SizeMode = PictureBoxSizeMode.Zoom;
            picFlecheItineraire.TabIndex = 60;
            picFlecheItineraire.TabStop = false;
            // 
            // lblTempsArrivee
            // 
            lblTempsArrivee.AutoSize = true;
            lblTempsArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            lblTempsArrivee.Location = new Point(178, 112);
            lblTempsArrivee.Name = "lblTempsArrivee";
            lblTempsArrivee.Size = new Size(48, 20);
            lblTempsArrivee.TabIndex = 19;
            lblTempsArrivee.Text = "heurA";
            // 
            // lblTempsDepart
            // 
            lblTempsDepart.AutoSize = true;
            lblTempsDepart.ForeColor = Color.FromArgb(205, 33, 42);
            lblTempsDepart.Location = new Point(102, 112);
            lblTempsDepart.Name = "lblTempsDepart";
            lblTempsDepart.Size = new Size(49, 20);
            lblTempsDepart.TabIndex = 18;
            lblTempsDepart.Text = "heurD";
            // 
            // lblArrivee2
            // 
            lblArrivee2.AutoSize = true;
            lblArrivee2.ForeColor = Color.FromArgb(205, 33, 42);
            lblArrivee2.Location = new Point(144, 83);
            lblArrivee2.Name = "lblArrivee2";
            lblArrivee2.Size = new Size(56, 20);
            lblArrivee2.TabIndex = 17;
            lblArrivee2.Text = "Arrivée";
            // 
            // lblDepart2
            // 
            lblDepart2.AutoSize = true;
            lblDepart2.ForeColor = Color.FromArgb(205, 33, 42);
            lblDepart2.Location = new Point(122, 23);
            lblDepart2.Name = "lblDepart2";
            lblDepart2.Size = new Size(55, 20);
            lblDepart2.TabIndex = 16;
            lblDepart2.Text = "Départ";
            // 
            // lblNumLigneResultat
            // 
            lblNumLigneResultat.AutoSize = true;
            lblNumLigneResultat.ForeColor = Color.FromArgb(205, 33, 42);
            lblNumLigneResultat.Location = new Point(181, 237);
            lblNumLigneResultat.Name = "lblNumLigneResultat";
            lblNumLigneResultat.Size = new Size(43, 20);
            lblNumLigneResultat.TabIndex = 16;
            lblNumLigneResultat.Text = "NUM";
            // 
            // lstStations
            // 
            lstStations.BackColor = Color.FromArgb(255, 230, 188);
            lstStations.ForeColor = Color.FromArgb(205, 33, 42);
            lstStations.FormattingEnabled = true;
            lstStations.Location = new Point(6, 275);
            lstStations.Name = "lstStations";
            lstStations.Size = new Size(343, 164);
            lstStations.TabIndex = 7;
            lstStations.Visible = false;
            // 
            // grpResultat2
            // 
            grpResultat2.Controls.Add(lblTemps);
            grpResultat2.Location = new Point(113, 161);
            grpResultat2.Name = "grpResultat2";
            grpResultat2.Size = new Size(126, 68);
            grpResultat2.TabIndex = 19;
            grpResultat2.TabStop = false;
            grpResultat2.Paint += grpResultat2_Paint;
            // 
            // lblTemps
            // 
            lblTemps.AutoSize = true;
            lblTemps.ForeColor = Color.FromArgb(205, 33, 42);
            lblTemps.Location = new Point(42, 23);
            lblTemps.Name = "lblTemps";
            lblTemps.Size = new Size(43, 20);
            lblTemps.TabIndex = 18;
            lblTemps.Text = "Xmin";
            lblTemps.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIntituleNumLigne
            // 
            lblIntituleNumLigne.AutoSize = true;
            lblIntituleNumLigne.Location = new Point(9, 237);
            lblIntituleNumLigne.Name = "lblIntituleNumLigne";
            lblIntituleNumLigne.Size = new Size(138, 20);
            lblIntituleNumLigne.TabIndex = 4;
            lblIntituleNumLigne.Text = "N°Ligne de départ :";
            // 
            // picVoirPlus
            // 
            picVoirPlus.Dock = DockStyle.Top;
            picVoirPlus.Image = (Image)resources.GetObject("picVoirPlus.Image");
            picVoirPlus.Location = new Point(3, 281);
            picVoirPlus.Name = "picVoirPlus";
            picVoirPlus.Size = new Size(350, 61);
            picVoirPlus.SizeMode = PictureBoxSizeMode.Zoom;
            picVoirPlus.TabIndex = 3;
            picVoirPlus.TabStop = false;
            picVoirPlus.Click += picVoirPlus_Click;
            // 
            // grpRecherche
            // 
            grpRecherche.Controls.Add(lblTitre);
            grpRecherche.Controls.Add(grpRecherche2);
            grpRecherche.Controls.Add(grpRecherche1);
            grpRecherche.Location = new Point(3, 281);
            grpRecherche.Name = "grpRecherche";
            grpRecherche.Size = new Size(355, 445);
            grpRecherche.TabIndex = 58;
            grpRecherche.TabStop = false;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(9, 45);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(163, 29);
            lblTitre.TabIndex = 30;
            lblTitre.Text = "RECHERCHE";
            // 
            // grpRecherche2
            // 
            grpRecherche2.Controls.Add(lblArrivee);
            grpRecherche2.Controls.Add(lblDepart);
            grpRecherche2.Controls.Add(cmbDepart);
            grpRecherche2.Controls.Add(cmbArrivee);
            grpRecherche2.Location = new Point(3, 89);
            grpRecherche2.Name = "grpRecherche2";
            grpRecherche2.Size = new Size(347, 195);
            grpRecherche2.TabIndex = 31;
            grpRecherche2.TabStop = false;
            grpRecherche2.Paint += grpRecherche2_Paint_1;
            // 
            // lblArrivee
            // 
            lblArrivee.AutoSize = true;
            lblArrivee.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblArrivee.ForeColor = Color.FromArgb(15, 93, 70);
            lblArrivee.Location = new Point(16, 107);
            lblArrivee.Name = "lblArrivee";
            lblArrivee.Size = new Size(140, 20);
            lblArrivee.TabIndex = 32;
            lblArrivee.Text = "Station d'arrivée :";
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepart.ForeColor = Color.FromArgb(15, 93, 70);
            lblDepart.Location = new Point(16, 23);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(146, 20);
            lblDepart.TabIndex = 31;
            lblDepart.Text = "Station de départ :";
            // 
            // cmbDepart
            // 
            cmbDepart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepart.ForeColor = Color.FromArgb(205, 33, 42);
            cmbDepart.FormattingEnabled = true;
            cmbDepart.Location = new Point(16, 59);
            cmbDepart.Name = "cmbDepart";
            cmbDepart.Size = new Size(316, 26);
            cmbDepart.TabIndex = 33;
            cmbDepart.Text = "Choisir une station";
            // 
            // cmbArrivee
            // 
            cmbArrivee.Font = new Font("Microsoft Sans Serif", 9F);
            cmbArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            cmbArrivee.FormattingEnabled = true;
            cmbArrivee.Location = new Point(16, 139);
            cmbArrivee.Name = "cmbArrivee";
            cmbArrivee.Size = new Size(316, 26);
            cmbArrivee.TabIndex = 34;
            cmbArrivee.Text = "Choisir une station";
            // 
            // grpRecherche1
            // 
            grpRecherche1.Controls.Add(dtpArrivee);
            grpRecherche1.Controls.Add(lblHoraireArrivee);
            grpRecherche1.Controls.Add(lblHoraires);
            grpRecherche1.Controls.Add(lblHoraireDepart);
            grpRecherche1.Controls.Add(dtpDepart);
            grpRecherche1.Location = new Point(3, 281);
            grpRecherche1.Name = "grpRecherche1";
            grpRecherche1.Size = new Size(347, 157);
            grpRecherche1.TabIndex = 20;
            grpRecherche1.TabStop = false;
            grpRecherche1.Paint += grpRecherche1_Paint;
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblHoraires.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraires.Location = new Point(16, 23);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(84, 20);
            lblHoraires.TabIndex = 23;
            lblHoraires.Text = "Horaires :";
            // 
            // lblHoraireDepart
            // 
            lblHoraireDepart.AutoSize = true;
            lblHoraireDepart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraireDepart.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraireDepart.Location = new Point(16, 67);
            lblHoraireDepart.Name = "lblHoraireDepart";
            lblHoraireDepart.Size = new Size(130, 18);
            lblHoraireDepart.TabIndex = 24;
            lblHoraireDepart.Text = "Horaire de départ :";
            // 
            // dtpDepart
            // 
            dtpDepart.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDepart.CalendarForeColor = Color.FromArgb(205, 33, 42);
            dtpDepart.CustomFormat = "\"HH:mm:SS\"";
            dtpDepart.Format = DateTimePickerFormat.Time;
            dtpDepart.Location = new Point(203, 60);
            dtpDepart.Name = "dtpDepart";
            dtpDepart.ShowUpDown = true;
            dtpDepart.Size = new Size(129, 27);
            dtpDepart.TabIndex = 26;
            dtpDepart.Value = new DateTime(2025, 4, 29, 22, 31, 8, 0);
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
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(0, 0);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(27, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 23;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // lblHoraireArrivee
            // 
            lblHoraireArrivee.AutoSize = true;
            lblHoraireArrivee.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraireArrivee.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraireArrivee.Location = new Point(16, 108);
            lblHoraireArrivee.Name = "lblHoraireArrivee";
            lblHoraireArrivee.Size = new Size(130, 18);
            lblHoraireArrivee.TabIndex = 27;
            lblHoraireArrivee.Text = "Horaire de départ :";
            // 
            // dtpArrivee
            // 
            dtpArrivee.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpArrivee.CalendarForeColor = Color.FromArgb(205, 33, 42);
            dtpArrivee.CustomFormat = "\"HH:mm:SS\"";
            dtpArrivee.Format = DateTimePickerFormat.Time;
            dtpArrivee.Location = new Point(203, 102);
            dtpArrivee.Name = "dtpArrivee";
            dtpArrivee.ShowUpDown = true;
            dtpArrivee.Size = new Size(129, 27);
            dtpArrivee.TabIndex = 28;
            dtpArrivee.Value = new DateTime(2025, 4, 29, 22, 31, 8, 0);
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
            pnlRecherche.PerformLayout();
            flpResultat.ResumeLayout(false);
            grpResultat.ResumeLayout(false);
            grpResultat.PerformLayout();
            grpResultat1.ResumeLayout(false);
            grpResultat1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDeuxPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFlecheItineraire).EndInit();
            grpResultat2.ResumeLayout(false);
            grpResultat2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVoirPlus).EndInit();
            grpRecherche.ResumeLayout(false);
            grpRecherche.PerformLayout();
            grpRecherche2.ResumeLayout(false);
            grpRecherche2.PerformLayout();
            grpRecherche1.ResumeLayout(false);
            grpRecherche1.PerformLayout();
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
        private GroupBox grpRecherche;
        private GroupBox grpRecherche1;
        private Label lblHoraires;
        private Label lblHoraireDepart;
        private DateTimePicker dtpDepart;
        private GroupBox grpRecherche2;
        private Label lblTitre;
        private Label lblArrivee;
        private Label lblDepart;
        private ComboBox cmbDepart;
        private ComboBox cmbArrivee;
        private FlowLayoutPanel flpResultat;
        private GroupBox grpResultat;
        private ListBox lstStations;
        private Label lblIntituleNumLigne;
        private PictureBox picVoirPlus;
        private Label lblNumLigneResultat;
        private GroupBox grpResultat1;
        private Label lblTempsArrivee;
        private Label lblTempsDepart;
        private Label lblArrivee2;
        private Label lblDepart2;
        private GroupBox grpResultat2;
        private Label lblTemps;
        private PictureBox picDeuxPoints;
        private PictureBox picFlecheItineraire;
        private Label lblHoraireArrivee;
        private DateTimePicker dtpArrivee;
    }
}