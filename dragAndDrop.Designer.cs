namespace Coursework
{
    partial class dragAndDrop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dragAndDrop));
            timeLeft = new Label();
            questionText = new Label();
            Title = new Label();
            pictureBox1 = new PictureBox();
            draggable1 = new Panel();
            draggablePicture1 = new PictureBox();
            dragLabel1 = new Label();
            draggable2 = new Panel();
            draggablePicture2 = new PictureBox();
            dragLabel2 = new Label();
            draggable3 = new Panel();
            draggablePicture3 = new PictureBox();
            dragLabel3 = new Label();
            draggable4 = new Panel();
            draggablePicture4 = new PictureBox();
            dragLabel4 = new Label();
            dropPoint4 = new Panel();
            dropPointPicture4 = new PictureBox();
            dropPoint3 = new Panel();
            dropPointPicture3 = new PictureBox();
            dropPoint2 = new Panel();
            dropPointPicture2 = new PictureBox();
            dropPoint1 = new Panel();
            dropPointPicture1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            draggable1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)draggablePicture1).BeginInit();
            draggable2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)draggablePicture2).BeginInit();
            draggable3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)draggablePicture3).BeginInit();
            draggable4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)draggablePicture4).BeginInit();
            dropPoint4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture4).BeginInit();
            dropPoint3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture3).BeginInit();
            dropPoint2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture2).BeginInit();
            dropPoint1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture1).BeginInit();
            SuspendLayout();
            // 
            // timeLeft
            // 
            timeLeft.BackColor = Color.Transparent;
            timeLeft.Font = new Font("Itim", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timeLeft.ForeColor = Color.White;
            timeLeft.Location = new Point(39, 44);
            timeLeft.Name = "timeLeft";
            timeLeft.Size = new Size(57, 33);
            timeLeft.TabIndex = 53;
            timeLeft.Text = "150";
            timeLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // questionText
            // 
            questionText.BackColor = Color.Transparent;
            questionText.Font = new Font("Itim", 18F, FontStyle.Regular, GraphicsUnit.Point);
            questionText.ForeColor = Color.White;
            questionText.Location = new Point(137, 73);
            questionText.Name = "questionText";
            questionText.Size = new Size(635, 78);
            questionText.TabIndex = 54;
            questionText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco";
            // 
            // Title
            // 
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(134, 15);
            Title.Name = "Title";
            Title.Size = new Size(397, 74);
            Title.TabIndex = 52;
            Title.Text = "Question x.";
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
            // draggable1
            // 
            draggable1.AllowDrop = true;
            draggable1.BackColor = Color.Transparent;
            draggable1.BackgroundImage = Properties.Resources.DragDrop;
            draggable1.BackgroundImageLayout = ImageLayout.Zoom;
            draggable1.Controls.Add(draggablePicture1);
            draggable1.Controls.Add(dragLabel1);
            draggable1.Location = new Point(52, 239);
            draggable1.Margin = new Padding(0);
            draggable1.Name = "draggable1";
            draggable1.Size = new Size(175, 100);
            draggable1.TabIndex = 55;
            draggable1.MouseDown += Draggable_MouseDown;
            draggable1.MouseMove += Draggable_MouseMove;
            draggable1.MouseUp += Draggable_MouseUp;
            // 
            // draggablePicture1
            // 
            draggablePicture1.Enabled = false;
            draggablePicture1.Location = new Point(7, 8);
            draggablePicture1.Margin = new Padding(0);
            draggablePicture1.Name = "draggablePicture1";
            draggablePicture1.Size = new Size(160, 85);
            draggablePicture1.SizeMode = PictureBoxSizeMode.Zoom;
            draggablePicture1.TabIndex = 1;
            draggablePicture1.TabStop = false;
            // 
            // dragLabel1
            // 
            dragLabel1.Enabled = false;
            dragLabel1.Font = new Font("Itim", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dragLabel1.Location = new Point(7, 8);
            dragLabel1.Margin = new Padding(0);
            dragLabel1.Name = "dragLabel1";
            dragLabel1.Size = new Size(160, 85);
            dragLabel1.TabIndex = 0;
            dragLabel1.Text = "DragMe!";
            dragLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // draggable2
            // 
            draggable2.BackColor = Color.Transparent;
            draggable2.BackgroundImage = Properties.Resources.DragDrop;
            draggable2.BackgroundImageLayout = ImageLayout.Zoom;
            draggable2.Controls.Add(draggablePicture2);
            draggable2.Controls.Add(dragLabel2);
            draggable2.Location = new Point(233, 239);
            draggable2.Margin = new Padding(0);
            draggable2.Name = "draggable2";
            draggable2.Size = new Size(175, 100);
            draggable2.TabIndex = 56;
            draggable2.MouseDown += Draggable_MouseDown;
            draggable2.MouseMove += Draggable_MouseMove;
            draggable2.MouseUp += Draggable_MouseUp;
            // 
            // draggablePicture2
            // 
            draggablePicture2.Enabled = false;
            draggablePicture2.Location = new Point(7, 8);
            draggablePicture2.Margin = new Padding(0);
            draggablePicture2.Name = "draggablePicture2";
            draggablePicture2.Size = new Size(160, 85);
            draggablePicture2.SizeMode = PictureBoxSizeMode.Zoom;
            draggablePicture2.TabIndex = 64;
            draggablePicture2.TabStop = false;
            // 
            // dragLabel2
            // 
            dragLabel2.Enabled = false;
            dragLabel2.Font = new Font("Itim", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dragLabel2.Location = new Point(7, 8);
            dragLabel2.Margin = new Padding(0);
            dragLabel2.Name = "dragLabel2";
            dragLabel2.Size = new Size(160, 85);
            dragLabel2.TabIndex = 63;
            dragLabel2.Text = "Drag Me!";
            dragLabel2.TextAlign = ContentAlignment.MiddleCenter;
            dragLabel2.MouseDown += Draggable_MouseDown;
            // 
            // draggable3
            // 
            draggable3.BackColor = Color.Transparent;
            draggable3.BackgroundImage = Properties.Resources.DragDrop;
            draggable3.BackgroundImageLayout = ImageLayout.Zoom;
            draggable3.Controls.Add(draggablePicture3);
            draggable3.Controls.Add(dragLabel3);
            draggable3.Location = new Point(52, 345);
            draggable3.Margin = new Padding(0);
            draggable3.Name = "draggable3";
            draggable3.Size = new Size(175, 100);
            draggable3.TabIndex = 57;
            draggable3.MouseDown += Draggable_MouseDown;
            draggable3.MouseMove += Draggable_MouseMove;
            draggable3.MouseUp += Draggable_MouseUp;
            // 
            // draggablePicture3
            // 
            draggablePicture3.Enabled = false;
            draggablePicture3.Location = new Point(7, 8);
            draggablePicture3.Margin = new Padding(0);
            draggablePicture3.Name = "draggablePicture3";
            draggablePicture3.Size = new Size(160, 85);
            draggablePicture3.SizeMode = PictureBoxSizeMode.Zoom;
            draggablePicture3.TabIndex = 65;
            draggablePicture3.TabStop = false;
            // 
            // dragLabel3
            // 
            dragLabel3.Enabled = false;
            dragLabel3.Font = new Font("Itim", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dragLabel3.Location = new Point(7, 8);
            dragLabel3.Margin = new Padding(0);
            dragLabel3.Name = "dragLabel3";
            dragLabel3.Size = new Size(160, 85);
            dragLabel3.TabIndex = 64;
            dragLabel3.Text = "Drag Me!";
            dragLabel3.TextAlign = ContentAlignment.MiddleCenter;
            dragLabel3.MouseDown += Draggable_MouseDown;
            // 
            // draggable4
            // 
            draggable4.BackColor = Color.Transparent;
            draggable4.BackgroundImage = Properties.Resources.DragDrop;
            draggable4.BackgroundImageLayout = ImageLayout.Zoom;
            draggable4.Controls.Add(draggablePicture4);
            draggable4.Controls.Add(dragLabel4);
            draggable4.Location = new Point(233, 345);
            draggable4.Margin = new Padding(0);
            draggable4.Name = "draggable4";
            draggable4.Size = new Size(175, 100);
            draggable4.TabIndex = 58;
            draggable4.MouseDown += Draggable_MouseDown;
            draggable4.MouseMove += Draggable_MouseMove;
            draggable4.MouseUp += Draggable_MouseUp;
            // 
            // draggablePicture4
            // 
            draggablePicture4.Enabled = false;
            draggablePicture4.Location = new Point(7, 8);
            draggablePicture4.Margin = new Padding(0);
            draggablePicture4.Name = "draggablePicture4";
            draggablePicture4.Size = new Size(160, 85);
            draggablePicture4.SizeMode = PictureBoxSizeMode.Zoom;
            draggablePicture4.TabIndex = 65;
            draggablePicture4.TabStop = false;
            // 
            // dragLabel4
            // 
            dragLabel4.Enabled = false;
            dragLabel4.Font = new Font("Itim", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dragLabel4.Location = new Point(7, 8);
            dragLabel4.Margin = new Padding(0);
            dragLabel4.Name = "dragLabel4";
            dragLabel4.Size = new Size(160, 85);
            dragLabel4.TabIndex = 64;
            dragLabel4.Text = "Drag Me!";
            dragLabel4.TextAlign = ContentAlignment.MiddleCenter;
            dragLabel4.MouseDown += Draggable_MouseDown;
            // 
            // dropPoint4
            // 
            dropPoint4.AllowDrop = true;
            dropPoint4.BackColor = Color.Transparent;
            dropPoint4.BackgroundImage = Properties.Resources.DragDrop;
            dropPoint4.BackgroundImageLayout = ImageLayout.Zoom;
            dropPoint4.Controls.Add(dropPointPicture4);
            dropPoint4.Location = new Point(581, 451);
            dropPoint4.Name = "dropPoint4";
            dropPoint4.Size = new Size(175, 100);
            dropPoint4.TabIndex = 62;
            // 
            // dropPointPicture4
            // 
            dropPointPicture4.Enabled = false;
            dropPointPicture4.Location = new Point(7, 8);
            dropPointPicture4.Margin = new Padding(0);
            dropPointPicture4.Name = "dropPointPicture4";
            dropPointPicture4.Size = new Size(160, 85);
            dropPointPicture4.SizeMode = PictureBoxSizeMode.Zoom;
            dropPointPicture4.TabIndex = 3;
            dropPointPicture4.TabStop = false;
            // 
            // dropPoint3
            // 
            dropPoint3.AllowDrop = true;
            dropPoint3.BackColor = Color.Transparent;
            dropPoint3.BackgroundImage = Properties.Resources.DragDrop;
            dropPoint3.BackgroundImageLayout = ImageLayout.Zoom;
            dropPoint3.Controls.Add(dropPointPicture3);
            dropPoint3.Location = new Point(581, 345);
            dropPoint3.Name = "dropPoint3";
            dropPoint3.Size = new Size(175, 100);
            dropPoint3.TabIndex = 61;
            // 
            // dropPointPicture3
            // 
            dropPointPicture3.Enabled = false;
            dropPointPicture3.Location = new Point(7, 8);
            dropPointPicture3.Margin = new Padding(0);
            dropPointPicture3.Name = "dropPointPicture3";
            dropPointPicture3.Size = new Size(160, 85);
            dropPointPicture3.SizeMode = PictureBoxSizeMode.Zoom;
            dropPointPicture3.TabIndex = 3;
            dropPointPicture3.TabStop = false;
            // 
            // dropPoint2
            // 
            dropPoint2.AllowDrop = true;
            dropPoint2.BackColor = Color.Transparent;
            dropPoint2.BackgroundImage = Properties.Resources.DragDrop;
            dropPoint2.BackgroundImageLayout = ImageLayout.Zoom;
            dropPoint2.Controls.Add(dropPointPicture2);
            dropPoint2.Location = new Point(581, 239);
            dropPoint2.Name = "dropPoint2";
            dropPoint2.Size = new Size(175, 100);
            dropPoint2.TabIndex = 60;
            // 
            // dropPointPicture2
            // 
            dropPointPicture2.Enabled = false;
            dropPointPicture2.Location = new Point(7, 8);
            dropPointPicture2.Margin = new Padding(0);
            dropPointPicture2.Name = "dropPointPicture2";
            dropPointPicture2.Size = new Size(160, 85);
            dropPointPicture2.SizeMode = PictureBoxSizeMode.Zoom;
            dropPointPicture2.TabIndex = 3;
            dropPointPicture2.TabStop = false;
            // 
            // dropPoint1
            // 
            dropPoint1.AllowDrop = true;
            dropPoint1.BackColor = Color.Transparent;
            dropPoint1.BackgroundImage = Properties.Resources.DragDrop;
            dropPoint1.BackgroundImageLayout = ImageLayout.Zoom;
            dropPoint1.Controls.Add(dropPointPicture1);
            dropPoint1.Location = new Point(581, 133);
            dropPoint1.Name = "dropPoint1";
            dropPoint1.Size = new Size(175, 100);
            dropPoint1.TabIndex = 59;
            // 
            // dropPointPicture1
            // 
            dropPointPicture1.Enabled = false;
            dropPointPicture1.Location = new Point(7, 8);
            dropPointPicture1.Margin = new Padding(0);
            dropPointPicture1.Name = "dropPointPicture1";
            dropPointPicture1.Size = new Size(160, 85);
            dropPointPicture1.SizeMode = PictureBoxSizeMode.Zoom;
            dropPointPicture1.TabIndex = 2;
            dropPointPicture1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Itim", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 182, 166);
            label1.Location = new Point(0, 510);
            label1.Name = "label1";
            label1.Size = new Size(563, 51);
            label1.TabIndex = 63;
            label1.Text = "Drag and drop questions are worth 2 points!\r\nYou gain a point for every 2 correct guesses.\r\n\r\n\r\n";
            // 
            // dragAndDrop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(label1);
            Controls.Add(draggable4);
            Controls.Add(draggable3);
            Controls.Add(draggable2);
            Controls.Add(draggable1);
            Controls.Add(timeLeft);
            Controls.Add(pictureBox1);
            Controls.Add(dropPoint4);
            Controls.Add(dropPoint3);
            Controls.Add(dropPoint2);
            Controls.Add(dropPoint1);
            Controls.Add(questionText);
            Controls.Add(Title);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "dragAndDrop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drag and Drop";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            draggable1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)draggablePicture1).EndInit();
            draggable2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)draggablePicture2).EndInit();
            draggable3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)draggablePicture3).EndInit();
            draggable4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)draggablePicture4).EndInit();
            dropPoint4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dropPointPicture4).EndInit();
            dropPoint3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dropPointPicture3).EndInit();
            dropPoint2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dropPointPicture2).EndInit();
            dropPoint1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dropPointPicture1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label timeLeft;
        private Label questionText;
        private Label Title;
        private PictureBox pictureBox1;
        private Panel draggable1;
        private Panel draggable2;
        private Panel draggable3;
        private Panel draggable4;
        private Panel dropPoint4;
        private Panel dropPoint3;
        private Panel dropPoint2;
        private Panel dropPoint1;
        private Label dragLabel1;
        private Label dragLabel2;
        private Label dragLabel3;
        private Label dragLabel4;
        private PictureBox draggablePicture1;
        private PictureBox draggablePicture2;
        private PictureBox draggablePicture3;
        private PictureBox draggablePicture4;
        private PictureBox dropPointPicture4;
        private PictureBox dropPointPicture3;
        private PictureBox dropPointPicture2;
        private PictureBox dropPointPicture1;
        private Label label1;
    }
}