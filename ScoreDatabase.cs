using System;
using System.Collections.Generic;
using System.IO;

namespace MaduGlebTARpv23
{
    public class ScoreDatabase
    {
        private string filePath = "scores.txt";

        // Сохранение рекорда
        public void SaveScore(string playerName, int score)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{playerName}:{score}");
            }
        }

        // Получение всех рекордов
        public List<(string playerName, int score)> GetAllScores()
        {
            var scores = new List<(string playerName, int score)>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(':');
                    if (data.Length == 2 && int.TryParse(data[1], out int score))
                    {
                        scores.Add((data[0], score));
                    }
                }
            }

            return scores;
        }

        // Получение наивысшего рекорда
        public (string playerName, int score) GetHighScore()
        {
            var scores = GetAllScores();
            if (scores.Count > 0)
            {
                (string playerName, int score) highScore = scores[0];
                foreach (var score in scores)
                {
                    if (score.score > highScore.score)
                    {
                        highScore = score;
                    }
                }
                return highScore;
            }
            return ("Никого", 0);
        }
    }
}
