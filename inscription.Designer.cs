namespace application_metro
{
    partial class Inscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            lblConnexion = new Label();
            lnkConnexion = new LinkLabel();
            btnInscription = new Button();
            picOeil = new PictureBox();
            txtMdp = new TextBox();
            txtEmail = new TextBox();
            lblTitre = new Label();
            btnRetour = new Button();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            lblNaissance = new Label();
            dtpNaissance = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)picOeil).BeginInit();
            SuspendLayout();
            // 
            // lblConnexion
            // 
            lblConnexion.AutoSize = true;
            lblConnexion.Location = new Point(287, 355);
            lblConnexion.Name = "lblConnexion";
            lblConnexion.Size = new Size(193, 20);
            lblConnexion.TabIndex = 17;
            lblConnexion.Text = "Vous avez déjà un compte ?";
            // 
            // lnkConnexion
            // 
            lnkConnexion.AutoSize = true;
            lnkConnexion.Location = new Point(482, 355);
            lnkConnexion.Name = "lnkConnexion";
            lnkConnexion.Size = new Size(94, 20);
            lnkConnexion.TabIndex = 16;
            lnkConnexion.TabStop = true;
            lnkConnexion.Text = "Se connecter";
            lnkConnexion.LinkClicked += lnkConnexion_LinkClicked;
            // 
            // btnInscription
            // 
            btnInscription.Location = new Point(621, 381);
            btnInscription.Name = "btnInscription";
            btnInscription.Size = new Size(134, 40);
            btnInscription.TabIndex = 15;
            btnInscription.Text = "S'inscrire";
            btnInscription.UseVisualStyleBackColor = true;
            btnInscription.Click += btnInscription_Click;
            // 
            // picOeil
            // 
            picOeil.Image = (Image)resources.GetObject("picOeil.Image");
            picOeil.Location = new Point(562, 311);
            picOeil.Name = "picOeil";
            picOeil.Size = new Size(31, 27);
            picOeil.SizeMode = PictureBoxSizeMode.CenterImage;
            picOeil.TabIndex = 14;
            picOeil.TabStop = false;
            picOeil.Click += picOeil_Click;
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(272, 311);
            txtMdp.Name = "txtMdp";
            txtMdp.PasswordChar = '*';
            txtMdp.PlaceholderText = "Saisir votre mot de passe";
            txtMdp.Size = new Size(322, 27);
            txtMdp.TabIndex = 13;
            txtMdp.TextChanged += txtMdp_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(272, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Saisir votre adresse mail";
            txtEmail.Size = new Size(322, 27);
            txtEmail.TabIndex = 12;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 30F);
            lblTitre.Location = new Point(303, 46);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(258, 67);
            lblTitre.TabIndex = 11;
            lblTitre.Text = "Inscription";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(46, 30);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(126, 39);
            btnRetour.TabIndex = 10;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(272, 152);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(322, 27);
            txtNom.TabIndex = 18;
            txtNom.Text = "Nom";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(272, 185);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(322, 27);
            txtPrenom.TabIndex = 19;
            txtPrenom.Text = "Prénom";
            // 
            // lblNaissance
            // 
            lblNaissance.AutoSize = true;
            lblNaissance.Location = new Point(271, 235);
            lblNaissance.Name = "lblNaissance";
            lblNaissance.Size = new Size(129, 20);
            lblNaissance.TabIndex = 20;
            lblNaissance.Text = "Date de naissance";
            // 
            // dtpNaissance
            // 
            dtpNaissance.Location = new Point(406, 230);
            dtpNaissance.Name = "dtpNaissance";
            dtpNaissance.Size = new Size(187, 27);
            dtpNaissance.TabIndex = 21;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpNaissance);
            Controls.Add(lblNaissance);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(lblConnexion);
            Controls.Add(lnkConnexion);
            Controls.Add(btnInscription);
            Controls.Add(picOeil);
            Controls.Add(txtMdp);
            Controls.Add(txtEmail);
            Controls.Add(lblTitre);
            Controls.Add(btnRetour);
            Name = "Inscription";
            Text = "Page d'inscription";
            ((System.ComponentModel.ISupportInitialize)picOeil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConnexion;
        private LinkLabel lnkConnexion;
        private Button btnInscription;
        private PictureBox picOeil;
        private TextBox txtMdp;
        private TextBox txtEmail;
        private Label lblTitre;
        private Button btnRetour;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private Label lblNaissance;
        private DateTimePicker dtpNaissance;
    }
}