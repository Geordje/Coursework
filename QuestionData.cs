using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Coursework
{
    public class QuestionData
    {
        public int response_code { get; set; }
        public List<questionInfo> results { get; set; }
        public static Form newMulti;
        public static Form newTrueFalse;
        static int qnum=1;
        
        public static void PlayQuestion(QuestionData thisQuestionData, player activePlayer)
        {
            try
            {
                timeKeeper timeKeeperInstance = Ready.timeKeeperInstance;
                Random rnd = new Random();
                int r = rnd.Next(thisQuestionData.results.Count);
                questionInfo currentQ = thisQuestionData.results[r];
                currentQ.questionNo = qnum;
                qnum++;
                thisQuestionData.results.RemoveAt(r);
                if (currentQ.type == "multiple")
                {
                    newMulti = new multipleChoice(currentQ, activePlayer);
                    newMulti.Show();

                }
                else if (currentQ.type == "boolean")
                {
                    newTrueFalse = new TrueFalse(currentQ, activePlayer);
                    newTrueFalse.Show();

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
                Ready.timeKeeperInstance.Stop();
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
