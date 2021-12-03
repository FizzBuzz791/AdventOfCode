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
            var length = Input[0].Length;
            var binaryOxygenRating = "";
            var binaryCO2Rating = "";
            var validOxygenResults = Input;
            var validCO2Results = Input;

            var counter = 0;
            while (validOxygenResults.Length > 1)
            {
                var bitsAtIndex = validOxygenResults.Select(x => x[counter]);
                var countOfOnes = bitsAtIndex.Count(x => x == '1');
                var countOfZeroes = bitsAtIndex.Count(x => x == '0');

                validOxygenResults = countOfOnes >= countOfZeroes
                    ? validOxygenResults.Where(x => x[counter] == '1').ToArray()
                    : validOxygenResults.Where(x => x[counter] == '0').ToArray();

                counter++;
            }
            binaryOxygenRating = validOxygenResults[0];

            // Reset counter
            counter = 0;

            while (validCO2Results.Length > 1)
            {
                var bitsAtIndex = validCO2Results.Select(x => x[counter]);
                var countOfOnes = bitsAtIndex.Count(x => x == '1');
                var countOfZeroes = bitsAtIndex.Count(x => x == '0');

                validCO2Results = countOfZeroes <= countOfOnes
                    ? validCO2Results.Where(x => x[counter] == '0').ToArray()
                    : validCO2Results.Where(x => x[counter] == '1').ToArray();

                counter++;
            }
            binaryCO2Rating = validCO2Results[0];

            var oxygenRate = Convert.ToInt32(binaryOxygenRating, 2);
            var CO2Rate = Convert.ToInt32(binaryCO2Rating, 2);

            return $"Part 2: {oxygenRate * CO2Rate}";
        }
    }
}