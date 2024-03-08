namespace Coursework
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Title = new Label();
            pictureBox1 = new PictureBox();
            PasswordF = new TextBox();
            UsernameF = new TextBox();
            logInButton = new CoolButton();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Hide = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Hide).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 44F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(299, 42);
            Title.Name = "Title";
            Title.Size = new Size(186, 71);
            Title.TabIndex = 11;
            Title.Text = "Log In";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PasswordF
            // 
            PasswordF.BorderStyle = BorderStyle.None;
            PasswordF.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordF.ForeColor = Color.FromArgb(179, 63, 38);
            PasswordF.Location = new Point(105, 328);
            PasswordF.Margin = new Padding(3, 2, 3, 2);
            PasswordF.Name = "PasswordF";
            PasswordF.PlaceholderText = "Password";
            PasswordF.Size = new Size(571, 32);
            PasswordF.TabIndex = 2;
            PasswordF.UseSystemPasswordChar = true;
            // 
            // UsernameF
            // 
            UsernameF.BorderStyle = BorderStyle.None;
            UsernameF.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameF.ForeColor = Color.FromArgb(179, 63, 38);
            UsernameF.Location = new Point(105, 245);
            UsernameF.Margin = new Padding(3, 2, 3, 2);
            UsernameF.Name = "UsernameF";
            UsernameF.PlaceholderText = "Username";
            UsernameF.Size = new Size(571, 32);
            UsernameF.TabIndex = 1;
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.White;
            logInButton.Cursor = Cursors.Hand;
            logInButton.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            logInButton.FlatAppearance.BorderSize = 5;
            logInButton.FlatStyle = FlatStyle.Flat;
            logInButton.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.ForeColor = Color.FromArgb(179, 63, 38);
            logInButton.Location = new Point(490, 420);
            logInButton.Margin = new Padding(3, 2, 3, 2);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(202, 68);
            logInButton.TabIndex = 3;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image__1_;
            pictureBox2.Location = new Point(93, 220);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(599, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.image__1_;
            pictureBox3.Location = new Point(93, 303);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(599, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // Hide
            // 
            Hide.Cursor = Cursors.Hand;
            Hide.Image = Properties.Resources.Crossed_Eye;
            Hide.Location = new Point(698, 319);
            Hide.Name = "Hide";
            Hide.Size = new Size(50, 50);
            Hide.SizeMode = PictureBoxSizeMode.Zoom;
            Hide.TabIndex = 23;
            Hide.TabStop = false;
            Hide.MouseCaptureChanged += Hide_MouseCaptureChanged;
            Hide.MouseDown += Hide_MouseDown;
            Hide.MouseLeave += Hide_MouseCaptureChanged;
            Hide.MouseUp += Hide_MouseCaptureChanged;
            // 
            // Login
            // 
            AcceptButton = logInButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(Hide);
            Controls.Add(PasswordF);
            Controls.Add(UsernameF);
            Controls.Add(logInButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(Title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Hide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Title;
        private PictureBox pictureBox1;
        private TextBox PasswordF;
        private TextBox UsernameF;
        private CoolButton logInButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox Hide;
    }
}