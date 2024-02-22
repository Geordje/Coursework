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
    public partial class multipleChoice : Form
    {
        public multipleChoice(questionInfo currentQ, player activePlayer)
        {
            InitializeComponent();
            questionText.Text = currentQ.question;
            Random rnd = new Random();
            int r = rnd.Next(3);
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
    }
}
