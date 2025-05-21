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
            btnRecherche.Location = new Point(122, 196);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(190, 37);
            btnRecherche.TabIndex = 27;
            btnRecherche.Text = "Rechercher";
            btnRecherche.UseVisualStyleBackColor = true;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // cmbLignes
            // 
            cmbLignes.Enabled = false;
            cmbLignes.FormattingEnabled = true;
            cmbLignes.Location = new Point(14, 136);
            cmbLignes.Margin = new Padding(3, 4, 3, 4);
            cmbLignes.Name = "cmbLignes";
            cmbLignes.Size = new Size(186, 28);
            cmbLignes.TabIndex = 26;
            cmbLignes.Text = "Ligne n°";
            cmbLignes.SelectedIndexChanged += cmbLignes_SelectedIndexChanged;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(11, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 39);
            btnRetour.TabIndex = 25;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // calDate
            // 
            calDate.Location = new Point(67, 668);
            calDate.Margin = new Padding(10, 12, 10, 12);
            calDate.Name = "calDate";
            calDate.TabIndex = 30;
            // 
            // lstStations
            // 
            lstStations.FormattingEnabled = true;
            lstStations.Location = new Point(14, 309);
            lstStations.Margin = new Padding(3, 4, 3, 4);
            lstStations.Name = "lstStations";
            lstStations.Size = new Size(409, 284);
            lstStations.TabIndex = 31;
            // 
            // cmbStation
            // 
            cmbStation.Enabled = false;
            cmbStation.FormattingEnabled = true;
            cmbStation.Location = new Point(361, 69);
            cmbStation.Margin = new Padding(3, 2, 3, 2);
            cmbStation.Name = "cmbStation";
            cmbStation.Size = new Size(163, 28);
            cmbStation.TabIndex = 32;
            cmbStation.Text = "Nom de la station";
            cmbStation.SelectedIndexChanged += cmbStation_SelectedIndexChanged;
            // 
            // Consultation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 1004);
            Controls.Add(lstStations);
            Controls.Add(calDate);
            Controls.Add(btnRecherche);
            Controls.Add(cmbLignes);
            Controls.Add(btnRetour);
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