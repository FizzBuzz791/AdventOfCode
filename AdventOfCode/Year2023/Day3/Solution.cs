using System;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2023.Day3
{
    public class Solution(IPuzzle puzzle) : BaseSolution<string[]>(puzzle, StringArraySelector), ISolvable
    {
        private readonly char[] ValidSymbols = ['*', '#', '+', '$', '/', '%', '=', '-', '&', '@'];

        public string SolvePart1()
        {
            for (int rowIndex = 0; rowIndex < Input.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < Input[rowIndex].Length; colIndex++)
                {
                    if (int.TryParse(Input[rowIndex][colIndex].ToString(), out var part))
                    {
                    }
                }
            }

            return $"Part 1: {0}";
        }

        private bool IsAdjacentToSymbol(int rowIndex, int colIndex)
        {
            var isAdjacent = false;

            // Top left
            isAdjacent &= rowIndex > 0 && colIndex > 0 && ValidSymbols.Contains(Input[rowIndex - 1][colIndex - 1]);

            // Top middle
            isAdjacent &= rowIndex > 0 && ValidSymbols.Contains(Input[rowIndex - 1][colIndex]);

            // Top right
            // Middle left
            // Middle right
            // Bottom left
            // Bottom middle
            // Bottom right

            return isAdjacent;
        }

        public string SolvePart2()
        {
            throw new NotImplementedException();
        }
    }
}