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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profiles));
            Title = new Label();
            byAlphabet = new CoolButton();
            byAge = new CoolButton();
            profileGrid = new DataGridView();
            byRuns = new CoolButton();
            Back = new PictureBox();
            editEnable = new PictureBox();
            Submit = new CoolButton();
            ((System.ComponentModel.ISupportInitialize)profileGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editEnable).BeginInit();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Itim", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(179, 63, 38);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            profileGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            profileGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Itim", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            profileGrid.DefaultCellStyle = dataGridViewCellStyle2;
            profileGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            profileGrid.GridColor = Color.FromArgb(255, 182, 166);
            profileGrid.Location = new Point(12, 164);
            profileGrid.Name = "profileGrid";
            profileGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Itim", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            profileGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            profileGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            profileGrid.RowTemplate.Height = 25;
            profileGrid.RowTemplate.ReadOnly = true;
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
            // Back
            // 
            Back.Cursor = Cursors.Hand;
            Back.Image = (Image)resources.GetObject("Back.Image");
            Back.Location = new Point(12, 11);
            Back.Name = "Back";
            Back.Size = new Size(84, 79);
            Back.SizeMode = PictureBoxSizeMode.Zoom;
            Back.TabIndex = 45;
            Back.TabStop = false;
            Back.Click += Back_Click;
            // 
            // editEnable
            // 
            editEnable.Cursor = Cursors.Hand;
            editEnable.Image = Properties.Resources.Edit;
            editEnable.Location = new Point(687, 8);
            editEnable.Name = "editEnable";
            editEnable.Size = new Size(85, 77);
            editEnable.SizeMode = PictureBoxSizeMode.Zoom;
            editEnable.TabIndex = 46;
            editEnable.TabStop = false;
            editEnable.Click += editEnable_Click;
            // 
            // Submit
            // 
            Submit.BackColor = Color.White;
            Submit.Cursor = Cursors.Hand;
            Submit.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            Submit.FlatAppearance.BorderSize = 5;
            Submit.FlatStyle = FlatStyle.Flat;
            Submit.Font = new Font("Itim", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Submit.ForeColor = Color.FromArgb(179, 63, 38);
            Submit.Location = new Point(632, 491);
            Submit.Margin = new Padding(3, 2, 3, 2);
            Submit.Name = "Submit";
            Submit.Size = new Size(128, 46);
            Submit.TabIndex = 47;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Visible = false;
            Submit.Click += Submit_Click;
            // 
            // Profiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(Submit);
            Controls.Add(editEnable);
            Controls.Add(Back);
            Controls.Add(byRuns);
            Controls.Add(profileGrid);
            Controls.Add(byAge);
            Controls.Add(byAlphabet);
            Controls.Add(Title);
            Name = "Profiles";
            Text = "Profiles";
            ((System.ComponentModel.ISupportInitialize)profileGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)editEnable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private CoolButton byAlphabet;
        private CoolButton byAge;
        private CoolButton byRuns;
        private PictureBox Back;
        public DataGridView profileGrid;
        public CoolButton Submit;
        public PictureBox editEnable;
    }
}