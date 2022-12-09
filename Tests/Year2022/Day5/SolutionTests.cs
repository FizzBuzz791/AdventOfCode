using AdventOfCode.Year2022.Day5;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2022.Day5
{
    public class SolutionTests
    {
        [TestCase("    [D]    \n[N] [C]    \n[Z] [M] [P]\n 1   2   3 \n\nmove 1 from 2 to 1\nmove 3 from 1 to 3\nmove 2 from 2 to 1\nmove 1 from 1 to 2\n", "CMZ")]
        public void Part1ReturnsExpectedResult(string input, string expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day5 = new Solution(puzzle);

            // Act
            string result = day5.SolvePart1();

            // Assert
            result.ShouldBe($"Part 1: {expectedResult}");
        }

        [TestCase("    [D]    \n[N] [C]    \n[Z] [M] [P]\n 1   2   3 \n\nmove 1 from 2 to 1\nmove 3 from 1 to 3\nmove 2 from 2 to 1\nmove 1 from 1 to 2\n", "MCD")]
        public void Part2ReturnsExpectedResult(string input, string expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day5 = new Solution(puzzle);

            // Act
            string result = day5.SolvePart2();

            // Assert
            result.ShouldBe($"Part 2: {expectedResult}");
        }
    }
}