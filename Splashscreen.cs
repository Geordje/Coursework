namespace Coursework
{
    public partial class Splashscreen : Form
    {
        int ticks = 0;
        public Splashscreen()
        {
            InitializeComponent();
            LoadClock.Start();
        }

        private void LoadClock_Tick(object sender, EventArgs e)
        {
            ticks++;
            progressBar.Increment(1);
            if (progressBar.Value == 100)
            {
                LoadClock.Stop();
                this.Hide();
                new Prompt().Show();
                progressBar.BackColor = Color.Red; 
            }
        }
    }
}