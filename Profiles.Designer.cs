namespace Coursework
{
    partial class Profiles
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
            byAlphabet = new CoolButton();
            byAge = new CoolButton();
            profileGrid = new DataGridView();
            byRuns = new CoolButton();
            ((System.ComponentModel.ISupportInitialize)profileGrid).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 44F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(279, 14);
            Title.Name = "Title";
            Title.Size = new Size(226, 71);
            Title.TabIndex = 39;
            Title.Text = "Profiles";
            // 
            // byAlphabet
            // 
            byAlphabet.BackColor = Color.FromArgb(255, 182, 166);
            byAlphabet.Cursor = Cursors.Hand;
            byAlphabet.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            byAlphabet.FlatAppearance.BorderSize = 5;
            byAlphabet.FlatStyle = FlatStyle.Flat;
            byAlphabet.Font = new Font("Itim", 16F, FontStyle.Regular, GraphicsUnit.Point);
            byAlphabet.ForeColor = Color.FromArgb(179, 63, 38);
            byAlphabet.Location = new Point(12, 93);
            byAlphabet.Margin = new Padding(3, 2, 3, 2);
            byAlphabet.Name = "byAlphabet";
            byAlphabet.Size = new Size(220, 46);
            byAlphabet.TabIndex = 40;
            byAlphabet.Text = "Sort Alphabetically";
            byAlphabet.UseVisualStyleBackColor = false;
            byAlphabet.Click += byAlphabet_Click;
            // 
            // byAge
            // 
            byAge.BackColor = Color.White;
            byAge.Cursor = Cursors.Hand;
            byAge.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            byAge.FlatAppearance.BorderSize = 5;
            byAge.FlatStyle = FlatStyle.Flat;
            byAge.Font = new Font("Itim", 16F, FontStyle.Regular, GraphicsUnit.Point);
            byAge.ForeColor = Color.FromArgb(179, 63, 38);
            byAge.Location = new Point(285, 93);
            byAge.Margin = new Padding(3, 2, 3, 2);
            byAge.Name = "byAge";
            byAge.Size = new Size(220, 46);
            byAge.TabIndex = 42;
            byAge.Text = "Sort by Age";
            byAge.UseVisualStyleBackColor = false;
            byAge.Click += byAge_Click;
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
            profileGrid.TabIndex = 43;
            // 
            // byRuns
            // 
            byRuns.BackColor = Color.FromArgb(255, 182, 166);
            byRuns.Cursor = Cursors.Hand;
            byRuns.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            byRuns.FlatAppearance.BorderSize = 5;
            byRuns.FlatStyle = FlatStyle.Flat;
            byRuns.Font = new Font("Itim", 16F, FontStyle.Regular, GraphicsUnit.Point);
            byRuns.ForeColor = Color.FromArgb(179, 63, 38);
            byRuns.Location = new Point(552, 93);
            byRuns.Margin = new Padding(3, 2, 3, 2);
            byRuns.Name = "byRuns";
            byRuns.Size = new Size(220, 46);
            byRuns.TabIndex = 44;
            byRuns.Text = "Sort by Runs";
            byRuns.UseVisualStyleBackColor = false;
            byRuns.Click += byRuns_Click;
            // 
            // Profiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(byRuns);
            Controls.Add(profileGrid);
            Controls.Add(byAge);
            Controls.Add(byAlphabet);
            Controls.Add(Title);
            Name = "Profiles";
            Text = "Profiles";
            ((System.ComponentModel.ISupportInitialize)profileGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private CoolButton byAlphabet;
        private CoolButton byAge;
        private DataGridView profileGrid;
        private CoolButton byRuns;
    }
}