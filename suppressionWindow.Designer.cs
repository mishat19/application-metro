namespace application_metro
{
    partial class suppressionWindow
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
            btnNon = new Button();
            lblHoraires = new Label();
            btnOui = new Button();
            lblSuppression = new Label();
            SuspendLayout();
            // 
            // btnNon
            // 
            btnNon.Location = new Point(374, 235);
            btnNon.Name = "btnNon";
            btnNon.Size = new Size(126, 39);
            btnNon.TabIndex = 59;
            btnNon.Text = "Non";
            btnNon.UseVisualStyleBackColor = true;
            // 
            // lblHoraires
            // 
            lblHoraires.AutoSize = true;
            lblHoraires.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraires.Location = new Point(194, 74);
            lblHoraires.Name = "lblHoraires";
            lblHoraires.Size = new Size(115, 25);
            lblHoraires.TabIndex = 58;
            lblHoraires.Text = "Suppression";
            // 
            // btnOui
            // 
            btnOui.Location = new Point(242, 235);
            btnOui.Name = "btnOui";
            btnOui.Size = new Size(126, 39);
            btnOui.TabIndex = 60;
            btnOui.Text = "Oui";
            btnOui.UseVisualStyleBackColor = true;
            // 
            // lblSuppression
            // 
            lblSuppression.AutoSize = true;
            lblSuppression.Location = new Point(169, 110);
            lblSuppression.Name = "lblSuppression";
            lblSuppression.Size = new Size(172, 40);
            lblSuppression.TabIndex = 61;
            lblSuppression.Text = "Êtes-vous sûr de vouloir\r\nsupprimer ces données ?";
            // 
            // suppressionWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 286);
            Controls.Add(lblSuppression);
            Controls.Add(btnOui);
            Controls.Add(btnNon);
            Controls.Add(lblHoraires);
            Name = "suppressionWindow";
            Text = "Supprimer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNon;
        private Label lblHoraires;
        private Button btnOui;
        private Label lblSuppression;
    }
}