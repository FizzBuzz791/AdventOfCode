using System.Collections.Generic;
using AdventOfCode.Year2018.Day2;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2018.Day2
{
    public class SolutionTests
    {
        [TestCaseSource(nameof(Part1Cases))]
        public void FindsChecksum(string input, int expectedChecksum)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(input);

            var day2 = new Solution(puzzle);

            // Act
            string checksum = day2.SolvePart1();

            // Assert
            checksum.ShouldBe($"Part 1: {expectedChecksum}");
        }

        private static IEnumerable<object[]> Part1Cases()
        {
            yield return new object[] { "abcdef\nbababc\nabbcde\nabcccd\naabcdd\nabcdee\nababab\n", 12 };
        }

        [TestCaseSource(nameof(Part2Cases))]
        public void FindsCommonCharacters(string input, string expectedCommonCharacters)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(input);

            var day2 = new Solution(puzzle);

            // Act
            string commonCharacters = day2.SolvePart2();

            // Assert
            commonCharacters.ShouldBe($"Part 2: {expectedCommonCharacters}");
        }

        private static IEnumerable<object[]> Part2Cases()
        {
            yield return new object[] { "abcde\nfghij\nklmno\npqrst\nfguij\naxcye\nwvxyz", "fgij" };
        }
    }
}