namespace application_metro
{
    partial class Consultation
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
            btnRecherche = new Button();
            cmbLignes = new ComboBox();
            btnRetour = new Button();
            calDate = new MonthCalendar();
            lstStations = new ListBox();
            cmbStation = new ComboBox();
            SuspendLayout();
            // 
            // picSupprimer
            // 
            picSupprimer.Image = (Image)resources.GetObject("picSupprimer.Image");
            picSupprimer.Location = new Point(148, 102);
            picSupprimer.Name = "picSupprimer";
            picSupprimer.Size = new Size(26, 28);
            picSupprimer.SizeMode = PictureBoxSizeMode.CenterImage;
            picSupprimer.TabIndex = 28;
            picSupprimer.TabStop = false;
            // 
            // btnRecherche
            // 
            btnRecherche.Enabled = false;
            btnRecherche.Location = new Point(277, 113);
            btnRecherche.Margin = new Padding(3, 2, 3, 2);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(166, 28);
            btnRecherche.TabIndex = 27;
            btnRecherche.Text = "Rechercher";
            btnRecherche.UseVisualStyleBackColor = true;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // cmbLignes
            // 
            cmbLignes.Enabled = false;
            cmbLignes.FormattingEnabled = true;
            cmbLignes.Location = new Point(12, 102);
            cmbLignes.Name = "cmbLignes";
            cmbLignes.Size = new Size(163, 23);
            cmbLignes.TabIndex = 26;
            cmbLignes.Text = "Ligne n°";
            cmbLignes.SelectedIndexChanged += cmbLignes_SelectedIndexChanged;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(10, 9);
            btnRetour.Margin = new Padding(3, 2, 3, 2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(110, 29);
            btnRetour.TabIndex = 25;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // grpDestinations
            // 
            grpDestinations.Controls.Add(rjToggleButton2);
            grpDestinations.Controls.Add(rjToggleButton1);
            grpDestinations.Controls.Add(lblDestinationB);
            grpDestinations.Controls.Add(lblDestinationA);
            grpDestinations.Location = new Point(12, 136);
            grpDestinations.Name = "grpDestinations";
            grpDestinations.Size = new Size(358, 90);
            grpDestinations.TabIndex = 29;
            grpDestinations.TabStop = false;
            // 
            // rjToggleButton2
            // 
            rjToggleButton2.AutoSize = true;
            rjToggleButton2.Checked = true;
            rjToggleButton2.CheckState = CheckState.Checked;
            rjToggleButton2.Location = new Point(264, 26);
            rjToggleButton2.MinimumSize = new Size(45, 22);
            rjToggleButton2.Name = "rjToggleButton2";
            rjToggleButton2.OffBackColor = Color.Gray;
            rjToggleButton2.OffToggleColor = Color.Gainsboro;
            rjToggleButton2.OnBackColor = Color.MediumSlateBlue;
            rjToggleButton2.OnToggleColor = Color.WhiteSmoke;
            rjToggleButton2.Size = new Size(45, 22);
            rjToggleButton2.TabIndex = 33;
            rjToggleButton2.UseVisualStyleBackColor = true;
            // 
            // rjToggleButton1
            // 
            rjToggleButton1.AutoSize = true;
            rjToggleButton1.Location = new Point(72, 26);
            rjToggleButton1.MinimumSize = new Size(45, 22);
            rjToggleButton1.Name = "rjToggleButton1";
            rjToggleButton1.OffBackColor = Color.Gray;
            rjToggleButton1.OffToggleColor = Color.Gainsboro;
            rjToggleButton1.OnBackColor = Color.MediumSlateBlue;
            rjToggleButton1.OnToggleColor = Color.WhiteSmoke;
            rjToggleButton1.Size = new Size(45, 22);
            rjToggleButton1.TabIndex = 32;
            rjToggleButton1.UseVisualStyleBackColor = true;
            // 
            // lblDestinationB
            // 
            lblDestinationB.AutoSize = true;
            lblDestinationB.Location = new Point(207, 57);
            lblDestinationB.Name = "lblDestinationB";
            lblDestinationB.Size = new Size(129, 20);
            lblDestinationB.TabIndex = 31;
            lblDestinationB.Text = "Vers Destination B";
            // 
            // lblDestinationA
            // 
            lblDestinationA.AutoSize = true;
            lblDestinationA.Location = new Point(32, 57);
            lblDestinationA.Name = "lblDestinationA";
            lblDestinationA.Size = new Size(130, 20);
            lblDestinationA.TabIndex = 30;
            lblDestinationA.Text = "Vers Destination A";
            // 
            // calDate
            // 
            calDate.Location = new Point(59, 501);
            calDate.Name = "calDate";
            calDate.TabIndex = 30;
            // 
            // lstStations
            // 
            lstStations.FormattingEnabled = true;
            lstStations.Location = new Point(12, 232);
            lstStations.Name = "lstStations";
            lstStations.Size = new Size(358, 224);
            lstStations.TabIndex = 31;
            // 
            // cmbStation
            // 
            cmbStation.Enabled = false;
            cmbStation.FormattingEnabled = true;
            cmbStation.Location = new Point(361, 69);
            cmbStation.Margin = new Padding(3, 2, 3, 2);
            cmbStation.Name = "cmbStation";
            cmbStation.Size = new Size(163, 23);
            cmbStation.TabIndex = 32;
            cmbStation.Text = "Nom de la station";
            cmbStation.SelectedIndexChanged += cmbStation_SelectedIndexChanged;
            // 
            // Consultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 753);
            Controls.Add(lstStations);
            Controls.Add(calDate);
            Controls.Add(btnRecherche);
            Controls.Add(cmbLignes);
            Controls.Add(btnRetour);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Consultation";
            Text = "Horaires de la station";
            Load += consultation_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnRecherche;
        private ComboBox cmbLignes;
        private Button btnRetour;
        private MonthCalendar calDate;
        private ListBox lstStations;
        private ComboBox cmbStation;
    }
}