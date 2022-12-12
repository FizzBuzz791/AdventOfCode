using AdventOfCode.Year2022.Day8;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2022.Day8
{
    public class SolutionTests
    {
        [TestCase("30373\n25512\n65332\n33549\n35390\n", 21)]
        public void Part1ReturnsExpectedResult(string input, int expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day8 = new Solution(puzzle);

            // Act
            string result = day8.SolvePart1();

            // Assert
            result.ShouldBe($"Part 1: {expectedResult}");
        }

        [TestCase("30373\n25512\n65332\n33549\n35390\n", 8)]
        public void Part2ReturnsExpectedResult(string input, int expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day8 = new Solution(puzzle);

            // Act
            string result = day8.SolvePart2();

            // Assert
            result.ShouldBe($"Part 2: {expectedResult}");
        }
    }
}