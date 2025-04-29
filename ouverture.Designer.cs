namespace application_metro
{
    partial class ouverture
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
            // 
            // btnNoConnexion
            // 
            btnNoConnexion.Location = new Point(256, 320);
            btnNoConnexion.Name = "btnNoConnexion";
            btnNoConnexion.Size = new Size(290, 74);
            btnNoConnexion.TabIndex = 1;
            btnNoConnexion.Text = "Rester déconnecté";
            btnNoConnexion.UseVisualStyleBackColor = true;
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
            // ouverture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitre);
            Controls.Add(btnNoConnexion);
            Controls.Add(btnConnexion);
            Name = "ouverture";
            Text = "Mon application métro rapide";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnexion;
        private Button btnNoConnexion;
        private Label lblTitre;
    }
}
