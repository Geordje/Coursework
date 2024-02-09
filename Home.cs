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
    public partial class Home : Form
    {
        public player activePlayer;
        public Home(player activePassthrough)
        {
            InitializeComponent();
            player activePlayer = activePassthrough;
            usernameSpot.Text = activePlayer.username;
            switch (activePlayer.defaultPFP)
            {
                case 'h':
                    activePlayer.ProfilePicture = Properties.Resources.Hippo;
                    break;
                case 't':
                    activePlayer.ProfilePicture = Properties.Resources.Tiger;
                    break;
                case 'd':
                    activePlayer.ProfilePicture = Properties.Resources.Dog;
                    break;
                case 'e':
                    activePlayer.ProfilePicture = Properties.Resources.Elephant;
                    break;
                case 'p':
                    activePlayer.ProfilePicture = Properties.Resources.Tiger;
                    break;
                case 'c':
                    activePlayer.ProfilePicture = new Bitmap(activePlayer.pathToCustomPFP);
                    ProfilePicture.BackColor = Color.White;
                    break;
            }
            ProfilePicture.Image = activePlayer.ProfilePicture;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            new Prompt().Show();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Hide();
            new Quiz_Type(activePlayer).Show();
        }
    }
}
