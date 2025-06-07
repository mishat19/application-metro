using System;
using System.Drawing;
using System.Windows.Forms;

namespace application_metro
{
    public class TrainErrorManager
    {
        private readonly PictureBox trainPictureBox;
        private readonly Label errorLabel;
        private readonly System.Windows.Forms.Timer trainTimer;
        private readonly int startX;
        private readonly int endX;
        private readonly int stepX;
        private readonly int trainTop;

        public TrainErrorManager(PictureBox trainPictureBox, Label errorLabel, int startX = -300, int endX = 30, int stepX = 5, int trainTop = 210)
        {
            this.trainPictureBox = trainPictureBox ?? throw new ArgumentNullException(nameof(trainPictureBox));
            this.errorLabel = errorLabel ?? throw new ArgumentNullException(nameof(errorLabel));
            this.startX = startX;
            this.endX = endX;
            this.stepX = stepX;
            this.trainTop = trainTop;

            // Setup error label inside the train
            errorLabel.Location = new Point(20, 15); // position dans le train
            errorLabel.ForeColor = Color.FromArgb(15, 93, 70);
            errorLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            errorLabel.AutoSize = true;

            // Setup train PictureBox initial state
            trainPictureBox.Visible = false;
            trainPictureBox.Top = trainTop;

            // Timer setup
            trainTimer = new System.Windows.Forms.Timer();
            trainTimer.Interval = 15;
            trainTimer.Tick += TrainTimer_Tick;
        }

        public void ShowError(string message)
        {
            errorLabel.Text = message;
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
