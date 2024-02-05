using Microsoft.VisualBasic.Devices;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Hide_Hold(object sender, MouseEventArgs e)
        { 
            PasswordF.UseSystemPasswordChar = false;
            CPasswordF.UseSystemPasswordChar = false;
            Hide.Image = Coursework.Properties.Resources.icons8_eye_240;
        }
        private void Hide_MouseCaptureChanged(object sender, EventArgs e)
        {
            PasswordF.UseSystemPasswordChar = true;
            CPasswordF.UseSystemPasswordChar = true;
            Hide.Image = Coursework.Properties.Resources.Crossed_Eye;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Prompt().Show();
        }

        private void coolButton1_Click(object sender, EventArgs e)
        {
            if(PasswordF.Text != CPasswordF.Text)
            {

            }
        }
    }
}
