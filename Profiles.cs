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
    public partial class Profiles : Form
    {
        static player activePlayer;
        public Profiles(player activePassthrough)
        {
            activePlayer = activePassthrough;
            InitializeComponent();
            LoadDataFromCsv();
        }
        public void LoadDataFromCsv()
        {
            var dt = new DataTable();
            dt.Columns.Add("Profile Picture", typeof(Image));
            dt.Columns.Add("Username");
            dt.Columns.Add("Quizzes Done", typeof(int));

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
                        string runs = fields[3];
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
                        // Resize the image if it is not null
                        if (profilePicture != null)
                        {
                            profilePicture = ResizeImage(profilePicture, 50, 50);
                            dt.Rows.Add(profilePicture, username, runs);
                        }
                        // Add the row to the DataTable
                    }
                }
            }
            profileGrid.DataSource = dt;
            // Set column width and alignment
            profileGrid.Columns["Profile Picture"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            profileGrid.Columns["Profile Picture"].Width = 50;
            profileGrid.Columns["Username"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            profileGrid.Columns["Quizzes Done"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Method to resize the image
        private Image ResizeImage(Image image, int width, int height)
        {
            var resizedImage = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void byRuns_Click(object sender, EventArgs e)
        {
            byRuns.BackColor = Color.White;
            byAlphabet.BackColor = Color.FromArgb(255, 182, 166);
            byAge.BackColor = Color.FromArgb(255, 182, 166);
            var dt = (DataTable)profileGrid.DataSource;
            dt.DefaultView.Sort = ("Quizzes Done DESC");
            profileGrid.DataSource = dt.DefaultView.ToTable();
        }

        private void byAlphabet_Click(object sender, EventArgs e)
        {
            byAlphabet.BackColor = Color.White;
            byRuns.BackColor = Color.FromArgb(255, 182, 166);
            byAge.BackColor = Color.FromArgb(255, 182, 166);
            var dt = (DataTable)profileGrid.DataSource;
            dt.DefaultView.Sort = "Username ASC";
            profileGrid.DataSource = dt.DefaultView.ToTable();
        }

        private void byAge_Click(object sender, EventArgs e)
        {
            byAge.BackColor = Color.White;
            byAlphabet.BackColor = Color.FromArgb(255, 182, 166);
            byRuns.BackColor = Color.FromArgb(255, 182, 166);
            LoadDataFromCsv();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home(activePlayer).Show();
        }

        private void editEnable_Click(object sender, EventArgs e)
        {
            new AdminPopup().Show();
        }

        private bool CheckForComma(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(","))
                    {
                        MessageBox.Show($"Please remove the comma from the cell: {cell.Value.ToString()}", "Comma Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }
            }
            return false;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (CheckForComma(profileGrid))
            {
                return;
            }

            SaveDataToCsv();
            Submit.Hide();
            profileGrid.AllowUserToDeleteRows = false;
            profileGrid.ShowEditingIcon = false;
            profileGrid.ReadOnly = true;
            profileGrid.Columns[1].ReadOnly = false;
            editEnable.Show();
            byAlphabet.Show();
            byRuns.Show();
            byAge.Show();
            byAge.BackColor = Color.FromArgb(255, 182, 166);
            byAlphabet.BackColor = Color.White;
            byRuns.BackColor = Color.White;
            profileGrid.Columns.Remove("passwords");
        }

        public void SaveDataToCsv()
        {
            StringBuilder csvContent = new StringBuilder();

            // commits the changes to the CSV file
            foreach (DataGridViewRow row in profileGrid.Rows)
            {
                if (row.Cells["Username"].Value == null)
                {
                    continue;
                }
                string username = row.Cells["Username"].Value.ToString();
                string password = row.Cells["passwords"].Value.ToString();
                string runs = row.Cells["Quizzes Done"].Value.ToString();

                string pfpChar = row.Cells[2].Value.ToString();

                // Find matching username row and keep the pfpChar value
                foreach (string line in File.ReadLines("userDatabase.csv"))
                {
                    string[] fields = line.Split(',');
                    if (fields[0] == username)
                    {
                        pfpChar = fields[2];
                        break;
                    }
                }

                csvContent.AppendLine($"{username},{password},{pfpChar},{runs}");
                //leaves pfp char unchanged
            }

            // Writes the content to the file
            File.WriteAllText("userDatabase.csv", csvContent.ToString());
        }
        public void EditEnable()
        {
            LoadDataFromCsv();
            Submit.Show();
            profileGrid.AllowUserToDeleteRows = true;
            profileGrid.ShowEditingIcon = true;
            profileGrid.ReadOnly = false;
            profileGrid.Columns[1].ReadOnly = true;
            editEnable.Visible = false;
            byAge.BackColor = Color.White;
            byAlphabet.BackColor = Color.FromArgb(255, 182, 166);
            byRuns.BackColor = Color.FromArgb(255, 182, 166);
            byAlphabet.Visible = false;
            byRuns.Visible = false;
            byAge.Visible = false;
            profileGrid.Columns.Add("passwords", "Password");

            // Add passwords from userDatabase.csv
            foreach (DataGridViewRow row in profileGrid.Rows)
            {
                if(row.Cells["Username"].Value?.ToString() != null)
                {
                    string username = row.Cells["Username"].Value.ToString();
                    string password = GetPasswordFromCsv(username);
                    row.Cells["passwords"].Value = password;
                }
            }
        }

        public string GetPasswordFromCsv(string username)
        {
            string[] lines = File.ReadAllLines("userDatabase.csv");
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (fields[0] == username)
                {
                    return fields[1];
                }
                
            }
            return null;

        }
    }
}
