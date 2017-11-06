using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisApp
{
    class TennisGame1 : ITennisGame
    {
        private int playerScore = 0;
        private int opponentScore = 0;
        private string playerName;
        private string opponentName;

        public TennisGame1(string playerName, string opponentName)
        {
            this.playerName = playerName;
            this.opponentName = opponentName;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                playerScore += 1;
            else
                opponentScore += 1;
        }
        
        public string EqualScores()
        {
            string score = String.Empty;
            switch (playerScore)
            {
                case 0:
                    score = "Love-All";
                    break;
                case 1:
                    score = "Fifteen-All";
                    break;
                case 2:
                    score = "Thirty-All";
                    break;
                default:
                    score = "Deuce";
                    break;
            }
            return score;
        }

        public string AfterDouce()
        {
            string score = String.Empty;
            int scoreDifference = playerScore - opponentScore;
            if (scoreDifference == 1) score = "Advantage player1";
            else if (scoreDifference == -1) score = "Advantage player2";
            else if (scoreDifference >= 2) score = "Win for player1";
            else score = "Win for player2";
            return score;
        }

        public string GetScore()
        {
            string score = "";
            int tempScore = 0;
            if (playerScore == opponentScore)
            {
                score = EqualScores();
            }
            else if (playerScore >= 4 || opponentScore >= 4)
            {
                score = AfterDouce();
            }
            else
            {
                for (int i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = playerScore;
                    else { score += "-"; tempScore = opponentScore; }
                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }
    }
}
