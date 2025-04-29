namespace application_metro
{
    partial class inscription
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
            lblInscription = new Label();
            lnkInscription = new LinkLabel();
            btnConnexion = new Button();
            picOeil = new PictureBox();
            txtMdp = new TextBox();
            txtEmail = new TextBox();
            lblTitre = new Label();
            btnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)picOeil).BeginInit();
            SuspendLayout();
            // 
            // lblInscription
            // 
            lblInscription.AutoSize = true;
            lblInscription.Location = new Point(272, 328);
            lblInscription.Name = "lblInscription";
            lblInscription.Size = new Size(248, 20);
            lblInscription.TabIndex = 17;
            lblInscription.Text = "Vous n'avez pas encore de compte ?";
            // 
            // lnkInscription
            // 
            lnkInscription.AutoSize = true;
            lnkInscription.Location = new Point(519, 328);
            lnkInscription.Name = "lnkInscription";
            lnkInscription.Size = new Size(67, 20);
            lnkInscription.TabIndex = 16;
            lnkInscription.TabStop = true;
            lnkInscription.Text = "S'inscrire";
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(621, 381);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(134, 40);
            btnConnexion.TabIndex = 15;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = true;
            // 
            // picOeil
            // 
            picOeil.Location = new Point(563, 284);
            picOeil.Name = "picOeil";
            picOeil.Size = new Size(31, 27);
            picOeil.TabIndex = 14;
            picOeil.TabStop = false;
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(273, 284);
            txtMdp.Name = "txtMdp";
            txtMdp.PasswordChar = '*';
            txtMdp.Size = new Size(322, 27);
            txtMdp.TabIndex = 13;
            txtMdp.Text = "Saisir votre mot de passe";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(273, 238);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(322, 27);
            txtEmail.TabIndex = 12;
            txtEmail.Text = "Saisir votre adresse mail";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 30F);
            lblTitre.Location = new Point(303, 100);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(263, 67);
            lblTitre.TabIndex = 11;
            lblTitre.Text = "Connexion";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(46, 30);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 39);
            btnRetour.TabIndex = 10;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            // 
            // inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInscription);
            Controls.Add(lnkInscription);
            Controls.Add(btnConnexion);
            Controls.Add(picOeil);
            Controls.Add(txtMdp);
            Controls.Add(txtEmail);
            Controls.Add(lblTitre);
            Controls.Add(btnRetour);
            Name = "inscription";
            Text = "inscription";
            ((System.ComponentModel.ISupportInitialize)picOeil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInscription;
        private LinkLabel lnkInscription;
        private Button btnConnexion;
        private PictureBox picOeil;
        private TextBox txtMdp;
        private TextBox txtEmail;
        private Label lblTitre;
        private Button btnRetour;
    }
}