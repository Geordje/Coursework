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
        char Difficulty;
        public Categories(player activePassthrough, char difficultyPassthrough)
        {
            InitializeComponent();
            activePlayer = activePassthrough;
            Difficulty = difficultyPassthrough;
        }

        //everything: e
        //music : m
        //sports : s
        //television : t
        //history : h
        //gaming : g
        //computers : c
        //general knowledge : k
        //films : f

        private void Everything_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 'e').Show();
        }

        private void Music_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 'm').Show();
        }

        private void Sports_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 's').Show();
        }

        private void Television_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 't').Show();
        }

        private void History_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 'h').Show();
        }

        private void Gaming_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 'g').Show();
        }

        private void Computers_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 'c').Show();
        }

        private void Knowledge_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 'k').Show();
        }

        private void Films_Click(object sender, EventArgs e)
        {
            this.Close();
            new Ready(activePlayer, Difficulty, 'f').Show();
        }
    }
}
