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
            this.components = new System.ComponentModel.Container();
            this.correctIndicator = new System.Windows.Forms.Label();
            this.timeTaken = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scoreIndicator = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.placementIndicator = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.returnHome = new Coursework.CoolButton();
            this.placingAgain = new System.Windows.Forms.Label();
            this.topScore = new System.Windows.Forms.Label();
            this.difficultyMultiplierSlot = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // correctIndicator
            // 
            this.correctIndicator.BackColor = System.Drawing.Color.Transparent;
            this.correctIndicator.Font = new System.Drawing.Font("Itim", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctIndicator.ForeColor = System.Drawing.Color.White;
            this.correctIndicator.Location = new System.Drawing.Point(299, 129);
            this.correctIndicator.Name = "correctIndicator";
            this.correctIndicator.Size = new System.Drawing.Size(187, 57);
            this.correctIndicator.TabIndex = 50;
            this.correctIndicator.Text = "xx/20";
            this.correctIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeTaken
            // 
            this.timeTaken.BackColor = System.Drawing.Color.Transparent;
            this.timeTaken.Font = new System.Drawing.Font("Itim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeTaken.ForeColor = System.Drawing.Color.White;
            this.timeTaken.Location = new System.Drawing.Point(362, 439);
            this.timeTaken.Name = "timeTaken";
            this.timeTaken.Size = new System.Drawing.Size(60, 33);
            this.timeTaken.TabIndex = 49;
            this.timeTaken.Text = "150";
            this.timeTaken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Itim", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(277, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(230, 74);
            this.Title.TabIndex = 48;
            this.Title.Text = "Results";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Coursework.Properties.Resources.image__8_;
            this.pictureBox1.Location = new System.Drawing.Point(327, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // scoreIndicator
            // 
            this.scoreIndicator.BackColor = System.Drawing.Color.Transparent;
            this.scoreIndicator.Font = new System.Drawing.Font("Itim", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreIndicator.ForeColor = System.Drawing.Color.White;
            this.scoreIndicator.Location = new System.Drawing.Point(217, 186);
            this.scoreIndicator.Name = "scoreIndicator";
            this.scoreIndicator.Size = new System.Drawing.Size(350, 67);
            this.scoreIndicator.TabIndex = 51;
            this.scoreIndicator.Text = "Score:  XXXX";
            this.scoreIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreIndicator.MouseHover += new System.EventHandler(this.scoreIndicator_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Itim", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(320, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 40);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ranking:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // placementIndicator
            // 
            this.placementIndicator.BackColor = System.Drawing.Color.Transparent;
            this.placementIndicator.Font = new System.Drawing.Font("Itim", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placementIndicator.ForeColor = System.Drawing.Color.White;
            this.placementIndicator.Location = new System.Drawing.Point(197, 319);
            this.placementIndicator.Name = "placementIndicator";
            this.placementIndicator.Size = new System.Drawing.Size(387, 80);
            this.placementIndicator.TabIndex = 53;
            this.placementIndicator.Text = "xth place in Wildcard";
            this.placementIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Coursework.Properties.Resources.Trophy;
            this.pictureBox3.Location = new System.Drawing.Point(8, 439);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // returnHome
            // 
            this.returnHome.BackColor = System.Drawing.Color.White;
            this.returnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.returnHome.FlatAppearance.BorderSize = 5;
            this.returnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnHome.Font = new System.Drawing.Font("Itim", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.returnHome.Location = new System.Drawing.Point(559, 482);
            this.returnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnHome.Name = "returnHome";
            this.returnHome.Size = new System.Drawing.Size(202, 68);
            this.returnHome.TabIndex = 55;
            this.returnHome.Text = "Return Home";
            this.returnHome.UseVisualStyleBackColor = false;
            this.returnHome.Click += new System.EventHandler(this.returnHome_Click);
            // 
            // placingAgain
            // 
            this.placingAgain.AutoSize = true;
            this.placingAgain.BackColor = System.Drawing.Color.Transparent;
            this.placingAgain.Font = new System.Drawing.Font("Itim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placingAgain.ForeColor = System.Drawing.Color.White;
            this.placingAgain.Location = new System.Drawing.Point(55, 463);
            this.placingAgain.Name = "placingAgain";
            this.placingAgain.Size = new System.Drawing.Size(59, 33);
            this.placingAgain.TabIndex = 56;
            this.placingAgain.Text = "150";
            this.placingAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topScore
            // 
            this.topScore.BackColor = System.Drawing.Color.Transparent;
            this.topScore.Font = new System.Drawing.Font("Itim", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topScore.ForeColor = System.Drawing.Color.White;
            this.topScore.Location = new System.Drawing.Point(513, 9);
            this.topScore.Name = "topScore";
            this.topScore.Size = new System.Drawing.Size(266, 71);
            this.topScore.TabIndex = 57;
            this.topScore.Text = "placeholder";
            this.topScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // difficultyMultiplierSlot
            // 
            this.difficultyMultiplierSlot.BackColor = System.Drawing.Color.Transparent;
            this.difficultyMultiplierSlot.Font = new System.Drawing.Font("Itim", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficultyMultiplierSlot.ForeColor = System.Drawing.Color.White;
            this.difficultyMultiplierSlot.Location = new System.Drawing.Point(492, 65);
            this.difficultyMultiplierSlot.Name = "difficultyMultiplierSlot";
            this.difficultyMultiplierSlot.Size = new System.Drawing.Size(287, 71);
            this.difficultyMultiplierSlot.TabIndex = 58;
            this.difficultyMultiplierSlot.Text = "Difficulty Multiplier: 1.4x";
            this.difficultyMultiplierSlot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.BackgroundImage = global::Coursework.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.difficultyMultiplierSlot);
            this.Controls.Add(this.topScore);
            this.Controls.Add(this.placingAgain);
            this.Controls.Add(this.returnHome);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.placementIndicator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scoreIndicator);
            this.Controls.Add(this.correctIndicator);
            this.Controls.Add(this.timeTaken);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Results";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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