using AdventOfCode.Year2022.Day1;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2022.Day1
{
    public class SolutionTests
    {
        [TestCase("1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000\n", 24000)]
        public void Part1ReturnsExpectedResult(string input, int calories)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day1 = new Solution(puzzle);

            // Act
            string result = day1.SolvePart1();

            // Assert
            result.ShouldBe($"Part 1: {calories}");
        }
    }
}