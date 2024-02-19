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
    public partial class Quiz_Type : Form
    {
        public player activePlayer;
        public Quiz_Type(player activepassthrough)
        {
            InitializeComponent();
            player activePlayer = activepassthrough;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home(activePlayer).Show();
        }

        private void eWildcard_Click(object sender, EventArgs e)
        {
            this.Close();
            new Categories(activePlayer, 'e').Show();
        }

        private void mWildcard_Click(object sender, EventArgs e)
        {
            this.Close();
            new Categories(activePlayer, 'm').Show();
        }

        private void hWildcard_Click(object sender, EventArgs e)
        {
            this.Close();
            new Categories(activePlayer, 'h').Show();
        }
    }
}
