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
            Title.Text = $"Question {currentQ.questionNo}";
            Ready.timeKeeperInstance.TimeUpdated += TimerInstance_TimeUpdated;
            timeLeft.Text = Ready.timeKeeperInstance.GetRemainingTimeInSeconds().ToString();
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
        private void TimerInstance_TimeUpdated(object sender, int remainingTimeInSeconds)
        {
            timeLeft.Text = remainingTimeInSeconds.ToString();
        }
    }
}
