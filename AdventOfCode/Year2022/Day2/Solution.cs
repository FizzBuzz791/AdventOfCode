using System;
using NAoCHelper;

namespace AdventOfCode.Year2022.Day2
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        private readonly int WinScore = 6;
        private readonly int DrawScore = 3;
        private readonly int LoseScore = 0;
        private readonly int RockScore = 1;
        private readonly int PaperScore = 2;
        private readonly int ScissorsScore = 3;

        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            int score = 0;
            foreach (var round in Input)
            {
                string[] moves = round.Split(' ');
                int opponentMove = GetMoveScore(moves[0]);
                int myMove = GetMoveScore(moves[1]);

                score += myMove;

                if (myMove == opponentMove)
                {
                    score += DrawScore;
                }
                else if ((myMove == RockScore && opponentMove == ScissorsScore) ||
                    (myMove == ScissorsScore && opponentMove == PaperScore) ||
                    (myMove == PaperScore && opponentMove == RockScore))
                {
                    score += WinScore;
                }
                else
                {
                    score += LoseScore;
                }
            }

            return $"Part 1: {score}";
        }

        public string SolvePart2()
        {
            int score = 0;
            foreach (var round in Input)
            {
                string[] moves = round.Split(' ');
                int opponentMove = GetMoveScore(moves[0]);
                score += moves[1] switch
                {
                    "Y" => DrawScore + opponentMove,
                    "X" => LoseScore + (opponentMove == RockScore ? ScissorsScore : opponentMove == ScissorsScore ? PaperScore : RockScore),
                    "Z" => WinScore + (opponentMove == RockScore ? PaperScore : opponentMove == PaperScore ? ScissorsScore : RockScore),
                    _ => throw new NotImplementedException()
                };
            }

            return $"Part 2: {score}";
        }

        private int GetMoveScore(string move)
        {
            return move switch
            {
                "A" or "X" => RockScore,
                "B" or "Y" => PaperScore,
                "C" or "Z" => ScissorsScore,
                _ => throw new NotImplementedException()
            };
        }
    }
}