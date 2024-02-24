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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.PictureBox();
            this.bQuizButton = new Coursework.CoolButton();
            this.eWildcard = new Coursework.CoolButton();
            this.mWildcard = new Coursework.CoolButton();
            this.hWildcard = new Coursework.CoolButton();
            this.pDisclaimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework.Properties.Resources.Pattern;
            this.pictureBox1.Location = new System.Drawing.Point(224, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 569);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Itim", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(243, 45);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(299, 71);
            this.Title.TabIndex = 12;
            this.Title.Text = "Quiz Mode";
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(11, 46);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(84, 79);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 18;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // bQuizButton
            // 
            this.bQuizButton.BackColor = System.Drawing.Color.White;
            this.bQuizButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.bQuizButton.FlatAppearance.BorderSize = 5;
            this.bQuizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bQuizButton.Font = new System.Drawing.Font("Itim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bQuizButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.bQuizButton.Location = new System.Drawing.Point(61, 180);
            this.bQuizButton.Name = "bQuizButton";
            this.bQuizButton.Size = new System.Drawing.Size(230, 100);
            this.bQuizButton.TabIndex = 19;
            this.bQuizButton.Text = "Base Quiz";
            this.bQuizButton.UseVisualStyleBackColor = false;
            // 
            // eWildcard
            // 
            this.eWildcard.BackColor = System.Drawing.Color.White;
            this.eWildcard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eWildcard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.eWildcard.FlatAppearance.BorderSize = 5;
            this.eWildcard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eWildcard.Font = new System.Drawing.Font("Itim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eWildcard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.eWildcard.Location = new System.Drawing.Point(556, 137);
            this.eWildcard.Name = "eWildcard";
            this.eWildcard.Size = new System.Drawing.Size(215, 100);
            this.eWildcard.TabIndex = 20;
            this.eWildcard.Text = "Easy WildCard";
            this.eWildcard.UseVisualStyleBackColor = false;
            this.eWildcard.Click += new System.EventHandler(this.eWildcard_Click);
            // 
            // mWildcard
            // 
            this.mWildcard.BackColor = System.Drawing.Color.White;
            this.mWildcard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mWildcard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.mWildcard.FlatAppearance.BorderSize = 5;
            this.mWildcard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mWildcard.Font = new System.Drawing.Font("Itim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mWildcard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.mWildcard.Location = new System.Drawing.Point(486, 286);
            this.mWildcard.Name = "mWildcard";
            this.mWildcard.Size = new System.Drawing.Size(215, 100);
            this.mWildcard.TabIndex = 21;
            this.mWildcard.Text = "Intermediate WildCard";
            this.mWildcard.UseVisualStyleBackColor = false;
            this.mWildcard.Click += new System.EventHandler(this.mWildcard_Click);
            // 
            // hWildcard
            // 
            this.hWildcard.BackColor = System.Drawing.Color.White;
            this.hWildcard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hWildcard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.hWildcard.FlatAppearance.BorderSize = 5;
            this.hWildcard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hWildcard.Font = new System.Drawing.Font("Itim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hWildcard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.hWildcard.Location = new System.Drawing.Point(416, 435);
            this.hWildcard.Name = "hWildcard";
            this.hWildcard.Size = new System.Drawing.Size(215, 100);
            this.hWildcard.TabIndex = 22;
            this.hWildcard.Text = "Hard WildCard";
            this.hWildcard.UseVisualStyleBackColor = false;
            this.hWildcard.Click += new System.EventHandler(this.hWildcard_Click);
            // 
            // pDisclaimer
            // 
            this.pDisclaimer.BackColor = System.Drawing.Color.Transparent;
            this.pDisclaimer.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pDisclaimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.pDisclaimer.Location = new System.Drawing.Point(13, 464);
            this.pDisclaimer.Name = "pDisclaimer";
            this.pDisclaimer.Size = new System.Drawing.Size(221, 88);
            this.pDisclaimer.TabIndex = 23;
            this.pDisclaimer.Text = "Wildcard quizzes are quizzes compiled from a large online trivia repository, all " +
    "questions are generally unpredictable.";
            // 
            // Quiz_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pDisclaimer);
            this.Controls.Add(this.hWildcard);
            this.Controls.Add(this.mWildcard);
            this.Controls.Add(this.eWildcard);
            this.Controls.Add(this.bQuizButton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Quiz_Type";
            this.Text = "Quiz_Type";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}