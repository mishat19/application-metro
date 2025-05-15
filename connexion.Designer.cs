namespace application_metro
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            btnRetour = new Button();
            lblTitre = new Label();
            txtEmail = new TextBox();
            txtMdp = new TextBox();
            picOeil = new PictureBox();
            btnConnexion = new Button();
            lnkInscription = new LinkLabel();
            lblInscription = new Label();
            ((System.ComponentModel.ISupportInitialize)picOeil).BeginInit();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(12, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 39);
            btnRetour.TabIndex = 0;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 30F);
            lblTitre.Location = new Point(269, 82);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(263, 67);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "Connexion";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(239, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Saisir votre adresse mail";
            txtEmail.Size = new Size(322, 27);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(239, 266);
            txtMdp.Name = "txtMdp";
            txtMdp.PasswordChar = '*';
            txtMdp.PlaceholderText = "Saisir votre mot de passe";
            txtMdp.Size = new Size(322, 27);
            txtMdp.TabIndex = 5;
            txtMdp.TextChanged += txtMdp_TextChanged;
            // 
            // picOeil
            // 
            picOeil.BackColor = Color.Transparent;
            picOeil.Image = (Image)resources.GetObject("picOeil.Image");
            picOeil.Location = new Point(530, 266);
            picOeil.Name = "picOeil";
            picOeil.Size = new Size(31, 27);
            picOeil.SizeMode = PictureBoxSizeMode.CenterImage;
            picOeil.TabIndex = 6;
            picOeil.TabStop = false;
            picOeil.Click += picOeil_Click;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(587, 363);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(134, 40);
            btnConnexion.TabIndex = 7;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // lnkInscription
            // 
            lnkInscription.AutoSize = true;
            lnkInscription.Location = new Point(485, 310);
            lnkInscription.Name = "lnkInscription";
            lnkInscription.Size = new Size(67, 20);
            lnkInscription.TabIndex = 8;
            lnkInscription.TabStop = true;
            lnkInscription.Text = "S'inscrire";
            lnkInscription.LinkClicked += lnkInscription_LinkClicked;
            // 
            // lblInscription
            // 
            lblInscription.AutoSize = true;
            lblInscription.Location = new Point(238, 310);
            lblInscription.Name = "lblInscription";
            lblInscription.Size = new Size(248, 20);
            lblInscription.TabIndex = 9;
            lblInscription.Text = "Vous n'avez pas encore de compte ?";
            // 
            // Connexion
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
            Name = "Connexion";
            Text = "Page de connexion";
            ((System.ComponentModel.ISupportInitialize)picOeil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private Label lblTitre;
        private TextBox txtEmail;
        private TextBox txtMdp;
        private PictureBox picOeil;
        private Button btnConnexion;
        private LinkLabel lnkInscription;
        private Label lblInscription;
    }
}