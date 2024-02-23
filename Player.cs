using Coursework.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    [Serializable]
    public class player
    {
        public string username { get; set; }
        public string password { get; set; }
        public int score { get; set; }
        public int currentScore { get; set; }
        public double topWildScore { get; set; }
        public double topBaseScore { get; set; }
        public char defaultPFP { get; set; }
        public string pathToCustomPFP { get; set; }
        public Image ProfilePicture { get; set; }

        public player(string name, string pass)
        {
            this.username = name;
            this.password = pass;
            this.currentScore = 0;
            this.topWildScore = 0;
            this.topBaseScore = 0;
            this.pathToCustomPFP = "none";

        }
        public void AccumulativeReset()
        {
            this.score = 0;
        }
        public void Accumulate()
        {
            this.score++;
            new System.Media.SoundPlayer(Resources.Correct_Ding).Play();
        }
        public void AddToDatabase()
        {
            File.AppendAllText("userDatabase.csv",(this.username.ToLower() + "," + this.password + "," + this.topWildScore + "," + this.topBaseScore + "," + this.defaultPFP + "," + this.pathToCustomPFP + Environment.NewLine));
        }
        public void UpdateTopScore(int newscore, int secondsTaken, string difficulty)
        {

        }

    }
}
