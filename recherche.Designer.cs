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
            grpTrajet.Size = new Size(358, 282);
            grpTrajet.TabIndex = 16;
            grpTrajet.TabStop = false;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(105, 179);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(126, 28);
            btnDetails.TabIndex = 17;
            btnDetails.Text = "Détails";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // lblDuree
            // 
            lblDuree.AutoSize = true;
            lblDuree.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuree.Location = new Point(288, 127);
            lblDuree.Name = "lblDuree";
            lblDuree.Size = new Size(64, 25);
            lblDuree.TabIndex = 24;
            lblDuree.Text = "40min";
            // 
            // lblLigne
            // 
            lblLigne.AutoSize = true;
            lblLigne.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLigne.Location = new Point(0, 127);
            lblLigne.Name = "lblLigne";
            lblLigne.Size = new Size(74, 25);
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
            lblHeureArrivee.Location = new Point(197, 62);
            lblHeureArrivee.Name = "lblHeureArrivee";
            lblHeureArrivee.Size = new Size(98, 20);
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
            lblHeureDepart.Location = new Point(57, 62);
            lblHeureDepart.Name = "lblHeureDepart";
            lblHeureDepart.Size = new Size(97, 20);
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
            lblStationArrivee.Location = new Point(197, 33);
            lblStationArrivee.Name = "lblStationArrivee";
            lblStationArrivee.Size = new Size(107, 20);
            lblStationArrivee.TabIndex = 18;
            lblStationArrivee.Text = "Station Arrivée";
            // 
            // lblStationDepart
            // 
            lblStationDepart.AutoSize = true;
            lblStationDepart.Location = new Point(48, 33);
            lblStationDepart.Name = "lblStationDepart";
            lblStationDepart.Size = new Size(106, 20);
            lblStationDepart.TabIndex = 17;
            lblStationDepart.Text = "Station Départ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 682);
            label8.Name = "label8";
            label8.Size = new Size(211, 28);
            label8.TabIndex = 15;
            label8.Text = "Trajet le plus rapide :";
            // 
            // btnRecherche
            // 
            btnRecherche.Location = new Point(12, 601);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(358, 64);
            btnRecherche.TabIndex = 8;
            btnRecherche.Text = "Lancer la recherche";
            btnRecherche.UseVisualStyleBackColor = true;
            // 
            // dtpArrivee
            // 
            dtpArrivee.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            dtpArrivee.Location = new Point(143, 552);
            dtpArrivee.Name = "dtpArrivee";
            dtpArrivee.Size = new Size(227, 27);
            dtpArrivee.TabIndex = 14;
            // 
            // dtpDepart
            // 
            dtpDepart.CustomFormat = "\"dd/MM HH:mm\"";
            dtpDepart.Location = new Point(143, 518);
            dtpDepart.Name = "dtpDepart";
            dtpDepart.Size = new Size(227, 27);
            dtpDepart.TabIndex = 13;
            dtpDepart.Value = new DateTime(2025, 4, 29, 22, 31, 8, 0);
            // 
            // lblHoraireArrivée
            // 
            lblHoraireArrivée.AutoSize = true;
            lblHoraireArrivée.Location = new Point(12, 557);
            lblHoraireArrivée.Name = "lblHoraireArrivée";
            lblHoraireArrivée.Size = new Size(120, 20);
            lblHoraireArrivée.TabIndex = 12;
            lblHoraireArrivée.Text = "Horaire d'arrivée";
            // 
            // lblHoraireDepart
            // 
            lblHoraireDepart.AutoSize = true;
            lblHoraireDepart.Location = new Point(12, 525);
            lblHoraireDepart.Name = "lblHoraireDepart";
            lblHoraireDepart.Size = new Size(128, 20);
            lblHoraireDepart.TabIndex = 11;
            lblHoraireDepart.Text = "Horaire de départ";
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblHoraires.Location = new Point(12, 491);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(77, 23);
            lblHoraires.TabIndex = 10;
            lblHoraires.Text = "Horaires";
            // 
            // cmbArrivee
            // 
            cmbArrivee.FormattingEnabled = true;
            cmbArrivee.Location = new Point(12, 434);
            cmbArrivee.Name = "cmbArrivee";
            cmbArrivee.Size = new Size(358, 28);
            cmbArrivee.TabIndex = 19;
            cmbArrivee.Text = "Choisir une station";
            // 
            // lblArrivee
            // 
            lblArrivee.AutoSize = true;
            lblArrivee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblArrivee.Location = new Point(12, 408);
            lblArrivee.Name = "lblArrivee";
            lblArrivee.Size = new Size(144, 23);
            lblArrivee.TabIndex = 5;
            lblArrivee.Text = "Station d'arrivée";
            // 
            // cmbDepart
            // 
            cmbDepart.FormattingEnabled = true;
            cmbDepart.Location = new Point(12, 368);
            cmbDepart.Name = "cmbDepart";
            cmbDepart.Size = new Size(358, 28);
            cmbDepart.TabIndex = 18;
            cmbDepart.Text = "Choisir une station";
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDepart.Location = new Point(12, 342);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(152, 23);
            lblDepart.TabIndex = 4;
            lblDepart.Text = "Station de départ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 295);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 3;
            label1.Text = "Recherche";
            // 
            // picMap
            // 
            picMap.Location = new Point(12, 73);
            picMap.Name = "picMap";
            picMap.Size = new Size(358, 200);
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