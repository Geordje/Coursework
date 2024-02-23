using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class QuestionData
    {
        public int response_code { get; set; }
        public List<questionInfo> results { get; set; }
        public int secondsLeft { get; set; }
        public static void PlayQuestion(QuestionData thisQuestionData, player activePlayer)
        {
            try
            {
                Random rnd = new Random();
                int r = rnd.Next(thisQuestionData.results.Count);
                questionInfo currentQ = thisQuestionData.results[r];
                thisQuestionData.results.RemoveAt(r);
                if (currentQ.type == "multiple")
                {
                    new multipleChoice(currentQ, activePlayer).Show();

                }
                else if (currentQ.type == "boolean")
                {
                    new TrueFalse(currentQ, activePlayer).Show();

                }
                else if (currentQ.type == "written")
                {

                }
                else if (currentQ.type == "dragdrop")
                {

                }
            }
            catch(Exception)
            {
                new Results(activePlayer, Categories.Difficulty).Show();

            }

        }

    }
    public class questionInfo
    {
        public string type { get; set; }
        public string difficulty { get; set; }
        public string category { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }
        public List<string> incorrect_answers { get; set; }
        public int questionNo { get; set; }
    }

}
