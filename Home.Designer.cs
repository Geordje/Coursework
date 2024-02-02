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
            this.Title = new System.Windows.Forms.Label();
            this.logInButton = new Coursework.CoolButton();
            this.registerButton = new Coursework.CoolButton();
            this.coolButton1 = new Coursework.CoolButton();
            this.coolButton2 = new Coursework.CoolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Itim", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(217, 60);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(352, 81);
            this.Title.TabIndex = 12;
            this.Title.Text = "Trivia Deck";
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.White;
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.logInButton.FlatAppearance.BorderSize = 5;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Font = new System.Drawing.Font("Itim", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.logInButton.Location = new System.Drawing.Point(440, 355);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(254, 73);
            this.logInButton.TabIndex = 15;
            this.logInButton.Text = "Leaderboard";
            this.logInButton.UseVisualStyleBackColor = false;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.White;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.registerButton.FlatAppearance.BorderSize = 5;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Itim", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.registerButton.Location = new System.Drawing.Point(90, 355);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(254, 73);
            this.registerButton.TabIndex = 14;
            this.registerButton.Text = "Profiles";
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // coolButton1
            // 
            this.coolButton1.BackColor = System.Drawing.Color.White;
            this.coolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coolButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.coolButton1.FlatAppearance.BorderSize = 5;
            this.coolButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coolButton1.Font = new System.Drawing.Font("Itim", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coolButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.coolButton1.Location = new System.Drawing.Point(265, 449);
            this.coolButton1.Name = "coolButton1";
            this.coolButton1.Size = new System.Drawing.Size(254, 73);
            this.coolButton1.TabIndex = 16;
            this.coolButton1.Text = "Runner";
            this.coolButton1.UseVisualStyleBackColor = false;
            // 
            // coolButton2
            // 
            this.coolButton2.BackColor = System.Drawing.Color.White;
            this.coolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coolButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.coolButton2.FlatAppearance.BorderSize = 5;
            this.coolButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coolButton2.Font = new System.Drawing.Font("Itim", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coolButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.coolButton2.Location = new System.Drawing.Point(90, 215);
            this.coolButton2.Name = "coolButton2";
            this.coolButton2.Size = new System.Drawing.Size(604, 111);
            this.coolButton2.TabIndex = 17;
            this.coolButton2.Text = "Start Quiz!";
            this.coolButton2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Coursework.Properties.Resources.Hippo;
            this.pictureBox2.Location = new System.Drawing.Point(686, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Itim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(578, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "NamePlaceholder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.coolButton2);
            this.Controls.Add(this.coolButton1);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.Title);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private CoolButton logInButton;
        private CoolButton registerButton;
        private CoolButton coolButton1;
        private CoolButton coolButton2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}