using AdventOfCode.Year2023.Day2;
using NAoCHelper;
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tests.Year2023.Day2
{
    public class SolutionTests
    {
        [TestCase("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 8)]
        public void Part1ReturnsExpectedResult(string input, int expectedResult)
        {
            // Arrange
            var puzzle = Substitute.For<IPuzzle>();
            puzzle.GetInputAsync().Returns(_ => input);

            var day2 = new Solution(puzzle);

            // Act
            string result = day2.SolvePart1();

            // Assert
            result.ShouldBe($"Part 1: {expectedResult}");
        }
    }
}