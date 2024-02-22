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
    public partial class TrueFalse : Form
    {
        public static bool chosenAnswer;
        public TrueFalse(questionInfo currentQ, player activePlayer)
        {
            InitializeComponent();
            questionText.Text = currentQ.question;
        }

        private void trueCard_Click(object sender, EventArgs e)
        {
            chosenAnswer = true;
        }

        private void falseCard_Click(object sender, EventArgs e)
        {
            chosenAnswer= false;
        }
    }
}
