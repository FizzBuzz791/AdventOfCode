using System;
using System.Collections.Generic;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2022.Day1
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        private List<Elf> Elves = new();

        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
            Elf currentElf = new();
            foreach (var input in Input)
            {
                if (input == string.Empty)
                {
                    Elves.Add(currentElf);
                    currentElf = new();
                }
                else
                {
                    currentElf.AddFoodItem(int.Parse(input));
                }
            }

            // Add the last elf.
            Elves.Add(currentElf);
        }

        public string SolvePart1()
        {
            return $"Part 1: {Elves.Select(e => e.GetTotalCalories()).Max()}";
        }

        public string SolvePart2()
        {
            var totalCalories = Elves.Select(e => e.GetTotalCalories()).ToList();
            totalCalories.Sort();
            totalCalories.Reverse();
            return $"Part 2: {totalCalories[0] + totalCalories[1] + totalCalories[2]}";
        }
    }
}