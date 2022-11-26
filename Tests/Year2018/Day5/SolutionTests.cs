using System.Collections.Generic;
using AdventOfCode.Year2018.Day5;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2018.Day5
{
    public class SolutionTests
    {
        [TestCaseSource(nameof(Part1Cases))]
        public void FindsReactedPolymerLength(string input, int expectedLength)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(input);

            var day5 = new Solution(puzzle);

            // Act
            string reactedPolymerLength = day5.SolvePart1();

            // Assert
            reactedPolymerLength.ShouldBe($"Part 1: {expectedLength}");
        }

        private static IEnumerable<object[]> Part1Cases()
        {
            yield return new object[] { "aA", 0 };
            yield return new object[] { "abBA", 0 };
            yield return new object[] { "abAB", 4 };
            yield return new object[] { "aabAAB", 6 };
            yield return new object[] { "dabAcCaCBAcCcaDA", 10 };
        }

        [TestCaseSource(nameof(Part2Cases))]
        public void FindsShortestReactedPolymerLength(string input, int expectedLength)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(input);

            var day5 = new Solution(puzzle);

            // Act
            string shortestReactedPolymerLength = day5.SolvePart2();

            // Assert
            shortestReactedPolymerLength.ShouldBe($"Part 2: {expectedLength}");
        }

        private static IEnumerable<object[]> Part2Cases()
        {
            yield return new object[] { "dabAcCaCBAcCcaDA", 8 };
        }
    }
}