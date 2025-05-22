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
            lblErreur = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picOeil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            lblTitre.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(76, 105);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(230, 59);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "Connexion";
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.FromArgb(205, 33, 42);
            txtEmail.Location = new Point(12, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Saisir votre adresse mail";
            txtEmail.Size = new Size(358, 27);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtMdp
            // 
            txtMdp.ForeColor = Color.FromArgb(205, 33, 42);
            txtMdp.Location = new Point(12, 262);
            txtMdp.Name = "txtMdp";
            txtMdp.PasswordChar = '*';
            txtMdp.PlaceholderText = "Saisir votre mot de passe";
            txtMdp.Size = new Size(358, 27);
            txtMdp.TabIndex = 5;
            txtMdp.TextChanged += txtMdp_TextChanged;
            // 
            // picOeil
            // 
            picOeil.BackColor = Color.Transparent;
            picOeil.Image = (Image)resources.GetObject("picOeil.Image");
            picOeil.Location = new Point(339, 262);
            picOeil.Name = "picOeil";
            picOeil.Size = new Size(31, 27);
            picOeil.SizeMode = PictureBoxSizeMode.CenterImage;
            picOeil.TabIndex = 6;
            picOeil.TabStop = false;
            picOeil.Click += picOeil_Click;
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = Color.FromArgb(205, 33, 42);
            btnConnexion.FlatStyle = FlatStyle.Flat;
            btnConnexion.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btnConnexion.ForeColor = Color.White;
            btnConnexion.Location = new Point(236, 490);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(134, 40);
            btnConnexion.TabIndex = 7;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // lnkInscription
            // 
            lnkInscription.AutoSize = true;
            lnkInscription.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkInscription.LinkColor = Color.FromArgb(15, 93, 70);
            lnkInscription.Location = new Point(303, 360);
            lnkInscription.Name = "lnkInscription";
            lnkInscription.Size = new Size(68, 19);
            lnkInscription.TabIndex = 8;
            lnkInscription.TabStop = true;
            lnkInscription.Text = "S'inscrire";
            lnkInscription.LinkClicked += lnkInscription_LinkClicked;
            // 
            // lblInscription
            // 
            lblInscription.AutoSize = true;
            lblInscription.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInscription.ForeColor = Color.FromArgb(205, 33, 42);
            lblInscription.Location = new Point(12, 357);
            lblInscription.Name = "lblInscription";
            lblInscription.Size = new Size(285, 26);
            lblInscription.TabIndex = 9;
            lblInscription.Text = "Vous n'avez pas encore de compte ?";
            // 
            // lblErreur
            // 
            lblErreur.AutoSize = true;
            lblErreur.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblErreur.ForeColor = Color.FromArgb(15, 93, 70);
            lblErreur.Location = new Point(12, 292);
            lblErreur.Name = "lblErreur";
            lblErreur.Size = new Size(193, 25);
            lblErreur.TabIndex = 10;
            lblErreur.Text = "Identifiants incorrects";
            lblErreur.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imgFondMilan2;
            pictureBox1.Location = new Point(-359, 340);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(938, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(382, 753);
            Controls.Add(lblErreur);
            Controls.Add(lblInscription);
            Controls.Add(lnkInscription);
            Controls.Add(btnConnexion);
            Controls.Add(picOeil);
            Controls.Add(txtMdp);
            Controls.Add(txtEmail);
            Controls.Add(lblTitre);
            Controls.Add(btnRetour);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Connexion";
            Text = "Page de connexion";
            ((System.ComponentModel.ISupportInitialize)picOeil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lblErreur;
        private PictureBox pictureBox1;
    }
}