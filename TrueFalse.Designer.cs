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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.questionText = new System.Windows.Forms.Label();
            this.trueCard = new System.Windows.Forms.PictureBox();
            this.falseCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trueCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Coursework.Properties.Resources.image__8_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Itim", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(225, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(334, 74);
            this.Title.TabIndex = 43;
            this.Title.Text = "Question x.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Itim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 33);
            this.label1.TabIndex = 44;
            this.label1.Text = "150";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionText
            // 
            this.questionText.BackColor = System.Drawing.Color.Transparent;
            this.questionText.Font = new System.Drawing.Font("Itim", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionText.ForeColor = System.Drawing.Color.White;
            this.questionText.Location = new System.Drawing.Point(40, 127);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(704, 149);
            this.questionText.TabIndex = 45;
            this.questionText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud" +
    " exercitation ullamco";
            this.questionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trueCard
            // 
            this.trueCard.BackColor = System.Drawing.Color.Transparent;
            this.trueCard.Image = global::Coursework.Properties.Resources.image__9_;
            this.trueCard.Location = new System.Drawing.Point(93, 287);
            this.trueCard.Name = "trueCard";
            this.trueCard.Size = new System.Drawing.Size(224, 272);
            this.trueCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trueCard.TabIndex = 46;
            this.trueCard.TabStop = false;
            this.trueCard.Click += new System.EventHandler(this.trueCard_Click);
            // 
            // falseCard
            // 
            this.falseCard.BackColor = System.Drawing.Color.Transparent;
            this.falseCard.Image = global::Coursework.Properties.Resources.False1;
            this.falseCard.Location = new System.Drawing.Point(470, 279);
            this.falseCard.Name = "falseCard";
            this.falseCard.Size = new System.Drawing.Size(244, 288);
            this.falseCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.falseCard.TabIndex = 47;
            this.falseCard.TabStop = false;
            this.falseCard.Click += new System.EventHandler(this.falseCard_Click);
            // 
            // TrueFalse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.BackgroundImage = global::Coursework.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.falseCard);
            this.Controls.Add(this.trueCard);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "TrueFalse";
            this.Text = "TrueFalse";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trueCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label Title;
        private Label label1;
        private Label questionText;
        private PictureBox trueCard;
        private PictureBox falseCard;
    }
}