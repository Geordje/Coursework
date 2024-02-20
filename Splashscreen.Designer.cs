namespace Coursework
{
    partial class Splashscreen
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
            components = new System.ComponentModel.Container();
            LoadClock = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            loadingIndicator = new Label();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoadClock
            // 
            LoadClock.Enabled = true;
            LoadClock.Interval = 10;
            LoadClock.Tick += LoadClock_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(179, 63, 38);
            pictureBox1.Image = Properties.Resources.LoadingAnimation;
            pictureBox1.Location = new Point(118, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(549, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loadingIndicator
            // 
            loadingIndicator.AutoSize = true;
            loadingIndicator.BackColor = Color.Transparent;
            loadingIndicator.Font = new Font("Itim", 30F, FontStyle.Regular, GraphicsUnit.Point);
            loadingIndicator.ForeColor = Color.White;
            loadingIndicator.Location = new Point(310, 465);
            loadingIndicator.Name = "loadingIndicator";
            loadingIndicator.Size = new Size(164, 48);
            loadingIndicator.TabIndex = 1;
            loadingIndicator.Text = "Loading.";
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.RosyBrown;
            progressBar.Location = new Point(217, 439);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(351, 23);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 3;
            // 
            // Splashscreen
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(progressBar);
            Controls.Add(loadingIndicator);
            Controls.Add(pictureBox1);
            Cursor = Cursors.AppStarting;
            Font = new Font("Itim", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Splashscreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trivia Deck Loading";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer LoadClock;
        private Label loadingIndicator;
        private ProgressBar progressBar;
    }
}