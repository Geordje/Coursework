namespace Coursework
{
    partial class Prompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prompt));
            Title = new Label();
            Subheading = new Label();
            registerButton = new CoolButton();
            logInButton = new CoolButton();
            close = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 50F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(216, 68);
            Title.Name = "Title";
            Title.Size = new Size(352, 81);
            Title.TabIndex = 2;
            Title.Text = "Trivia Deck";
            // 
            // Subheading
            // 
            Subheading.AutoSize = true;
            Subheading.BackColor = Color.Transparent;
            Subheading.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Subheading.ForeColor = Color.White;
            Subheading.Location = new Point(225, 140);
            Subheading.Name = "Subheading";
            Subheading.Size = new Size(335, 40);
            Subheading.TabIndex = 3;
            Subheading.Text = "Welcome To The Quiz!";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.White;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            registerButton.FlatAppearance.BorderSize = 5;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.ForeColor = Color.FromArgb(179, 63, 38);
            registerButton.Location = new Point(135, 348);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(195, 67);
            registerButton.TabIndex = 4;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.White;
            logInButton.Cursor = Cursors.Hand;
            logInButton.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            logInButton.FlatAppearance.BorderSize = 5;
            logInButton.FlatStyle = FlatStyle.Flat;
            logInButton.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.ForeColor = Color.FromArgb(179, 63, 38);
            logInButton.Location = new Point(454, 348);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(195, 67);
            logInButton.TabIndex = 5;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click;
            // 
            // close
            // 
            close.Cursor = Cursors.Hand;
            close.Image = (Image)resources.GetObject("close.Image");
            close.Location = new Point(12, 47);
            close.Name = "close";
            close.Size = new Size(84, 79);
            close.SizeMode = PictureBoxSizeMode.Zoom;
            close.TabIndex = 19;
            close.TabStop = false;
            close.Click += close_Click;
            // 
            // Prompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(close);
            Controls.Add(logInButton);
            Controls.Add(registerButton);
            Controls.Add(Subheading);
            Controls.Add(Title);
            Name = "Prompt";
            Text = "Prompt";
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Subheading;
        private CoolButton registerButton;
        private CoolButton logInButton;
        private PictureBox close;
    }
}