using Coursework.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Coursework
{
    public partial class Results : Form
    {
        player activePlayer;
        static string popUpText;
        int timeLeft = Ready.timeKeeperInstance.GetRemainingTimeInSeconds();
        private bool isShowing = false;
        public Results(player activePassthrough, string difficulty)
        {
            Ready.timeKeeperInstance.Stop();
            int thisScore = scoreGenerator.GenerateScore(timeLeft, difficulty, activePassthrough);
            InitializeComponent();
            activePlayer = activePassthrough;
            correctIndicator.Text = $"Points: {activePlayer.currentScore.ToString()}/20";
            activePlayer.AccumulativeReset();
            timeTaken.Text = (150 - timeLeft).ToString();
            scoreIndicator.Text = $"Score: {thisScore.ToString()}";
            new System.Media.SoundPlayer(Resources.Done).Play();


            if (Quiz_Type.mode == "wildcard")
            {
                if (thisScore > activePlayer.topWildScore)
                {
                    topScore.Text = $"New top score!";
                }
                else
                {
                    topScore.Text = $"Your top score: {activePlayer.topWildScore}";
                }
                popUpText = $"Your score is calculated by the time taken to complete the wildcard quiz, the difficulty of the wildcard quiz, and the amount of questions answered correctly!\nThis is done using the following formula: (Correct Guesses x 90) x(1 + Time Saved x 0.01) x Difficulty Multiplier";
            }
            else
            {
                if (thisScore > activePlayer.topBaseScore)
                {
                    topScore.Text = $"New top score!";
                }
                else
                {
                    topScore.Text = $"Your top score: {activePlayer.topBaseScore}";
                }
                popUpText = $"Your score is calculated by the time taken to complete the wildcard quiz, the difficulty of the wildcard quiz, and the amount of questions answered correctly!\nThis is done using the following formula: (Correct Guesses x 90) x(1 + Time Saved x 0.01)";

            }
            activePlayer.UpdateScoresBinFile(thisScore, Quiz_Type.mode);

            string[] lines = File.ReadAllLines("scores.bin");
            int rank = 1;
            int otherAttempts=0;
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                string otherUsername = data[0];
                int otherTopScore;
                if( difficulty == "base")
                {
                    otherTopScore = int.Parse(data[2]);
                }
                else
                {
                    otherTopScore = int.Parse(data[1]);
                }
                if(otherTopScore>0)
                {
                    otherAttempts++;
                }
                if (otherUsername != activePlayer.username)
                {
                    if (thisScore < otherTopScore)
                    {
                        rank++;
                    }
                }
            }
            
            placementIndicator.Text = $"This would place you {rank.ToString()}{AddSuffix(rank)} of the {otherAttempts.ToString()} players!";
            placingAgain.Text = rank.ToString();

            if (Quiz_Type.mode == "wildcard")
            {
                difficultyMultiplierSlot.Show();
                difficultyMultiplierSlot.Text = $"Difficulty Multiplier: {scoreGenerator.difficultyMultiplier}X";
            }
            else
            {
                difficultyMultiplierSlot.Hide();
            }
        }

        private void returnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home(activePlayer).Show();
        }

        public static string AddSuffix(int num)
        {
            switch (num)
            {
                case 11: return "th";
                case 12: return "th";
                case 13: return "th";
                default: break;
                
            }
            switch(num.ToString().Last())
            {
                case '1': return "st";
                case '2': return "nd";
                case '3': return "rd";
                default: return "th";
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            if (isShowing) return;

            isShowing = true;
            toolTip1.BackColor = Color.White;
            toolTip1.ToolTipTitle = "How is this generated?";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.AutomaticDelay = 1000;
            toolTip1.ReshowDelay = 300;
            toolTip1.Show(popUpText, scoreIndicator);
            isShowing = false;
        }

        private void scoreIndicator_MouseHover(object sender, EventArgs e)
        {
            toolTip1_Popup(sender, null);
        }
    }
}
