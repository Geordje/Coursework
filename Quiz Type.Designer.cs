namespace Coursework
{
    partial class Quiz_Type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz_Type));
            pictureBox1 = new PictureBox();
            Title = new Label();
            Back = new PictureBox();
            bQuizButton = new CoolButton();
            eWildcard = new CoolButton();
            mWildcard = new CoolButton();
            hWildcard = new CoolButton();
            pDisclaimer = new Label();
            topScores = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Back).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pattern;
            pictureBox1.Location = new Point(224, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(561, 569);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 44F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(243, 45);
            Title.Name = "Title";
            Title.Size = new Size(299, 71);
            Title.TabIndex = 12;
            Title.Text = "Quiz Mode";
            // 
            // Back
            // 
            Back.Cursor = Cursors.Hand;
            Back.Image = (Image)resources.GetObject("Back.Image");
            Back.Location = new Point(11, 46);
            Back.Name = "Back";
            Back.Size = new Size(84, 79);
            Back.SizeMode = PictureBoxSizeMode.Zoom;
            Back.TabIndex = 18;
            Back.TabStop = false;
            Back.Click += Back_Click;
            // 
            // bQuizButton
            // 
            bQuizButton.BackColor = Color.White;
            bQuizButton.Cursor = Cursors.Hand;
            bQuizButton.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            bQuizButton.FlatAppearance.BorderSize = 5;
            bQuizButton.FlatStyle = FlatStyle.Flat;
            bQuizButton.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            bQuizButton.ForeColor = Color.FromArgb(179, 63, 38);
            bQuizButton.Location = new Point(61, 180);
            bQuizButton.Name = "bQuizButton";
            bQuizButton.Size = new Size(230, 100);
            bQuizButton.TabIndex = 19;
            bQuizButton.Text = "Base Quiz";
            bQuizButton.UseVisualStyleBackColor = false;
            // 
            // eWildcard
            // 
            eWildcard.BackColor = Color.White;
            eWildcard.Cursor = Cursors.Hand;
            eWildcard.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            eWildcard.FlatAppearance.BorderSize = 5;
            eWildcard.FlatStyle = FlatStyle.Flat;
            eWildcard.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            eWildcard.ForeColor = Color.FromArgb(179, 63, 38);
            eWildcard.Location = new Point(556, 137);
            eWildcard.Name = "eWildcard";
            eWildcard.Size = new Size(215, 100);
            eWildcard.TabIndex = 20;
            eWildcard.Text = "Easy WildCard";
            eWildcard.UseVisualStyleBackColor = false;
            eWildcard.Click += eWildcard_Click;
            // 
            // mWildcard
            // 
            mWildcard.BackColor = Color.White;
            mWildcard.Cursor = Cursors.Hand;
            mWildcard.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            mWildcard.FlatAppearance.BorderSize = 5;
            mWildcard.FlatStyle = FlatStyle.Flat;
            mWildcard.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            mWildcard.ForeColor = Color.FromArgb(179, 63, 38);
            mWildcard.Location = new Point(486, 286);
            mWildcard.Name = "mWildcard";
            mWildcard.Size = new Size(215, 100);
            mWildcard.TabIndex = 21;
            mWildcard.Text = "Intermediate WildCard";
            mWildcard.UseVisualStyleBackColor = false;
            mWildcard.Click += mWildcard_Click;
            // 
            // hWildcard
            // 
            hWildcard.BackColor = Color.White;
            hWildcard.Cursor = Cursors.Hand;
            hWildcard.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            hWildcard.FlatAppearance.BorderSize = 5;
            hWildcard.FlatStyle = FlatStyle.Flat;
            hWildcard.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            hWildcard.ForeColor = Color.FromArgb(179, 63, 38);
            hWildcard.Location = new Point(416, 435);
            hWildcard.Name = "hWildcard";
            hWildcard.Size = new Size(215, 100);
            hWildcard.TabIndex = 22;
            hWildcard.Text = "Hard WildCard";
            hWildcard.UseVisualStyleBackColor = false;
            hWildcard.Click += hWildcard_Click;
            // 
            // pDisclaimer
            // 
            pDisclaimer.BackColor = Color.Transparent;
            pDisclaimer.Font = new Font("Itim", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pDisclaimer.ForeColor = Color.FromArgb(255, 182, 166);
            pDisclaimer.Location = new Point(12, 464);
            pDisclaimer.Name = "pDisclaimer";
            pDisclaimer.Size = new Size(221, 88);
            pDisclaimer.TabIndex = 23;
            pDisclaimer.Text = "Wildcard quizzes are quizzes compiled from a large online trivia repository, an internet connection is required.";
            // 
            // topScores
            // 
            topScores.BackColor = Color.Transparent;
            topScores.Font = new Font("Itim", 14F, FontStyle.Regular, GraphicsUnit.Point);
            topScores.ForeColor = Color.White;
            topScores.Location = new Point(11, 393);
            topScores.Name = "topScores";
            topScores.Size = new Size(335, 71);
            topScores.TabIndex = 58;
            topScores.Text = "Your top WildCard score: XXXX\r\nYour top Base Quiz score: XXXX\r\n";
            topScores.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Quiz_Type
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(topScores);
            Controls.Add(pDisclaimer);
            Controls.Add(hWildcard);
            Controls.Add(mWildcard);
            Controls.Add(eWildcard);
            Controls.Add(bQuizButton);
            Controls.Add(Back);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            Name = "Quiz_Type";
            Text = "Quiz_Type";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Title;
        private PictureBox Back;
        private CoolButton bQuizButton;
        private CoolButton eWildcard;
        private CoolButton mWildcard;
        private CoolButton hWildcard;
        private Label pDisclaimer;
        private Label topScores;
    }
}