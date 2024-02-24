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
        static double difficultyMultiplier;
        public static double GenerateScore(int timeSaved, string difficulty, player activePlayer)
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
            double finalScore = (activePlayer.currentScore * difficultyMultiplier * 90) * (1+ timeSaved * 0.005);

            if (finalScore > activePlayer.topWildScore)
            {
                activePlayer.topWildScore = finalScore;
            }
            if(!File.Exists("scores.bin"))
            {
                BinaryWriter bw = new BinaryWriter(File.Open("scores.bin", FileMode.Create));
                bw.Write(activePlayer.username + "," + finalScore);
                bw.Close();
            }
            else
            {
                BinaryWriter bw = new BinaryWriter(File.Open("scores.bin", FileMode.Append));
                bw.Write(activePlayer.username + "," + finalScore);
                bw.Close();
            }
            return finalScore;
        }
    }
}
