namespace Coursework
{
    partial class AdminPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPopup));
            this.Hide = new System.Windows.Forms.PictureBox();
            this.PasswordF = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Prompter = new System.Windows.Forms.Label();
            this.Enter = new Coursework.CoolButton();
            this.Cancel = new Coursework.CoolButton();
            ((System.ComponentModel.ISupportInitialize)(this.Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Hide
            // 
            this.Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide.Image = global::Coursework.Properties.Resources.Crossed_Eye;
            this.Hide.Location = new System.Drawing.Point(626, 58);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(10, 10);
            this.Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hide.TabIndex = 26;
            this.Hide.TabStop = false;
            // 
            // PasswordF
            // 
            this.PasswordF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordF.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.PasswordF.Location = new System.Drawing.Point(41, 54);
            this.PasswordF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordF.Name = "PasswordF";
            this.PasswordF.PlaceholderText = "Password";
            this.PasswordF.Size = new System.Drawing.Size(340, 20);
            this.PasswordF.TabIndex = 1;
            this.PasswordF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordF.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Coursework.Properties.Resources.image__1_;
            this.pictureBox3.Location = new System.Drawing.Point(35, 42);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(352, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // Prompter
            // 
            this.Prompter.AutoSize = true;
            this.Prompter.BackColor = System.Drawing.Color.Transparent;
            this.Prompter.Font = new System.Drawing.Font("Itim", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prompter.ForeColor = System.Drawing.Color.White;
            this.Prompter.Location = new System.Drawing.Point(65, 9);
            this.Prompter.Name = "Prompter";
            this.Prompter.Size = new System.Drawing.Size(293, 27);
            this.Prompter.TabIndex = 27;
            this.Prompter.Text = "Enter administrator password";
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.White;
            this.Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.Enter.FlatAppearance.BorderSize = 2;
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter.Font = new System.Drawing.Font("Itim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.Enter.Location = new System.Drawing.Point(35, 93);
            this.Enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(100, 31);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.Cancel.FlatAppearance.BorderSize = 2;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Itim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.Cancel.Location = new System.Drawing.Point(287, 93);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 31);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AdminPopup
            // 
            this.AcceptButton = this.Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(423, 135);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Prompter);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.PasswordF);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Entry";
            ((System.ComponentModel.ISupportInitialize)(this.Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Hide;
        private TextBox PasswordF;
        private PictureBox pictureBox3;
        private Label Prompter;
        private CoolButton Enter;
        private CoolButton Cancel;
    }
}