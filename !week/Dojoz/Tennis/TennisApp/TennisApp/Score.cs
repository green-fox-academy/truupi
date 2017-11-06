using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisApp
{
    public interface IScore
    {
        int GameState { get; set; }
        string ValueOfScore { get; set; }
        string EqualScore { get; set; }
    }

    public class Love : IScore
    {
        public int GameState { get; set; } = 0;
        public string ValueOfScore { get; set; } = "Love";
        public string EqualScore { get; set; } = "Love-All";
    }
    
    public class Fifteen : IScore
    {
        public int GameState { get; set; } = 1;
        public string ValueOfScore { get; set; } = "Fifteen";
        public string EqualScore { get; set; } = "Fifteen-All";
    }

    public class Thirty : IScore
    {
        public int GameState { get; set; } = 2;
        public string ValueOfScore { get; set; } = "Thirty";
        public string EqualScore { get; set; } = "Thirty-All";
    }

    public class Forty : IScore
    {
        public int GameState { get; set; } = 3;
        public string ValueOfScore { get; set; } = "Forty";
        public string EqualScore { get; set; } = "Deuce";
    }

    public class HigherThanForty : IScore
    {
        public int GameState { get; set; } = 4;
        public string ValueOfScore { get; set; } = "";
        public string EqualScore { get; set; } = "Deuce";
    }
}
