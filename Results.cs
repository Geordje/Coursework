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
    public partial class Results : Form
    {
        player activePlayer;
        public Results(player activePassthrough, string difficulty)
        {
            InitializeComponent();
            activePlayer = activePassthrough;
            correctIndicator.Text = $"{activePlayer.score.ToString()}/20";
            activePlayer.score = 0;

        }

        private void returnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home(activePlayer).Show();
        }
    }
}
