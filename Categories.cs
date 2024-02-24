namespace Coursework
{
    public partial class Categories : Form
    {
        public static player activePlayer;
        public static string Difficulty;
        public Categories(player activePassthrough, string difficultyPassthrough)
        {
            activePlayer = activePassthrough;
            Difficulty = difficultyPassthrough;
            InitializeComponent();
        }

        //everything: none
        //music : 12
        //sports : 21
        //television : 14
        //history : 23
        //gaming : 15
        //computers : 18
        //general knowledge : 9
        //films : 11


        private void Everything_Click(object sender, EventArgs e)
        {
            this.Close();
            Ready readyForm = new Ready(activePlayer, Difficulty);
            readyForm.Show();
        }

        private void Music_Click(object sender, EventArgs e)
        {
            this.Close();
            Ready ready = new Ready(activePlayer,Difficulty,12);
            ready.Show();
        }

        private void Sports_Click(object sender, EventArgs e)
        {
            new Ready(activePlayer, Difficulty, 21).Show();
            this.Close();
        }

        private void Television_Click(object sender, EventArgs e)
        {
            this.Close();
            Ready readyForm = new Ready(activePlayer, Difficulty, 14);
            readyForm.Show();
        }

        private void History_Click(object sender, EventArgs e)
        {
            this.Close();
            Ready readyForm = new Ready(activePlayer, Difficulty, 23);
            readyForm.Show();
        }

        private void Gaming_Click(object sender, EventArgs e)
        {
            this.Close();
            Ready readyForm = new Ready(activePlayer, Difficulty, 15);
            readyForm.Show();
        }

        private void Computers_Click(object sender, EventArgs e)
        {
            this.Close();
            Ready readyForm = new Ready(activePlayer, Difficulty, 18);
            readyForm.Show();
        }

        private void Knowledge_Click(object sender, EventArgs e)
        {
            this.Close();
            Ready readyForm = new Ready(activePlayer, Difficulty, 9);
            readyForm.Show();

        }

        private void Films_Click(object sender, EventArgs e)
        {
            this.Close();
            Ready readyForm = new Ready(activePlayer, Difficulty, 11);
            readyForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new Quiz_Type(activePlayer).Show();
        }
    }
}
