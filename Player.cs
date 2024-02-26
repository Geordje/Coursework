using Coursework.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    [Serializable]
    public class player
    {
        public string username { get; set; }
        private string password { get; set; }
        public int currentScore { get; set; }
        public int topWildScore { get; set; }
        public int topBaseScore { get; set; }
        public char defaultPFP { get; set; }
        public string pathToCustomPFP { get; set; }
        public Image ProfilePicture { get; set; }

        public player(string name, string pass)
        {
            this.username = name;
            this.password = pass;
            this.currentScore = 0;
            this.pathToCustomPFP = "none";
            using (StreamReader reader = new StreamReader("scores.bin"))
            {
                string line;
                bool found = false;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace("\u000e", "");
                    string[] parts = line.Split(',');
                    if (parts[0] == this.username)
                    {
                        topWildScore = Convert.ToInt32(parts[1]);
                        topBaseScore = Convert.ToInt32(parts[2]);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    topWildScore = 0;
                    topBaseScore = 0;
                }
            }



        }
        public void AccumulativeReset()
        {
            this.currentScore = 0;
        }
        public void Accumulate()
        {
            this.currentScore++;
            new System.Media.SoundPlayer(Resources.Correct_Ding).Play();
        }
        public void CreateDatabaseForPlayer()
        {
            File.WriteAllText("userDatabase.csv",(this.username.ToLower() + "," + this.password + "," + this.defaultPFP + "," + this.pathToCustomPFP + Environment.NewLine));
        }
        public void AddToDatabase()
        {
            File.AppendAllText("userDatabase.csv",(this.username.ToLower() + "," + this.password + ","  + this.defaultPFP + "," + this.pathToCustomPFP + Environment.NewLine));
        }



        public void UpdateScoresBinFile(int newScore, string mode)
        {
            bool updated = false;
            bool found = false;
            if(mode == "wildcard")
            {
                if (newScore > topWildScore)
                {
                    topWildScore = newScore;
                    updated = true;
                }
            }
            else if (mode == "base")
            {
                if (newScore > topBaseScore)
                {
                    topBaseScore = newScore;
                    updated = true;
                }
            }
            if (updated)
            {
                string tempFile = Path.GetTempFileName();
                using (var sr = new StreamReader("scores.bin"))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == username)
                        {
                            parts[1] = topWildScore.ToString();
                            parts[2] = topBaseScore.ToString();
                            line = string.Join(",", parts);
                            found = true;
                        }
                        sw.WriteLine(line);
                    }
                    if (!found)
                    {
                        sw.WriteLine(username + "," + topWildScore + "," + topBaseScore);
                    }
                }
                File.Delete("scores.bin");
                File.Move(tempFile, "scores.bin");
            }
                
            
        }
    }
}
