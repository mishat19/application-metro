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
            txtMdp = new TextBox();
            txtEmail = new TextBox();
            lblTitre = new Label();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            lblNaissance = new Label();
            dtpNaissance = new DateTimePicker();
            picRetour = new PictureBox();
            picOeilOff = new PictureBox();
            picFond2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOeilOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).BeginInit();
            SuspendLayout();
            // 
            // lblConnexion
            // 
            lblConnexion.AutoSize = true;
            lblConnexion.Font = new Font("Gliker", 9F, FontStyle.Bold);
            lblConnexion.ForeColor = Color.FromArgb(15, 93, 70);
            lblConnexion.Location = new Point(12, 493);
            lblConnexion.Name = "lblConnexion";
            lblConnexion.Size = new Size(229, 18);
            lblConnexion.TabIndex = 17;
            lblConnexion.Text = "Vous avez déjà un compte ?";
            // 
            // lnkConnexion
            // 
            lnkConnexion.AutoSize = true;
            lnkConnexion.Font = new Font("DynaPuff", 9F);
            lnkConnexion.LinkColor = Color.FromArgb(205, 33, 42);
            lnkConnexion.Location = new Point(244, 492);
            lnkConnexion.Name = "lnkConnexion";
            lnkConnexion.Size = new Size(108, 19);
            lnkConnexion.TabIndex = 16;
            lnkConnexion.TabStop = true;
            lnkConnexion.Text = "Se connecter";
            lnkConnexion.LinkClicked += lnkConnexion_LinkClicked;
            // 
            // btnInscription
            // 
            btnInscription.BackColor = Color.FromArgb(205, 33, 42);
            btnInscription.Font = new Font("DynaPuff", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInscription.ForeColor = Color.White;
            btnInscription.Location = new Point(223, 590);
            btnInscription.Name = "btnInscription";
            btnInscription.Size = new Size(147, 54);
            btnInscription.TabIndex = 15;
            btnInscription.Text = "S'inscrire";
            btnInscription.UseVisualStyleBackColor = false;
            btnInscription.Click += btnInscription_Click;
            // 
            // txtMdp
            // 
            txtMdp.Font = new Font("DynaPuff", 9F);
            txtMdp.Location = new Point(12, 402);
            txtMdp.Name = "txtMdp";
            txtMdp.PasswordChar = '*';
            txtMdp.PlaceholderText = "Saisir votre mot de passe";
            txtMdp.Size = new Size(358, 25);
            txtMdp.TabIndex = 13;
            txtMdp.TextChanged += txtMdp_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("DynaPuff", 9F);
            txtEmail.Location = new Point(12, 369);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Saisir votre adresse mail";
            txtEmail.Size = new Size(358, 25);
            txtEmail.TabIndex = 12;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Gliker", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(40, 94);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(303, 56);
            lblTitre.TabIndex = 11;
            lblTitre.Text = "INSCRIPTION";
            // 
            // txtNom
            // 
            txtNom.Font = new Font("DynaPuff", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNom.Location = new Point(12, 228);
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = "Nom";
            txtNom.Size = new Size(322, 25);
            txtNom.TabIndex = 18;
            // 
            // txtPrenom
            // 
            txtPrenom.Font = new Font("DynaPuff", 9F);
            txtPrenom.Location = new Point(12, 261);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.PlaceholderText = "Prénom";
            txtPrenom.Size = new Size(322, 25);
            txtPrenom.TabIndex = 19;
            // 
            // lblNaissance
            // 
            lblNaissance.AutoSize = true;
            lblNaissance.Font = new Font("Gliker", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaissance.ForeColor = Color.FromArgb(15, 93, 70);
            lblNaissance.Location = new Point(12, 317);
            lblNaissance.Name = "lblNaissance";
            lblNaissance.Size = new Size(161, 18);
            lblNaissance.TabIndex = 20;
            lblNaissance.Text = "Date de naissance :";
            // 
            // dtpNaissance
            // 
            dtpNaissance.CalendarForeColor = Color.FromArgb(205, 33, 42);
            dtpNaissance.CalendarTitleBackColor = Color.FromArgb(15, 93, 70);
            dtpNaissance.CalendarTitleForeColor = Color.FromArgb(205, 33, 42);
            dtpNaissance.CustomFormat = "dd-MM-yyyy";
            dtpNaissance.Font = new Font("DynaPuff", 9F);
            dtpNaissance.Format = DateTimePickerFormat.Custom;
            dtpNaissance.Location = new Point(185, 312);
            dtpNaissance.Name = "dtpNaissance";
            dtpNaissance.Size = new Size(122, 25);
            dtpNaissance.TabIndex = 21;
            // 
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(1, 0);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(51, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 22;
            picRetour.TabStop = false;
            picRetour.Click += pictureBox1_Click;
            // 
            // picOeilOff
            // 
            picOeilOff.Image = Properties.Resources.oeiloff;
            picOeilOff.Location = new Point(333, 400);
            picOeilOff.Name = "picOeilOff";
            picOeilOff.Size = new Size(37, 25);
            picOeilOff.SizeMode = PictureBoxSizeMode.Zoom;
            picOeilOff.TabIndex = 28;
            picOeilOff.TabStop = false;
            picOeilOff.Click += picOeilOff_Click;
            // 
            // picFond2
            // 
            picFond2.Image = Properties.Resources.imgFondMilan1;
            picFond2.Location = new Point(-43, 281);
            picFond2.Name = "picFond2";
            picFond2.Size = new Size(872, 552);
            picFond2.SizeMode = PictureBoxSizeMode.Zoom;
            picFond2.TabIndex = 54;
            picFond2.TabStop = false;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(382, 753);
            Controls.Add(picOeilOff);
            Controls.Add(picRetour);
            Controls.Add(dtpNaissance);
            Controls.Add(lblNaissance);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(lblConnexion);
            Controls.Add(lnkConnexion);
            Controls.Add(btnInscription);
            Controls.Add(txtMdp);
            Controls.Add(txtEmail);
            Controls.Add(lblTitre);
            Controls.Add(picFond2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Inscription";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Page d'inscription";
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOeilOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConnexion;
        private LinkLabel lnkConnexion;
        private Button btnInscription;
        private TextBox txtMdp;
        private TextBox txtEmail;
        private Label lblTitre;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private Label lblNaissance;
        private DateTimePicker dtpNaissance;
        private PictureBox picRetour;
        private PictureBox picOeilOff;
        private PictureBox picFond2;
    }
}