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
            lstStations = new ListBox();
            cmbStation = new ComboBox();
            picFond2 = new PictureBox();
            picRetour = new PictureBox();
            picHome = new PictureBox();
            lblTitre = new Label();
            cmbLignes = new ComboBox();
            picHoraires = new PictureBox();
            dtpDateTime = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)picFond2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHoraires).BeginInit();
            SuspendLayout();
            // 
            // btnRecherche
            // 
            btnRecherche.BackColor = Color.FromArgb(205, 33, 42);
            btnRecherche.Enabled = false;
            btnRecherche.FlatStyle = FlatStyle.Flat;
            btnRecherche.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecherche.ForeColor = Color.White;
            btnRecherche.Location = new Point(12, 240);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(354, 53);
            btnRecherche.TabIndex = 27;
            btnRecherche.Text = "Rechercher";
            btnRecherche.UseVisualStyleBackColor = false;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // lstStations
            // 
            lstStations.BackColor = Color.FromArgb(255, 230, 188);
            lstStations.Font = new Font("Microsoft Sans Serif", 9F);
            lstStations.ForeColor = Color.FromArgb(205, 33, 42);
            lstStations.FormattingEnabled = true;
            lstStations.ItemHeight = 18;
            lstStations.Location = new Point(16, 343);
            lstStations.Margin = new Padding(3, 5, 3, 5);
            lstStations.Name = "lstStations";
            lstStations.Size = new Size(354, 184);
            lstStations.TabIndex = 31;
            // 
            // cmbStation
            // 
            cmbStation.Enabled = false;
            cmbStation.Font = new Font("Microsoft Sans Serif", 9F);
            cmbStation.ForeColor = Color.FromArgb(205, 33, 42);
            cmbStation.FormattingEnabled = true;
            cmbStation.Location = new Point(206, 162);
            cmbStation.Margin = new Padding(3, 4, 3, 4);
            cmbStation.Name = "cmbStation";
            cmbStation.Size = new Size(164, 26);
            cmbStation.TabIndex = 32;
            cmbStation.Text = "Nom de la station";
            cmbStation.SelectedIndexChanged += cmbStation_SelectedIndexChanged;
            // 
            // picFond2
            // 
            picFond2.Image = (Image)resources.GetObject("picFond2.Image");
            picFond2.Location = new Point(-25, 287);
            picFond2.Name = "picFond2";
            picFond2.Size = new Size(872, 552);
            picFond2.SizeMode = PictureBoxSizeMode.Zoom;
            picFond2.TabIndex = 53;
            picFond2.TabStop = false;
            // 
            // picRetour
            // 
            picRetour.Image = (Image)resources.GetObject("picRetour.Image");
            picRetour.Location = new Point(2, 1);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(26, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 54;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // picHome
            // 
            picHome.Image = (Image)resources.GetObject("picHome.Image");
            picHome.Location = new Point(34, 1);
            picHome.Name = "picHome";
            picHome.Size = new Size(27, 25);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 55;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(150, 91);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(79, 20);
            lblTitre.TabIndex = 56;
            lblTitre.Text = "HORAIRES";
            // 
            // cmbLignes
            // 
            cmbLignes.Enabled = false;
            cmbLignes.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLignes.ForeColor = Color.FromArgb(205, 33, 42);
            cmbLignes.FormattingEnabled = true;
            cmbLignes.Location = new Point(16, 162);
            cmbLignes.Margin = new Padding(3, 4, 3, 4);
            cmbLignes.Name = "cmbLignes";
            cmbLignes.Size = new Size(182, 26);
            cmbLignes.TabIndex = 26;
            cmbLignes.Text = "Ligne n°";
            cmbLignes.SelectedIndexChanged += cmbLignes_SelectedIndexChanged;
            // 
            // picHoraires
            // 
            picHoraires.Image = (Image)resources.GetObject("picHoraires.Image");
            picHoraires.Location = new Point(154, 12);
            picHoraires.Name = "picHoraires";
            picHoraires.Size = new Size(75, 68);
            picHoraires.SizeMode = PictureBoxSizeMode.Zoom;
            picHoraires.TabIndex = 57;
            picHoraires.TabStop = false;
            // 
            // dtpDateTime
            // 
            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.Location = new Point(16, 195);
            dtpDateTime.Name = "dtpDateTime";
            dtpDateTime.ShowUpDown = true;
            dtpDateTime.Size = new Size(354, 27);
            dtpDateTime.TabIndex = 58;
            // 
            // Consultation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(382, 753);
            Controls.Add(dtpDateTime);
            Controls.Add(picHoraires);
            Controls.Add(lblTitre);
            Controls.Add(picHome);
            Controls.Add(picRetour);
            Controls.Add(cmbStation);
            Controls.Add(lstStations);
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
            ((System.ComponentModel.ISupportInitialize)picHoraires).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRecherche;
        private ListBox lstStations;
        private ComboBox comboBox1;
        private ComboBox cmbStation;
        private PictureBox picFond2;
        private PictureBox picRetour;
        private PictureBox picHome;
        private Label lblTitre;
        private ComboBox cmbLignes;
        private PictureBox picHoraires;
        private DateTimePicker dtpDateTime;
    }
}