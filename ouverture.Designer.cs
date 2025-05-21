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
            pnlOuverture = new Panel();
            lblDeconnexion = new Label();
            lblTitre = new Label();
            btnNoConnexion = new Button();
            btnConnexion = new Button();
            picFond1 = new PictureBox();
            pnlOuverture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFond1).BeginInit();
            SuspendLayout();
            // 
            // pnlOuverture
            // 
            pnlOuverture.BackColor = Color.FromArgb(255, 230, 188);
            pnlOuverture.Controls.Add(lblDeconnexion);
            pnlOuverture.Controls.Add(lblTitre);
            pnlOuverture.Controls.Add(btnNoConnexion);
            pnlOuverture.Controls.Add(btnConnexion);
            pnlOuverture.Controls.Add(picFond1);
            pnlOuverture.Dock = DockStyle.Fill;
            pnlOuverture.Location = new Point(0, 0);
            pnlOuverture.Name = "pnlOuverture";
            pnlOuverture.Size = new Size(382, 753);
            pnlOuverture.TabIndex = 4;
            // 
            // lblDeconnexion
            // 
            lblDeconnexion.AutoSize = true;
            lblDeconnexion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeconnexion.ForeColor = Color.FromArgb(15, 93, 70);
            lblDeconnexion.Location = new Point(85, 567);
            lblDeconnexion.Name = "lblDeconnexion";
            lblDeconnexion.Size = new Size(213, 23);
            lblDeconnexion.TabIndex = 7;
            lblDeconnexion.Text = "Vous avez été déconnecté";
            lblDeconnexion.Visible = false;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(15, 93, 70);
            lblTitre.Location = new Point(63, 150);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(261, 63);
            lblTitre.TabIndex = 6;
            lblTitre.Text = "BIENVENUE !";
            // 
            // btnNoConnexion
            // 
            btnNoConnexion.BackColor = Color.FromArgb(205, 33, 42);
            btnNoConnexion.FlatStyle = FlatStyle.Flat;
            btnNoConnexion.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold);
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
            btnConnexion.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnexion.ForeColor = Color.White;
            btnConnexion.Location = new Point(40, 305);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(290, 74);
            btnConnexion.TabIndex = 4;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click_1;
            // 
            // picFond1
            // 
            picFond1.Location = new Point(-93, 216);
            picFond1.Name = "picFond1";
            picFond1.Size = new Size(1296, 544);
            picFond1.SizeMode = PictureBoxSizeMode.Zoom;
            picFond1.TabIndex = 8;
            picFond1.TabStop = false;
            picFond1.Click += pictureBox1_Click;
            // 
            // Ouverture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 753);
            Controls.Add(pnlOuverture);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ouverture";
            Text = "Mon application métro";
            pnlOuverture.ResumeLayout(false);
            pnlOuverture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFond1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOuverture;
        public Label lblDeconnexion;
        private Label lblTitre;
        private Button btnNoConnexion;
        private Button btnConnexion;
        private PictureBox picFond1;
    }
}
