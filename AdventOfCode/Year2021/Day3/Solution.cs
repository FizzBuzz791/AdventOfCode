using System;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2021.Day3
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            var length = Input[0].Length;
            var binaryGammaRate = "";
            var binaryEpsilonRate = "";
            for (int i = 0; i < length; i++)
            {
                var bitsAtIndex = Input.Select(x => x[i]);
                var countOfOnes = bitsAtIndex.Count(x => x == '1');
                var countOfZeroes = bitsAtIndex.Count(x => x == '0');

                binaryGammaRate += countOfOnes > countOfZeroes ? '1' : '0';
                binaryEpsilonRate += countOfOnes < countOfZeroes ? '1' : '0';
            }
            var gammaRate = Convert.ToInt32(binaryGammaRate, 2);
            var epsilonRate = Convert.ToInt32(binaryEpsilonRate, 2);
            return $"Part 1: {gammaRate * epsilonRate}";
        }

        public string SolvePart2()
        {
            return $"Part 2:";
        }
    }
}