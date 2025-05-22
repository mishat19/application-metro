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
            picFond2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picFond2).BeginInit();
            SuspendLayout();
            // 
            // btnRecherche
            // 
            btnRecherche.BackColor = Color.FromArgb(205, 33, 42);
            btnRecherche.Enabled = false;
            btnRecherche.FlatStyle = FlatStyle.Flat;
            btnRecherche.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold);
            btnRecherche.ForeColor = Color.White;
            btnRecherche.Location = new Point(81, 146);
            btnRecherche.Margin = new Padding(3, 2, 3, 2);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(172, 40);
            btnRecherche.TabIndex = 27;
            btnRecherche.Text = "Rechercher";
            btnRecherche.UseVisualStyleBackColor = false;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // cmbLignes
            // 
            cmbLignes.Enabled = false;
            cmbLignes.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            cmbLignes.ForeColor = Color.FromArgb(205, 33, 42);
            cmbLignes.FormattingEnabled = true;
            cmbLignes.Location = new Point(12, 102);
            cmbLignes.Name = "cmbLignes";
            cmbLignes.Size = new Size(163, 29);
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
            // calDate
            // 
            calDate.BackColor = Color.FromArgb(255, 230, 188);
            calDate.Location = new Point(52, 380);
            calDate.Margin = new Padding(10, 12, 10, 12);
            calDate.Name = "calDate";
            calDate.TabIndex = 30;
            calDate.TitleBackColor = Color.Aqua;
            calDate.TitleForeColor = Color.Aqua;
            calDate.TrailingForeColor = Color.Green;
            calDate.DateSelected += calDate_DateSelected;
            // 
            // lstStations
            // 
            lstStations.BackColor = Color.FromArgb(255, 230, 188);
            lstStations.FormattingEnabled = true;
            lstStations.ItemHeight = 15;
            lstStations.Location = new Point(14, 200);
            lstStations.Margin = new Padding(3, 4, 3, 4);
            lstStations.Name = "lstStations";
            lstStations.Size = new Size(310, 154);
            lstStations.TabIndex = 31;
            lstStations.SelectedIndexChanged += lstStations_SelectedIndexChanged;
            // 
            // cmbStation
            // 
            cmbStation.Enabled = false;
            cmbStation.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            cmbStation.ForeColor = Color.FromArgb(205, 33, 42);
            cmbStation.FormattingEnabled = true;
            cmbStation.Location = new Point(180, 102);
            cmbStation.Name = "cmbStation";
            cmbStation.Size = new Size(144, 29);
            cmbStation.TabIndex = 32;
            cmbStation.Text = "Nom de la station";
            cmbStation.SelectedIndexChanged += cmbStation_SelectedIndexChanged;
            // 
            // picFond2
            // 
            picFond2.Image = Properties.Resources.imgFondMilan1;
            picFond2.Location = new Point(-19, 200);
            picFond2.Margin = new Padding(3, 2, 3, 2);
            picFond2.Name = "picFond2";
            picFond2.Size = new Size(763, 414);
            picFond2.SizeMode = PictureBoxSizeMode.Zoom;
            picFond2.TabIndex = 53;
            picFond2.TabStop = false;
            // 
            // Consultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(334, 565);
            Controls.Add(cmbStation);
            Controls.Add(lstStations);
            Controls.Add(calDate);
            Controls.Add(btnRecherche);
            Controls.Add(cmbLignes);
            Controls.Add(btnRetour);
            Controls.Add(picFond2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Consultation";
            Text = "Horaires de la station";
            Load += consultation_Load;
            ((System.ComponentModel.ISupportInitialize)picFond2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRecherche;
        private ComboBox cmbLignes;
        private Button btnRetour;
        private MonthCalendar calDate;
        private ListBox lstStations;
        private ComboBox comboBox1;
        private ComboBox cmbStation;
        private PictureBox picFond2;
    }
}