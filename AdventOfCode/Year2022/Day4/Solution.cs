using System;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2022.Day4
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            int overlappingPairs = 0;

            foreach (var input in Input)
            {
                var elves = input.Split(',');
                var elf1 = new Range(elves[0]);
                var elf2 = new Range(elves[1]);

                if (elf1.Contains(elf2) || elf2.Contains(elf1))
                {
                    overlappingPairs++;
                }
            }

            return $"Part 1: {overlappingPairs}";
        }

        public string SolvePart2()
        {
            int overlappingPairs = 0;

            foreach (var input in Input)
            {
                var elves = input.Split(',');
                var elf1 = new Range(elves[0]);
                var elf2 = new Range(elves[1]);

                if (elf1.Overlaps(elf2) || elf2.Overlaps(elf1))
                {
                    overlappingPairs++;
                }
            }

            return $"Part 2: {overlappingPairs}";
        }
    }

    public class Range
    {
        public int Start { get; }
        public int End { get; }

        public Range(string input)
        {
            string[] parts = input.Split("-");
            Start = int.Parse(parts[0]);
            End = int.Parse(parts[1]);
        }

        public bool Contains(Range range)
        {
            return Start <= range.Start && range.End <= End;
        }

        public bool Overlaps(Range range)
        {
            return (range.Start <= Start && Start <= range.End) || (range.Start <= End && End <= range.End);
        }
    }
}