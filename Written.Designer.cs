namespace Coursework
{
    partial class Written
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Written));
            answerSlot = new TextBox();
            submitButton = new CoolButton();
            pictureBox2 = new PictureBox();
            timeLeft = new Label();
            questionText = new Label();
            Title = new Label();
            pictureBox1 = new PictureBox();
            formatHelper = new Label();
            treeHint = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)treeHint).BeginInit();
            SuspendLayout();
            // 
            // answerSlot
            // 
            answerSlot.BorderStyle = BorderStyle.None;
            answerSlot.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            answerSlot.ForeColor = Color.FromArgb(179, 63, 38);
            answerSlot.Location = new Point(107, 378);
            answerSlot.Margin = new Padding(3, 2, 3, 2);
            answerSlot.Name = "answerSlot";
            answerSlot.PlaceholderText = "Answer";
            answerSlot.Size = new Size(571, 32);
            answerSlot.TabIndex = 1;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.White;
            submitButton.Cursor = Cursors.Hand;
            submitButton.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            submitButton.FlatAppearance.BorderSize = 5;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.ForeColor = Color.FromArgb(179, 63, 38);
            submitButton.Location = new Point(490, 441);
            submitButton.Margin = new Padding(3, 2, 3, 2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(202, 68);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image__1_;
            pictureBox2.Location = new Point(93, 353);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(599, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // timeLeft
            // 
            timeLeft.BackColor = Color.Transparent;
            timeLeft.Font = new Font("Itim", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timeLeft.ForeColor = Color.White;
            timeLeft.Location = new Point(38, 45);
            timeLeft.Name = "timeLeft";
            timeLeft.Size = new Size(57, 33);
            timeLeft.TabIndex = 53;
            timeLeft.Text = "150";
            timeLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // questionText
            // 
            questionText.BackColor = Color.Transparent;
            questionText.Font = new Font("Itim", 30F, FontStyle.Regular, GraphicsUnit.Point);
            questionText.ForeColor = Color.White;
            questionText.Location = new Point(40, 105);
            questionText.Name = "questionText";
            questionText.Size = new Size(704, 247);
            questionText.TabIndex = 54;
            questionText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco";
            questionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 46F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(194, 28);
            Title.Name = "Title";
            Title.Size = new Size(397, 74);
            Title.TabIndex = 52;
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
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // formatHelper
            // 
            formatHelper.BackColor = Color.Transparent;
            formatHelper.Font = new Font("Itim", 14F, FontStyle.Regular, GraphicsUnit.Point);
            formatHelper.ForeColor = Color.FromArgb(255, 182, 166);
            formatHelper.ImageAlign = ContentAlignment.TopLeft;
            formatHelper.Location = new Point(93, 444);
            formatHelper.Name = "formatHelper";
            formatHelper.Size = new Size(391, 71);
            formatHelper.TabIndex = 55;
            formatHelper.Text = "Format: Lorem ipsum dolor sit amet, consectetur adipiscing elit, \r\n\r\n";
            // 
            // treeHint
            // 
            treeHint.BackgroundImageLayout = ImageLayout.Zoom;
            treeHint.Cursor = Cursors.Hand;
            treeHint.Image = Properties.Resources.treeHint;
            treeHint.Location = new Point(704, 441);
            treeHint.Name = "treeHint";
            treeHint.Size = new Size(68, 68);
            treeHint.SizeMode = PictureBoxSizeMode.Zoom;
            treeHint.TabIndex = 56;
            treeHint.TabStop = false;
            treeHint.Click += treeHint_Click;
            // 
            // Written
            // 
            AcceptButton = submitButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(treeHint);
            Controls.Add(formatHelper);
            Controls.Add(timeLeft);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            Controls.Add(answerSlot);
            Controls.Add(submitButton);
            Controls.Add(pictureBox2);
            Controls.Add(questionText);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Written";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Written Question";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)treeHint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox answerSlot;
        private CoolButton submitButton;
        private PictureBox pictureBox2;
        public Label timeLeft;
        private Label questionText;
        private Label Title;
        private PictureBox pictureBox1;
        private Label formatHelper;
        private PictureBox treeHint;
    }
}