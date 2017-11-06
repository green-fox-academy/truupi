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
        private string playerName = "player1";
        private string opponentName = "player2";
        private string score;

        public TennisGame1(string playerName, string opponentName)
        {
            this.playerName = playerName;
            this.opponentName = opponentName;
        }

        public void WonPoint(string gameWinner)
        {
            if (gameWinner.Equals(playerName))
            {
                playerScore++;
            }
            else
            {
                opponentScore++;
            }
        }

        public string GetScore()
        {
            score = String.Empty;
            if (playerScore == opponentScore)
            {
                EqualScores();
            }
            else if (playerScore >= 4 || opponentScore >= 4)
            {
                AfterDouceScores();
            }
            else
            {
                BeforeDouceScores();
            }
            return score;
        }

        private void BeforeDouceScores()
        {
            int tempScore = 0;
            for (int i = 1; i < 3; i++)
            {
                if (i == 1)
                {
                    tempScore = playerScore;
                }
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

        private void EqualScores()
        {
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
        }

        private void AfterDouceScores()
        {
            int scoreDifference = playerScore - opponentScore;

            if (scoreDifference == 1)
            {
                score = $"Advantage {playerName}";
            }
            else if (scoreDifference == -1)
            {
                score = $"Advantage {opponentName}";
            }
            else if (scoreDifference >= 2)
            {
                score = $"Win for {playerName}";
            }
            else
            {
                score = $"Win for {opponentName}";
            }
        }
    }
}
