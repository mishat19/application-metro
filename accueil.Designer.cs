namespace application_metro
{
    partial class accueil
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
            lblTitre.Font = new Font("Segoe UI", 30F);
            lblTitre.Location = new Point(317, 55);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(185, 67);
            lblTitre.TabIndex = 5;
            lblTitre.Text = "Accueil";
            // 
            // btnRecherche
            // 
            btnRecherche.Location = new Point(264, 251);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(290, 74);
            btnRecherche.TabIndex = 4;
            btnRecherche.Text = "Rechercher un itinéraire";
            btnRecherche.UseVisualStyleBackColor = true;
            // 
            // btnConsultation
            // 
            btnConsultation.Location = new Point(264, 160);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(290, 74);
            btnConsultation.TabIndex = 3;
            btnConsultation.Text = "Consulter le réseau";
            btnConsultation.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 55);
            btnRetour.TabIndex = 6;
            btnRetour.Text = "Se déconnecter/\r\nSe connecter";
            btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(264, 364);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(290, 74);
            btnAdmin.TabIndex = 7;
            btnAdmin.Text = "Gérer les données";
            btnAdmin.UseVisualStyleBackColor = true;
            // 
            // accueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdmin);
            Controls.Add(btnRetour);
            Controls.Add(lblTitre);
            Controls.Add(btnRecherche);
            Controls.Add(btnConsultation);
            Name = "accueil";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private Button btnRecherche;
        private Button btnConsultation;
        private Button btnRetour;
        private Button btnAdmin;
    }
}