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
            this.Start = new Coursework.CoolButton();
            this.logOut = new System.Windows.Forms.PictureBox();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.usernameSpot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
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
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.White;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.Start.FlatAppearance.BorderSize = 5;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Itim", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.Start.Location = new System.Drawing.Point(90, 215);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(604, 111);
            this.Start.TabIndex = 17;
            this.Start.Text = "Start Quiz!";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // logOut
            // 
            this.logOut.Image = global::Coursework.Properties.Resources.Exit;
            this.logOut.Location = new System.Drawing.Point(12, 48);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(84, 79);
            this.logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOut.TabIndex = 18;
            this.logOut.TabStop = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePicture.Image = global::Coursework.Properties.Resources.Hippo;
            this.ProfilePicture.Location = new System.Drawing.Point(686, 48);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(86, 79);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 19;
            this.ProfilePicture.TabStop = false;
            // 
            // usernameSpot
            // 
            this.usernameSpot.AutoEllipsis = true;
            this.usernameSpot.BackColor = System.Drawing.Color.Transparent;
            this.usernameSpot.Font = new System.Drawing.Font("Itim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameSpot.ForeColor = System.Drawing.Color.White;
            this.usernameSpot.Location = new System.Drawing.Point(542, 130);
            this.usernameSpot.Name = "usernameSpot";
            this.usernameSpot.Size = new System.Drawing.Size(230, 17);
            this.usernameSpot.TabIndex = 20;
            this.usernameSpot.Text = "NamePlaceholder";
            this.usernameSpot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.usernameSpot);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.coolButton1);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.Title);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private CoolButton logInButton;
        private CoolButton registerButton;
        private CoolButton coolButton1;
        private CoolButton Start;
        private PictureBox logOut;
        private PictureBox ProfilePicture;
        private Label usernameSpot;
    }
}