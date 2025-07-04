using System;
using System.IO;

namespace BlueTeamerRole
{
    public class HighScoreManager
    {
        private const string FilePath = "highscore.txt";

        public class HighScore
        {
            public double Monero { get; set; }
            public int Hacks { get; set; }
            public string Target { get; set; }
        }

        public static void SaveHighScore(double monero, int hacks, string target)
        {
            string scoreLine = $"{monero:F2},{hacks},{target}";
            File.WriteAllText(FilePath, scoreLine);
        }

        public static HighScore LoadHighScore()
        {
            if (!File.Exists(FilePath))
                return new HighScore { Monero = 0, Hacks = 0, Target = "None" };

            string[] data = File.ReadAllText(FilePath).Split(',');
            return new HighScore
            {
                Monero = double.TryParse(data[0], out double monero) ? monero : 0,
                Hacks = int.TryParse(data[1], out int hacks) ? hacks : 0,
                Target = data.Length > 2 ? data[2] : "None"
            };
        }
    }
}