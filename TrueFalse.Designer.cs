namespace Coursework
{
    partial class TrueFalse
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
            pictureBox1 = new PictureBox();
            Title = new Label();
            timeLeft = new Label();
            questionText = new Label();
            trueCard = new PictureBox();
            falseCard = new PictureBox();
            categoryIndicator = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trueCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)falseCard).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.image__8_;
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // Title
            // 
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 46F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(194, 29);
            Title.Name = "Title";
            Title.Size = new Size(397, 74);
            Title.TabIndex = 43;
            Title.Text = "Question x.";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeLeft
            // 
            timeLeft.BackColor = Color.Transparent;
            timeLeft.Font = new Font("Itim", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timeLeft.ForeColor = Color.White;
            timeLeft.Location = new Point(37, 45);
            timeLeft.Name = "timeLeft";
            timeLeft.Size = new Size(59, 33);
            timeLeft.TabIndex = 44;
            timeLeft.Text = "150";
            timeLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // questionText
            // 
            questionText.BackColor = Color.Transparent;
            questionText.Font = new Font("Itim", 26F, FontStyle.Regular, GraphicsUnit.Point);
            questionText.ForeColor = Color.White;
            questionText.Location = new Point(40, 105);
            questionText.Name = "questionText";
            questionText.Size = new Size(704, 171);
            questionText.TabIndex = 45;
            questionText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco";
            questionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trueCard
            // 
            trueCard.BackColor = Color.Transparent;
            trueCard.Cursor = Cursors.Hand;
            trueCard.Image = Properties.Resources.image__9_;
            trueCard.Location = new Point(93, 287);
            trueCard.Name = "trueCard";
            trueCard.Size = new Size(224, 272);
            trueCard.SizeMode = PictureBoxSizeMode.Zoom;
            trueCard.TabIndex = 46;
            trueCard.TabStop = false;
            trueCard.Click += trueCard_Click;
            // 
            // falseCard
            // 
            falseCard.BackColor = Color.Transparent;
            falseCard.Cursor = Cursors.Hand;
            falseCard.Image = Properties.Resources.False1;
            falseCard.Location = new Point(470, 279);
            falseCard.Name = "falseCard";
            falseCard.Size = new Size(244, 288);
            falseCard.SizeMode = PictureBoxSizeMode.Zoom;
            falseCard.TabIndex = 47;
            falseCard.TabStop = false;
            falseCard.Click += falseCard_Click;
            // 
            // categoryIndicator
            // 
            categoryIndicator.BackColor = Color.FromArgb(255, 182, 166);
            categoryIndicator.BorderStyle = BorderStyle.FixedSingle;
            categoryIndicator.Dock = DockStyle.Bottom;
            categoryIndicator.FlatStyle = FlatStyle.Flat;
            categoryIndicator.Font = new Font("Itim", 14F, FontStyle.Regular, GraphicsUnit.Point);
            categoryIndicator.ForeColor = Color.FromArgb(179, 63, 38);
            categoryIndicator.Location = new Point(0, 532);
            categoryIndicator.Name = "categoryIndicator";
            categoryIndicator.Size = new Size(784, 29);
            categoryIndicator.TabIndex = 48;
            categoryIndicator.Text = "Category: XXXXXXXXXXXX";
            categoryIndicator.TextAlign = ContentAlignment.MiddleCenter;
            categoryIndicator.Visible = false;
            // 
            // TrueFalse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(categoryIndicator);
            Controls.Add(questionText);
            Controls.Add(falseCard);
            Controls.Add(trueCard);
            Controls.Add(timeLeft);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "TrueFalse";
            Text = "TrueFalse";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trueCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)falseCard).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label Title;
        private Label questionText;
        private PictureBox trueCard;
        private PictureBox falseCard;
        public Label timeLeft;
        private Label label1;
        private Label categoryIndicator;
    }
}