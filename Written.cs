using Coursework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Written : Form
    {
        Random randint = new Random();
        static int r;
        static player activePlayer;
        private questionInfo thisQuestion;
        public Written(questionInfo currentQ, player activePassthrough)
        {
            Ready.timeKeeperInstance.TimeUpdated += TimerInstance_TimeUpdated;
            InitializeComponent();
            activePlayer = activePassthrough;
            questionText.Text = currentQ.question;
            Title.Text = $"Question {currentQ.questionNo}";
            timeLeft.Text = Ready.timeKeeperInstance.GetRemainingTimeInSeconds().ToString();
            formatHelper.Text = currentQ.incorrect_answers[0];
            treeHint.Visible = false;
            if (currentQ.correct_answer == "DayGoesHere")
            {
                currentQ.correct_answer = DateTime.Now.DayOfWeek.ToString();
            }
            else if (currentQ.correct_answer == "DaysUntillChristmasGoesHere")
            {
                treeHint.Visible = true;
                if (DateTime.Now.Month == 12 && DateTime.Now.Day > 25)
                {
                    DateTime christmas = new DateTime(DateTime.Now.Year + 1, 12, 25);
                    DateTime today = DateTime.Today;
                    currentQ.correct_answer = (christmas - today).Days.ToString();
                }
                else
                {
                    DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);
                    DateTime today = DateTime.Today;
                    currentQ.correct_answer = (christmas - today).Days.ToString();
                }

            }
            thisQuestion = currentQ;
        }
        void TimerInstance_TimeUpdated(object sender, int remainingTimeInSeconds)
        {
            timeLeft.Text = remainingTimeInSeconds.ToString();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (answerSlot.Text.ToLower() == thisQuestion.correct_answer.ToLower())
            {
                activePlayer.Accumulate();
            }
            else
            {
                new System.Media.SoundPlayer(Resources.Incorrect).Play();
            }
            this.Close();
            QuestionData.PlayQuestion(Ready.thisQuestionData, activePlayer);
        }

        private void treeHint_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://www.google.com/search?q=how+many+days+until+christmas&rlz=1C1ONGR_en-GBGB933GB933&oq=how+many+days+&gs_lcrp=EgZjaHJvbWUqDAgCEAAYFBiHAhiABDIGCAAQRRg5MgcIARAAGIAEMgwIAhAAGBQYhwIYgAQyBwgDEAAYgAQyBwgEEAAYgAQyBwgFEAAYgAQyBwgGEAAYgAQyBwgHEAAYgAQyBwgIEAAYgAQyBwgJEAAYgATSAQgzMDkwajBqN6gCALACAA&sourceid=chrome&ie=UTF-8";
            myProcess.Start();

        }
    }
}
