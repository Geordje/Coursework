namespace Coursework
{
    partial class multipleChoice
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
            questionText = new Label();
            timeLeft = new Label();
            Title = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            answer1txt = new Label();
            answer2txt = new Label();
            pictureBox4 = new PictureBox();
            answer3txt = new Label();
            pictureBox5 = new PictureBox();
            answer4txt = new Label();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // questionText
            // 
            questionText.BackColor = Color.Transparent;
            questionText.Font = new Font("Itim", 30F, FontStyle.Regular, GraphicsUnit.Point);
            questionText.ForeColor = Color.White;
            questionText.Location = new Point(40, 127);
            questionText.Name = "questionText";
            questionText.Size = new Size(704, 199);
            questionText.TabIndex = 50;
            questionText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco";
            questionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeLeft
            // 
            timeLeft.BackColor = Color.Transparent;
            timeLeft.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            timeLeft.ForeColor = Color.White;
            timeLeft.Location = new Point(38, 45);
            timeLeft.Name = "timeLeft";
            timeLeft.Size = new Size(57, 33);
            timeLeft.TabIndex = 49;
            timeLeft.Text = "90";
            timeLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 46F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(194, 28);
            Title.Name = "Title";
            Title.Size = new Size(397, 74);
            Title.TabIndex = 48;
            Title.Text = "Question x.";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.image__8_;
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Card;
            pictureBox3.Location = new Point(35, 339);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 194);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            // 
            // answer1txt
            // 
            answer1txt.BackColor = Color.White;
            answer1txt.Cursor = Cursors.Hand;
            answer1txt.Font = new Font("Itim", 14F, FontStyle.Regular, GraphicsUnit.Point);
            answer1txt.ForeColor = Color.FromArgb(179, 63, 38);
            answer1txt.Location = new Point(48, 353);
            answer1txt.Name = "answer1txt";
            answer1txt.Size = new Size(125, 168);
            answer1txt.TabIndex = 55;
            answer1txt.Text = "Answer1";
            answer1txt.TextAlign = ContentAlignment.MiddleCenter;
            answer1txt.Click += answer1txt_Click;
            // 
            // answer2txt
            // 
            answer2txt.BackColor = Color.White;
            answer2txt.Cursor = Cursors.Hand;
            answer2txt.Font = new Font("Itim", 14F, FontStyle.Regular, GraphicsUnit.Point);
            answer2txt.ForeColor = Color.FromArgb(179, 63, 38);
            answer2txt.Location = new Point(236, 353);
            answer2txt.Name = "answer2txt";
            answer2txt.Size = new Size(125, 168);
            answer2txt.TabIndex = 57;
            answer2txt.Text = "Answer2";
            answer2txt.TextAlign = ContentAlignment.MiddleCenter;
            answer2txt.Click += answer2txt_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.Card;
            pictureBox4.Location = new Point(223, 339);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 194);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 56;
            pictureBox4.TabStop = false;
            // 
            // answer3txt
            // 
            answer3txt.BackColor = Color.White;
            answer3txt.Cursor = Cursors.Hand;
            answer3txt.Font = new Font("Itim", 14F, FontStyle.Regular, GraphicsUnit.Point);
            answer3txt.ForeColor = Color.FromArgb(179, 63, 38);
            answer3txt.Location = new Point(424, 353);
            answer3txt.Name = "answer3txt";
            answer3txt.Size = new Size(125, 168);
            answer3txt.TabIndex = 59;
            answer3txt.Text = "Answer3";
            answer3txt.TextAlign = ContentAlignment.MiddleCenter;
            answer3txt.Click += answer3txt_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.Card;
            pictureBox5.Location = new Point(411, 339);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(150, 194);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 58;
            pictureBox5.TabStop = false;
            // 
            // answer4txt
            // 
            answer4txt.BackColor = Color.White;
            answer4txt.Cursor = Cursors.Hand;
            answer4txt.Font = new Font("Itim", 14F, FontStyle.Regular, GraphicsUnit.Point);
            answer4txt.ForeColor = Color.FromArgb(179, 63, 38);
            answer4txt.Location = new Point(612, 353);
            answer4txt.Name = "answer4txt";
            answer4txt.Size = new Size(125, 168);
            answer4txt.TabIndex = 61;
            answer4txt.Text = "Answer4";
            answer4txt.TextAlign = ContentAlignment.MiddleCenter;
            answer4txt.Click += answer4txt_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.Card;
            pictureBox6.Location = new Point(599, 339);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(150, 194);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 60;
            pictureBox6.TabStop = false;
            // 
            // multipleChoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(timeLeft);
            Controls.Add(answer4txt);
            Controls.Add(pictureBox6);
            Controls.Add(answer3txt);
            Controls.Add(pictureBox5);
            Controls.Add(answer2txt);
            Controls.Add(pictureBox4);
            Controls.Add(answer1txt);
            Controls.Add(pictureBox3);
            Controls.Add(questionText);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "multipleChoice";
            Text = "multipleChoice";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label questionText;
        private Label Title;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label answer1txt;
        private Label answer2txt;
        private PictureBox pictureBox4;
        private Label answer3txt;
        private PictureBox pictureBox5;
        private Label answer4txt;
        private PictureBox pictureBox6;
        public Label timeLeft;
    }
}