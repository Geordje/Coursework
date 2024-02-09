using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Coursework
{
    public partial class RegisterPFP : Form
    {
        public player activePlayer;
        public RegisterPFP(player activeplayer )
        {
           InitializeComponent();

        }
        private void Back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Cancel registering this user?", "Changed your mind?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var lines = System.IO.File.ReadAllLines("userDatabase.csv");
                System.IO.File.WriteAllLines("userDatabase.csv", lines.Take(lines.Length - 1).ToArray());
                Hide();
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
                activePlayer.pathToCustomPFP = openFileDialog1.FileName;
                Custom.Image = new Bitmap(activePlayer.pathToCustomPFP);
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string filePath = "userDatabase.csv";
            string itemline = File.ReadLines(filePath).ToArray().Last();
            string[] items = itemline.Split(",");
            items[4]=activePlayer.defaultPFP.ToString();
            if(activePlayer.pathToCustomPFP != null)
            {
                items[5] = activePlayer.pathToCustomPFP;
            }
            var lines = File.ReadAllLines("userDatabase.csv");
            File.WriteAllLines("userDatabase.csv", lines.Take(lines.Length - 1).ToArray());
            File.AppendAllText(filePath, string.Join(",", items) +Environment.NewLine);
            Hide();
            new Home(activePlayer).Show();
        }
    }
}
