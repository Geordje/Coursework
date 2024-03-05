namespace Coursework
{
    partial class RegisterPFP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPFP));
            Hippo = new PictureBox();
            Tiger = new PictureBox();
            Dog = new PictureBox();
            Elephant = new PictureBox();
            Pig = new PictureBox();
            Custom = new PictureBox();
            Confirm = new PictureBox();
            ChoosePFP = new Label();
            RegisterPrompt = new Label();
            openFileDialog1 = new OpenFileDialog();
            Back = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Hippo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tiger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Elephant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Custom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Confirm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Back).BeginInit();
            SuspendLayout();
            // 
            // Hippo
            // 
            Hippo.BackColor = Color.Transparent;
            Hippo.Cursor = Cursors.Hand;
            Hippo.Image = Properties.Resources.Hippo;
            Hippo.Location = new Point(53, 200);
            Hippo.Name = "Hippo";
            Hippo.Size = new Size(116, 116);
            Hippo.SizeMode = PictureBoxSizeMode.Zoom;
            Hippo.TabIndex = 0;
            Hippo.TabStop = false;
            Hippo.Click += Hippo_Click;
            // 
            // Tiger
            // 
            Tiger.BackColor = Color.Transparent;
            Tiger.Cursor = Cursors.Hand;
            Tiger.Image = Properties.Resources.Tiger;
            Tiger.Location = new Point(193, 200);
            Tiger.Name = "Tiger";
            Tiger.Size = new Size(116, 116);
            Tiger.SizeMode = PictureBoxSizeMode.Zoom;
            Tiger.TabIndex = 1;
            Tiger.TabStop = false;
            Tiger.Click += Tiger_Click;
            // 
            // Dog
            // 
            Dog.BackColor = Color.Transparent;
            Dog.Cursor = Cursors.Hand;
            Dog.Image = Properties.Resources.Dog;
            Dog.Location = new Point(333, 200);
            Dog.Name = "Dog";
            Dog.Size = new Size(116, 116);
            Dog.SizeMode = PictureBoxSizeMode.Zoom;
            Dog.TabIndex = 2;
            Dog.TabStop = false;
            Dog.Click += Dog_Click;
            // 
            // Elephant
            // 
            Elephant.BackColor = Color.Transparent;
            Elephant.Cursor = Cursors.Hand;
            Elephant.Image = Properties.Resources.Elephant;
            Elephant.Location = new Point(473, 200);
            Elephant.Name = "Elephant";
            Elephant.Size = new Size(116, 116);
            Elephant.SizeMode = PictureBoxSizeMode.Zoom;
            Elephant.TabIndex = 3;
            Elephant.TabStop = false;
            Elephant.Click += Elephant_Click;
            // 
            // Pig
            // 
            Pig.BackColor = Color.Transparent;
            Pig.Cursor = Cursors.Hand;
            Pig.Image = Properties.Resources.Pig;
            Pig.Location = new Point(613, 200);
            Pig.Name = "Pig";
            Pig.Size = new Size(116, 116);
            Pig.SizeMode = PictureBoxSizeMode.Zoom;
            Pig.TabIndex = 4;
            Pig.TabStop = false;
            Pig.Click += Pig_Click;
            // 
            // Custom
            // 
            Custom.BackColor = Color.Transparent;
            Custom.Cursor = Cursors.Hand;
            Custom.Image = Properties.Resources.Plus;
            Custom.Location = new Point(53, 322);
            Custom.Name = "Custom";
            Custom.Size = new Size(116, 116);
            Custom.SizeMode = PictureBoxSizeMode.Zoom;
            Custom.TabIndex = 5;
            Custom.TabStop = false;
            Custom.Click += Custom_Click;
            // 
            // Confirm
            // 
            Confirm.Cursor = Cursors.Hand;
            Confirm.Image = Properties.Resources.Tick;
            Confirm.Location = new Point(466, 322);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(264, 116);
            Confirm.SizeMode = PictureBoxSizeMode.Zoom;
            Confirm.TabIndex = 6;
            Confirm.TabStop = false;
            Confirm.Click += Confirm_Click;
            // 
            // ChoosePFP
            // 
            ChoosePFP.AutoSize = true;
            ChoosePFP.BackColor = Color.Transparent;
            ChoosePFP.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ChoosePFP.ForeColor = Color.White;
            ChoosePFP.Location = new Point(61, 149);
            ChoosePFP.Name = "ChoosePFP";
            ChoosePFP.Size = new Size(299, 33);
            ChoosePFP.TabIndex = 7;
            ChoosePFP.Text = "Choose a profile picture!";
            // 
            // RegisterPrompt
            // 
            RegisterPrompt.AutoSize = true;
            RegisterPrompt.BackColor = Color.Transparent;
            RegisterPrompt.Font = new Font("Itim", 40F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterPrompt.ForeColor = Color.White;
            RegisterPrompt.Location = new Point(281, 21);
            RegisterPrompt.Name = "RegisterPrompt";
            RegisterPrompt.Size = new Size(220, 65);
            RegisterPrompt.TabIndex = 8;
            RegisterPrompt.Text = "Register";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Image files(*.jpeg; *.bmp; *.png; *.jpg)| *.jpeg; *.bmp; *.png; *.jpg";
            openFileDialog1.Title = "Choose a profile picture!";
            // 
            // Back
            // 
            Back.Cursor = Cursors.Hand;
            Back.Image = (Image)resources.GetObject("Back.Image");
            Back.Location = new Point(12, 21);
            Back.Name = "Back";
            Back.Size = new Size(84, 79);
            Back.SizeMode = PictureBoxSizeMode.Zoom;
            Back.TabIndex = 19;
            Back.TabStop = false;
            Back.Click += Back_Click;
            // 
            // RegisterPFP
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(782, 553);
            Controls.Add(Back);
            Controls.Add(RegisterPrompt);
            Controls.Add(ChoosePFP);
            Controls.Add(Confirm);
            Controls.Add(Custom);
            Controls.Add(Pig);
            Controls.Add(Elephant);
            Controls.Add(Dog);
            Controls.Add(Tiger);
            Controls.Add(Hippo);
            Font = new Font("Itim", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterPFP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile Picture Select";
            ((System.ComponentModel.ISupportInitialize)Hippo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tiger).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dog).EndInit();
            ((System.ComponentModel.ISupportInitialize)Elephant).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pig).EndInit();
            ((System.ComponentModel.ISupportInitialize)Custom).EndInit();
            ((System.ComponentModel.ISupportInitialize)Confirm).EndInit();
            ((System.ComponentModel.ISupportInitialize)Back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Hippo;
        private PictureBox Tiger;
        private PictureBox Dog;
        private PictureBox Elephant;
        private PictureBox Pig;
        private PictureBox Custom;
        private PictureBox Confirm;
        private Label ChoosePFP;
        private Label RegisterPrompt;
        private PictureBox Back;
        private OpenFileDialog openFileDialog1;
    }
}