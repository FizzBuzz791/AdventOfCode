using AdventOfCode.Year2022.Day4;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2022.Day4
{
    public class SolutionTests
    {
        [TestCase("2-4,6-8\n2-3,4-5\n5-7,7-9\n2-8,3-7\n6-6,4-6\n2-6,4-8\n", 2)]
        public void Part1ReturnsExpectedResult(string input, int overlappingPairs)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day4 = new Solution(puzzle);

            // Act
            string result = day4.SolvePart1();

            // Assert
            result.ShouldBe($"Part 1: {overlappingPairs}");
        }

        [TestCase("2-4,6-8\n2-3,4-5\n5-7,7-9\n2-8,3-7\n6-6,4-6\n2-6,4-8\n", 4)]
        public void Part2ReturnsExpectedResult(string input, int score)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day4 = new Solution(puzzle);

            // Act
            string result = day4.SolvePart2();

            // Assert
            result.ShouldBe($"Part 2: {score}");
        }
    }
}