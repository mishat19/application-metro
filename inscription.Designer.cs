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
            grpNomPrenom = new GroupBox();
            grpAdrMdp = new GroupBox();
            picInscription = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOeilOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).BeginInit();
            grpNomPrenom.SuspendLayout();
            grpAdrMdp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInscription).BeginInit();
            SuspendLayout();
            // 
            // lblConnexion
            // 
            lblConnexion.AutoSize = true;
            lblConnexion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblConnexion.ForeColor = Color.FromArgb(15, 93, 70);
            lblConnexion.Location = new Point(12, 501);
            lblConnexion.Name = "lblConnexion";
            lblConnexion.Size = new Size(220, 18);
            lblConnexion.TabIndex = 17;
            lblConnexion.Text = "Vous avez déjà un compte ?";
            // 
            // lnkConnexion
            // 
            lnkConnexion.AutoSize = true;
            lnkConnexion.Font = new Font("Microsoft Sans Serif", 9F);
            lnkConnexion.LinkColor = Color.FromArgb(205, 33, 42);
            lnkConnexion.Location = new Point(253, 501);
            lnkConnexion.Name = "lnkConnexion";
            lnkConnexion.Size = new Size(96, 18);
            lnkConnexion.TabIndex = 16;
            lnkConnexion.TabStop = true;
            lnkConnexion.Text = "Se connecter";
            lnkConnexion.LinkClicked += lnkConnexion_LinkClicked;
            // 
            // btnInscription
            // 
            btnInscription.BackColor = Color.FromArgb(205, 33, 42);
            btnInscription.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            txtMdp.Font = new Font("Microsoft Sans Serif", 9F);
            txtMdp.ForeColor = Color.FromArgb(205, 33, 42);
            txtMdp.Location = new Point(15, 65);
            txtMdp.Name = "txtMdp";
            txtMdp.PasswordChar = '*';
            txtMdp.PlaceholderText = "Saisir votre mot de passe";
            txtMdp.Size = new Size(322, 24);
            txtMdp.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.ForeColor = Color.FromArgb(205, 33, 42);
            txtEmail.Location = new Point(15, 26);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Saisir votre adresse mail";
            txtEmail.Size = new Size(322, 24);
            txtEmail.TabIndex = 12;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(40, 94);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(326, 54);
            lblTitre.TabIndex = 11;
            lblTitre.Text = "INSCRIPTION";
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNom.ForeColor = Color.FromArgb(205, 33, 42);
            txtNom.Location = new Point(15, 26);
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = "Nom";
            txtNom.Size = new Size(322, 24);
            txtNom.TabIndex = 18;
            // 
            // txtPrenom
            // 
            txtPrenom.Font = new Font("Microsoft Sans Serif", 9F);
            txtPrenom.ForeColor = Color.FromArgb(205, 33, 42);
            txtPrenom.Location = new Point(15, 75);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.PlaceholderText = "Prénom";
            txtPrenom.Size = new Size(322, 24);
            txtPrenom.TabIndex = 19;
            // 
            // lblNaissance
            // 
            lblNaissance.AutoSize = true;
            lblNaissance.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaissance.ForeColor = Color.FromArgb(15, 93, 70);
            lblNaissance.Location = new Point(12, 323);
            lblNaissance.Name = "lblNaissance";
            lblNaissance.Size = new Size(157, 18);
            lblNaissance.TabIndex = 20;
            lblNaissance.Text = "Date de naissance :";
            // 
            // dtpNaissance
            // 
            dtpNaissance.CalendarForeColor = Color.FromArgb(205, 33, 42);
            dtpNaissance.CalendarTitleBackColor = Color.FromArgb(15, 93, 70);
            dtpNaissance.CalendarTitleForeColor = Color.FromArgb(205, 33, 42);
            dtpNaissance.CustomFormat = "dd-MM-yyyy";
            dtpNaissance.Font = new Font("Microsoft Sans Serif", 9F);
            dtpNaissance.Format = DateTimePickerFormat.Custom;
            dtpNaissance.Location = new Point(223, 318);
            dtpNaissance.Name = "dtpNaissance";
            dtpNaissance.Size = new Size(122, 24);
            dtpNaissance.TabIndex = 21;
            // 
            // picRetour
            // 
            picRetour.Image = (Image)resources.GetObject("picRetour.Image");
            picRetour.Location = new Point(1, 0);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(33, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 22;
            picRetour.TabStop = false;
            picRetour.Click += pictureBox1_Click;
            // 
            // picOeilOff
            // 
            picOeilOff.BackColor = Color.White;
            picOeilOff.Image = Properties.Resources.oeiloff;
            picOeilOff.Location = new Point(300, 65);
            picOeilOff.Name = "picOeilOff";
            picOeilOff.Size = new Size(37, 25);
            picOeilOff.SizeMode = PictureBoxSizeMode.Zoom;
            picOeilOff.TabIndex = 28;
            picOeilOff.TabStop = false;
            picOeilOff.Click += picOeilOff_Click;
            // 
            // picFond2
            // 
            picFond2.Image = (Image)resources.GetObject("picFond2.Image");
            picFond2.Location = new Point(-43, 281);
            picFond2.Name = "picFond2";
            picFond2.Size = new Size(872, 552);
            picFond2.SizeMode = PictureBoxSizeMode.Zoom;
            picFond2.TabIndex = 54;
            picFond2.TabStop = false;
            // 
            // grpNomPrenom
            // 
            grpNomPrenom.Controls.Add(txtNom);
            grpNomPrenom.Controls.Add(txtPrenom);
            grpNomPrenom.Location = new Point(12, 180);
            grpNomPrenom.Name = "grpNomPrenom";
            grpNomPrenom.Size = new Size(354, 119);
            grpNomPrenom.TabIndex = 55;
            grpNomPrenom.TabStop = false;
            grpNomPrenom.Paint += grpNomPrenom_Paint;
            // 
            // grpAdrMdp
            // 
            grpAdrMdp.Controls.Add(picOeilOff);
            grpAdrMdp.Controls.Add(txtMdp);
            grpAdrMdp.Controls.Add(txtEmail);
            grpAdrMdp.Location = new Point(12, 362);
            grpAdrMdp.Name = "grpAdrMdp";
            grpAdrMdp.Size = new Size(354, 119);
            grpAdrMdp.TabIndex = 56;
            grpAdrMdp.TabStop = false;
            grpAdrMdp.Paint += grpAdrMdp_Paint;
            // 
            // picInscription
            // 
            picInscription.Image = (Image)resources.GetObject("picInscription.Image");
            picInscription.Location = new Point(150, 33);
            picInscription.Name = "picInscription";
            picInscription.Size = new Size(83, 76);
            picInscription.SizeMode = PictureBoxSizeMode.Zoom;
            picInscription.TabIndex = 57;
            picInscription.TabStop = false;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(382, 753);
            Controls.Add(picInscription);
            Controls.Add(grpAdrMdp);
            Controls.Add(grpNomPrenom);
            Controls.Add(picRetour);
            Controls.Add(dtpNaissance);
            Controls.Add(lblNaissance);
            Controls.Add(lblConnexion);
            Controls.Add(lnkConnexion);
            Controls.Add(btnInscription);
            Controls.Add(lblTitre);
            Controls.Add(picFond2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Inscription";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Page d'inscription";
            Load += Inscription_Load;
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOeilOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).EndInit();
            grpNomPrenom.ResumeLayout(false);
            grpNomPrenom.PerformLayout();
            grpAdrMdp.ResumeLayout(false);
            grpAdrMdp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picInscription).EndInit();
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
        private GroupBox grpNomPrenom;
        private GroupBox grpAdrMdp;
        private PictureBox picInscription;
    }
}