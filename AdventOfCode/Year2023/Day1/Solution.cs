using System;
using System.Collections.Generic;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2023.Day1
{
    public class Solution(IPuzzle puzzle) : BaseSolution<string[]>(puzzle, StringArraySelector), ISolvable
    {
        private readonly Dictionary<string, int> numbers = new() {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 }
        };

        public string SolvePart1()
        {
            var results = new List<int>();

            foreach (var line in Input)
            {
                var firstNumber = line.ToArray().ToList().Find(c => int.TryParse(c.ToString(), out _));
                var lastNumber = line.ToArray().ToList().FindLast(c => int.TryParse(c.ToString(), out _));
                results.Add(int.Parse($"{firstNumber}{lastNumber}"));
            }

            return $"Part 1: {results.Sum()}";
        }

        public string SolvePart2()
        {
            var results = new List<int>();

            foreach (var line in Input)
            {
                var firstIntIndex = line.ToArray().ToList().FindIndex(c => int.TryParse(c.ToString(), out _));
                var firstStringNumber = numbers.MinBy(num => line.IndexOf(num.Key) > -1 ? line.IndexOf(num.Key) : 99);
                var firstNumber = line.Contains(firstStringNumber.Key) && (line.IndexOf(firstStringNumber.Key) < firstIntIndex || firstIntIndex == -1) ? firstStringNumber.Value : int.Parse(line[firstIntIndex].ToString());

                var lastIntIndex = line.ToArray().ToList().FindLastIndex(c => int.TryParse(c.ToString(), out _));
                var lastStringNumber = numbers.MaxBy(num => line.LastIndexOf(num.Key));
                var lastNumber = line.Contains(lastStringNumber.Key) && (line.LastIndexOf(lastStringNumber.Key) > lastIntIndex || lastIntIndex == -1) ? lastStringNumber.Value : int.Parse(line[lastIntIndex].ToString());

                results.Add(int.Parse($"{firstNumber}{lastNumber}"));
            }

            return $"Part 2: {results.Sum()}";
        }
    }
}