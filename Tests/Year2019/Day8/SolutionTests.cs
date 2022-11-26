using AdventOfCode.Year2019.Day8;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2019.Day8
{
    public class SolutionTests
    {
        [TestCase("003006012012", 4)]
        public void FindsExpectedChecksum(string input, int expectedOutput)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(input);

            var day8 = new Solution(puzzle);
            Solution.OverrideDimensions(3, 2);

            // Act
            string checksum = day8.SolvePart1();

            // Assert
            checksum.ShouldBe($"Part 1: {expectedOutput}");
        }

        [TestCase("0222112222120000", "Part 2:\n #\n# \n")]
        public void DecodesImageCorrectly(string input, string expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(input);

            var day8 = new Solution(puzzle);
            Solution.OverrideDimensions(2, 2);

            // Act
            string output = day8.SolvePart2();

            // Assert
            output.ShouldBe(expectedResult);
        }
    }
}