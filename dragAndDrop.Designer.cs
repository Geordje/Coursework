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
            timeLeft = new Label();
            questionText = new Label();
            Title = new Label();
            pictureBox1 = new PictureBox();
            draggable1 = new Panel();
            dragLabel1 = new Label();
            draggable2 = new Panel();
            dragLabel2 = new Label();
            draggable3 = new Panel();
            dragLabel3 = new Label();
            draggable4 = new Panel();
            dragLabel4 = new Label();
            dropPoint4 = new Panel();
            dropPoint3 = new Panel();
            dropPoint2 = new Panel();
            dropPoint1 = new Panel();
            draggablePicture1 = new PictureBox();
            draggablePicture2 = new PictureBox();
            draggablePicture3 = new PictureBox();
            draggablePicture4 = new PictureBox();
            dropPointPicture1 = new PictureBox();
            dropPointPicture2 = new PictureBox();
            dropPointPicture3 = new PictureBox();
            dropPointPicture4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            draggable1.SuspendLayout();
            draggable2.SuspendLayout();
            draggable3.SuspendLayout();
            draggable4.SuspendLayout();
            dropPoint4.SuspendLayout();
            dropPoint3.SuspendLayout();
            dropPoint2.SuspendLayout();
            dropPoint1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)draggablePicture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)draggablePicture2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)draggablePicture3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)draggablePicture4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture4).BeginInit();
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
            // 
            // dragLabel1
            // 
            dragLabel1.Font = new Font("Itim", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dragLabel1.Location = new Point(0, 0);
            dragLabel1.Margin = new Padding(0);
            dragLabel1.Name = "dragLabel1";
            dragLabel1.Size = new Size(175, 100);
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
            // 
            // dragLabel2
            // 
            dragLabel2.Font = new Font("Itim", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dragLabel2.Location = new Point(0, 0);
            dragLabel2.Margin = new Padding(0);
            dragLabel2.Name = "dragLabel2";
            dragLabel2.Size = new Size(175, 100);
            dragLabel2.TabIndex = 63;
            dragLabel2.Text = "Drag Me!";
            dragLabel2.TextAlign = ContentAlignment.MiddleCenter;
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
            // 
            // dragLabel3
            // 
            dragLabel3.Font = new Font("Itim", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dragLabel3.Location = new Point(0, 0);
            dragLabel3.Margin = new Padding(0);
            dragLabel3.Name = "dragLabel3";
            dragLabel3.Size = new Size(175, 100);
            dragLabel3.TabIndex = 64;
            dragLabel3.Text = "Drag Me!";
            dragLabel3.TextAlign = ContentAlignment.MiddleCenter;
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
            // 
            // dragLabel4
            // 
            dragLabel4.Font = new Font("Itim", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dragLabel4.Location = new Point(0, 0);
            dragLabel4.Margin = new Padding(0);
            dragLabel4.Name = "dragLabel4";
            dragLabel4.Size = new Size(175, 100);
            dragLabel4.TabIndex = 64;
            dragLabel4.Text = "Drag Me!";
            dragLabel4.TextAlign = ContentAlignment.MiddleCenter;
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
            dropPoint4.DragDrop += DropPoint_DragDrop;
            dropPoint4.DragEnter += DropPoint_DragEnter;
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
            dropPoint3.DragDrop += DropPoint_DragDrop;
            dropPoint3.DragEnter += DropPoint_DragEnter;
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
            dropPoint2.DragDrop += DropPoint_DragDrop;
            dropPoint2.DragEnter += DropPoint_DragEnter;
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
            dropPoint1.DragDrop += DropPoint_DragDrop;
            dropPoint1.DragEnter += DropPoint_DragEnter;
            // 
            // draggablePicture1
            // 
            draggablePicture1.Location = new Point(7, 8);
            draggablePicture1.Margin = new Padding(0);
            draggablePicture1.Name = "draggablePicture1";
            draggablePicture1.Size = new Size(160, 85);
            draggablePicture1.SizeMode = PictureBoxSizeMode.Zoom;
            draggablePicture1.TabIndex = 1;
            draggablePicture1.TabStop = false;
            // 
            // draggablePicture2
            // 
            draggablePicture2.Location = new Point(7, 8);
            draggablePicture2.Margin = new Padding(0);
            draggablePicture2.Name = "draggablePicture2";
            draggablePicture2.Size = new Size(160, 85);
            draggablePicture2.SizeMode = PictureBoxSizeMode.Zoom;
            draggablePicture2.TabIndex = 64;
            draggablePicture2.TabStop = false;
            // 
            // draggablePicture3
            // 
            draggablePicture3.Location = new Point(7, 8);
            draggablePicture3.Margin = new Padding(0);
            draggablePicture3.Name = "draggablePicture3";
            draggablePicture3.Size = new Size(160, 85);
            draggablePicture3.SizeMode = PictureBoxSizeMode.Zoom;
            draggablePicture3.TabIndex = 65;
            draggablePicture3.TabStop = false;
            // 
            // draggablePicture4
            // 
            draggablePicture4.Location = new Point(7, 8);
            draggablePicture4.Margin = new Padding(0);
            draggablePicture4.Name = "draggablePicture4";
            draggablePicture4.Size = new Size(160, 85);
            draggablePicture4.SizeMode = PictureBoxSizeMode.Zoom;
            draggablePicture4.TabIndex = 65;
            draggablePicture4.TabStop = false;
            // 
            // dropPointPicture1
            // 
            dropPointPicture1.Location = new Point(7, 8);
            dropPointPicture1.Margin = new Padding(0);
            dropPointPicture1.Name = "dropPointPicture1";
            dropPointPicture1.Size = new Size(160, 85);
            dropPointPicture1.SizeMode = PictureBoxSizeMode.Zoom;
            dropPointPicture1.TabIndex = 2;
            dropPointPicture1.TabStop = false;
            // 
            // dropPointPicture2
            // 
            dropPointPicture2.Location = new Point(7, 8);
            dropPointPicture2.Margin = new Padding(0);
            dropPointPicture2.Name = "dropPointPicture2";
            dropPointPicture2.Size = new Size(160, 85);
            dropPointPicture2.SizeMode = PictureBoxSizeMode.Zoom;
            dropPointPicture2.TabIndex = 3;
            dropPointPicture2.TabStop = false;
            // 
            // dropPointPicture3
            // 
            dropPointPicture3.Location = new Point(7, 8);
            dropPointPicture3.Margin = new Padding(0);
            dropPointPicture3.Name = "dropPointPicture3";
            dropPointPicture3.Size = new Size(160, 85);
            dropPointPicture3.SizeMode = PictureBoxSizeMode.Zoom;
            dropPointPicture3.TabIndex = 3;
            dropPointPicture3.TabStop = false;
            // 
            // dropPointPicture4
            // 
            dropPointPicture4.Location = new Point(7, 8);
            dropPointPicture4.Margin = new Padding(0);
            dropPointPicture4.Name = "dropPointPicture4";
            dropPointPicture4.Size = new Size(160, 85);
            dropPointPicture4.SizeMode = PictureBoxSizeMode.Zoom;
            dropPointPicture4.TabIndex = 3;
            dropPointPicture4.TabStop = false;
            // 
            // dragAndDrop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(dropPoint4);
            Controls.Add(draggable4);
            Controls.Add(dropPoint3);
            Controls.Add(dropPoint2);
            Controls.Add(draggable3);
            Controls.Add(dropPoint1);
            Controls.Add(draggable2);
            Controls.Add(draggable1);
            Controls.Add(timeLeft);
            Controls.Add(questionText);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "dragAndDrop";
            Text = "dragAndDrop";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            draggable1.ResumeLayout(false);
            draggable2.ResumeLayout(false);
            draggable3.ResumeLayout(false);
            draggable4.ResumeLayout(false);
            dropPoint4.ResumeLayout(false);
            dropPoint3.ResumeLayout(false);
            dropPoint2.ResumeLayout(false);
            dropPoint1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)draggablePicture1).EndInit();
            ((System.ComponentModel.ISupportInitialize)draggablePicture2).EndInit();
            ((System.ComponentModel.ISupportInitialize)draggablePicture3).EndInit();
            ((System.ComponentModel.ISupportInitialize)draggablePicture4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dropPointPicture4).EndInit();
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
    }
}