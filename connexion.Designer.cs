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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            lblTitre = new Label();
            txtEmail = new PlaceholderTextBox();
            txtMdp = new PlaceholderTextBox();
            btnConnexion = new Button();
            lnkInscription = new LinkLabel();
            lblInscription = new Label();
            lblErreur = new Label();
            picConnexion = new PictureBox();
            picRetour = new PictureBox();
            picOeilOff = new PictureBox();
            grpConnexion = new GroupBox();
            picTrain1 = new PictureBox();
            grpInscriptionConnexion = new GroupBox();
            timerTrain = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picConnexion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOeilOff).BeginInit();
            grpConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTrain1).BeginInit();
            grpInscriptionConnexion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(46, 105);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(308, 54);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "CONNEXION";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 7.79999971F);
            txtEmail.ForeColor = Color.FromArgb(205, 33, 42);
            txtEmail.Location = new Point(20, 26);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderColor = Color.FromArgb(205, 33, 42);
            txtEmail.PlaceholderText = "Saisir votre adresse mail";
            txtEmail.Size = new Size(318, 22);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "Saisir votre adresse mail";
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtMdp
            // 
            txtMdp.Font = new Font("Microsoft Sans Serif", 7.79999971F);
            txtMdp.ForeColor = Color.FromArgb(205, 33, 42);
            txtMdp.Location = new Point(20, 57);
            txtMdp.Name = "txtMdp";
            txtMdp.PlaceholderColor = Color.FromArgb(205, 33, 42);
            txtMdp.PlaceholderText = "Saisir votre mot de passe";
            txtMdp.Size = new Size(318, 22);
            txtMdp.TabIndex = 5;
            txtMdp.Text = "Saisir votre mot de passe";
            txtMdp.TextChanged += txtMdp_TextChanged;
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = Color.FromArgb(205, 33, 42);
            btnConnexion.Enabled = false;
            btnConnexion.FlatStyle = FlatStyle.Flat;
            btnConnexion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            lnkInscription.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkInscription.LinkColor = Color.FromArgb(205, 33, 42);
            lnkInscription.Location = new Point(274, 23);
            lnkInscription.Name = "lnkInscription";
            lnkInscription.Size = new Size(69, 18);
            lnkInscription.TabIndex = 8;
            lnkInscription.TabStop = true;
            lnkInscription.Text = "S'inscrire";
            lnkInscription.LinkClicked += lnkInscription_LinkClicked;
            // 
            // lblInscription
            // 
            lblInscription.AutoSize = true;
            lblInscription.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInscription.ForeColor = Color.FromArgb(15, 93, 70);
            lblInscription.Location = new Point(6, 23);
            lblInscription.Name = "lblInscription";
            lblInscription.Size = new Size(252, 18);
            lblInscription.TabIndex = 9;
            lblInscription.Text = "Vous n'avez pas encore de compte ?";
            lblInscription.Click += lblInscription_Click;
            // 
            // lblErreur
            // 
            lblErreur.BackColor = Color.Transparent;
            lblErreur.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblErreur.ForeColor = Color.FromArgb(15, 93, 70);
            lblErreur.Location = new Point(10, 10);
            lblErreur.Name = "lblErreur";
            lblErreur.Size = new Size(190, 20);
            lblErreur.TabIndex = 10;
            lblErreur.Text = "Identifiants incorrects";
            lblErreur.TextAlign = ContentAlignment.MiddleCenter;
            lblErreur.Visible = false;
            // 
            // picConnexion
            // 
            picConnexion.Image = Properties.Resources.imgFondMilan2;
            picConnexion.Location = new Point(-359, 336);
            picConnexion.Name = "picConnexion";
            picConnexion.Size = new Size(938, 478);
            picConnexion.SizeMode = PictureBoxSizeMode.Zoom;
            picConnexion.TabIndex = 11;
            picConnexion.TabStop = false;
            // 
            // picRetour
            // 
            picRetour.Image = Properties.Resources.imgFlecheGauche;
            picRetour.Location = new Point(1, 2);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(51, 25);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 26;
            picRetour.TabStop = false;
            picRetour.Click += picRetour_Click;
            // 
            // picOeilOff
            // 
            picOeilOff.BackColor = Color.White;
            picOeilOff.Image = Properties.Resources.oeiloff;
            picOeilOff.Location = new Point(301, 57);
            picOeilOff.Name = "picOeilOff";
            picOeilOff.Size = new Size(37, 23);
            picOeilOff.SizeMode = PictureBoxSizeMode.Zoom;
            picOeilOff.TabIndex = 27;
            picOeilOff.TabStop = false;
            picOeilOff.Click += picOeilOff_Click;
            // 
            // grpConnexion
            // 
            grpConnexion.Controls.Add(picTrain1);
            grpConnexion.Controls.Add(txtEmail);
            grpConnexion.Controls.Add(picOeilOff);
            grpConnexion.Controls.Add(txtMdp);
            grpConnexion.Location = new Point(12, 191);
            grpConnexion.Name = "grpConnexion";
            grpConnexion.Size = new Size(358, 128);
            grpConnexion.TabIndex = 28;
            grpConnexion.TabStop = false;
            grpConnexion.Paint += groupBox1_Paint;
            // 
            // picTrain1
            // 
            picTrain1.Image = Properties.Resources.imgTrainRose1;
            picTrain1.Location = new Point(20, 86);
            picTrain1.Name = "picTrain1";
            picTrain1.Size = new Size(211, 53);
            picTrain1.SizeMode = PictureBoxSizeMode.Zoom;
            picTrain1.TabIndex = 61;
            picTrain1.TabStop = false;
            picTrain1.Visible = false;
            // 
            // grpInscriptionConnexion
            // 
            grpInscriptionConnexion.Controls.Add(lblInscription);
            grpInscriptionConnexion.Controls.Add(lnkInscription);
            grpInscriptionConnexion.Location = new Point(12, 325);
            grpInscriptionConnexion.Name = "grpInscriptionConnexion";
            grpInscriptionConnexion.Size = new Size(358, 62);
            grpInscriptionConnexion.TabIndex = 29;
            grpInscriptionConnexion.TabStop = false;
            grpInscriptionConnexion.Paint += grpInscriptionConnexion_Paint;
            // 
            // timerTrain
            // 
            timerTrain.Interval = 5;
            timerTrain.Tick += timerTrain_Tick;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 188);
            ClientSize = new Size(382, 753);
            Controls.Add(grpInscriptionConnexion);
            Controls.Add(grpConnexion);
            Controls.Add(picRetour);
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
            ((System.ComponentModel.ISupportInitialize)picTrain1).EndInit();
            grpInscriptionConnexion.ResumeLayout(false);
            grpInscriptionConnexion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitre;
        private PlaceholderTextBox txtEmail;
        private PlaceholderTextBox txtMdp;
        private Button btnConnexion;
        private LinkLabel lnkInscription;
        private Label lblInscription;
        private Label lblErreur;
        private PictureBox picConnexion;
        private PictureBox picRetour;
        private PictureBox picOeilOff;
        private GroupBox grpConnexion;
        private GroupBox grpInscriptionConnexion;
        private PictureBox picTrain1;
        private System.Windows.Forms.Timer timerTrain;
    }
}