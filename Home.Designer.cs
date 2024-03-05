namespace Coursework
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            Title = new Label();
            leaderboardButton = new CoolButton();
            profilesButton = new CoolButton();
            Start = new CoolButton();
            logOut = new PictureBox();
            ProfilePicture = new PictureBox();
            usernameSpot = new Label();
            QuizNumberIndicator = new Label();
            openFileDialog1 = new OpenFileDialog();
            tenQuizzes = new PictureBox();
            thirtyQuizzes = new PictureBox();
            fiftyQuizzes = new PictureBox();
            oneQuiz = new PictureBox();
            hundredQuizzes = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tenQuizzes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thirtyQuizzes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiftyQuizzes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oneQuiz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hundredQuizzes).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 50F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(217, 60);
            Title.Name = "Title";
            Title.Size = new Size(352, 81);
            Title.TabIndex = 12;
            Title.Text = "Trivia Deck";
            // 
            // leaderboardButton
            // 
            leaderboardButton.BackColor = Color.White;
            leaderboardButton.Cursor = Cursors.Hand;
            leaderboardButton.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            leaderboardButton.FlatAppearance.BorderSize = 5;
            leaderboardButton.FlatStyle = FlatStyle.Flat;
            leaderboardButton.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            leaderboardButton.ForeColor = Color.FromArgb(179, 63, 38);
            leaderboardButton.Location = new Point(440, 355);
            leaderboardButton.Name = "leaderboardButton";
            leaderboardButton.Size = new Size(254, 73);
            leaderboardButton.TabIndex = 15;
            leaderboardButton.Text = "Leaderboard";
            leaderboardButton.UseVisualStyleBackColor = false;
            leaderboardButton.Click += leaderboardButton_Click;
            // 
            // profilesButton
            // 
            profilesButton.BackColor = Color.White;
            profilesButton.Cursor = Cursors.Hand;
            profilesButton.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            profilesButton.FlatAppearance.BorderSize = 5;
            profilesButton.FlatStyle = FlatStyle.Flat;
            profilesButton.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            profilesButton.ForeColor = Color.FromArgb(179, 63, 38);
            profilesButton.Location = new Point(90, 355);
            profilesButton.Name = "profilesButton";
            profilesButton.Size = new Size(254, 73);
            profilesButton.TabIndex = 14;
            profilesButton.Text = "Profiles";
            profilesButton.UseVisualStyleBackColor = false;
            profilesButton.Click += profilesButton_Click;
            // 
            // Start
            // 
            Start.BackColor = Color.White;
            Start.Cursor = Cursors.Hand;
            Start.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            Start.FlatAppearance.BorderSize = 5;
            Start.FlatStyle = FlatStyle.Flat;
            Start.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Start.ForeColor = Color.FromArgb(179, 63, 38);
            Start.Location = new Point(90, 215);
            Start.Name = "Start";
            Start.Size = new Size(604, 111);
            Start.TabIndex = 17;
            Start.Text = "Start Quiz!";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // logOut
            // 
            logOut.Image = Properties.Resources.Exit;
            logOut.Location = new Point(12, 48);
            logOut.Name = "logOut";
            logOut.Size = new Size(84, 79);
            logOut.SizeMode = PictureBoxSizeMode.Zoom;
            logOut.TabIndex = 18;
            logOut.TabStop = false;
            logOut.Click += logOut_Click;
            // 
            // ProfilePicture
            // 
            ProfilePicture.Image = Properties.Resources.Hippo;
            ProfilePicture.Location = new Point(686, 48);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(86, 79);
            ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            ProfilePicture.TabIndex = 19;
            ProfilePicture.TabStop = false;
            ProfilePicture.Click += ProfilePicture_Click;
            // 
            // usernameSpot
            // 
            usernameSpot.AutoEllipsis = true;
            usernameSpot.BackColor = Color.Transparent;
            usernameSpot.Font = new Font("Itim", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usernameSpot.ForeColor = Color.White;
            usernameSpot.Location = new Point(542, 130);
            usernameSpot.Name = "usernameSpot";
            usernameSpot.Size = new Size(230, 17);
            usernameSpot.TabIndex = 20;
            usernameSpot.Text = "NamePlaceholder";
            usernameSpot.TextAlign = ContentAlignment.MiddleRight;
            // 
            // QuizNumberIndicator
            // 
            QuizNumberIndicator.AutoEllipsis = true;
            QuizNumberIndicator.BackColor = Color.Transparent;
            QuizNumberIndicator.Font = new Font("Itim", 16F, FontStyle.Regular, GraphicsUnit.Point);
            QuizNumberIndicator.ForeColor = Color.White;
            QuizNumberIndicator.Location = new Point(6, 516);
            QuizNumberIndicator.Name = "QuizNumberIndicator";
            QuizNumberIndicator.Size = new Size(250, 41);
            QuizNumberIndicator.TabIndex = 21;
            QuizNumberIndicator.Text = "Youve done XX quizzes!";
            QuizNumberIndicator.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Image files(*.jpeg; *.bmp; *.png; *.jpg)| *.jpeg; *.bmp; *.png; *.jpg";
            openFileDialog1.Title = "Choose a profile picture!";
            // 
            // tenQuizzes
            // 
            tenQuizzes.BackgroundImage = Properties.Resources.image__7_;
            tenQuizzes.BackgroundImageLayout = ImageLayout.Zoom;
            tenQuizzes.Location = new Point(56, 482);
            tenQuizzes.Name = "tenQuizzes";
            tenQuizzes.Size = new Size(40, 40);
            tenQuizzes.TabIndex = 22;
            tenQuizzes.TabStop = false;
            // 
            // thirtyQuizzes
            // 
            thirtyQuizzes.BackgroundImage = Properties.Resources.image__7_;
            thirtyQuizzes.BackgroundImageLayout = ImageLayout.Zoom;
            thirtyQuizzes.Location = new Point(102, 482);
            thirtyQuizzes.Name = "thirtyQuizzes";
            thirtyQuizzes.Size = new Size(40, 40);
            thirtyQuizzes.TabIndex = 23;
            thirtyQuizzes.TabStop = false;
            // 
            // fiftyQuizzes
            // 
            fiftyQuizzes.BackgroundImage = Properties.Resources.image__7_;
            fiftyQuizzes.BackgroundImageLayout = ImageLayout.Zoom;
            fiftyQuizzes.Location = new Point(148, 482);
            fiftyQuizzes.Name = "fiftyQuizzes";
            fiftyQuizzes.Size = new Size(40, 40);
            fiftyQuizzes.TabIndex = 24;
            fiftyQuizzes.TabStop = false;
            // 
            // oneQuiz
            // 
            oneQuiz.BackgroundImage = Properties.Resources.image__7_;
            oneQuiz.BackgroundImageLayout = ImageLayout.Zoom;
            oneQuiz.Location = new Point(10, 482);
            oneQuiz.Name = "oneQuiz";
            oneQuiz.Size = new Size(40, 40);
            oneQuiz.TabIndex = 25;
            oneQuiz.TabStop = false;
            // 
            // hundredQuizzes
            // 
            hundredQuizzes.BackgroundImage = Properties.Resources.image__7_;
            hundredQuizzes.BackgroundImageLayout = ImageLayout.Zoom;
            hundredQuizzes.Location = new Point(194, 482);
            hundredQuizzes.Name = "hundredQuizzes";
            hundredQuizzes.Size = new Size(40, 40);
            hundredQuizzes.TabIndex = 26;
            hundredQuizzes.TabStop = false;
            // 
            // Home
            // 
            AcceptButton = Start;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(hundredQuizzes);
            Controls.Add(oneQuiz);
            Controls.Add(fiftyQuizzes);
            Controls.Add(thirtyQuizzes);
            Controls.Add(tenQuizzes);
            Controls.Add(QuizNumberIndicator);
            Controls.Add(usernameSpot);
            Controls.Add(ProfilePicture);
            Controls.Add(logOut);
            Controls.Add(Start);
            Controls.Add(leaderboardButton);
            Controls.Add(profilesButton);
            Controls.Add(Title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)logOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)tenQuizzes).EndInit();
            ((System.ComponentModel.ISupportInitialize)thirtyQuizzes).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiftyQuizzes).EndInit();
            ((System.ComponentModel.ISupportInitialize)oneQuiz).EndInit();
            ((System.ComponentModel.ISupportInitialize)hundredQuizzes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private CoolButton leaderboardButton;
        private CoolButton profilesButton;
        private CoolButton coolButton1;
        private CoolButton Start;
        private PictureBox logOut;
        private PictureBox ProfilePicture;
        private Label usernameSpot;
        private Label QuizNumberIndicator;
        private OpenFileDialog openFileDialog1;
        private PictureBox tenQuizzes;
        private PictureBox thirtyQuizzes;
        private PictureBox fiftyQuizzes;
        private PictureBox oneQuiz;
        private PictureBox hundredQuizzes;
    }
}