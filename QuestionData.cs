using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Coursework
{
    public class QuestionData
    {
        public int response_code { get; set; }
        public List<questionInfo> results { get; set; }
        public static Form newMulti;
        public static Form newTrueFalse;
        public static Form newWritten;
        public static Form newDragDrop;
        static int qnum=1;
        private static List<Form> openForms = new List<Form>();
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
                    var multipleChoiceForm = new multipleChoice(currentQ, activePlayer);
                    openForms.Add(multipleChoiceForm);
                    multipleChoiceForm.Show();

                }
                else if (currentQ.type == "boolean")
                {
                    var trueeFalseForm = new TrueFalse(currentQ, activePlayer);
                    openForms.Add(trueeFalseForm);
                    trueeFalseForm.Show();

                }
                else if (currentQ.type == "written")
                {

                }
                else if (currentQ.type == "dragdrop")
                {
                    var dragdropForm = new dragAndDrop(currentQ, activePlayer);
                    openForms.Add(dragdropForm);
                    dragdropForm.Show();
                }
            }
            catch(ArgumentOutOfRangeException)
            { 
                QuizEnd(activePlayer);
            }
            catch (Exception e)
            {
                Ready.timeKeeperInstance.Stop();
                MessageBox.Show($"An error has occured, please try again{Environment.NewLine}Error: {e}","Error with quiz");
                new Home(activePlayer).Show();
                qnum = 1;
            }

        }
        public static void QuizEnd(player activePlayer)
        {
            foreach (var form in openForms)
            {
                form.Close();
            }
            if (Quiz_Type.mode == "base")
            {
                new Results(activePlayer, "base").Show();
            }
            else
            {
                new Results(activePlayer, Categories.Difficulty).Show();
            }
            qnum = 1;
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
