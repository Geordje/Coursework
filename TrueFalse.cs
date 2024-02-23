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
        static questionInfo currentQ;
        static player activePlayer;

        public TrueFalse(questionInfo currentPassthrough, player activePassthrough)
        {
            InitializeComponent();
            currentQ = currentPassthrough;
            activePlayer = activePassthrough;
            questionText.Text = currentQ.question;
        }

        private void trueCard_Click(object sender, EventArgs e)
        {
            if (currentQ.correct_answer == "True")
            {
                activePlayer.Accumulate();
            }
            this.Close();
            QuestionData.PlayQuestion(Ready.thisQuestionData, activePlayer);
        }

        private void falseCard_Click(object sender, EventArgs e)
        {
            if (currentQ.correct_answer == "False")
            {
                activePlayer.Accumulate();
            }
            this.Close();
            QuestionData.PlayQuestion(Ready.thisQuestionData, activePlayer);
        }
        public void updateTimer(int timePassthrough)
        {
            timeLeft.Text = timePassthrough.ToString();
        }
    }
}
