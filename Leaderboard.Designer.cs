namespace Coursework
{
    partial class Leaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard));
            this.Back = new System.Windows.Forms.PictureBox();
            this.baseQuiz = new Coursework.CoolButton();
            this.profileGrid = new System.Windows.Forms.DataGridView();
            this.Wildcard = new Coursework.CoolButton();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(12, 11);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(84, 79);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 51;
            this.Back.TabStop = false;
            // 
            // baseQuiz
            // 
            this.baseQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.baseQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baseQuiz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.baseQuiz.FlatAppearance.BorderSize = 5;
            this.baseQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseQuiz.Font = new System.Drawing.Font("Itim", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baseQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.baseQuiz.Location = new System.Drawing.Point(416, 93);
            this.baseQuiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baseQuiz.Name = "baseQuiz";
            this.baseQuiz.Size = new System.Drawing.Size(220, 46);
            this.baseQuiz.TabIndex = 50;
            this.baseQuiz.Text = "Base Quiz";
            this.baseQuiz.UseVisualStyleBackColor = false;
            // 
            // profileGrid
            // 
            this.profileGrid.AllowUserToOrderColumns = true;
            this.profileGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profileGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.profileGrid.BackgroundColor = System.Drawing.Color.White;
            this.profileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.profileGrid.Location = new System.Drawing.Point(12, 164);
            this.profileGrid.Name = "profileGrid";
            this.profileGrid.RowTemplate.Height = 25;
            this.profileGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.profileGrid.ShowEditingIcon = false;
            this.profileGrid.Size = new System.Drawing.Size(760, 385);
            this.profileGrid.TabIndex = 49;
            // 
            // Wildcard
            // 
            this.Wildcard.BackColor = System.Drawing.Color.White;
            this.Wildcard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wildcard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.Wildcard.FlatAppearance.BorderSize = 5;
            this.Wildcard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wildcard.Font = new System.Drawing.Font("Itim", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wildcard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.Wildcard.Location = new System.Drawing.Point(149, 93);
            this.Wildcard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wildcard.Name = "Wildcard";
            this.Wildcard.Size = new System.Drawing.Size(220, 46);
            this.Wildcard.TabIndex = 48;
            this.Wildcard.Text = "Wildcard!";
            this.Wildcard.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Itim", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(220, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(345, 71);
            this.Title.TabIndex = 46;
            this.Title.Text = "Leaderboard";
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.baseQuiz);
            this.Controls.Add(this.profileGrid);
            this.Controls.Add(this.Wildcard);
            this.Controls.Add(this.Title);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Back;
        private CoolButton baseQuiz;
        private DataGridView profileGrid;
        private CoolButton Wildcard;
        private Label Title;
    }
}