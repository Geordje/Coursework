namespace Coursework
{
    partial class Ready
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
            this.readyText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // readyText
            // 
            this.readyText.AutoSize = true;
            this.readyText.BackColor = System.Drawing.Color.Transparent;
            this.readyText.Font = new System.Drawing.Font("Itim", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readyText.ForeColor = System.Drawing.Color.White;
            this.readyText.Location = new System.Drawing.Point(321, 453);
            this.readyText.Name = "readyText";
            this.readyText.Size = new System.Drawing.Size(142, 48);
            this.readyText.TabIndex = 3;
            this.readyText.Text = "Ready?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.pictureBox1.Image = global::Coursework.Properties.Resources.loadinggif;
            this.pictureBox1.Location = new System.Drawing.Point(118, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Ready
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.readyText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ready";
            this.Text = "Ready";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label readyText;
        private PictureBox pictureBox1;
    }
}