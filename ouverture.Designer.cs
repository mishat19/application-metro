namespace application_metro
{
    partial class Ouverture
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnexion = new Button();
            btnNoConnexion = new Button();
            lblTitre = new Label();
            lblDeconnexion = new Label();
            SuspendLayout();
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(256, 217);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(290, 74);
            btnConnexion.TabIndex = 0;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // btnNoConnexion
            // 
            btnNoConnexion.Location = new Point(256, 320);
            btnNoConnexion.Name = "btnNoConnexion";
            btnNoConnexion.Size = new Size(290, 74);
            btnNoConnexion.TabIndex = 1;
            btnNoConnexion.Text = "Rester déconnecté";
            btnNoConnexion.UseVisualStyleBackColor = true;
            btnNoConnexion.Click += btnNoConnexion_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 30F);
            lblTitre.Location = new Point(262, 86);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(284, 67);
            lblTitre.TabIndex = 2;
            lblTitre.Text = "Bienvenue !";
            // 
            // lblDeconnexion
            // 
            lblDeconnexion.AutoSize = true;
            lblDeconnexion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeconnexion.ForeColor = Color.ForestGreen;
            lblDeconnexion.Location = new Point(299, 409);
            lblDeconnexion.Name = "lblDeconnexion";
            lblDeconnexion.Size = new Size(213, 23);
            lblDeconnexion.TabIndex = 3;
            lblDeconnexion.Text = "Vous avez été déconnecté";
            lblDeconnexion.Visible = false;
            lblDeconnexion.Click += lblDeconnexion_Click;
            // 
            // Ouverture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDeconnexion);
            Controls.Add(lblTitre);
            Controls.Add(btnNoConnexion);
            Controls.Add(btnConnexion);
            Name = "Ouverture";
            Text = "Mon application métro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnexion;
        private Button btnNoConnexion;
        private Label lblTitre;
        public Label lblDeconnexion;
    }
}
