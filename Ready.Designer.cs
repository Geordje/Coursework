namespace Coursework
{
    partial class Ready
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
            readyText = new Label();
            pictureBox1 = new PictureBox();
            startTimer = new System.Windows.Forms.Timer(components);
            mainTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // readyText
            // 
            readyText.BackColor = Color.Transparent;
            readyText.Font = new Font("Itim", 30F, FontStyle.Regular, GraphicsUnit.Point);
            readyText.ForeColor = Color.White;
            readyText.Location = new Point(321, 453);
            readyText.Name = "readyText";
            readyText.Size = new Size(142, 48);
            readyText.TabIndex = 3;
            readyText.Text = "Ready?";
            readyText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(179, 63, 38);
            pictureBox1.Image = Properties.Resources.loadinggif;
            pictureBox1.Location = new Point(118, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(549, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // startTimer
            // 
            startTimer.Interval = 1000;
            startTimer.Tick += startTimer_Tick;
            // 
            // Ready
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(readyText);
            Controls.Add(pictureBox1);
            Cursor = Cursors.AppStarting;
            Name = "Ready";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label readyText;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer mainTimer;
        public System.Windows.Forms.Timer startTimer;
    }
}