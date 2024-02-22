using Newtonsoft.Json;
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

namespace Coursework
{
    public partial class Ready : Form
    {
        public static player activePlayer;
        public static string difficulty;
        public static int category;
        QuestionData thisQuestionData = new QuestionData();

        public Ready(player activePassthrough)
        {
            activePlayer = activePassthrough;
            //ready screen for the base quiz
            InitializeComponent();
            string[] line;
            int i = 0;
            FileStream aFile = new FileStream("baseQuiz.csv", FileMode.Open);
            StreamReader s = new StreamReader(aFile);
            while (s.ReadLine() != null)
            {
                if (i != 0)
                {
                    line = s.ReadLine().Split(",");
                    thisQuestionData.results[i].type= line[0];
                    thisQuestionData.results[i].question = line[1];
                    thisQuestionData.results[i].correct_answer = line[2];
                    thisQuestionData.results[i].incorrect_answers.Add(line[3] +","+ line[4] +","+ line[5]);
                }
                i++;

            }
            s.Close();
        }
        public Ready(player activePassthrough, string difficultyPassthrough, int categoryPassthrough)
        {
            InitializeComponent();
            //ready screen for wildcard
            activePlayer = activePassthrough;
            difficulty = difficultyPassthrough;
            category = categoryPassthrough;
            var json = new WebClient().DownloadString($"https://opentdb.com/api.php?amount=20&category={category}&difficulty={difficulty}");
            QuestionData thisQuestionData = JsonConvert.DeserializeObject<QuestionData>(json);

            foreach (var questionItem in thisQuestionData.results)
            {
                questionItem.question = HttpUtility.HtmlDecode(questionItem.question);
                questionItem.correct_answer = HttpUtility.HtmlDecode(questionItem.correct_answer);
                for (int i = 0; i < questionItem.incorrect_answers.Count; i++)
                {
                    questionItem.incorrect_answers[i] = HttpUtility.HtmlDecode(questionItem.incorrect_answers[i]);
                }
            }
            QuestionData.PlayQuestion(thisQuestionData,activePlayer);

        }
        public Ready(player activePassthrough, string difficultyPassthrough)
        {
            //ready screen for uncategorised
            activePlayer = activePassthrough;
            difficulty = difficultyPassthrough;
            InitializeComponent();
            var json = new WebClient().DownloadString($"https://opentdb.com/api.php?amount=20&difficulty={difficulty}");
            QuestionData thisQuestionData = JsonConvert.DeserializeObject<QuestionData>(json);

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
    }
}
