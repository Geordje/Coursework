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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
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
            topScore = new Label();
            difficultyMultiplierSlot = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // correctIndicator
            // 
            correctIndicator.BackColor = Color.Transparent;
            correctIndicator.Font = new Font("Itim", 35F, FontStyle.Regular, GraphicsUnit.Point);
            correctIndicator.ForeColor = Color.White;
            correctIndicator.Location = new Point(196, 129);
            correctIndicator.Name = "correctIndicator";
            correctIndicator.Size = new Size(392, 57);
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
            pictureBox1.Location = new Point(325, 407);
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
            scoreIndicator.Location = new Point(217, 186);
            scoreIndicator.Name = "scoreIndicator";
            scoreIndicator.Size = new Size(350, 67);
            scoreIndicator.TabIndex = 51;
            scoreIndicator.Text = "Score:  XXXX";
            scoreIndicator.TextAlign = ContentAlignment.MiddleCenter;
            scoreIndicator.MouseHover += scoreIndicator_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(320, 279);
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
            placementIndicator.Size = new Size(387, 86);
            placementIndicator.TabIndex = 53;
            placementIndicator.Text = "xth place in Wildcard";
            placementIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Trophy;
            pictureBox3.Location = new Point(12, 439);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 118);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 54;
            pictureBox3.TabStop = false;
            // 
            // returnHome
            // 
            returnHome.BackColor = Color.White;
            returnHome.Cursor = Cursors.Hand;
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
            placingAgain.BackColor = Color.Transparent;
            placingAgain.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            placingAgain.ForeColor = Color.White;
            placingAgain.Location = new Point(59, 463);
            placingAgain.Name = "placingAgain";
            placingAgain.Size = new Size(59, 33);
            placingAgain.TabIndex = 56;
            placingAgain.Text = "150";
            placingAgain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // topScore
            // 
            topScore.BackColor = Color.Transparent;
            topScore.Font = new Font("Itim", 17F, FontStyle.Regular, GraphicsUnit.Point);
            topScore.ForeColor = Color.White;
            topScore.Location = new Point(513, 9);
            topScore.Name = "topScore";
            topScore.Size = new Size(266, 71);
            topScore.TabIndex = 57;
            topScore.Text = "placeholder";
            topScore.TextAlign = ContentAlignment.TopRight;
            // 
            // difficultyMultiplierSlot
            // 
            difficultyMultiplierSlot.BackColor = Color.Transparent;
            difficultyMultiplierSlot.Font = new Font("Itim", 17F, FontStyle.Regular, GraphicsUnit.Point);
            difficultyMultiplierSlot.ForeColor = Color.White;
            difficultyMultiplierSlot.Location = new Point(492, 65);
            difficultyMultiplierSlot.Name = "difficultyMultiplierSlot";
            difficultyMultiplierSlot.Size = new Size(287, 71);
            difficultyMultiplierSlot.TabIndex = 58;
            difficultyMultiplierSlot.Text = "Difficulty Multiplier: 1.4x";
            difficultyMultiplierSlot.TextAlign = ContentAlignment.TopRight;
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(difficultyMultiplierSlot);
            Controls.Add(topScore);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Results";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label topScore;
        private Label difficultyMultiplierSlot;
        private ToolTip toolTip1;
    }
}