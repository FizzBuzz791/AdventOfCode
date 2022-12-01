using AdventOfCode.Year2021.Day6;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2021.Day6
{
    public class SolutionTests
    {
        [TestCase("3,4,3,1,2", 5934)]
        public void Part1ReturnsExpectedResult(string input, int fish)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day6 = new Solution(puzzle);

            // Act
            string result = day6.SolvePart1();

            // Assert
            result.ShouldBe($"Part 1: {fish}");
        }
    }
}