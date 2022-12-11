using System.Collections.Generic;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2022.Day6
{
    public class Solution : BaseSolution<string>, ISolvable
    {
        public Solution(IPuzzle puzzle) : base(puzzle, x => x.Trim('\n'))
        {
        }

        public string SolvePart1()
        {
            int markerIndex = -1;
            int windowIndex = 0;
            while (windowIndex < Input.Length - 5 && markerIndex == -1)
            {
                HashSet<char> charSet = new(Input.Skip(windowIndex).Take(4));
                if (charSet.Count == 4)
                {
                    markerIndex = windowIndex;
                }

                windowIndex++;
            }

            return $"Part 1: {markerIndex + 4}";
        }

        public string SolvePart2()
        {
            int markerIndex = -1;
            int windowIndex = 0;
            while (windowIndex < Input.Length - 5 && markerIndex == -1)
            {
                HashSet<char> charSet = new(Input.Skip(windowIndex).Take(14));
                if (charSet.Count == 14)
                {
                    markerIndex = windowIndex;
                }

                windowIndex++;
            }

            return $"Part 2: {markerIndex + 14}";
        }
    }
}