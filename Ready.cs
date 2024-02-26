using Coursework.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Coursework
{
    public partial class Ready : Form
    {
        public static player activePlayer;
        public static string difficulty;
        public static int category;
        private static int seconds;
        public static QuestionData thisQuestionData = new QuestionData();
        public static timeKeeper timeKeeperInstance = new timeKeeper();


        public Ready(player activePassthrough)
        {
            activePlayer = activePassthrough;
            //ready screen for the base quiz
            InitializeComponent();
            string[] line;
            FileStream aFile = new FileStream("baseQuiz.csv", FileMode.Open);
            StreamReader s = new StreamReader(aFile);
            int i = 0;
            seconds = 0;
            while (s.ReadLine() != null)
            {
                if (i != 0)
                {
                    line = s.ReadLine().Split(",");
                    thisQuestionData.results[i].type = line[0];
                    thisQuestionData.results[i].question = line[1];
                    thisQuestionData.results[i].correct_answer = line[2];
                    thisQuestionData.results[i].incorrect_answers.Add(line[3] + "," + line[4] + "," + line[5]);
                }
                i++;

            }
            s.Close();
        }
        public Ready(player activePassthrough, string difficultyPassthrough, int categoryPassthrough)
        {
            InitializeComponent();
            //ready screen for wildcard
            startTimer.Start();
            activePlayer = activePassthrough;
            difficulty = difficultyPassthrough;
            category = categoryPassthrough;
            seconds = 0;

            var json = new WebClient().DownloadString($"https://opentdb.com/api.php?amount=20&category={category}&difficulty={difficulty}");
            thisQuestionData = JsonConvert.DeserializeObject<QuestionData>(json);

            foreach (var questionItem in thisQuestionData.results)
            {
                questionItem.question = HttpUtility.HtmlDecode(questionItem.question);
                questionItem.correct_answer = HttpUtility.HtmlDecode(questionItem.correct_answer);
                for (int i = 0; i < questionItem.incorrect_answers.Count; i++)
                {
                    questionItem.incorrect_answers[i] = HttpUtility.HtmlDecode(questionItem.incorrect_answers[i]);
                }
            }
        }
        public Ready(player activePassthrough, string difficultyPassthrough)
        {
            InitializeComponent();
            //ready screen for wildcardUncategorised
            startTimer.Start();
            activePlayer = activePassthrough;
            difficulty = difficultyPassthrough;
            seconds = 0;

            var json = new WebClient().DownloadString($"https://opentdb.com/api.php?amount=20&difficulty={difficulty}");
            thisQuestionData = JsonConvert.DeserializeObject<QuestionData>(json);

            foreach (var questionItem in thisQuestionData.results)
            {
                questionItem.question = HttpUtility.HtmlDecode(questionItem.question);
                questionItem.correct_answer = HttpUtility.HtmlDecode(questionItem.correct_answer);
                for (int i = 0; i < questionItem.incorrect_answers.Count; i++)
                {
                    questionItem.incorrect_answers[i] = HttpUtility.HtmlDecode(questionItem.incorrect_answers[i]);
                }
            }
        }

        public void startTimer_Tick(object sender, EventArgs e)
        {
            if (seconds < 5)
            {
                switch (seconds)
                {
                    case 2: readyText.Text = "3"; break;
                    case 3: readyText.Text = "2"; break;
                    case 4: readyText.Text = "1"; break;
                }
                seconds++;
            }

            else
            {
                timeKeeperInstance.Start();
                startTimer.Stop();
                QuestionData.PlayQuestion(thisQuestionData, activePlayer);
                this.Hide();
            }
        }
    }
}
