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
        public static player activePlayer;
        public static Profiles profilePage;

        public Home(player activePassthrough)
        {
            InitializeComponent();
            activePlayer = activePassthrough;
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
                    activePlayer.ProfilePicture = Properties.Resources.Pig;
                    break;
                case 'c':
                    ProfilePicture.BackColor = Color.White;
                    var files = Directory.EnumerateFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProfilePictures"), $"{activePlayer.username.ToLower()}*", SearchOption.TopDirectoryOnly);
                    using (Image temp = Image.FromFile(files.First()))
                    {
                        activePlayer.ProfilePicture = new Bitmap(temp);
                    }
                    break;
            }
            ProfilePicture.Image = activePlayer.ProfilePicture;
            QuizNumberIndicator.Text = $"Quizzes completed: {activePlayer.runCount}";
        }
        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Log out {activePlayer.username}?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                new Prompt().Show();
            }
            else { }


        }

        private void Start_Click(object sender, EventArgs e)
        {
            Hide();
            new Quiz_Type(activePlayer).Show();
        }

        private void profilesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            profilePage = new Profiles(activePlayer);
            profilePage.Show();
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Upload new profile picture?", "Change Profile Picture?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    activePlayer.ProfilePicture = null;
                    ProfilePicture.Image = null;

                    activePlayer.defaultPFP = 'c';
                    var lines = File.ReadAllLines("userDatabase.csv");
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Contains(activePlayer.username))
                        {
                            lines[i] = lines[i].Split(',')[0] + "," + lines[i].Split(',')[1] + "," + activePlayer.defaultPFP + "," + lines[i].Split(',')[3];
                        }
                    }
                    File.WriteAllLines("userDatabase.csv", lines);
                    string pathToImage = openFileDialog1.FileName;
                    string destinationFilePath = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProfilePictures"), activePlayer.username.ToLower() + Path.GetExtension(openFileDialog1.FileName));
                    File.Copy(pathToImage, destinationFilePath, true);
                    activePlayer.ProfilePicture = Image.FromFile(destinationFilePath);
                    ProfilePicture.Image = activePlayer.ProfilePicture;
                }
            }
            
        }
    }
}
