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

        public RegisterPFP()
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
        char tempPFP = 'n';
        string customPFPname="none";
        private void Hippo_Click(object sender, EventArgs e)
        {
            tempPFP = 'h';
            Hippo.BackColor = Color.White;
            Tiger.BackColor = Color.Transparent;
            Elephant.BackColor = Color.Transparent;
            Dog.BackColor = Color.Transparent;
            Pig.BackColor = Color.Transparent;
            Pig.BackColor = Color.Transparent; Custom.BackColor = Color.Transparent;

        }

        private void Tiger_Click(object sender, EventArgs e)
        {
            tempPFP = 't';
            Hippo.BackColor = Color.Transparent;
            Tiger.BackColor = Color.White;
            Elephant.BackColor = Color.Transparent;
            Dog.BackColor = Color.Transparent;
            Pig.BackColor = Color.Transparent;
            Custom.BackColor = Color.Transparent;
        }

        private void Dog_Click(object sender, EventArgs e)
        {
            tempPFP = 'd';
            Hippo.BackColor = Color.Transparent;
            Tiger.BackColor = Color.Transparent;
            Elephant.BackColor = Color.Transparent;
            Dog.BackColor = Color.White;
            Pig.BackColor = Color.Transparent;
            Custom.BackColor = Color.Transparent;
        }

        private void Elephant_Click(object sender, EventArgs e)
        {
            tempPFP = 'e';
            Hippo.BackColor = Color.Transparent;
            Tiger.BackColor = Color.Transparent;
            Elephant.BackColor = Color.White;
            Dog.BackColor = Color.Transparent;
            Pig.BackColor = Color.Transparent;
            Custom.BackColor = Color.Transparent;
        }

        private void Pig_Click(object sender, EventArgs e)
        {
            tempPFP = 'p';
            Hippo.BackColor = Color.Transparent;
            Tiger.BackColor = Color.Transparent;
            Elephant.BackColor = Color.Transparent;
            Dog.BackColor = Color.Transparent;
            Pig.BackColor = Color.White;
            Custom.BackColor = Color.Transparent;
        }

        public void Custom_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tempPFP = 'c';
                Hippo.BackColor = Color.Transparent;
                Tiger.BackColor = Color.Transparent;
                Elephant.BackColor = Color.Transparent;
                Dog.BackColor = Color.Transparent;
                Pig.BackColor = Color.Transparent;
                Custom.BackColor = Color.White;
                string customPFPname = openFileDialog1.FileName;
                Bitmap customPFP = new Bitmap(customPFPname);
                Custom.Image = customPFP;
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string filePath = "userDatabase.csv";
            string itemline = File.ReadLines(filePath).ToArray().Last();
            string[] items = itemline.Split(",");
            MessageBox.Show(string.Join(",", items) + Environment.NewLine);
            items[4]=tempPFP.ToString();
            if(customPFPname != null)
            {
                items[5] = customPFPname;
            }
            var lines = System.IO.File.ReadAllLines("userDatabase.csv");
            File.WriteAllLines("userDatabase.csv", lines.Take(lines.Length - 1).ToArray());
            File.AppendAllText(filePath, string.Join(",", items) +Environment.NewLine);
            MessageBox.Show("done");
            Hide();
            new Home().Show();
        }
    }
}
