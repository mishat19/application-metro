namespace application_metro
{
    partial class Carte
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
            cmbLignes = new ComboBox();
            picMap = new PictureBox();
            btnRetour = new Button();
            btnRecherche = new Button();
            btnHoraires = new Button();
            picSupprimer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSupprimer).BeginInit();
            SuspendLayout();
            // 
            // cmbLignes
            // 
            cmbLignes.FormattingEnabled = true;
            cmbLignes.Location = new Point(101, 93);
            cmbLignes.Name = "cmbLignes";
            cmbLignes.Size = new Size(186, 28);
            cmbLignes.TabIndex = 21;
            cmbLignes.Text = "Ligne n°";
            // 
            // picMap
            // 
            picMap.Location = new Point(101, 210);
            picMap.Name = "picMap";
            picMap.Size = new Size(579, 355);
            picMap.TabIndex = 20;
            picMap.TabStop = false;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 39);
            btnRetour.TabIndex = 19;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnRecherche
            // 
            btnRecherche.Location = new Point(507, 93);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(173, 28);
            btnRecherche.TabIndex = 22;
            btnRecherche.Text = "Rechercher";
            btnRecherche.UseVisualStyleBackColor = true;
            // 
            // btnHoraires
            // 
            btnHoraires.Enabled = false;
            btnHoraires.Location = new Point(222, 152);
            btnHoraires.Name = "btnHoraires";
            btnHoraires.Size = new Size(332, 41);
            btnHoraires.TabIndex = 23;
            btnHoraires.Text = "Voir les horaires";
            btnHoraires.UseVisualStyleBackColor = true;
            // 
            // picSupprimer
            // 
            picSupprimer.Location = new Point(242, 93);
            picSupprimer.Name = "picSupprimer";
            picSupprimer.Size = new Size(26, 28);
            picSupprimer.TabIndex = 24;
            picSupprimer.TabStop = false;
            // 
            // carte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(picSupprimer);
            Controls.Add(btnHoraires);
            Controls.Add(btnRecherche);
            Controls.Add(cmbLignes);
            Controls.Add(picMap);
            Controls.Add(btnRetour);
            Name = "carte";
            Text = "Consultation - Carte";
            Load += carte_Load;
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSupprimer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbLignes;
        private PictureBox picMap;
        private Button btnRetour;
        private Button btnRecherche;
        private Button btnHoraires;
        private PictureBox picSupprimer;
    }
}