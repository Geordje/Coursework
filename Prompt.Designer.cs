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
            this.Title = new System.Windows.Forms.Label();
            this.Subheading = new System.Windows.Forms.Label();
            this.registerButton = new Coursework.CoolButton();
            this.logInButton = new Coursework.CoolButton();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Itim", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(216, 68);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(352, 81);
            this.Title.TabIndex = 2;
            this.Title.Text = "Trivia Deck";
            // 
            // Subheading
            // 
            this.Subheading.AutoSize = true;
            this.Subheading.BackColor = System.Drawing.Color.Transparent;
            this.Subheading.Font = new System.Drawing.Font("Itim", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subheading.ForeColor = System.Drawing.Color.White;
            this.Subheading.Location = new System.Drawing.Point(225, 140);
            this.Subheading.Name = "Subheading";
            this.Subheading.Size = new System.Drawing.Size(335, 40);
            this.Subheading.TabIndex = 3;
            this.Subheading.Text = "Welcome To The Quiz!";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.White;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.registerButton.FlatAppearance.BorderSize = 5;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Itim", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.registerButton.Location = new System.Drawing.Point(135, 348);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(195, 67);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.White;
            this.logInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.logInButton.FlatAppearance.BorderSize = 5;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Font = new System.Drawing.Font("Itim", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.logInButton.Location = new System.Drawing.Point(454, 348);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(195, 67);
            this.logInButton.TabIndex = 5;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            // 
            // Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.Subheading);
            this.Controls.Add(this.Title);
            this.Name = "Prompt";
            this.Text = "Prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label Subheading;
        private CoolButton registerButton;
        private CoolButton logInButton;
    }
}