using System;
using System.Collections.Generic;
using TennisApp.Collections;

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
                EqualScores(playerScore);
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
            if (ScoreCollections.ScoreList.Exists(score => score.GameState == currentScore))
            {
                return ScoreCollections.ScoreList
                    .Find(score => score.GameState == currentScore)
                    .ValueOfScore;
            }
            return "Can't handle this GameState! Give up!";
        }

        private void BeforeDouceScores()
        {
            score = CurrentScore(playerScore) + "-" + CurrentScore(opponentScore);
        }

        private void EqualScores(int currentScore)
        {
            score = ScoreCollections.ScoreList
                .Find(s => s.GameState == currentScore)
                .EqualScore;
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
