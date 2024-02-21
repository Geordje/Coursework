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
        player activePlayer;
        string difficulty;
        int category;
        
        public Ready(player activePassthrough)
        {
            //ready screen for the base quiz
            InitializeComponent();
            
        }
        public Ready(player activePassthrough, string difficultyPassthrough, int categoryPassthrough)
        {
            //ready screen for wildcard
            activePlayer = activePassthrough;
            difficulty = difficultyPassthrough;
            category = categoryPassthrough;
            InitializeComponent();
            var json = new WebClient().DownloadString($"https://opentdb.com/api.php?amount=20&category={category}&difficulty={difficulty}");
            QuestionData questionData = JsonConvert.DeserializeObject<QuestionData>(json);

            foreach (var questionItem in questionData.results)
            {
                questionItem.question = HttpUtility.HtmlDecode(questionItem.question);
                questionItem.correct_answer = HttpUtility.HtmlDecode(questionItem.correct_answer);
                for (int i = 0; i < questionItem.incorrect_answers.Count; i++)
                {
                    questionItem.incorrect_answers[i] = HttpUtility.HtmlDecode(questionItem.incorrect_answers[i]);
                }
                MessageBox.Show(questionItem.question);
            }

        }
        public Ready(player activePassthrough, string difficultyPassthrough)
        {
            //ready screen for uncategorised
            activePlayer = activePassthrough;
            difficulty = difficultyPassthrough;
            InitializeComponent();
            var json = new WebClient().DownloadString($"https://opentdb.com/api.php?amount=20&difficulty={difficulty}");
            QuestionData questionData = JsonConvert.DeserializeObject<QuestionData>(json);

            foreach (var questionItem in questionData.results)
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
