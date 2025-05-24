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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultation));
            btnRecherche = new Button();
            cmbLignes = new ComboBox();
            calDate = new MonthCalendar();
            lstStations = new ListBox();
            cmbStation = new ComboBox();
            picFond2 = new PictureBox();
            picRetour = new PictureBox();
            picHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picFond2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
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
            lstStations.Font = new Font("DynaPuff", 9F);
            lstStations.ForeColor = Color.FromArgb(205, 33, 42);
            lstStations.FormattingEnabled = true;
            lstStations.ItemHeight = 19;
            lstStations.Location = new Point(16, 267);
            lstStations.Margin = new Padding(3, 5, 3, 5);
            lstStations.Name = "lstStations";
            lstStations.Size = new Size(354, 194);
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
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(12, 12);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(51, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 54;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // picHome
            // 
            picHome.Image = Properties.Resources.home;
            picHome.Location = new Point(59, 12);
            picHome.Name = "picHome";
            picHome.Size = new Size(27, 25);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 55;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // Consultation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(382, 753);
            Controls.Add(picHome);
            Controls.Add(picRetour);
            Controls.Add(cmbStation);
            Controls.Add(lstStations);
            Controls.Add(calDate);
            Controls.Add(btnRecherche);
            Controls.Add(cmbLignes);
            Controls.Add(picFond2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Consultation";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Horaires de la station";
            Load += consultation_Load;
            ((System.ComponentModel.ISupportInitialize)picFond2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRecherche;
        private ComboBox cmbLignes;
        private MonthCalendar calDate;
        private ListBox lstStations;
        private ComboBox comboBox1;
        private ComboBox cmbStation;
        private PictureBox picFond2;
        private PictureBox picRetour;
        private PictureBox picHome;
    }
}