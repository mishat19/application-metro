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
            // btnRecherche
            // 
            btnRecherche.Enabled = false;
            btnRecherche.Location = new Point(277, 113);
            btnRecherche.Margin = new Padding(3, 2, 3, 2);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(151, 21);
            btnRecherche.TabIndex = 27;
            btnRecherche.Text = "Rechercher";
            btnRecherche.UseVisualStyleBackColor = true;
            // 
            // cmbLignes
            // 
            cmbLignes.Enabled = false;
            cmbLignes.FormattingEnabled = true;
            cmbLignes.Location = new Point(175, 69);
            cmbLignes.Margin = new Padding(3, 2, 3, 2);
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
            // calDate
            // 
            calDate.Location = new Point(238, 251);
            calDate.Margin = new Padding(8, 7, 8, 7);
            calDate.Name = "calDate";
            calDate.TabIndex = 30;
            // 
            // lstStations
            // 
            lstStations.FormattingEnabled = true;
            lstStations.ItemHeight = 15;
            lstStations.Location = new Point(238, 163);
            lstStations.Margin = new Padding(3, 2, 3, 2);
            lstStations.Name = "lstStations";
            lstStations.Size = new Size(230, 79);
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
            // 
            // Consultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 448);
            Controls.Add(cmbStation);
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