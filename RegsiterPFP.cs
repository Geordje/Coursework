using Coursework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Coursework
{
    public partial class RegisterPFP : Form
    {
        public player activePlayer;
        public RegisterPFP(player activePassthrough)
        {
            InitializeComponent();
            activePlayer = activePassthrough;
            activePlayer.defaultPFP = 'x'; 
        }
        private void Back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Cancel registering this user?", "Changed your mind?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var lines = System.IO.File.ReadAllLines("userDatabase.csv");
                System.IO.File.WriteAllLines("userDatabase.csv", lines.Take(lines.Length - 1).ToArray());
                this.Close();
                new Prompt().Show();

            }
        }

        private void Hippo_Click(object sender, EventArgs e)
        {
            activePlayer.defaultPFP = 'h';
            Hippo.BackColor = Color.White;
            Tiger.BackColor = Color.Transparent;
            Elephant.BackColor = Color.Transparent;
            Dog.BackColor = Color.Transparent;
            Pig.BackColor = Color.Transparent;
            Custom.BackColor = Color.Transparent;
            activePlayer.ProfilePicture = Properties.Resources.Hippo;
        }

        private void Tiger_Click(object sender, EventArgs e)
        {
            activePlayer.defaultPFP = 't';
            Hippo.BackColor = Color.Transparent;
            Tiger.BackColor = Color.White;
            Elephant.BackColor = Color.Transparent;
            Dog.BackColor = Color.Transparent;
            Pig.BackColor = Color.Transparent;
            Custom.BackColor = Color.Transparent;
            activePlayer.ProfilePicture = Properties.Resources.Tiger;
        }

        private void Dog_Click(object sender, EventArgs e)
        {
            activePlayer.defaultPFP = 'd';
            Hippo.BackColor = Color.Transparent;
            Tiger.BackColor = Color.Transparent;
            Elephant.BackColor = Color.Transparent;
            Dog.BackColor = Color.White;
            Pig.BackColor = Color.Transparent;
            Custom.BackColor = Color.Transparent;
            activePlayer.ProfilePicture = Properties.Resources.Dog;
        }

        private void Elephant_Click(object sender, EventArgs e)
        {
            activePlayer.defaultPFP = 'e';
            Hippo.BackColor = Color.Transparent;
            Tiger.BackColor = Color.Transparent;
            Elephant.BackColor = Color.White;
            Dog.BackColor = Color.Transparent;
            Pig.BackColor = Color.Transparent;
            Custom.BackColor = Color.Transparent;
            activePlayer.ProfilePicture = Properties.Resources.Elephant;
        }

        private void Pig_Click(object sender, EventArgs e)
        {
            activePlayer.defaultPFP = 'p';
            Hippo.BackColor = Color.Transparent;
            Tiger.BackColor = Color.Transparent;
            Elephant.BackColor = Color.Transparent;
            Dog.BackColor = Color.Transparent;
            Pig.BackColor = Color.White;
            Custom.BackColor = Color.Transparent;
            activePlayer.ProfilePicture = Properties.Resources.Pig;
        }

        public void Custom_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                activePlayer.defaultPFP = 'c';
                Hippo.BackColor = Color.Transparent;
                Tiger.BackColor = Color.Transparent;
                Elephant.BackColor = Color.Transparent;
                Dog.BackColor = Color.Transparent;
                Pig.BackColor = Color.Transparent;
                Custom.BackColor = Color.White;
                Custom.Image = activePlayer.ProfilePicture = Bitmap.FromFile($@"{openFileDialog1.FileName}");
            }
        }

        public void Confirm_Click(object sender, EventArgs e)
        {
            if (activePlayer.defaultPFP != 'x')
            {

                var lines = File.ReadAllLines("userDatabase.csv");
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(activePlayer.username))
                    {
                        lines[i].Split(",")[2] = activePlayer.defaultPFP.ToString();
                    }
                }
                File.WriteAllLines("userDatabase.csv", lines);
                if(activePlayer.defaultPFP == 'c')
                {
                    string pathToImage = openFileDialog1.FileName;
                    string destinationFilePath = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProfilePictures"), activePlayer.username.ToLower()+ Path.GetExtension(openFileDialog1.FileName));
                    File.Copy(pathToImage, destinationFilePath, true);
                }
                new Home(activePlayer).Show();
                this.Close();

            }
            else
            {
                DialogResult result = MessageBox.Show("Please select or upload a picture!", "Error continuing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
            }
        }
    }
}
                
            
    




