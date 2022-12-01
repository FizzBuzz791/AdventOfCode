using AdventOfCode.Year2022.Day2;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2022.Day2
{
    public class SolutionTests
    {
        [TestCase("A Y\nB X\nC Z\n", 15)]
        public void Part1ReturnsExpectedResult(string input, int score)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day2 = new Solution(puzzle);

            // Act
            string result = day2.SolvePart1();

            // Assert
            result.ShouldBe($"Part 1: {score}");
        }

        [TestCase("A Y\nB X\nC Z\n", 12)]
        public void Part2ReturnsExpectedResult(string input, int score)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day2 = new Solution(puzzle);

            // Act
            string result = day2.SolvePart2();

            // Assert
            result.ShouldBe($"Part 2: {score}");
        }
    }
}