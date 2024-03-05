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
            Back = new PictureBox();
            baseQuiz = new CoolButton();
            profileGrid = new DataGridView();
            Wildcard = new CoolButton();
            Title = new Label();
            Ascending = new Button();
            Descending = new Button();
            ((System.ComponentModel.ISupportInitialize)Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileGrid).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Cursor = Cursors.Hand;
            Back.Image = (Image)resources.GetObject("Back.Image");
            Back.Location = new Point(12, 11);
            Back.Name = "Back";
            Back.Size = new Size(84, 79);
            Back.SizeMode = PictureBoxSizeMode.Zoom;
            Back.TabIndex = 51;
            Back.TabStop = false;
            Back.Click += Back_Click;
            // 
            // baseQuiz
            // 
            baseQuiz.BackColor = Color.FromArgb(255, 182, 166);
            baseQuiz.Cursor = Cursors.Hand;
            baseQuiz.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            baseQuiz.FlatAppearance.BorderSize = 5;
            baseQuiz.FlatStyle = FlatStyle.Flat;
            baseQuiz.Font = new Font("Itim", 16F, FontStyle.Regular, GraphicsUnit.Point);
            baseQuiz.ForeColor = Color.FromArgb(179, 63, 38);
            baseQuiz.Location = new Point(416, 93);
            baseQuiz.Margin = new Padding(3, 2, 3, 2);
            baseQuiz.Name = "baseQuiz";
            baseQuiz.Size = new Size(220, 46);
            baseQuiz.TabIndex = 50;
            baseQuiz.Text = "Base Quiz";
            baseQuiz.UseVisualStyleBackColor = false;
            baseQuiz.Click += baseQuiz_Click;
            // 
            // profileGrid
            // 
            profileGrid.AllowUserToOrderColumns = true;
            profileGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            profileGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            profileGrid.BackgroundColor = Color.White;
            profileGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            profileGrid.GridColor = Color.FromArgb(255, 182, 166);
            profileGrid.Location = new Point(12, 164);
            profileGrid.Name = "profileGrid";
            profileGrid.RowTemplate.Height = 25;
            profileGrid.ScrollBars = ScrollBars.Vertical;
            profileGrid.ShowEditingIcon = false;
            profileGrid.Size = new Size(760, 385);
            profileGrid.TabIndex = 49;
            // 
            // Wildcard
            // 
            Wildcard.BackColor = Color.White;
            Wildcard.Cursor = Cursors.Hand;
            Wildcard.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            Wildcard.FlatAppearance.BorderSize = 5;
            Wildcard.FlatStyle = FlatStyle.Flat;
            Wildcard.Font = new Font("Itim", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Wildcard.ForeColor = Color.FromArgb(179, 63, 38);
            Wildcard.Location = new Point(149, 93);
            Wildcard.Margin = new Padding(3, 2, 3, 2);
            Wildcard.Name = "Wildcard";
            Wildcard.Size = new Size(220, 46);
            Wildcard.TabIndex = 48;
            Wildcard.Text = "Wildcard!";
            Wildcard.UseVisualStyleBackColor = false;
            Wildcard.Click += Wildcard_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 44F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(220, 14);
            Title.Name = "Title";
            Title.Size = new Size(345, 71);
            Title.TabIndex = 46;
            Title.Text = "Leaderboard";
            // 
            // Ascending
            // 
            Ascending.BackColor = Color.FromArgb(255, 182, 166);
            Ascending.BackgroundImage = Properties.Resources.RedArrowUp;
            Ascending.BackgroundImageLayout = ImageLayout.Zoom;
            Ascending.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            Ascending.FlatAppearance.BorderSize = 4;
            Ascending.FlatStyle = FlatStyle.Flat;
            Ascending.Location = new Point(674, 93);
            Ascending.Name = "Ascending";
            Ascending.Size = new Size(46, 46);
            Ascending.TabIndex = 52;
            Ascending.UseVisualStyleBackColor = false;
            Ascending.Click += Ascending_Click;
            // 
            // Descending
            // 
            Descending.BackColor = Color.White;
            Descending.BackgroundImage = Properties.Resources.RedArrowDown;
            Descending.BackgroundImageLayout = ImageLayout.Zoom;
            Descending.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            Descending.FlatAppearance.BorderSize = 4;
            Descending.FlatStyle = FlatStyle.Flat;
            Descending.Location = new Point(726, 93);
            Descending.Name = "Descending";
            Descending.Size = new Size(46, 46);
            Descending.TabIndex = 53;
            Descending.UseVisualStyleBackColor = false;
            Descending.Click += Descending_Click;
            // 
            // Leaderboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(Descending);
            Controls.Add(Ascending);
            Controls.Add(Back);
            Controls.Add(baseQuiz);
            Controls.Add(profileGrid);
            Controls.Add(Wildcard);
            Controls.Add(Title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Leaderboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leaderboard";
            ((System.ComponentModel.ISupportInitialize)Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Back;
        private CoolButton baseQuiz;
        private DataGridView profileGrid;
        private CoolButton Wildcard;
        private Label Title;
        private Button Ascending;
        private Button Descending;
    }
}