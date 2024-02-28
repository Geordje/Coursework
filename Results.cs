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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Coursework
{
    public partial class Results : Form
    {
        player activePlayer;
        int timeLeft = Ready.timeKeeperInstance.GetRemainingTimeInSeconds();
        string popUpText = $"Your score is calculated by the time taken to complete the quiz, the difficulty of the quiz, and the amount of questions answered correctly!\nThis is done using the following formula: (Correct Guesses x 90) x(1 + Time Saved x 0.01) x Difficulty Multiplier";
        private bool isShowing = false;
        public Results(player activePassthrough, string difficulty)
        {
            Ready.timeKeeperInstance.Stop();
            int thisScore = scoreGenerator.GenerateScore(timeLeft, difficulty, activePassthrough);
            InitializeComponent();
            activePlayer = activePassthrough;
            correctIndicator.Text = $"{activePlayer.currentScore.ToString()}/20";
            activePlayer.AccumulativeReset();
            timeTaken.Text = (150 - timeLeft).ToString();
            scoreIndicator.Text = $"Score: {thisScore.ToString()}";
            new System.Media.SoundPlayer(Resources.Done).Play();
            if (thisScore > activePlayer.topWildScore)
            {
                topScore.Text = $"New top score!";
            }
            else
            {
                if (Quiz_Type.mode == "wildcard")
                    topScore.Text = $"Your top score: {activePlayer.topWildScore}";
                else
                    topScore.Text = $"Your top score: {activePlayer.topBaseScore}";
            }
            activePlayer.UpdateScoresBinFile(thisScore, Quiz_Type.mode);
            difficultyMultiplierSlot.Text = $"Difficulty Multiplier: {scoreGenerator.difficultyMultiplier}X";

            

        }

        private void returnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home(activePlayer).Show();
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
