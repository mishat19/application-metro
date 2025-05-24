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
            label8 = new Label();
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
            label1 = new Label();
            picMap = new PictureBox();
            btnRetour = new Button();
            pnlRecherche = new Panel();
            grpTrajet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            pnlRecherche.SuspendLayout();
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
            grpTrajet.Location = new Point(12, 713);
            grpTrajet.Name = "grpTrajet";
            grpTrajet.Size = new Size(339, 282);
            grpTrajet.TabIndex = 16;
            grpTrajet.TabStop = false;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.FromArgb(205, 33, 42);
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Font = new Font("Gliker", 10.2F);
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
            lblDuree.Font = new Font("DynaPuff", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDuree.ForeColor = Color.FromArgb(205, 33, 42);
            lblDuree.Location = new Point(275, 127);
            lblDuree.Name = "lblDuree";
            lblDuree.Size = new Size(64, 23);
            lblDuree.TabIndex = 24;
            lblDuree.Text = "40min";
            // 
            // lblLigne
            // 
            lblLigne.AutoSize = true;
            lblLigne.Font = new Font("DynaPuff", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLigne.ForeColor = Color.FromArgb(205, 33, 42);
            lblLigne.Location = new Point(0, 127);
            lblLigne.Name = "lblLigne";
            lblLigne.Size = new Size(76, 23);
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
            lblHeureArrivee.Font = new Font("DynaPuff", 7.79999971F);
            lblHeureArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            lblHeureArrivee.Location = new Point(197, 62);
            lblHeureArrivee.Name = "lblHeureArrivee";
            lblHeureArrivee.Size = new Size(98, 17);
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
            lblHeureDepart.Font = new Font("DynaPuff", 7.79999971F);
            lblHeureDepart.ForeColor = Color.FromArgb(205, 33, 42);
            lblHeureDepart.Location = new Point(57, 62);
            lblHeureDepart.Name = "lblHeureDepart";
            lblHeureDepart.Size = new Size(95, 17);
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
            lblStationArrivee.Font = new Font("DynaPuff", 7.79999971F);
            lblStationArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            lblStationArrivee.Location = new Point(197, 33);
            lblStationArrivee.Name = "lblStationArrivee";
            lblStationArrivee.Size = new Size(108, 17);
            lblStationArrivee.TabIndex = 18;
            lblStationArrivee.Text = "Station Arrivée";
            // 
            // lblStationDepart
            // 
            lblStationDepart.AutoSize = true;
            lblStationDepart.Font = new Font("DynaPuff", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStationDepart.ForeColor = Color.FromArgb(205, 33, 42);
            lblStationDepart.Location = new Point(48, 33);
            lblStationDepart.Name = "lblStationDepart";
            lblStationDepart.Size = new Size(106, 17);
            lblStationDepart.TabIndex = 17;
            lblStationDepart.Text = "Station Départ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gliker", 10.2F);
            label8.ForeColor = Color.FromArgb(15, 93, 70);
            label8.Location = new Point(12, 682);
            label8.Name = "label8";
            label8.Size = new Size(178, 20);
            label8.TabIndex = 15;
            label8.Text = "Trajet le plus rapide :";
            // 
            // btnRecherche
            // 
            btnRecherche.BackColor = Color.FromArgb(205, 33, 42);
            btnRecherche.Font = new Font("DynaPuff", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecherche.ForeColor = Color.White;
            btnRecherche.Location = new Point(12, 601);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(339, 64);
            btnRecherche.TabIndex = 8;
            btnRecherche.Text = "Lancer la recherche";
            btnRecherche.UseVisualStyleBackColor = false;
            // 
            // dtpArrivee
            // 
            dtpArrivee.CalendarForeColor = Color.FromArgb(205, 33, 42);
            dtpArrivee.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            dtpArrivee.Location = new Point(155, 552);
            dtpArrivee.Name = "dtpArrivee";
            dtpArrivee.Size = new Size(196, 27);
            dtpArrivee.TabIndex = 14;
            // 
            // dtpDepart
            // 
            dtpDepart.CalendarForeColor = Color.FromArgb(205, 33, 42);
            dtpDepart.CustomFormat = "\"dd/MM HH:mm\"";
            dtpDepart.Location = new Point(155, 518);
            dtpDepart.Name = "dtpDepart";
            dtpDepart.Size = new Size(196, 27);
            dtpDepart.TabIndex = 13;
            dtpDepart.Value = new DateTime(2025, 4, 29, 22, 31, 8, 0);
            // 
            // lblHoraireArrivée
            // 
            lblHoraireArrivée.AutoSize = true;
            lblHoraireArrivée.Font = new Font("DynaPuff", 9F);
            lblHoraireArrivée.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraireArrivée.Location = new Point(12, 557);
            lblHoraireArrivée.Name = "lblHoraireArrivée";
            lblHoraireArrivée.Size = new Size(133, 19);
            lblHoraireArrivée.TabIndex = 12;
            lblHoraireArrivée.Text = "Horaire d'arrivée";
            // 
            // lblHoraireDepart
            // 
            lblHoraireDepart.AutoSize = true;
            lblHoraireDepart.Font = new Font("DynaPuff", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraireDepart.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraireDepart.Location = new Point(12, 525);
            lblHoraireDepart.Name = "lblHoraireDepart";
            lblHoraireDepart.Size = new Size(139, 19);
            lblHoraireDepart.TabIndex = 11;
            lblHoraireDepart.Text = "Horaire de départ";
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Gliker", 10.2F);
            lblHoraires.ForeColor = Color.FromArgb(15, 93, 70);
            lblHoraires.Location = new Point(12, 491);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(77, 20);
            lblHoraires.TabIndex = 10;
            lblHoraires.Text = "Horaires";
            // 
            // cmbArrivee
            // 
            cmbArrivee.Font = new Font("DynaPuff", 9F);
            cmbArrivee.ForeColor = Color.FromArgb(205, 33, 42);
            cmbArrivee.FormattingEnabled = true;
            cmbArrivee.Location = new Point(12, 434);
            cmbArrivee.Name = "cmbArrivee";
            cmbArrivee.Size = new Size(339, 27);
            cmbArrivee.TabIndex = 19;
            cmbArrivee.Text = "Choisir une station";
            // 
            // lblArrivee
            // 
            lblArrivee.AutoSize = true;
            lblArrivee.Font = new Font("Gliker", 10.2F);
            lblArrivee.ForeColor = Color.FromArgb(15, 93, 70);
            lblArrivee.Location = new Point(12, 408);
            lblArrivee.Name = "lblArrivee";
            lblArrivee.Size = new Size(143, 20);
            lblArrivee.TabIndex = 5;
            lblArrivee.Text = "Station d'arrivée";
            // 
            // cmbDepart
            // 
            cmbDepart.Font = new Font("DynaPuff", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepart.ForeColor = Color.FromArgb(205, 33, 42);
            cmbDepart.FormattingEnabled = true;
            cmbDepart.Location = new Point(12, 368);
            cmbDepart.Name = "cmbDepart";
            cmbDepart.Size = new Size(339, 27);
            cmbDepart.TabIndex = 18;
            cmbDepart.Text = "Choisir une station";
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Font = new Font("Gliker", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepart.ForeColor = Color.FromArgb(15, 93, 70);
            lblDepart.Location = new Point(12, 342);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(152, 20);
            lblDepart.TabIndex = 4;
            lblDepart.Text = "Station de départ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gliker", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 93, 70);
            label1.Location = new Point(12, 295);
            label1.Name = "label1";
            label1.Size = new Size(146, 27);
            label1.TabIndex = 3;
            label1.Text = "RECHERCHE";
            // 
            // picMap
            // 
            picMap.Location = new Point(12, 73);
            picMap.Name = "picMap";
            picMap.Size = new Size(339, 200);
            picMap.TabIndex = 2;
            picMap.TabStop = false;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 39);
            btnRetour.TabIndex = 1;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // pnlRecherche
            // 
            pnlRecherche.AutoScroll = true;
            pnlRecherche.AutoScrollMinSize = new Size(0, 1300);
            pnlRecherche.BackColor = Color.FromArgb(255, 230, 188);
            pnlRecherche.Controls.Add(picMap);
            pnlRecherche.Controls.Add(cmbArrivee);
            pnlRecherche.Controls.Add(btnRetour);
            pnlRecherche.Controls.Add(cmbDepart);
            pnlRecherche.Controls.Add(label1);
            pnlRecherche.Controls.Add(lblDepart);
            pnlRecherche.Controls.Add(grpTrajet);
            pnlRecherche.Controls.Add(lblArrivee);
            pnlRecherche.Controls.Add(label8);
            pnlRecherche.Controls.Add(btnRecherche);
            pnlRecherche.Controls.Add(dtpArrivee);
            pnlRecherche.Controls.Add(lblHoraires);
            pnlRecherche.Controls.Add(dtpDepart);
            pnlRecherche.Controls.Add(lblHoraireDepart);
            pnlRecherche.Controls.Add(lblHoraireArrivée);
            pnlRecherche.Dock = DockStyle.Fill;
            pnlRecherche.Location = new Point(0, 0);
            pnlRecherche.Name = "pnlRecherche";
            pnlRecherche.Size = new Size(382, 753);
            pnlRecherche.TabIndex = 20;
            // 
            // Recherche
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 753);
            Controls.Add(pnlRecherche);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Recherche";
            Text = "Rechercher un itinéraire";
            Load += consultation_Load;
            grpTrajet.ResumeLayout(false);
            grpTrajet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            pnlRecherche.ResumeLayout(false);
            pnlRecherche.PerformLayout();
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
        private Label label8;
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
        private Label label1;
        private PictureBox picMap;
        private Button btnRetour;
        private Panel pnlRecherche;
    }
}