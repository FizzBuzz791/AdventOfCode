using System;
using System.Collections.Generic;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2023.Day2
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        readonly List<Game> games = [];

        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
            foreach (var gameRecord in Input)
            {
                var gameRecordParts = gameRecord.Split(':');
                var gameId = int.Parse(gameRecordParts[0].Split(' ')[1]);
                var game = new Game(gameId);
                game.DetermineMaximums(gameRecordParts[1].Split(';'));
                games.Add(game);
            }
        }

        public string SolvePart1()
        {
            return $"Part 1: {games.Where(g => g.MaxRed <= 12 && g.MaxGreen <= 13 && g.MaxBlue <= 14).Sum(g => g.GameId)}";
        }

        public string SolvePart2()
        {
            return $"Part 2: {games.Select(g => g.MaxRed * g.MaxBlue * g.MaxGreen).Sum()}";
        }
    }
}