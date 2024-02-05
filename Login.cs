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
    }
}
