using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Quiz_Type : Form
    {
        public static player activePlayer;
        public static string mode;
        public Quiz_Type(player activepassthrough)
        {
            InitializeComponent();
            activePlayer = activepassthrough;
            topScores.Text= $"Your top WildCard score: {activePlayer.topWildScore}\r\nYour top Base Quiz score: {activePlayer.topBaseScore}\r\n";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home(activePlayer).Show();
        }

        private void eWildcard_Click(object sender, EventArgs e)
        {
            this.Close();
            mode = "wildcard";
            new Categories(activePlayer, "easy").Show();
        }

        private void mWildcard_Click(object sender, EventArgs e)
        {
            this.Close();
            mode = "wildcard";
            new Categories(activePlayer, "medium").Show();
        }

        private void hWildcard_Click(object sender, EventArgs e)
        {
            this.Close();
            mode = "wildcard";
            new Categories(activePlayer, "hard").Show();
        }
    }
}
