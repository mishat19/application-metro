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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ouverture));
            pnlOuverture = new Panel();
            picLogo1 = new PictureBox();
            lblTitre = new Label();
            btnNoConnexion = new Button();
            btnConnexion = new Button();
            picFond2 = new PictureBox();
            picTrain1 = new PictureBox();
            lblDeconnexion = new Label();
            pnlOuverture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTrain1).BeginInit();
            picTrain1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlOuverture
            // 
            pnlOuverture.BackColor = Color.FromArgb(255, 230, 188);
            pnlOuverture.Controls.Add(picLogo1);
            pnlOuverture.Controls.Add(lblTitre);
            pnlOuverture.Controls.Add(btnNoConnexion);
            pnlOuverture.Controls.Add(btnConnexion);
            pnlOuverture.Controls.Add(picFond2);
            pnlOuverture.Controls.Add(picTrain1);
            pnlOuverture.Dock = DockStyle.Fill;
            pnlOuverture.Location = new Point(0, 0);
            pnlOuverture.Name = "pnlOuverture";
            pnlOuverture.Size = new Size(382, 753);
            pnlOuverture.TabIndex = 4;
            // 
            // picLogo1
            // 
            picLogo1.Image = (Image)resources.GetObject("picLogo1.Image");
            picLogo1.Location = new Point(111, 30);
            picLogo1.Name = "picLogo1";
            picLogo1.Size = new Size(161, 117);
            picLogo1.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo1.TabIndex = 54;
            picLogo1.TabStop = false;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(22, 150);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(339, 58);
            lblTitre.TabIndex = 6;
            lblTitre.Text = "BIENVENUE !";
            // 
            // btnNoConnexion
            // 
            btnNoConnexion.BackColor = Color.FromArgb(205, 33, 42);
            btnNoConnexion.FlatStyle = FlatStyle.Flat;
            btnNoConnexion.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNoConnexion.ForeColor = Color.White;
            btnNoConnexion.Location = new Point(40, 392);
            btnNoConnexion.Name = "btnNoConnexion";
            btnNoConnexion.Size = new Size(290, 74);
            btnNoConnexion.TabIndex = 5;
            btnNoConnexion.Text = "Rester déconnecté";
            btnNoConnexion.UseVisualStyleBackColor = false;
            btnNoConnexion.Click += btnNoConnexion_Click_1;
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = Color.FromArgb(205, 33, 42);
            btnConnexion.FlatStyle = FlatStyle.Flat;
            btnConnexion.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnexion.ForeColor = Color.White;
            btnConnexion.Location = new Point(40, 287);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(290, 74);
            btnConnexion.TabIndex = 4;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click_1;
            // 
            // picFond2
            // 
            picFond2.Image = (Image)resources.GetObject("picFond2.Image");
            picFond2.Location = new Point(-82, 270);
            picFond2.Name = "picFond2";
            picFond2.Size = new Size(872, 552);
            picFond2.SizeMode = PictureBoxSizeMode.Zoom;
            picFond2.TabIndex = 53;
            picFond2.TabStop = false;
            // 
            // picTrain1
            // 
            picTrain1.BackColor = Color.Transparent;
            picTrain1.Controls.Add(lblDeconnexion);
            picTrain1.Image = (Image)resources.GetObject("picTrain1.Image");
            picTrain1.Location = new Point(74, 224);
            picTrain1.Name = "picTrain1";
            picTrain1.Size = new Size(226, 57);
            picTrain1.SizeMode = PictureBoxSizeMode.Zoom;
            picTrain1.TabIndex = 55;
            picTrain1.TabStop = false;
            picTrain1.Visible = false;
            // 
            // lblDeconnexion
            // 
            lblDeconnexion.AutoSize = true;
            lblDeconnexion.BackColor = Color.Transparent;
            lblDeconnexion.Font = new Font("Microsoft Sans Serif", 9F);
            lblDeconnexion.ForeColor = Color.FromArgb(15, 93, 70);
            lblDeconnexion.Location = new Point(88, 247);
            lblDeconnexion.Name = "lblDeconnexion";
            lblDeconnexion.Size = new Size(182, 18);
            lblDeconnexion.TabIndex = 59;
            lblDeconnexion.Text = "Vous avez été déconnecté";
            lblDeconnexion.Visible = false;
            // 
            // Ouverture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 753);
            Controls.Add(pnlOuverture);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ouverture";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mon application métro";
            Load += Ouverture_Load;
            pnlOuverture.ResumeLayout(false);
            pnlOuverture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFond2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTrain1).EndInit();
            picTrain1.ResumeLayout(false);
            picTrain1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOuverture;
        public Label lblDeconnexion;
        private Label lblTitre;
        private Button btnNoConnexion;
        private Button btnConnexion;
        private PictureBox picFond2;
        private PictureBox picLogo1;
        private PictureBox picTrain1;
    }
}
