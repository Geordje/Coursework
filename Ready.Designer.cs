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
            readyText = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // readyText
            // 
            readyText.AutoSize = true;
            readyText.BackColor = Color.Transparent;
            readyText.Font = new Font("Itim", 30F, FontStyle.Regular, GraphicsUnit.Point);
            readyText.ForeColor = Color.White;
            readyText.Location = new Point(321, 453);
            readyText.Name = "readyText";
            readyText.Size = new Size(142, 48);
            readyText.TabIndex = 3;
            readyText.Text = "Ready?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(179, 63, 38);
            pictureBox1.Image = Properties.Resources.loadinggif;
            pictureBox1.Location = new Point(118, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(549, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(269, 224);
            dataGridView1.TabIndex = 4;
            // 
            // Ready
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(dataGridView1);
            Controls.Add(readyText);
            Controls.Add(pictureBox1);
            Name = "Ready";
            Text = "Ready";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label readyText;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
    }
}