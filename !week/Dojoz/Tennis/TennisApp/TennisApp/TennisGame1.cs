using System;

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
            if (playerScore.Equals(opponentScore))
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

        private string CurrentScore(int currentScore)
        {
            string resultScore = String.Empty;
            switch (currentScore)
            {
                case 0:
                    resultScore = "Love";
                    break;
                case 1:
                    resultScore = "Fifteen";
                    break;
                case 2:
                    resultScore = "Thirty";
                    break;
                case 3:
                    resultScore = "Forty";
                    break;
            }
            return resultScore;
        }

        private void BeforeDouceScores()
        {
            score = CurrentScore(playerScore) + "-" + CurrentScore(opponentScore);
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
