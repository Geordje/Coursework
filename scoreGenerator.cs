using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Coursework
{
    internal class scoreGenerator
    {
        public static double difficultyMultiplier;
        public static int GenerateScore(int timeSaved, string difficulty, player activePlayer)
        {
            //generate a score based on time taken, difficulty and the players score
            
            if (difficulty == "easy")
            {
                difficultyMultiplier = 1;
            }
            else if (difficulty == "medium")
            {
                difficultyMultiplier = 1.4;
            }
            else if (difficulty == "hard")
            {
                difficultyMultiplier = 1.8;
            }
            else
            {
                difficultyMultiplier = 1;
            }
            return Convert.ToInt32((activePlayer.currentScore * 90) * (1 + timeSaved * 0.01) * difficultyMultiplier);
        }
    }
}
