using AdventOfCode.Year2022.Day9;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2022.Day9
{
    public class SolutionTests
    {
        [TestCase("R 4\nU 4\nL 3\nD 1\nR 4\nD 1\nL 5\nR 2\n", 13)]
        public void Part1ReturnsExpectedResult(string input, int expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day9 = new Solution(puzzle);

            // Act
            string result = day9.SolvePart1();

            // Assert
            result.ShouldBe($"Part 1: {expectedResult}");
        }

        [TestCase("R 4\nU 4\nL 3\nD 1\nR 4\nD 1\nL 5\nR 2\n", 1)]
        [TestCase("R 5\nU 8\nL 8\nD 3\nR 17\nD 10\nL 25\nU 20\n", 36)]
        public void Part2ReturnsExpectedResult(string input, int expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day9 = new Solution(puzzle);

            // Act
            string result = day9.SolvePart2();

            // Assert
            result.ShouldBe($"Part 2: {expectedResult}");
        }
    }
}