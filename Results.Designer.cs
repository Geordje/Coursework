namespace Coursework
{
    partial class Results
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
            correctIndicator = new Label();
            timeTaken = new Label();
            Title = new Label();
            pictureBox1 = new PictureBox();
            scoreIndicator = new Label();
            label4 = new Label();
            placementIndicator = new Label();
            pictureBox3 = new PictureBox();
            returnHome = new CoolButton();
            placingAgain = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // correctIndicator
            // 
            correctIndicator.BackColor = Color.Transparent;
            correctIndicator.Font = new Font("Itim", 35F, FontStyle.Regular, GraphicsUnit.Point);
            correctIndicator.ForeColor = Color.White;
            correctIndicator.Location = new Point(299, 129);
            correctIndicator.Name = "correctIndicator";
            correctIndicator.Size = new Size(187, 57);
            correctIndicator.TabIndex = 50;
            correctIndicator.Text = "xx/20";
            correctIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeTaken
            // 
            timeTaken.BackColor = Color.Transparent;
            timeTaken.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            timeTaken.ForeColor = Color.White;
            timeTaken.Location = new Point(362, 439);
            timeTaken.Name = "timeTaken";
            timeTaken.Size = new Size(60, 33);
            timeTaken.TabIndex = 49;
            timeTaken.Text = "150";
            timeTaken.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 46F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(277, 29);
            Title.Name = "Title";
            Title.Size = new Size(230, 74);
            Title.TabIndex = 48;
            Title.Text = "Results";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.image__8_;
            pictureBox1.Location = new Point(327, 406);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // scoreIndicator
            // 
            scoreIndicator.BackColor = Color.Transparent;
            scoreIndicator.Font = new Font("Itim", 35F, FontStyle.Regular, GraphicsUnit.Point);
            scoreIndicator.ForeColor = Color.White;
            scoreIndicator.Location = new Point(187, 175);
            scoreIndicator.Name = "scoreIndicator";
            scoreIndicator.Size = new Size(410, 92);
            scoreIndicator.TabIndex = 51;
            scoreIndicator.Text = "Score:  XXXX";
            scoreIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(320, 267);
            label4.Name = "label4";
            label4.Size = new Size(145, 40);
            label4.TabIndex = 52;
            label4.Text = "Ranking:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // placementIndicator
            // 
            placementIndicator.BackColor = Color.Transparent;
            placementIndicator.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            placementIndicator.ForeColor = Color.White;
            placementIndicator.Location = new Point(197, 319);
            placementIndicator.Name = "placementIndicator";
            placementIndicator.Size = new Size(387, 80);
            placementIndicator.TabIndex = 53;
            placementIndicator.Text = "xth place in Wildcard";
            placementIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Trophy;
            pictureBox3.Location = new Point(8, 439);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 118);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 54;
            pictureBox3.TabStop = false;
            // 
            // returnHome
            // 
            returnHome.BackColor = Color.White;
            returnHome.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            returnHome.FlatAppearance.BorderSize = 5;
            returnHome.FlatStyle = FlatStyle.Flat;
            returnHome.Font = new Font("Itim", 22F, FontStyle.Regular, GraphicsUnit.Point);
            returnHome.ForeColor = Color.FromArgb(179, 63, 38);
            returnHome.Location = new Point(559, 482);
            returnHome.Margin = new Padding(3, 2, 3, 2);
            returnHome.Name = "returnHome";
            returnHome.Size = new Size(202, 68);
            returnHome.TabIndex = 55;
            returnHome.Text = "Return Home";
            returnHome.UseVisualStyleBackColor = false;
            returnHome.Click += returnHome_Click;
            // 
            // placingAgain
            // 
            placingAgain.AutoSize = true;
            placingAgain.BackColor = Color.Transparent;
            placingAgain.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            placingAgain.ForeColor = Color.White;
            placingAgain.Location = new Point(55, 463);
            placingAgain.Name = "placingAgain";
            placingAgain.Size = new Size(59, 33);
            placingAgain.TabIndex = 56;
            placingAgain.Text = "150";
            placingAgain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(placingAgain);
            Controls.Add(returnHome);
            Controls.Add(pictureBox3);
            Controls.Add(placementIndicator);
            Controls.Add(label4);
            Controls.Add(scoreIndicator);
            Controls.Add(correctIndicator);
            Controls.Add(timeTaken);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Results";
            Text = "Results";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label correctIndicator;
        private Label timeTaken;
        private Label Title;
        private PictureBox pictureBox1;
        private Label scoreIndicator;
        private Label label4;
        private Label placementIndicator;
        private PictureBox pictureBox3;
        private CoolButton returnHome;
        private Label placingAgain;
    }
}