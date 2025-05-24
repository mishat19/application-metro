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
            lblTitre = new Label();
            txtEmail = new TextBox();
            txtMdp = new TextBox();
            btnConnexion = new Button();
            lnkInscription = new LinkLabel();
            lblInscription = new Label();
            lblErreur = new Label();
            picConnexion = new PictureBox();
            picRetour = new PictureBox();
            picOeilOff = new PictureBox();
            grpConnexion = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picConnexion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOeilOff).BeginInit();
            grpConnexion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Gliker", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(61, 105);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(260, 56);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "Connexion";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("DynaPuff", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(205, 33, 42);
            txtEmail.Location = new Point(20, 26);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Saisir votre adresse mail";
            txtEmail.Size = new Size(318, 25);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtMdp
            // 
            txtMdp.Font = new Font("DynaPuff", 9F);
            txtMdp.ForeColor = Color.FromArgb(205, 33, 42);
            txtMdp.Location = new Point(20, 57);
            txtMdp.Name = "txtMdp";
            txtMdp.PasswordChar = '*';
            txtMdp.PlaceholderText = "Saisir votre mot de passe";
            txtMdp.Size = new Size(318, 25);
            txtMdp.TabIndex = 5;
            txtMdp.TextChanged += txtMdp_TextChanged;
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = Color.FromArgb(205, 33, 42);
            btnConnexion.FlatStyle = FlatStyle.Flat;
            btnConnexion.Font = new Font("DynaPuff", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            lnkInscription.Font = new Font("Gliker", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkInscription.LinkColor = Color.FromArgb(205, 33, 42);
            lnkInscription.Location = new Point(296, 378);
            lnkInscription.Name = "lnkInscription";
            lnkInscription.Size = new Size(74, 18);
            lnkInscription.TabIndex = 8;
            lnkInscription.TabStop = true;
            lnkInscription.Text = "S'inscrire";
            lnkInscription.LinkClicked += lnkInscription_LinkClicked;
            // 
            // lblInscription
            // 
            lblInscription.AutoSize = true;
            lblInscription.Font = new Font("DynaPuff", 9F);
            lblInscription.ForeColor = Color.FromArgb(15, 93, 70);
            lblInscription.Location = new Point(12, 378);
            lblInscription.Name = "lblInscription";
            lblInscription.Size = new Size(272, 19);
            lblInscription.TabIndex = 9;
            lblInscription.Text = "Vous n'avez pas encore de compte ?";
            // 
            // lblErreur
            // 
            lblErreur.AutoSize = true;
            lblErreur.Font = new Font("DynaPuff", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblErreur.ForeColor = Color.FromArgb(15, 93, 70);
            lblErreur.Location = new Point(20, 95);
            lblErreur.Name = "lblErreur";
            lblErreur.Size = new Size(204, 19);
            lblErreur.TabIndex = 10;
            lblErreur.Text = "Identifiants incorrects";
            lblErreur.Visible = false;
            // 
            // picConnexion
            // 
            picConnexion.Image = Properties.Resources.imgFondMilan2;
            picConnexion.Location = new Point(-359, 340);
            picConnexion.Name = "picConnexion";
            picConnexion.Size = new Size(938, 446);
            picConnexion.SizeMode = PictureBoxSizeMode.Zoom;
            picConnexion.TabIndex = 11;
            picConnexion.TabStop = false;
            // 
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(12, 12);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(51, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 26;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // picOeilOff
            // 
            picOeilOff.Image = Properties.Resources.oeiloff;
            picOeilOff.Location = new Point(301, 57);
            picOeilOff.Name = "picOeilOff";
            picOeilOff.Size = new Size(37, 25);
            picOeilOff.SizeMode = PictureBoxSizeMode.Zoom;
            picOeilOff.TabIndex = 27;
            picOeilOff.TabStop = false;
            picOeilOff.Click += picOeilOff_Click;
            // 
            // grpConnexion
            // 
            grpConnexion.Controls.Add(txtEmail);
            grpConnexion.Controls.Add(picOeilOff);
            grpConnexion.Controls.Add(lblErreur);
            grpConnexion.Controls.Add(txtMdp);
            grpConnexion.Location = new Point(12, 191);
            grpConnexion.Name = "grpConnexion";
            grpConnexion.Size = new Size(358, 128);
            grpConnexion.TabIndex = 28;
            grpConnexion.TabStop = false;
            grpConnexion.Paint += groupBox1_Paint;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(382, 753);
            Controls.Add(grpConnexion);
            Controls.Add(picRetour);
            Controls.Add(lblInscription);
            Controls.Add(lnkInscription);
            Controls.Add(btnConnexion);
            Controls.Add(lblTitre);
            Controls.Add(picConnexion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Connexion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Page de connexion";
            Load += Connexion_Load;
            Paint += Connexion_Paint;
            ((System.ComponentModel.ISupportInitialize)picConnexion).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOeilOff).EndInit();
            grpConnexion.ResumeLayout(false);
            grpConnexion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitre;
        private TextBox txtEmail;
        private TextBox txtMdp;
        private Button btnConnexion;
        private LinkLabel lnkInscription;
        private Label lblInscription;
        private Label lblErreur;
        private PictureBox picConnexion;
        private PictureBox picRetour;
        private PictureBox picOeilOff;
        private GroupBox grpConnexion;
    }
}