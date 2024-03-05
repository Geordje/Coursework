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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using CsvHelper;

using System.Formats.Asn1;
using System.Globalization;

namespace Coursework
{
    public partial class Ready : Form
    {
        public static player activePlayer;
        public static string difficulty;
        public static int category;
        private static int seconds;
        public static bool uncategorised;
        public static bool timeOutRan = false;
        public static QuestionData thisQuestionData = new QuestionData();
        public static timeKeeper timeKeeperInstance = new timeKeeper();

        public Ready(player activePassthrough)
        {
            InitializeComponent();
            uncategorised = false;
            timeKeeperInstance = new timeKeeper();
            timeKeeperInstance.TimeUp += TimeUp;
            startTimer.Start();
            activePlayer = activePassthrough;
            seconds = 0;
            using (var reader = new StreamReader("baseQuiz.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var allRecords = new List<questionInfo>();
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var record = new questionInfo
                    {
                        question = csv.GetField("Question"),
                        type = csv.GetField("QuestionType"),
                        correct_answer = csv.GetField("Correct Answer/Group"),
                        incorrect_answers = new List<string> {
                            csv.GetField("IncorrectAnswer1/FormatHelper"),
                            csv.GetField("IncorrectAnswer2"),
                            csv.GetField("IncorrectAnswer3")
                        }
                    };

                    allRecords.Add(record);
                }

                var random = new Random();
                var selectedRecords = allRecords.OrderBy(x => random.Next()).Take(20).ToList();
                thisQuestionData.results = selectedRecords;

                //remove one non drag drop question per drag drop question as drag drops are worth 2 points
                List<questionInfo> itemsToRemove = new List<questionInfo>();
                foreach (var questionItem in thisQuestionData.results)
                {
                    if (questionItem.type == "dragdrop")
                    {
                        questionInfo nonDragDropQuestion = thisQuestionData.results[random.Next(thisQuestionData.results.Count())];
                        while (nonDragDropQuestion.type == "dragdrop")
                        {
                            nonDragDropQuestion = thisQuestionData.results[random.Next(thisQuestionData.results.Count())];
                        }
                        itemsToRemove.Add(nonDragDropQuestion);
                    }
                }
                foreach (var item in itemsToRemove)
                {
                    thisQuestionData.results.Remove(item);
                }

            }
        }
        public Ready(player activePassthrough, string difficultyPassthrough, int categoryPassthrough)
        {
            InitializeComponent();
            //ready screen for wildcard
            uncategorised = false;
            timeKeeperInstance = new timeKeeper();
            timeKeeperInstance.TimeUp += TimeUp;
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
            uncategorised = true;
            timeKeeperInstance = new timeKeeper();
            timeKeeperInstance.TimeUp += TimeUp;
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
                startTimer.Stop();
                timeKeeperInstance.Start();
                QuestionData.PlayQuestion(thisQuestionData, activePlayer);
                new System.Media.SoundPlayer(Resources.Game_Start).Play();
                this.Hide();
            }
        }
        void TimeUp(object sender, EventArgs e)
        {
            QuestionData.QuizEnd(activePlayer);
        }
    }
}
