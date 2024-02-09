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
        public string username;
        public string password;
        public int score;
        public int currentScore;
        public double topWildScore;
        public double topBaseScore;
        public char defaultPFP;
        public string pathToCustomPFP;
        public Image ProfilePicture;
        
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
        }
        public void AddToDatabase()
        {
            File.AppendAllText("userDatabase.csv", (this.username + ", " + this.password + "," + this.topWildScore + "," + this.topBaseScore + "," + this.defaultPFP + "," + this.pathToCustomPFP + Environment.NewLine));
        }

    }
}
