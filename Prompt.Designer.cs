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
            Title = new Label();
            Subheading = new Label();
            registerButton = new CoolButton();
            logInButton = new CoolButton();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 40F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(215, 77);
            Title.Name = "Title";
            Title.Size = new Size(352, 81);
            Title.TabIndex = 2;
            Title.Text = "Trivia Deck";
            // 
            // Subheading
            // 
            Subheading.AutoSize = true;
            Subheading.BackColor = Color.Transparent;
            Subheading.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheading.ForeColor = Color.White;
            Subheading.Location = new Point(223, 164);
            Subheading.Name = "Subheading";
            Subheading.Size = new Size(335, 40);
            Subheading.TabIndex = 3;
            Subheading.Text = "Welcome To The Quiz!";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.White;
            registerButton.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            registerButton.FlatAppearance.BorderSize = 5;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.ForeColor = Color.FromArgb(179, 63, 38);
            registerButton.Location = new Point(97, 346);
            registerButton.Margin = new Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(223, 89);
            registerButton.TabIndex = 4;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.White;
            logInButton.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            logInButton.FlatAppearance.BorderSize = 5;
            logInButton.FlatStyle = FlatStyle.Flat;
            logInButton.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.ForeColor = Color.FromArgb(179, 63, 38);
            logInButton.Location = new Point(462, 346);
            logInButton.Margin = new Padding(3, 4, 3, 4);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(223, 89);
            logInButton.TabIndex = 5;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = false;
            // 
            // Prompt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(782, 553);
            Controls.Add(logInButton);
            Controls.Add(registerButton);
            Controls.Add(Subheading);
            Controls.Add(Title);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Prompt";
            Text = "Prompt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Subheading;
        private CoolButton registerButton;
        private CoolButton logInButton;
    }
}