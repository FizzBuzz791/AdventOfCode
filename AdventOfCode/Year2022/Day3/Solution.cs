using System;
using System.Collections.Generic;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2022.Day3
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            int prioritiesSum = 0;
            foreach (var rucksackItems in Input)
            {
                var compartment1 = rucksackItems[..(rucksackItems.Length / 2)];
                var compartment2 = rucksackItems[(rucksackItems.Length / 2)..];

                Console.WriteLine($"Rucksack Items: {rucksackItems}");
                Console.WriteLine($"Compartment 1: {compartment1}");
                Console.WriteLine($"Compartment 2: {compartment2}");
                var commonItem = compartment1.ToCharArray().Intersect(compartment2.ToCharArray());
                prioritiesSum += GetPriority(commonItem.First());
            }

            return $"Part 1: {prioritiesSum}";
        }

        public string SolvePart2()
        {
            int prioritiesSum = 0;
            for (int i = 0; i < Input.Length; i += 3)
            {
                var commonItem = Input[i].Intersect(Input[i + 1]).Intersect(Input[i + 2]);
                prioritiesSum += GetPriority(commonItem.First());
            }
            return $"Part 2: {prioritiesSum}";
        }

        private static int GetPriority(char rucksackItem)
        {
            int priority = rucksackItem - 96;
            if (priority < 1)
            {
                priority += 32 + 26; // 32 is diff in ASCII table between 'A' and 'a', 26 is length of the alphabet.
            }
            return priority;
        }
    }
}