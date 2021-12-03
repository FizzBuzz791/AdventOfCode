using System;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2021.Day1
{
    public class Solution : BaseSolution<int[]>, ISolvable
    {
        private static readonly Func<string, int[]> inputSelector = x => x.Trim('\n').Split("\n").Select(int.Parse).ToArray();
        public Solution(IPuzzle puzzle) : base(puzzle, inputSelector)
        {
        }

        public string SolvePart1()
        {
            var increaseCount = 0;
            for (var i = 1; i < Input.Length; i++)
            {
                if (Input[i] > Input[i - 1])
                {
                    increaseCount++;
                }
            }
            return $"Part 1: {increaseCount}";
        }

        public string SolvePart2()
        {
            var increaseCount = 0;
            var previousSum = 0;
            for (var i = 2; i < Input.Length; i++)
            {
                var currentSum = Input[i] + Input[i - 1] + Input[i - 2];
                if (previousSum != 0 && currentSum > previousSum)
                {
                    increaseCount++;
                }
                previousSum = currentSum;
            }
            return $"Part 2: {increaseCount}";
        }
    }
}