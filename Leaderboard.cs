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
    public partial class Leaderboard : Form
    {
        static player activePlayer;
        public Leaderboard(player activePassthrough)
        {
            activePlayer = activePassthrough;
            InitializeComponent();
            LoadDataFromCsv("wildcard");
        }
        public void LoadDataFromCsv(string mode)
        {
            var dt = new DataTable();
            dt.Columns.Add("Profile Picture", typeof(Image));
            dt.Columns.Add("Username");
            if (mode == "base")
            {
                dt.Columns.Add("Top Base Score", typeof(int));
            }
            else
            {
                dt.Columns.Add("Top WildCard Score", typeof(int));
            }

            using (var parser = new Microsoft.VisualBasic.FileIO.TextFieldParser("userDatabase.csv"))
            {
                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields != null)
                    {
                        string username = fields[0];
                        Image? profilePicture = null;
                        switch (fields[2])
                        {
                            case "h":
                                profilePicture = Properties.Resources.Hippo;
                                break;
                            case "t":
                                profilePicture = Properties.Resources.Tiger;
                                break;
                            case "d":
                                profilePicture = Properties.Resources.Dog;
                                break;
                            case "e":
                                profilePicture = Properties.Resources.Elephant;
                                break;
                            case "p":
                                profilePicture = Properties.Resources.Pig;
                                break;
                            case "c":
                                var files = System.IO.Directory.EnumerateFiles(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProfilePictures"), $"{username.ToLower()}*", SearchOption.TopDirectoryOnly);
                                using (Image temp = Image.FromFile(files.First()))
                                {
                                    profilePicture = new Bitmap(temp);
                                }
                                break;
                        }
                        if (profilePicture != null)
                        {
                            profilePicture = ResizeImage(profilePicture, 50, 50);
                        }
                        using (var sr = new StreamReader("scores.bin"))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                string[] parts = line.Split(',');
                                if (parts[0] == username)
                                {
                                    if (mode == "base")
                                    {
                                        dt.Rows.Add(profilePicture, username, parts[2]);
                                    }
                                    else
                                    {
                                        dt.Rows.Add(profilePicture, username, parts[1]);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            profileGrid.DataSource = dt.DefaultView.ToTable();
            profileGrid.Sort(profileGrid.Columns[2], ListSortDirection.Descending);

            // Set column width and alignment
            profileGrid.Columns["Profile Picture"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            profileGrid.Columns["Profile Picture"].Width = 50;
            profileGrid.Columns["Username"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            profileGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        //Resize the image
        private Image ResizeImage(Image image, int width, int height)
        {
            var resizedImage = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;

        }

        private void Ascending_Click(object sender, EventArgs e)
        {
            Ascending.BackColor = Color.White;
            Descending.BackColor = Color.FromArgb(255, 182, 166);
            var dt = (DataTable)profileGrid.DataSource;
            dt.DefaultView.Sort = $"{profileGrid.Columns[2].Name} ASC";
            profileGrid.DataSource = dt.DefaultView.ToTable();
        }
        private void Descending_Click(object sender, EventArgs e)
        {
            Descending.BackColor = Color.White;
            Ascending.BackColor = Color.FromArgb(255, 182, 166);
            var dt = (DataTable)profileGrid.DataSource;
            dt.DefaultView.Sort = ($"{profileGrid.Columns[2].Name} DESC");
            profileGrid.DataSource = dt.DefaultView.ToTable();
        }




        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home(activePlayer).Show();
        }

        private void Wildcard_Click(object sender, EventArgs e)
        {
            Wildcard.BackColor = Color.White;
            baseQuiz.BackColor = Color.FromArgb(255, 182, 166);
            LoadDataFromCsv("wildcard");
            Descending.BackColor = Color.White;
            Ascending.BackColor = Color.FromArgb(255, 182, 166);

        }

        private void baseQuiz_Click(object sender, EventArgs e)
        {
            baseQuiz.BackColor = Color.White;
            Wildcard.BackColor = Color.FromArgb(255, 182, 166);
            LoadDataFromCsv("base");
            Descending.BackColor = Color.White;
            Ascending.BackColor = Color.FromArgb(255, 182, 166);
        }
    }
}

