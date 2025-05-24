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
            lblDeconnexion = new Label();
            lblTitre = new Label();
            btnNoConnexion = new Button();
            btnConnexion = new Button();
            picFond2 = new PictureBox();
            picLogo1 = new PictureBox();
            pnlOuverture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFond2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo1).BeginInit();
            SuspendLayout();
            // 
            // pnlOuverture
            // 
            pnlOuverture.BackColor = Color.FromArgb(255, 230, 188);
            pnlOuverture.Controls.Add(picLogo1);
            pnlOuverture.Controls.Add(lblDeconnexion);
            pnlOuverture.Controls.Add(lblTitre);
            pnlOuverture.Controls.Add(btnNoConnexion);
            pnlOuverture.Controls.Add(btnConnexion);
            pnlOuverture.Controls.Add(picFond2);
            pnlOuverture.Dock = DockStyle.Fill;
            pnlOuverture.Location = new Point(0, 0);
            pnlOuverture.Name = "pnlOuverture";
            pnlOuverture.Size = new Size(382, 753);
            pnlOuverture.TabIndex = 4;
            // 
            // lblDeconnexion
            // 
            lblDeconnexion.AutoSize = true;
            lblDeconnexion.BorderStyle = BorderStyle.Fixed3D;
            lblDeconnexion.Font = new Font("DynaPuff", 9F);
            lblDeconnexion.ForeColor = Color.FromArgb(15, 93, 70);
            lblDeconnexion.Location = new Point(85, 567);
            lblDeconnexion.Name = "lblDeconnexion";
            lblDeconnexion.Size = new Size(207, 21);
            lblDeconnexion.TabIndex = 7;
            lblDeconnexion.Text = "Vous avez été déconnecté";
            lblDeconnexion.Visible = false;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Gliker", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(27, 150);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(329, 60);
            lblTitre.TabIndex = 6;
            lblTitre.Text = "BIENVENUE !";
            // 
            // btnNoConnexion
            // 
            btnNoConnexion.BackColor = Color.FromArgb(205, 33, 42);
            btnNoConnexion.FlatStyle = FlatStyle.Flat;
            btnNoConnexion.Font = new Font("DynaPuff", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNoConnexion.ForeColor = Color.White;
            btnNoConnexion.Location = new Point(40, 453);
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
            btnConnexion.Font = new Font("DynaPuff", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnexion.ForeColor = Color.White;
            btnConnexion.Location = new Point(40, 305);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(290, 74);
            btnConnexion.TabIndex = 4;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click_1;
            // 
            // picFond2
            // 
            picFond2.Image = Properties.Resources.imgFondMilan1;
            picFond2.Location = new Point(-82, 270);
            picFond2.Name = "picFond2";
            picFond2.Size = new Size(872, 552);
            picFond2.SizeMode = PictureBoxSizeMode.Zoom;
            picFond2.TabIndex = 53;
            picFond2.TabStop = false;
            // 
            // picLogo1
            // 
            picLogo1.Image = Properties.Resources.logo1;
            picLogo1.Location = new Point(111, 30);
            picLogo1.Name = "picLogo1";
            picLogo1.Size = new Size(161, 117);
            picLogo1.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo1.TabIndex = 54;
            picLogo1.TabStop = false;
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
            pnlOuverture.ResumeLayout(false);
            pnlOuverture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFond2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo1).EndInit();
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
    }
}
