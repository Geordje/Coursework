using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Ready : Form
    {
        player activePlayer;
        char difficulty;
        char category;
        
        public Ready(player activePassthrough)
        {
            InitializeComponent();
        }
        public Ready(player activePassthrough, char difficultyPassthrough, char categoryPassthrough)
        {
            activePlayer = activePassthrough;
            difficulty = difficultyPassthrough;
            category = categoryPassthrough;
            InitializeComponent();

            var json = new WebClient().DownloadString("https://opentdb.com/api.php?amount=10&category=23&difficulty=medium");
            QuestionData questionData = JsonConvert.DeserializeObject<QuestionData>(json);
            foreach(var questionStuff in questionData.questions)
            {
                MessageBox.Show($"{questionStuff.question}");
            }

        }
    }
}
