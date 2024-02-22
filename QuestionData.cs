using System;
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
        public static void PlayQuestion(QuestionData allquestions, player activePlayer)
        {
            Random rnd = new Random();
            int r = rnd.Next(allquestions.results.Count);
            questionInfo currentQ = allquestions.results[r];
            allquestions.results.RemoveAt(r);
            if (currentQ.type == "multiple")
            {
                new multipleChoice(currentQ, activePlayer).Show();
                
            }
            else if (currentQ.type == "boolean")
            {
                new TrueFalse(currentQ,activePlayer).Show();
                
            }
            else if (currentQ.type == "written")
            {

            }
            else if (currentQ.type == "dragdrop")
            {

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
    }
    

}
