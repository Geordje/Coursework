using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Prompt().Show();
        }

        private void Hide_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordF.UseSystemPasswordChar = false;
            Hide.Image = Coursework.Properties.Resources.icons8_eye_240;
        }

        private void Hide_MouseCaptureChanged(object sender, EventArgs e)
        {
            PasswordF.UseSystemPasswordChar = true;
            Hide.Image = Coursework.Properties.Resources.Crossed_Eye;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            bool done = false;
            int i = 0;

            foreach (string itemline in File.ReadLines("userDatabase.csv"))
            {
                if (!done)
                {
                    if (itemline.Split(',')[0] == UsernameF.Text.ToLower())
                    { 
                        if (itemline.Split(',')[1] == PasswordF.Text)
                        {
                            done = true;
                            player activeplayer = new player(UsernameF.Text, PasswordF.Text);
                            activeplayer.topWildScore = double.Parse(itemline.Split(',')[2]);
                            activeplayer.topBaseScore = double.Parse(itemline.Split(',')[3]);
                            activeplayer.defaultPFP = Convert.ToChar((itemline.Split(',')[4]));
                            activeplayer.pathToCustomPFP = itemline.Split(',')[5];
                            Hide();
                            new Home(activeplayer).Show();
                            this.Close();
                        }
                    }
                }

            }
            if (!done)
            {
                DialogResult result = MessageBox.Show("User details not found!", "Username or password incorrect", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    PasswordF.Text = "";
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                    new Prompt().Show();
                }
            }

        }
    }
}
