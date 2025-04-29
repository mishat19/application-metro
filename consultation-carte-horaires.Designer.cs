namespace application_metro
{
    partial class consultation_carte_horaires
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
            picSupprimer = new PictureBox();
            btnRecherche = new Button();
            cmbLignes = new ComboBox();
            btnRetour = new Button();
            grpDestinations = new GroupBox();
            lblDestinationB = new Label();
            lblDestinationA = new Label();
            calDate = new MonthCalendar();
            rjToggleButton1 = new CustomControls.RJControls.RJToggleButton();
            rjToggleButton2 = new CustomControls.RJControls.RJToggleButton();
            lstStations = new ListBox();
            ((System.ComponentModel.ISupportInitialize)picSupprimer).BeginInit();
            grpDestinations.SuspendLayout();
            SuspendLayout();
            // 
            // picSupprimer
            // 
            picSupprimer.Location = new Point(231, 93);
            picSupprimer.Name = "picSupprimer";
            picSupprimer.Size = new Size(26, 28);
            picSupprimer.TabIndex = 28;
            picSupprimer.TabStop = false;
            // 
            // btnRecherche
            // 
            btnRecherche.Location = new Point(507, 93);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(173, 28);
            btnRecherche.TabIndex = 27;
            btnRecherche.Text = "Rechercher";
            btnRecherche.UseVisualStyleBackColor = true;
            // 
            // cmbLignes
            // 
            cmbLignes.FormattingEnabled = true;
            cmbLignes.Location = new Point(90, 93);
            cmbLignes.Name = "cmbLignes";
            cmbLignes.Size = new Size(186, 28);
            cmbLignes.TabIndex = 26;
            cmbLignes.Text = "Ligne n°";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 39);
            btnRetour.TabIndex = 25;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            // 
            // grpDestinations
            // 
            grpDestinations.Controls.Add(rjToggleButton2);
            grpDestinations.Controls.Add(rjToggleButton1);
            grpDestinations.Controls.Add(lblDestinationB);
            grpDestinations.Controls.Add(lblDestinationA);
            grpDestinations.Location = new Point(176, 149);
            grpDestinations.Name = "grpDestinations";
            grpDestinations.Size = new Size(443, 90);
            grpDestinations.TabIndex = 29;
            grpDestinations.TabStop = false;
            // 
            // lblDestinationB
            // 
            lblDestinationB.AutoSize = true;
            lblDestinationB.Location = new Point(264, 57);
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
            calDate.Location = new Point(267, 375);
            calDate.Name = "calDate";
            calDate.TabIndex = 30;
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
            // rjToggleButton2
            // 
            rjToggleButton2.AutoSize = true;
            rjToggleButton2.Checked = true;
            rjToggleButton2.CheckState = CheckState.Checked;
            rjToggleButton2.Location = new Point(308, 26);
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
            // lstStations
            // 
            lstStations.FormattingEnabled = true;
            lstStations.Location = new Point(267, 259);
            lstStations.Name = "lstStations";
            lstStations.Size = new Size(262, 104);
            lstStations.TabIndex = 31;
            // 
            // consultation_carte_horaires
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 635);
            Controls.Add(lstStations);
            Controls.Add(calDate);
            Controls.Add(grpDestinations);
            Controls.Add(picSupprimer);
            Controls.Add(btnRecherche);
            Controls.Add(cmbLignes);
            Controls.Add(btnRetour);
            Name = "consultation_carte_horaires";
            Text = "consultation_carte_horaires";
            ((System.ComponentModel.ISupportInitialize)picSupprimer).EndInit();
            grpDestinations.ResumeLayout(false);
            grpDestinations.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picSupprimer;
        private Button btnRecherche;
        private ComboBox cmbLignes;
        private Button btnRetour;
        private GroupBox grpDestinations;
        private Label lblDestinationB;
        private Label lblDestinationA;
        private MonthCalendar calDate;
        private CustomControls.RJControls.RJToggleButton rjToggleButton2;
        private CustomControls.RJControls.RJToggleButton rjToggleButton1;
        private ListBox lstStations;
    }
}