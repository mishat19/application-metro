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
            btnRetour = new Button();
            picMap = new PictureBox();
            label1 = new Label();
            lblDepart = new Label();
            lblArrivee = new Label();
            btnRecherche = new Button();
            lblHoraires = new Label();
            lblHoraireDepart = new Label();
            lblHoraireArrivée = new Label();
            dtpDepart = new DateTimePicker();
            dtpArrivee = new DateTimePicker();
            label8 = new Label();
            grpTrajet = new GroupBox();
            btnDetails = new Button();
            lblDuree = new Label();
            lblLigne = new Label();
            lblSeparation2 = new Label();
            lblHeureArrivee = new Label();
            lblHeureDepart = new Label();
            lblSeparation = new Label();
            lblStationArrivee = new Label();
            lblStationDepart = new Label();
            picPlus = new PictureBox();
            cmbDepart = new ComboBox();
            cmbArrivee = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            grpTrajet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).BeginInit();
            SuspendLayout();
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
            // picMap
            // 
            picMap.Location = new Point(153, 59);
            picMap.Name = "picMap";
            picMap.Size = new Size(462, 200);
            picMap.TabIndex = 2;
            picMap.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 269);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 3;
            label1.Text = "Recherche";
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDepart.Location = new Point(65, 334);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(152, 23);
            lblDepart.TabIndex = 4;
            lblDepart.Text = "Station de départ";
            // 
            // lblArrivee
            // 
            lblArrivee.AutoSize = true;
            lblArrivee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblArrivee.Location = new Point(65, 397);
            lblArrivee.Name = "lblArrivee";
            lblArrivee.Size = new Size(144, 23);
            lblArrivee.TabIndex = 5;
            lblArrivee.Text = "Station d'arrivée";
            // 
            // btnRecherche
            // 
            btnRecherche.Location = new Point(227, 598);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(360, 48);
            btnRecherche.TabIndex = 8;
            btnRecherche.Text = "Lancer la recherche";
            btnRecherche.UseVisualStyleBackColor = true;
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblHoraires.Location = new Point(65, 473);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(77, 23);
            lblHoraires.TabIndex = 10;
            lblHoraires.Text = "Horaires";
            // 
            // lblHoraireDepart
            // 
            lblHoraireDepart.AutoSize = true;
            lblHoraireDepart.Location = new Point(65, 508);
            lblHoraireDepart.Name = "lblHoraireDepart";
            lblHoraireDepart.Size = new Size(128, 20);
            lblHoraireDepart.TabIndex = 11;
            lblHoraireDepart.Text = "Horaire de départ";
            // 
            // lblHoraireArrivée
            // 
            lblHoraireArrivée.AutoSize = true;
            lblHoraireArrivée.Location = new Point(65, 537);
            lblHoraireArrivée.Name = "lblHoraireArrivée";
            lblHoraireArrivée.Size = new Size(120, 20);
            lblHoraireArrivée.TabIndex = 12;
            lblHoraireArrivée.Text = "Horaire d'arrivée";
            // 
            // dtpDepart
            // 
            dtpDepart.CustomFormat = "\"dd/MM HH:mm\"";
            dtpDepart.Location = new Point(224, 503);
            dtpDepart.Name = "dtpDepart";
            dtpDepart.Size = new Size(250, 27);
            dtpDepart.TabIndex = 13;
            dtpDepart.Value = new DateTime(2025, 4, 29, 22, 31, 8, 0);
            // 
            // dtpArrivee
            // 
            dtpArrivee.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            dtpArrivee.Location = new Point(224, 537);
            dtpArrivee.Name = "dtpArrivee";
            dtpArrivee.Size = new Size(250, 27);
            dtpArrivee.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(65, 670);
            label8.Name = "label8";
            label8.Size = new Size(211, 28);
            label8.TabIndex = 15;
            label8.Text = "Trajet le plus rapide :";
            // 
            // grpTrajet
            // 
            grpTrajet.Controls.Add(btnDetails);
            grpTrajet.Controls.Add(lblDuree);
            grpTrajet.Controls.Add(lblLigne);
            grpTrajet.Controls.Add(lblSeparation2);
            grpTrajet.Controls.Add(lblHeureArrivee);
            grpTrajet.Controls.Add(lblHeureDepart);
            grpTrajet.Controls.Add(lblSeparation);
            grpTrajet.Controls.Add(lblStationArrivee);
            grpTrajet.Controls.Add(lblStationDepart);
            grpTrajet.Location = new Point(221, 712);
            grpTrajet.Name = "grpTrajet";
            grpTrajet.Size = new Size(394, 171);
            grpTrajet.TabIndex = 16;
            grpTrajet.TabStop = false;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(262, 137);
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
            lblDuree.Location = new Point(308, 100);
            lblDuree.Name = "lblDuree";
            lblDuree.Size = new Size(64, 25);
            lblDuree.TabIndex = 24;
            lblDuree.Text = "40min";
            // 
            // lblLigne
            // 
            lblLigne.AutoSize = true;
            lblLigne.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLigne.Location = new Point(6, 100);
            lblLigne.Name = "lblLigne";
            lblLigne.Size = new Size(74, 25);
            lblLigne.TabIndex = 23;
            lblLigne.Text = "N°Ligne";
            lblLigne.Click += label15_Click;
            // 
            // lblSeparation2
            // 
            lblSeparation2.AutoSize = true;
            lblSeparation2.Location = new Point(183, 62);
            lblSeparation2.Name = "lblSeparation2";
            lblSeparation2.Size = new Size(31, 20);
            lblSeparation2.TabIndex = 22;
            lblSeparation2.Text = "-->";
            // 
            // lblHeureArrivee
            // 
            lblHeureArrivee.AutoSize = true;
            lblHeureArrivee.Location = new Point(220, 62);
            lblHeureArrivee.Name = "lblHeureArrivee";
            lblHeureArrivee.Size = new Size(98, 20);
            lblHeureArrivee.TabIndex = 21;
            lblHeureArrivee.Text = "Heure arrivée";
            // 
            // lblHeureDepart
            // 
            lblHeureDepart.AutoSize = true;
            lblHeureDepart.Location = new Point(80, 62);
            lblHeureDepart.Name = "lblHeureDepart";
            lblHeureDepart.Size = new Size(97, 20);
            lblHeureDepart.TabIndex = 20;
            lblHeureDepart.Text = "Heure départ";
            // 
            // lblSeparation
            // 
            lblSeparation.AutoSize = true;
            lblSeparation.Location = new Point(183, 33);
            lblSeparation.Name = "lblSeparation";
            lblSeparation.Size = new Size(31, 20);
            lblSeparation.TabIndex = 19;
            lblSeparation.Text = "-->";
            // 
            // lblStationArrivee
            // 
            lblStationArrivee.AutoSize = true;
            lblStationArrivee.Location = new Point(220, 33);
            lblStationArrivee.Name = "lblStationArrivee";
            lblStationArrivee.Size = new Size(107, 20);
            lblStationArrivee.TabIndex = 18;
            lblStationArrivee.Text = "Station Arrivée";
            // 
            // lblStationDepart
            // 
            lblStationDepart.AutoSize = true;
            lblStationDepart.Location = new Point(71, 33);
            lblStationDepart.Name = "lblStationDepart";
            lblStationDepart.Size = new Size(106, 20);
            lblStationDepart.TabIndex = 17;
            lblStationDepart.Text = "Station Départ";
            // 
            // picPlus
            // 
            picPlus.Image = (Image)resources.GetObject("picPlus.Image");
            picPlus.Location = new Point(387, 908);
            picPlus.Name = "picPlus";
            picPlus.Size = new Size(48, 53);
            picPlus.SizeMode = PictureBoxSizeMode.CenterImage;
            picPlus.TabIndex = 17;
            picPlus.TabStop = false;
            // 
            // cmbDepart
            // 
            cmbDepart.FormattingEnabled = true;
            cmbDepart.Location = new Point(66, 366);
            cmbDepart.Name = "cmbDepart";
            cmbDepart.Size = new Size(408, 28);
            cmbDepart.TabIndex = 18;
            cmbDepart.Text = "Choisir une station";
            // 
            // cmbArrivee
            // 
            cmbArrivee.FormattingEnabled = true;
            cmbArrivee.Location = new Point(66, 432);
            cmbArrivee.Name = "cmbArrivee";
            cmbArrivee.Size = new Size(408, 28);
            cmbArrivee.TabIndex = 19;
            cmbArrivee.Text = "Choisir une station";
            // 
            // Recherche
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 973);
            Controls.Add(cmbArrivee);
            Controls.Add(cmbDepart);
            Controls.Add(picPlus);
            Controls.Add(grpTrajet);
            Controls.Add(label8);
            Controls.Add(dtpArrivee);
            Controls.Add(dtpDepart);
            Controls.Add(lblHoraireArrivée);
            Controls.Add(lblHoraireDepart);
            Controls.Add(lblHoraires);
            Controls.Add(btnRecherche);
            Controls.Add(lblArrivee);
            Controls.Add(lblDepart);
            Controls.Add(label1);
            Controls.Add(picMap);
            Controls.Add(btnRetour);
            Name = "Recherche";
            Text = "Rechercher un itinéraire";
            Load += consultation_Load;
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            grpTrajet.ResumeLayout(false);
            grpTrajet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private PictureBox picMap;
        private Label label1;
        private Label lblDepart;
        private Label lblArrivee;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnRecherche;
        private Label lblHoraires;
        private Label lblHoraireDepart;
        private Label lblHoraireArrivée;
        private DateTimePicker dtpDepart;
        private DateTimePicker dtpArrivee;
        private Label label8;
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
        private ComboBox cmbDepart;
        private ComboBox cmbArrivee;
    }
}