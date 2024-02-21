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
            this.Hippo = new System.Windows.Forms.PictureBox();
            this.Tiger = new System.Windows.Forms.PictureBox();
            this.Dog = new System.Windows.Forms.PictureBox();
            this.Elephant = new System.Windows.Forms.PictureBox();
            this.Pig = new System.Windows.Forms.PictureBox();
            this.Custom = new System.Windows.Forms.PictureBox();
            this.Confirm = new System.Windows.Forms.PictureBox();
            this.ChoosePFP = new System.Windows.Forms.Label();
            this.RegisterPrompt = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hippo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elephant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Custom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Confirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // Hippo
            // 
            this.Hippo.BackColor = System.Drawing.Color.Transparent;
            this.Hippo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hippo.Image = global::Coursework.Properties.Resources.Hippo;
            this.Hippo.Location = new System.Drawing.Point(53, 200);
            this.Hippo.Name = "Hippo";
            this.Hippo.Size = new System.Drawing.Size(116, 116);
            this.Hippo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hippo.TabIndex = 0;
            this.Hippo.TabStop = false;
            this.Hippo.Click += new System.EventHandler(this.Hippo_Click);
            // 
            // Tiger
            // 
            this.Tiger.BackColor = System.Drawing.Color.Transparent;
            this.Tiger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tiger.Image = global::Coursework.Properties.Resources.Tiger;
            this.Tiger.Location = new System.Drawing.Point(193, 200);
            this.Tiger.Name = "Tiger";
            this.Tiger.Size = new System.Drawing.Size(116, 116);
            this.Tiger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tiger.TabIndex = 1;
            this.Tiger.TabStop = false;
            this.Tiger.Click += new System.EventHandler(this.Tiger_Click);
            // 
            // Dog
            // 
            this.Dog.BackColor = System.Drawing.Color.Transparent;
            this.Dog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dog.Image = global::Coursework.Properties.Resources.Dog;
            this.Dog.Location = new System.Drawing.Point(333, 200);
            this.Dog.Name = "Dog";
            this.Dog.Size = new System.Drawing.Size(116, 116);
            this.Dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog.TabIndex = 2;
            this.Dog.TabStop = false;
            this.Dog.Click += new System.EventHandler(this.Dog_Click);
            // 
            // Elephant
            // 
            this.Elephant.BackColor = System.Drawing.Color.Transparent;
            this.Elephant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Elephant.Image = global::Coursework.Properties.Resources.Elephant;
            this.Elephant.Location = new System.Drawing.Point(473, 200);
            this.Elephant.Name = "Elephant";
            this.Elephant.Size = new System.Drawing.Size(116, 116);
            this.Elephant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Elephant.TabIndex = 3;
            this.Elephant.TabStop = false;
            this.Elephant.Click += new System.EventHandler(this.Elephant_Click);
            // 
            // Pig
            // 
            this.Pig.BackColor = System.Drawing.Color.Transparent;
            this.Pig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pig.Image = global::Coursework.Properties.Resources.Pig;
            this.Pig.Location = new System.Drawing.Point(613, 200);
            this.Pig.Name = "Pig";
            this.Pig.Size = new System.Drawing.Size(116, 116);
            this.Pig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pig.TabIndex = 4;
            this.Pig.TabStop = false;
            this.Pig.Click += new System.EventHandler(this.Pig_Click);
            // 
            // Custom
            // 
            this.Custom.BackColor = System.Drawing.Color.Transparent;
            this.Custom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Custom.Image = global::Coursework.Properties.Resources.Plus;
            this.Custom.Location = new System.Drawing.Point(53, 322);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(116, 116);
            this.Custom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Custom.TabIndex = 5;
            this.Custom.TabStop = false;
            this.Custom.Click += new System.EventHandler(this.Custom_Click);
            // 
            // Confirm
            // 
            this.Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm.Image = global::Coursework.Properties.Resources.Tick;
            this.Confirm.Location = new System.Drawing.Point(466, 322);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(264, 116);
            this.Confirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Confirm.TabIndex = 6;
            this.Confirm.TabStop = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // ChoosePFP
            // 
            this.ChoosePFP.AutoSize = true;
            this.ChoosePFP.BackColor = System.Drawing.Color.Transparent;
            this.ChoosePFP.Font = new System.Drawing.Font("Itim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoosePFP.ForeColor = System.Drawing.Color.White;
            this.ChoosePFP.Location = new System.Drawing.Point(61, 149);
            this.ChoosePFP.Name = "ChoosePFP";
            this.ChoosePFP.Size = new System.Drawing.Size(299, 33);
            this.ChoosePFP.TabIndex = 7;
            this.ChoosePFP.Text = "Choose a profile picture!";
            // 
            // RegisterPrompt
            // 
            this.RegisterPrompt.AutoSize = true;
            this.RegisterPrompt.BackColor = System.Drawing.Color.Transparent;
            this.RegisterPrompt.Font = new System.Drawing.Font("Itim", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterPrompt.ForeColor = System.Drawing.Color.White;
            this.RegisterPrompt.Location = new System.Drawing.Point(281, 21);
            this.RegisterPrompt.Name = "RegisterPrompt";
            this.RegisterPrompt.Size = new System.Drawing.Size(220, 65);
            this.RegisterPrompt.TabIndex = 8;
            this.RegisterPrompt.Text = "Register";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image files(*.jpeg; *.bmp; *.png; *.jpg)| *.jpeg; *.bmp; *.png; *.jpg";
            this.openFileDialog1.Title = "Choose a profile picture!";
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(12, 21);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(84, 79);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 19;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // RegisterPFP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(63)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.RegisterPrompt);
            this.Controls.Add(this.ChoosePFP);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Custom);
            this.Controls.Add(this.Pig);
            this.Controls.Add(this.Elephant);
            this.Controls.Add(this.Dog);
            this.Controls.Add(this.Tiger);
            this.Controls.Add(this.Hippo);
            this.Font = new System.Drawing.Font("Itim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "RegisterPFP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegsiterPFP";
            ((System.ComponentModel.ISupportInitialize)(this.Hippo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elephant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Custom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Confirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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