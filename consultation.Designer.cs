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
            btnRecherche.Font = new Font("DynaPuff", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecherche.ForeColor = Color.White;
            btnRecherche.Location = new Point(93, 195);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(197, 53);
            btnRecherche.TabIndex = 27;
            btnRecherche.Text = "Rechercher";
            btnRecherche.UseVisualStyleBackColor = false;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // cmbLignes
            // 
            cmbLignes.Enabled = false;
            cmbLignes.Font = new Font("DynaPuff", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLignes.ForeColor = Color.FromArgb(205, 33, 42);
            cmbLignes.FormattingEnabled = true;
            cmbLignes.Location = new Point(14, 136);
            cmbLignes.Margin = new Padding(3, 4, 3, 4);
            cmbLignes.Name = "cmbLignes";
            cmbLignes.Size = new Size(186, 27);
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
            calDate.BackColor = Color.FromArgb(255, 230, 188);
            calDate.Location = new Point(59, 507);
            calDate.Margin = new Padding(11, 16, 11, 16);
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
            lstStations.Location = new Point(16, 267);
            lstStations.Margin = new Padding(3, 5, 3, 5);
            lstStations.Name = "lstStations";
            lstStations.Size = new Size(354, 204);
            lstStations.TabIndex = 31;
            lstStations.SelectedIndexChanged += lstStations_SelectedIndexChanged;
            // 
            // cmbStation
            // 
            cmbStation.Enabled = false;
            cmbStation.Font = new Font("DynaPuff", 9F);
            cmbStation.ForeColor = Color.FromArgb(205, 33, 42);
            cmbStation.FormattingEnabled = true;
            cmbStation.Location = new Point(206, 136);
            cmbStation.Margin = new Padding(3, 4, 3, 4);
            cmbStation.Name = "cmbStation";
            cmbStation.Size = new Size(164, 27);
            cmbStation.TabIndex = 32;
            cmbStation.Text = "Nom de la station";
            cmbStation.SelectedIndexChanged += cmbStation_SelectedIndexChanged;
            // 
            // picFond2
            // 
            picFond2.Image = Properties.Resources.imgFondMilan1;
            picFond2.Location = new Point(-22, 267);
            picFond2.Name = "picFond2";
            picFond2.Size = new Size(872, 552);
            picFond2.SizeMode = PictureBoxSizeMode.Zoom;
            picFond2.TabIndex = 53;
            picFond2.TabStop = false;
            // 
            // Consultation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(382, 753);
            Controls.Add(cmbStation);
            Controls.Add(lstStations);
            Controls.Add(calDate);
            Controls.Add(btnRecherche);
            Controls.Add(cmbLignes);
            Controls.Add(btnRetour);
            Controls.Add(picFond2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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