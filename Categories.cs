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
    public partial class Categories : Form
    {
        player activePlayer;
        string Difficulty;
        public Categories(player activePassthrough, string difficultyPassthrough)
        {
            InitializeComponent();
            activePlayer = activePassthrough;
            Difficulty = difficultyPassthrough;
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
            new Ready(activePlayer, Difficulty).Show();
        }

        private void Music_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 12).Show();
        }

        private void Sports_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 21).Show();
        }

        private void Television_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 14).Show();
        }

        private void History_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 23).Show();
        }

        private void Gaming_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 15).Show();
        }

        private void Computers_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 18).Show();
        }

        private void Knowledge_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 9).Show();
        }

        private void Films_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 11).Show();
        }
    }
}
