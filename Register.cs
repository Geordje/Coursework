using System.IO;

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
            //Generic error MessageBox parts
            string title = "Error in Register";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

            //If passwords don't match
            if (PasswordF.Text != CPasswordF.Text)
            {
                DialogResult result = MessageBox.Show("Passwords are not matching!", title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                    new Prompt().Show();
                }
            }
            //If password is too short
            else if (PasswordF.Text.Length < 8)
            {
                DialogResult result = MessageBox.Show("Password is not over 8 characters!", title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                    new Prompt().Show();
                }
            }
            //If password doesn't contain digit
            else if (!PasswordF.Text.Any(char.IsDigit))
            {
                DialogResult result = MessageBox.Show("Password does not contain a number!", title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                    new Prompt().Show();
                }
            }
            //If password is the same as the username
            else if (PasswordF.Text == UsernameF.Text)
            {
                DialogResult result = MessageBox.Show("Password may not be the same as the username!", title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    PasswordF.Text = "";
                    CPasswordF.Text = "";
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                    new Prompt().Show();
                }
            }
            //If Username is too short
            else if (UsernameF.Text.Length < 4)
            {
                DialogResult result = MessageBox.Show("Username must be more than 3 characters long!", title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                    new Prompt().Show();
                }
            }
            //If password contains comma
            else if (PasswordF.Text.Contains(","))
            {
                DialogResult result = MessageBox.Show("Password cannot contian a comma!", title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                    new Prompt().Show();
                }
            }
            else
            {

                string filePath = "userDatabase.csv";
                player activePlayer = new player(UsernameF.Text, PasswordF.Text);

                try
                {
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show($"User database missing, will be recreated with {activePlayer.username} being the first user.", "No other users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        File.WriteAllText(filePath, (activePlayer.username + "," + activePlayer.password + "," + activePlayer.topWildScore + "," + activePlayer.topBaseScore + "," + activePlayer.defaultPFP + "," + activePlayer.pathToCustomPFP + Environment.NewLine));
                    }
                    else
                    {
                        File.AppendAllText(filePath, (activePlayer.username + "," + activePlayer.password + "," + activePlayer.topWildScore + "," + activePlayer.topBaseScore + "," + activePlayer.defaultPFP + "," + activePlayer.pathToCustomPFP + Environment.NewLine));
                    }
                    Hide();
                    new RegisterPFP().Show();
                }
                catch
                {
                    MessageBox.Show("error");
                }






        }
        }
    }
}