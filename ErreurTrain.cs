using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace application_metro
{
    public class TrainErrorManager
    {
        private readonly PictureBox trainPictureBox;
        private readonly Label errorLabel;
        private readonly Timer trainTimer;
        private readonly int startX;
        private readonly int endX;
        private readonly int stepX;
        private readonly int trainTop;

        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        private Font dynapuffFont;

        public TrainErrorManager(PictureBox trainPictureBox, Label errorLabel, int startX = -300, int endX = 30, int stepX = 5, int trainTop = 210)
        {
            this.trainPictureBox = trainPictureBox ?? throw new ArgumentNullException(nameof(trainPictureBox));
            this.errorLabel = errorLabel ?? throw new ArgumentNullException(nameof(errorLabel));
            this.startX = startX;
            this.endX = endX;
            this.stepX = stepX;
            this.trainTop = trainTop;

            // Load DynaPuff font from file
            try
            {
                fontCollection.AddFontFile(@"..\..\..\Fonts\DynaPuff-Regular.ttf");
                if (fontCollection.Families.Length > 0)
                {
                    dynapuffFont = new Font(fontCollection.Families[0], 9, FontStyle.Italic);
                }
                else
                {
                    dynapuffFont = new Font("Segoe UI", 10, FontStyle.Bold); // fallback
                }
            }
            catch
            {
                // En cas d'erreur, fallback
                dynapuffFont = new Font("Segoe UI", 10, FontStyle.Bold);
            }

            // Setup error label inside the train
            errorLabel.Location = new Point(20, 15); // position dans le train
            errorLabel.ForeColor = Color.FromArgb(15, 93, 70);
            errorLabel.Font = dynapuffFont;
            errorLabel.AutoSize = true;

            trainPictureBox.Visible = false;
            trainPictureBox.Top = trainTop;

            trainTimer = new Timer();
            trainTimer.Interval = 15;
            trainTimer.Tick += TrainTimer_Tick;
        }

        public void ShowError(string message)
        {
            errorLabel.Text = message;
            errorLabel.Font = dynapuffFont;  // applique la police dynapuff au moment de l'affichage
            errorLabel.Visible = true;

            trainPictureBox.Left = startX;
            trainPictureBox.Top = trainTop;
            trainPictureBox.Visible = true;
            trainPictureBox.BringToFront();

            trainTimer.Start();
        }

        private void TrainTimer_Tick(object sender, EventArgs e)
        {
            if (trainPictureBox.Left < endX)
            {
                trainPictureBox.Left += stepX;
            }
            else
            {
                trainTimer.Stop();
            }
        }
    }
}
