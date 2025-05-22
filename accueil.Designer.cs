namespace application_metro
{
    partial class Accueil
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
            lblTitre = new Label();
            btnRecherche = new Button();
            btnConsultation = new Button();
            btnRetour = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Impact", 30F);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(99, 98);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(180, 63);
            lblTitre.TabIndex = 5;
            lblTitre.Text = "Accueil";
            // 
            // btnRecherche
            // 
            btnRecherche.BackColor = Color.FromArgb(205, 33, 42);
            btnRecherche.FlatStyle = FlatStyle.Flat;
            btnRecherche.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold);
            btnRecherche.ForeColor = Color.White;
            btnRecherche.Location = new Point(29, 337);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(324, 74);
            btnRecherche.TabIndex = 4;
            btnRecherche.Text = "Rechercher un itinéraire";
            btnRecherche.UseVisualStyleBackColor = false;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // btnConsultation
            // 
            btnConsultation.BackColor = Color.FromArgb(205, 33, 42);
            btnConsultation.FlatStyle = FlatStyle.Flat;
            btnConsultation.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold);
            btnConsultation.ForeColor = Color.White;
            btnConsultation.Location = new Point(29, 220);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(324, 74);
            btnConsultation.TabIndex = 3;
            btnConsultation.Text = "Consulter le réseau";
            btnConsultation.UseVisualStyleBackColor = false;
            btnConsultation.Click += btnConsultation_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 55);
            btnRetour.TabIndex = 6;
            btnRetour.Text = "Se déconnecter/\r\nSe connecter";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(205, 33, 42);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(29, 457);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(324, 74);
            btnAdmin.TabIndex = 7;
            btnAdmin.Text = "Gérer les données";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(382, 753);
            Controls.Add(btnAdmin);
            Controls.Add(btnRetour);
            Controls.Add(lblTitre);
            Controls.Add(btnRecherche);
            Controls.Add(btnConsultation);
            Name = "Accueil";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private Button btnRecherche;
        private Button btnConsultation;
        public Button btnRetour;
        private Button btnAdmin;
    }
}