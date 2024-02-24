using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class multipleChoice : Form
    {
       
        Random randint = new Random();
        static int r;
        static player activePlayer;
        public multipleChoice(questionInfo currentQ, player activePassthrough)
        {
            //subscribe to the TimeUpdated event
            Ready.timeKeeperInstance.TimeUpdated += TimerInstance_TimeUpdated;
            r = randint.Next(0, 3);
            InitializeComponent();
            activePlayer = activePassthrough;
            questionText.Text = currentQ.question;
            Title.Text = $"Question {currentQ.questionNo}";
            timeLeft.Text = Ready.timeKeeperInstance.GetRemainingTimeInSeconds().ToString();

            if (r == 0)
            {
                answer1txt.Text = currentQ.correct_answer;
                answer2txt.Text = currentQ.incorrect_answers[0];
                answer3txt.Text = currentQ.incorrect_answers[1];
                answer4txt.Text = currentQ.incorrect_answers[2];
            }
            else if (r == 1)
            {
                answer1txt.Text = currentQ.incorrect_answers[0];
                answer2txt.Text = currentQ.correct_answer;
                answer3txt.Text = currentQ.incorrect_answers[1];
                answer4txt.Text = currentQ.incorrect_answers[2];
            }
            else if (r == 2)
            {
                answer1txt.Text = currentQ.incorrect_answers[0];
                answer2txt.Text = currentQ.incorrect_answers[1];
                answer3txt.Text = currentQ.correct_answer;
                answer4txt.Text = currentQ.incorrect_answers[2];
            }
            else if (r == 3)
            {
                answer1txt.Text = currentQ.incorrect_answers[0];
                answer2txt.Text = currentQ.incorrect_answers[1];
                answer3txt.Text = currentQ.incorrect_answers[2];
                answer4txt.Text = currentQ.correct_answer;
            }
        }

        private void answer1txt_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                activePlayer.Accumulate();
            }
            this.Close();
            QuestionData.PlayQuestion(Ready.thisQuestionData, activePlayer);
        }

        private void answer2txt_Click(object sender, EventArgs e)
        {
            if (r == 1)
            {
                activePlayer.Accumulate();
            }
            this.Close();
            QuestionData.PlayQuestion(Ready.thisQuestionData, activePlayer);
        }

        private void answer3txt_Click(object sender, EventArgs e)
        {
            if (r == 2)
            {
                activePlayer.Accumulate();
            }
            this.Close();
            QuestionData.PlayQuestion(Ready.thisQuestionData, activePlayer);
        }

        private void answer4txt_Click(object sender, EventArgs e)
        {
            if (r == 4)
            {
                activePlayer.Accumulate();
            }
            this.Close();
            QuestionData.PlayQuestion(Ready.thisQuestionData, activePlayer);
        }

        void TimerInstance_TimeUpdated(object sender, int remainingTimeInSeconds)
        {
            timeLeft.Text = remainingTimeInSeconds.ToString();
        }
        void Timeup()
        {
            this.Close();
            new Results(activePlayer, Categories.Difficulty).Show();
        }


    }
}
