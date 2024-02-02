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
            this.components = new System.ComponentModel.Container();
            this.LoadClock = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingIndicator = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadClock
            // 
            this.LoadClock.Enabled = true;
            this.LoadClock.Interval = 10;
            this.LoadClock.Tick += new System.EventHandler(this.LoadClock_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.pictureBox1.Image = global::Coursework.Properties.Resources.LoadingAnimation;
            this.pictureBox1.Location = new System.Drawing.Point(118, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadingIndicator
            // 
            this.loadingIndicator.AutoSize = true;
            this.loadingIndicator.BackColor = System.Drawing.Color.Transparent;
            this.loadingIndicator.Font = new System.Drawing.Font("Itim", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadingIndicator.ForeColor = System.Drawing.Color.White;
            this.loadingIndicator.Location = new System.Drawing.Point(310, 465);
            this.loadingIndicator.Name = "loadingIndicator";
            this.loadingIndicator.Size = new System.Drawing.Size(164, 48);
            this.loadingIndicator.TabIndex = 1;
            this.loadingIndicator.Text = "Loading.";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.RosyBrown;
            this.progressBar.Location = new System.Drawing.Point(217, 439);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(351, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            // 
            // Splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.loadingIndicator);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Splashscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivia Deck Loading";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer LoadClock;
        private Label loadingIndicator;
        private ProgressBar progressBar;
    }
}