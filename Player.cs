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
        public player(string name, string pass)
        {
            this.username = name;
            this.password = pass;
            this.currentScore = 0;
            this.topWildScore = 0;
            this.topBaseScore = 0;

        }
        public void AccumulativeReset()
        {
            this.score = 0;
        }
        public void Accumulate()
        {
            this.score++;
        }

    }
}
