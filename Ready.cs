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
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            var results = data.results.ToObject<List<QuestionData>>();

            string[,] formattedArray = new string[results.Count, 3];
            for (int i = 0; i < results.Count; i++)
            {
                formattedArray[i, 0] = results[i].Question;
                formattedArray[i, 1] = results[i].CorrectAnswer;
                formattedArray[i, 2] = string.Join(", ", results[i].IncorrectAnswers);
            }
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Question";
            dataGridView1.Columns[1].Name = "Correct Answer";
            dataGridView1.Columns[2].Name = "Incorrect Answers";

            for (int i = 0; i < results.Count; i++)
            {
                dataGridView1.Rows.Add(formattedArray[i, 0], formattedArray[i, 1], formattedArray[i, 2]);
            }
        }
    }
}
