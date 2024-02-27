using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            try
            {
                foreach (string itemline in File.ReadLines("userDatabase.csv"))
                {
                    if (!done)
                    {
                        if (itemline.Split(',')[0] == UsernameF.Text)
                        {
                            if (itemline.Split(',')[1] == PasswordF.Text)
                            {
                                done = true;
                                player activeplayer = new player(UsernameF.Text, PasswordF.Text);
                                activeplayer.defaultPFP = Convert.ToChar((itemline.Split(',')[2]));
                                activeplayer.pathToCustomPFP = itemline.Split(',')[3];
                                activeplayer.runCount = Convert.ToInt32(itemline.Split(',')[4]);
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
            catch (FileNotFoundException)
            {

                DialogResult result = MessageBox.Show("Database not present, register a user?", "Database Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    new Register().Show();
                }
                if (result == DialogResult.No)
                {
                }
            }
            catch (Exception)
            {

                DialogResult result = MessageBox.Show("Something went wrong with the database, would you like to try fix it?", "Database error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Most commonly, database error occur because it is open in another program{Environment.NewLine}Be sure to check if this is the case before taking further measure", "File may be open elsewhere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult result2 = MessageBox.Show("Wipe and recreate database?","Wipe Database", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes)
                    {
                        try
                        {
                            File.WriteAllText("userDatabase.csv", "");
                            this.Close();
                            new Register().Show();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Databaes cannot be changed, likely opened elsewhere", "Database cannot be changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (result2 == DialogResult.No)
                    {
                        MessageBox.Show("If not wiped, database may need manual tweaking; open database?", "Open database?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start("explorer", "\"" + "userDatabase.csv" + "\"" );
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Database cannot be opened, likely opened elsewhere", "Database cannot be opened", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

        }
    }
}
